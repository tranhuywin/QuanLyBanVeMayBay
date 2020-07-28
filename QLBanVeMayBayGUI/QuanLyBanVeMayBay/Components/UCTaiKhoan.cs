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
using DTO_QuanLy;

namespace QuanLyBanVeMayBay.Components
{
    public partial class UCTaiKhoan : UserControl
    {
        public UCTaiKhoan()
        {
            InitializeComponent();
        }
        public DTO_User dtoUser = new DTO_User();
        private void UCTimVe_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadUser()
        {
            TimKiemVe.dtoUser = dtoUser;
            TimKiemVe.LoadUser();
            pnl_TimVe.Controls.Clear();
            pnl_TimVe.Controls.Add(TimKiemVe);
        }

    }
}
