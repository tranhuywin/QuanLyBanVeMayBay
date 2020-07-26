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
using BUS_QuanLy.BUS_ChinhSuaKH;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCChinhSuaKH : UserControl
    {
        public UCChinhSuaKH()
        {
            InitializeComponent();
        }
        BUS_ChinhSuaKH busChinhSuaKH = new BUS_ChinhSuaKH();
        DTO_KhachHang dtoKhachHang = new DTO_KhachHang();
        private void XongBtn_Click(object sender, EventArgs e)
        {
            dtoKhachHang.CMND = CMNDtext.Text;
            dtoKhachHang.Email = Emailtext.Text;
            dtoKhachHang.HoTenKH = HoTentext.Text;
            dtoKhachHang.SDT = SDTtext.Text;
            dtoKhachHang.GioiTinh = GioiTinhtext.Text;
            if (busChinhSuaKH.LoadThemMoiKhachHang(dtoKhachHang))
            {
                MessageBox.Show("Thêm thành công");
                this.Hide();
            }
            else
                MessageBox.Show("Thêm thất bại");
            
        }

    }
}
