using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QuanLyBanVeMayBay.Components;

namespace QuanLyBanVeMayBay.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //handle header move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //done handle herder move
        private void ExitBtn_Click(object sender, EventArgs e) // nut thoat
        {
            Application.Exit();
        }
        private void HomePanel_Click(object sender, EventArgs e) // nut trang chu
        {
            ContentPanel.Controls.Clear(); // clear user control
            ContentPanel.Controls.Add(home1);// add user control
        }
        private void ThongTinPanel_Click(object sender, EventArgs e) // nut thong tin
        {
            ContentPanel.Controls.Clear(); 
            ContentPanel.Controls.Add(ucThongTin); 
        }

        private void BanVePanel_Click(object sender, EventArgs e) // nut ban ve
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucBanve);
        }

        private void HuyVePanel_Click(object sender, EventArgs e) // huy ve
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucHuyVe);
        }

        private void TTKhachHangPanel_Click(object sender, EventArgs e) // thong tin khach hang
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucttKhachHang);
        }

        private void DoanhThuPanel_Click(object sender, EventArgs e) // doanh thu
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucDoanhThu);
        }

        private void Header_MouseDown(object sender, MouseEventArgs e) // handle move
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TimKHpanel_Paint(object sender, PaintEventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucTimKiemKH);
        }

        private void TimVepanel_Paint(object sender, PaintEventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucTimVe);
        }
    }
}
