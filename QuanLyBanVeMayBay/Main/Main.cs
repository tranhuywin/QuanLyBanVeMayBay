using System;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
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

        private void BanVePanel_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucBanve);
        }

        private void HuyVePanel_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucHuyVe);
        }

        private void TTKhachHangPanel_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucttKhachHang);
        }

        private void DoanhThuPanel_Click(object sender, EventArgs e)
        {
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(ucDoanhThu);
        }
    }
}
