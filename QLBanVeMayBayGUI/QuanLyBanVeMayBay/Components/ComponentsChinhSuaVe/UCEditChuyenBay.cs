using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;

namespace QuanLyBanVeMayBay.Components.ComponentsChinhSuaVe
{
    public partial class UCEditChuyenBay : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public UCEditChuyenBay()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }
        DTO_TuyenBay dtoTuyenBay = new DTO_TuyenBay();
        DTO_ChiTietChuyenBay dtoChiTieTChuyenBay = new DTO_ChiTietChuyenBay();
        DTO_ChuyenBay dtoChuyenBay = new DTO_ChuyenBay();
        public class ObjectChuyenBay
        {
            public DTO_TuyenBay dtoTuyenBay { get; set; }
            public DTO_ChiTietChuyenBay dtoChiTieTChuyenBay { get; set; }
            public DTO_ChuyenBay dtoChuyenBay { get; set; }
        }
        private void Donebtn_Click(object sender, EventArgs e)
        {

                dtoChuyenBay.MaChuyenBay = MaChuyenBaytext.Text;
                dtoTuyenBay.SanBayDi = SanBayDitext.Text;
                dtoTuyenBay.SanBayDen = SanBayDentext.Text;
                dtoChuyenBay.NgayGio = NgayGioBaytext.Text;
                dtoChiTieTChuyenBay.SanBayTrungGian = SanBayTrungGiantext.Text;
                dtoChiTieTChuyenBay.ThoiGianDung = ThoiGianDungtext.Text;
                dtoChuyenBay.TenMayBay = TenMayBaytext.Text;
                dtoChuyenBay.ThoiGianBay = ThoiGianBaytext.Text;
            // start get value
            ObjectChuyenBay obj = new ObjectChuyenBay { dtoChiTieTChuyenBay = dtoChiTieTChuyenBay, dtoChuyenBay = dtoChuyenBay, dtoTuyenBay = dtoTuyenBay };
            var response = client.PostAsJsonAsync("/chinhsuave/LoadEditChuyenBay", obj).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var update = response.Content.ReadAsStringAsync();   // khong biet
            // end

            bool updateChuyenBay = bool.Parse(update.Result);
            if (updateChuyenBay)
                {
                    MessageBox.Show("Sửa thành công");
                    this.Hide();
                }
                else
                    MessageBox.Show("Sửa thất bại");

            
        }

        public void LoadDTOEditChuyenBay(DTO_ChiTietChuyenBay dtoChiTieTChuyenBay,DTO_ChuyenBay dtoChuyenBay,DTO_TuyenBay dtoTuyenBay)
        {
            this.dtoChiTieTChuyenBay = dtoChiTieTChuyenBay;
            this.dtoChuyenBay = dtoChuyenBay;
            this.dtoTuyenBay = dtoTuyenBay;
            ThoiGianDungtext.Text = dtoChiTieTChuyenBay.ThoiGianDung;
            MaChuyenBaytext.Text = dtoChuyenBay.MaChuyenBay;
            SanBayDentext.Text = dtoTuyenBay.SanBayDen;
            SanBayDitext.Text = dtoTuyenBay.SanBayDi;
            NgayGioBaytext.Text = dtoChuyenBay.NgayGio;
            SanBayTrungGiantext.Text = dtoChiTieTChuyenBay.SanBayTrungGian;
            ThoiGianBaytext.Text = dtoChuyenBay.ThoiGianBay;
            TenMayBaytext.Text = dtoChuyenBay.TenMayBay;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
