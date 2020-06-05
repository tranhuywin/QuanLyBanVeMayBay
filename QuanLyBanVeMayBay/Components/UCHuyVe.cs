using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanVeMayBay.Components.ComponentsHuyVe;

namespace QuanLyBanVeMayBay.Components
{
    public partial class UCHuyVe : UserControl
    {
        public UCHuyVe()
        {
            InitializeComponent();
        }

        private void UCHuyVe_Load(object sender, EventArgs e)
        {
            ContentDienTTPanel.Controls.Clear();
            ContentDienTTPanel.Controls.Add(DienThongTinKH);
        }
    }
}
