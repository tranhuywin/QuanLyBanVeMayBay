using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanVeMayBay.Components;

namespace QuanLyBanVeMayBay.Components
{
    public partial class UCTimVe : UserControl
    {
        public UCTimVe()
        {
            InitializeComponent();
        }

        private void UCTimVe_Load(object sender, EventArgs e)
        {
            pnl_TimVe.Controls.Clear();
            pnl_TimVe.Controls.Add(TimKiemVe);
        }
    }
}
