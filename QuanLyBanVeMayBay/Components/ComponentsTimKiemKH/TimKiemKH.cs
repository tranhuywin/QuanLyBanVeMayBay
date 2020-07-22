using BUS_QuanLy.BUS_TimKiemKH;
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

namespace QuanLyBanVeMayBay.Components.ComponentsTimKiemKH
{
    public partial class TimKiemKH : UserControl
    {
        public TimKiemKH()
        {
            InitializeComponent();
        }
        BUS_TimKiemKH busTimKiemKH = new BUS_TimKiemKH();
        private void TimKiemBtn_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTinTextBox())
            {
                DTO_KhachHang dtoKhachHang = new DTO_KhachHang { CMND = CMNDTxt.Text, HoTenKH = HoTenKHTxt.Text, Email = EmailTxt.Text, SDT = SDTTxt.Text, GioiTinh = "", MaKhachHang = "" };
                KhachHangDataGridView.DataSource = busTimKiemKH.LoadKhachHang(dtoKhachHang);
            }
        }
        private bool KiemTraThongTinTextBox()
        {
            return true;
        }
    }
}
