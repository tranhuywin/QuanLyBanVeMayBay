using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http;
using System.Net.Http.Headers;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCUpdateKhachHang : UserControl
    {   
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public UCUpdateKhachHang()
        {
            InitializeComponent();
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }
        private DTO_KhachHang dtoKhachHang = new DTO_KhachHang { MaKhachHang = "", HoTenKH = "", CMND = "", SDT = "", GioiTinh = "", Email = "" };

        public void LoadDTOKhachHang(DTO_KhachHang dtoKhachHang)
        {
            this.dtoKhachHang = dtoKhachHang;
            MaKHtext.Text = dtoKhachHang.MaKhachHang;
            HoTentext.Text = dtoKhachHang.HoTenKH;
            SDTtext.Text = dtoKhachHang.SDT;
            Emailtext.Text = dtoKhachHang.Email;
            GioiTinhtext.Text = dtoKhachHang.GioiTinh;
            CMNDtext.Text = dtoKhachHang.CMND;
        }

        private void LuuBtn_Click_1(object sender, EventArgs e)
        {
            dtoKhachHang = new DTO_KhachHang { MaKhachHang = MaKHtext.Text, HoTenKH = HoTentext.Text, CMND = CMNDtext.Text, SDT = SDTtext.Text, GioiTinh = GioiTinhtext.Text, Email = Emailtext.Text };
            // start get value
            var responseKhachHang = client.PostAsJsonAsync("/khachhang/updatekhachhang", dtoKhachHang).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var insert = responseKhachHang.Content.ReadAsStringAsync();   // khong biet
                                                                          // end

            bool AddKh = bool.Parse(insert.Result);

            if (AddKh)
                MessageBox.Show("Sửa thông tin Khách hàng thành công");
            else MessageBox.Show("Sửa thông tin khách hàng thất bại");
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
