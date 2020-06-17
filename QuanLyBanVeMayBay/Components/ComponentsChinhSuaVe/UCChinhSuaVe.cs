using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay.Components.ComponentsChinhSuaVe
{
    public partial class UCChinhSuaVe : UserControl
    {
        public UCChinhSuaVe()
        {
            InitializeComponent();
        }

        private void UCChinhSuaVe_Load(object sender, EventArgs e)
        {

        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Show();
        }

    }
}
