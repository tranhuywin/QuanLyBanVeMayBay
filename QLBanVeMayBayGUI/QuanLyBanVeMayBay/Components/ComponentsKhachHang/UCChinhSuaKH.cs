using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCChinhSuaKH : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public UCChinhSuaKH()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }
        DTO_KhachHang dtoKhachHang = new DTO_KhachHang();
        private void XongBtn_Click(object sender, EventArgs e)
        {
            dtoKhachHang.CMND = CMNDtext.Text;
            dtoKhachHang.Email = Emailtext.Text;
            dtoKhachHang.HoTenKH = HoTentext.Text;
            dtoKhachHang.SDT = SDTtext.Text;
            dtoKhachHang.GioiTinh = GioiTinhtext.Text;
            // start get value
            var responseKhachHang = client.PostAsJsonAsync("/khachhang/chinhsuakhachhang", dtoKhachHang).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var Update = responseKhachHang.Content.ReadAsStringAsync();   // khong biet
            // end

            bool UpdateKH = bool.Parse(Update.Result);
            if (UpdateKH)
            {
                MessageBox.Show("Thêm thành công");
                this.Hide();
            }
            else
                MessageBox.Show("Thêm thất bại");
            
        }

    }
}
