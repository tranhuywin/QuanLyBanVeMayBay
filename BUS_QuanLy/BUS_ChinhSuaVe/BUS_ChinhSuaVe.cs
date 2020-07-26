using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy.DAL_ChinhSuaVe;
using DTO_QuanLy;


namespace BUS_QuanLy.BUS_ChinhSuaVe
{
    public class BUS_ChinhSuaVe
    {
        DAL_ChinhSuaVe dalChinhSuaVe = new DAL_ChinhSuaVe();
        public DataTable LoadTableVe(DTO_ChuyenBay dtoChuyenBay )
        {
            return dalChinhSuaVe.LoadTableVeChuyenBay(dtoChuyenBay);
        }
    }
}
