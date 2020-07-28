using System;
using System.Windows.Forms;
using DTO_QuanLy;
using System.Net.Http.Headers;
using System.Net.Http;

namespace QuanLyBanVeMayBay.Components.ComponentsTaoTaiKhoan
{
    public partial class UCTaoTaiKhoan : UserControl
    {
        //declare url, client
        static HttpClient client = new HttpClient();
        private string URLAddress = Properties.Settings.Default.URLAddress;
        // end
        public UCTaoTaiKhoan()
        {
            InitializeComponent();
            MatKhauText.UseSystemPasswordChar = true;
            // innit client
            client.BaseAddress = new Uri(URLAddress);   // init base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // end
        }
        DTO_User dtoUser = new DTO_User();
        private void TaoTaiKhoanBtn_Click(object sender, EventArgs e)
        {
            dtoUser.ChucVu = "1";
            dtoUser.CMND = CMNDTxt.Text;
            dtoUser.DiaChi = DiaChiTxt.Text;
            dtoUser.HoTen = HoTenTxt.Text;
            dtoUser.NgaySinh = NgaySinhDateTimePicker.Value.ToString();
            dtoUser.User = TaiKhoanTxt.Text;
            dtoUser.Password = MatKhauText.Text;
            // start get value
            var responseKhachHang = client.PostAsJsonAsync("/taikhoan/Createtaikhoan", dtoUser).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
            var create = responseKhachHang.Content.ReadAsStringAsync();   // khong biet
                                                                          // end

            bool createTK = bool.Parse(create.Result);
            if (createTK)
                MessageBox.Show("Tạo tài khoản thành công");
            else
                MessageBox.Show("Tạo tài khoản thất bại");
        }

        private void AnHienMatKhauCheckBox_OnChange(object sender, EventArgs e)
        {
            if (MatKhauText.UseSystemPasswordChar)
                MatKhauText.UseSystemPasswordChar = false;
            else
                MatKhauText.UseSystemPasswordChar = true;
        }
    }
}
