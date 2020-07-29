using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http.Headers;
using System.Net.Http;

namespace QuanLyBanVeMayBay.Components.ComponentsChinhSuaVe
{
    public partial class UCChinhSuaChuyenBay : UserControl
    {
        DTO_TuyenBay dtoTuyenBay = new DTO_TuyenBay();
        DTO_ChiTietChuyenBay dtoChiTieTChuyenBay = new DTO_ChiTietChuyenBay();
        DTO_ChuyenBay dtoChuyenBay = new DTO_ChuyenBay();

        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public UCChinhSuaChuyenBay()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
            dtoChiTieTChuyenBay.MaChiTietChuyenBay = dtoChuyenBay.MaChiTietChuyenBay = generateID();
            dtoChuyenBay.MaTuyenBay = dtoTuyenBay.MaTuyenBay = generateID();
            dtoChuyenBay.MaChuyenBay  = generateID();
        }
        public class ObjectChinhSuaChuyenBay
        {
            public DTO_TuyenBay dtoTuyenBay { get; set; }
            public DTO_ChiTietChuyenBay dtoChiTieTChuyenBay { get; set; }
            public DTO_ChuyenBay dtoChuyenBay { get; set; }
        }

        private void Donebtn_Click(object sender, EventArgs e)
        {
            dtoTuyenBay.SanBayDi = SanBayDitext.Text;
            dtoTuyenBay.SanBayDen = SanBayDentext.Text;
            dtoChuyenBay.NgayGio = NgayGioBaytext.Text;
            dtoChiTieTChuyenBay.SanBayTrungGian = SanBayTrungGiantext.Text;
            dtoChiTieTChuyenBay.ThoiGianDung = ThoiGianDungtext.Text;
            dtoChuyenBay.TenMayBay = TenMayBaytext.Text;

            ObjectChinhSuaChuyenBay obj = new ObjectChinhSuaChuyenBay { dtoChiTieTChuyenBay = dtoChiTieTChuyenBay, dtoChuyenBay = dtoChuyenBay, dtoTuyenBay = dtoTuyenBay };
            // start get value
            var response = client.PostAsJsonAsync("/Chinhsuave/chinhsuachuyenbay", obj).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var update = response.Content.ReadAsStringAsync();   // khong biet
            // end
            bool UpdateChuyenBay = bool.Parse(update.Result);
            if (UpdateChuyenBay)
            {
                MessageBox.Show("Thêm thành công");
                this.Hide();
            }
            else
                MessageBox.Show("Thêm thất bại");

        }
        public void LoadMaChuyenBay()
        {         

            MaChuyenBaytext.Text=dtoChuyenBay.MaChuyenBay;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}
