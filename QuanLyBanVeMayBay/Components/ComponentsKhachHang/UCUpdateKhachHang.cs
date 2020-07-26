using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy.BUS_KhachHang;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCUpdateKhachHang : UserControl
    {
        public UCUpdateKhachHang()
        {
            InitializeComponent();
        }
        BUS_UpdateKH busUpdateKH = new BUS_UpdateKH();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LuuBtn_Click_1(object sender, EventArgs e)
        {
            dtoKhachHang = new DTO_KhachHang { MaKhachHang = MaKHtext.Text, HoTenKH = HoTentext.Text, CMND = CMNDtext.Text, SDT = SDTtext.Text, GioiTinh = GioiTinhtext.Text, Email = Emailtext.Text };
            bool AddKh = busUpdateKH.LoadUpdateKhachHang(dtoKhachHang);
            if (AddKh)
                MessageBox.Show("Sửa thông tin Khách hàng thành công");
            else MessageBox.Show("Sửa thông tin khách hàng thất bại");
            this.Hide();
        }
    }
}
