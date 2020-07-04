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
using System.Windows;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCKhachHang : UserControl
    {
        
        
        private void UCKhachHang_Load(object sender, EventArgs e)
        {
        }
        public UCKhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        private void Newbtn_Click_1(object sender, EventArgs e)
        {
            ucChinhSuaKH1.Show();
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            DTO_KhachHang dtoKhachHang = new DTO_KhachHang { HoTenKH = HoTenKHTxt.Text, CMND = CMNDTxt.Text };
            KhachHangDataGridView.DataSource = busKhachHang.LoadKhachHangComboBox(dtoKhachHang);
            KhachHangDataGridView.Show();
        }
    }
}
