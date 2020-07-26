using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Net.Http;
using System.Windows.Forms;


namespace QuanLyBanVeMayBay
{
    public partial class FormLogin : Form
    {
        BUS_Login busLogin = new BUS_Login(); //khong su dung web api
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //khong su dung web api
            DTO_User dtoUser = new DTO_User { User = UserTxt.Text, Password = UserTxt.Text, ChucVu = "0" };   // khoi tao DTO user, truyen user, password cho DTO vua tao, ChucVu = 0 = nhân viên, = 1 quản lý
            bool checkuser = busLogin.KiemTraUser(dtoUser); //  truyen DTO user qua BUS de xu ly thong tin
            if (checkuser == true)  // neu Bus login tra ve dung
            {
                Main.Main f = new Main.Main();
                this.Hide();
                f.dtoUser = dtoUser;
                f.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ");
            }


            //su dung web api de ket noi voi backend
            /*using (var client = new HttpClient())   //khoi tao
            {
                client.BaseAddress = new Uri("https://connectapiquanly.azurewebsites.net//");   //dia chi backend
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
                    f.Show();       // hien form main
                }
            }*/
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
