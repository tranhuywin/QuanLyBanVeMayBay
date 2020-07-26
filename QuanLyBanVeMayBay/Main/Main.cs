using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DTO_QuanLy;

namespace QuanLyBanVeMayBay.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
        public DTO_User dtoUser = new DTO_User();
        //handle header move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //done handle herder move
        private void Header_MouseDown(object sender, MouseEventArgs e) // handle move
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinisizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
        }

        private void BanVeBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucBanve);
        }

        private void HuyVeBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucHuyVe);
        }

        private void KhachHangBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucKhachHang);
        }

        private void ChinhSuaVeBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucChinhSuaVe);
        }

        private void TimVeBtn_Click(object sender, EventArgs e)//UC TaiKhoan
        {
            ContentPanel.Controls.Clear();
            ucTimVe1.dtoUser = dtoUser;
            ucTimVe1.LoadUser();
            ContentPanel.Controls.Add(ucTimVe1);
        }

        private void TimKHBtn_Click(object sender, EventArgs e) 
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucTimKiemKH1);
        }

        private void DoanhThuBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucDoanhThu);
        }

        private void TaoTaiKhoanBtn_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucTaoTaiKhoan1);
        }

    }
}
