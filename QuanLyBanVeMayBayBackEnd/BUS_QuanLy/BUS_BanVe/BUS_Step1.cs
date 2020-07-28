using DAL_QuanLy.DAL_BanVe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS_QuanLy.BUS_BanVe
{
    public class BUS_Step1
    {
        DAL_Step1 dalStep1 = new DAL_Step1();
        public DataTable LoadSanBayComboBox()
        {
            return dalStep1.LoadSanBayComboBox();
        }
    }
}
