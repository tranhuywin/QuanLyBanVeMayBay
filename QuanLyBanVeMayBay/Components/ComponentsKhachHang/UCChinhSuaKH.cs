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
    public partial class UCChinhSuaKH : UserControl
    {
        public UCChinhSuaKH()
        {
            InitializeComponent();
        }

        private void XongBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
