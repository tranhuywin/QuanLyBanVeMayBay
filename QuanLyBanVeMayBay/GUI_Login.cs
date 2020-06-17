using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanVeMayBay
{
    public partial class FormLogin : Form
    {
        BUS_Login busLogin = new BUS_Login();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            DTO_User dtoUser = new DTO_User(UserTxt.Text, PasswordTxt.Text, "1");   // khoi tao DTO user, truyen user, password cho DTO vua tao
            bool checkuser = busLogin.KiemTraUser(dtoUser); //  truyen DTO user qua BUS de xu ly thong tin
            if (checkuser == true)  // neu Bus login tra ve dung
            {
                MessageBox.Show("Thanh cong");
                Main.Main f = new Main.Main();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Co loi");
            }
        }
    }
}
