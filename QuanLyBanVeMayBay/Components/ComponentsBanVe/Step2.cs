using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy.BUS_BanVe;

namespace QuanLyBanVeMayBay.Components.ComponentsBanVe
{
    public partial class Step2 : UserControl
    {
        private BUS_Step2 busStep2 = new BUS_Step2();
        public Step2()
        {
            InitializeComponent();
            ConstructorVeMayBayDataGridView();
        }
        private void ConstructorVeMayBayDataGridView()
        {
            VemayBayDataGridView.DataSource = busStep2.LoadSanBayComboBox();
        }
    }
}
