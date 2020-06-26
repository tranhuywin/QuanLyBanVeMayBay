using DAL_QuanLy.DAL_BanVe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_BanVe
{
    public class BUS_Step2
    {
        private DAL_Step2 dalStep2 = new DAL_Step2();
        public DataTable LoadSanBayComboBox()
        {
            return dalStep2.LoadVeMayBayDataGridView();
        }
    }
}
