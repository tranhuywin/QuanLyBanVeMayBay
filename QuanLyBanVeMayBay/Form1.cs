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
            QuanLyBanVeMayBay.Main.Main f = new QuanLyBanVeMayBay.Main.Main();
            f.ShowDialog();
        }
    }
}
