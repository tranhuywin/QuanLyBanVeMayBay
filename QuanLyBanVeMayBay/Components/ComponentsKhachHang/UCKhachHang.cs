using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.Components.ComponentsKhachHang
{
    public partial class UCKhachHang : UserControl
    {
        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Show();
        }
    }
}
