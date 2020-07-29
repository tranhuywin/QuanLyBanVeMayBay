using DTO_QuanLy;
using System;
using System.Net.Http;
using System.Windows.Forms;


namespace QuanLyBanVeMayBay
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())   //khoi tao
            {
                client.BaseAddress = new Uri("https://qlbanvemaybay.azurewebsites.net/");   //dia chi backend
                DTO_User dtoUser = new DTO_User { User = UserTxt.Text, Password = UserTxt.Text, ChucVu = "0" }; // khoi tao DTO user, truyen user, password cho DTO vua tao
                var response = client.PostAsJsonAsync("login", dtoUser).Result;     // gui DTO user len web sever bang Method POST, va nhan ket qua tra ve
                var a = response.Content.ReadAsStringAsync();   // khong biet
                if (a.Result == "false") // 0 = false, khong co User
                {
                    MessageBox.Show("Thông tin đăng nhập không hợp lệ");
                }
                else        // true = 1, co User
                {
                    Main.Main f = new Main.Main();  // khoi tao form main
                    this.Hide();    // an form login
                    f.dtoUser = dtoUser;
                    f.Show();       // hien form main
                }
            }
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnHienMatKhauCheckBox_OnChange(object sender, EventArgs e)
        {
            if (PasswordTxt.isPassword)
                PasswordTxt.isPassword = false;
            else
                PasswordTxt.isPassword = true;
        }
    }
}
