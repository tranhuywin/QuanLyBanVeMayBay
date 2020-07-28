using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanVeMayBay.Components.ComponentsTimKiemKH;

namespace QuanLyBanVeMayBay.Components
{
    public partial class UCTimKiemKH : UserControl
    {
        public UCTimKiemKH()
        {
            InitializeComponent();
        }

        private void UCTimKiemKH_Load(object sender, EventArgs e)
        {
            pnl_TimKiemKH.Controls.Clear();
            pnl_TimKiemKH.Controls.Add(TimKiemKH);
        }
    }
}
