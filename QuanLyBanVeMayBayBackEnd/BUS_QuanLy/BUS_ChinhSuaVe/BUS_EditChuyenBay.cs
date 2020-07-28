using DAL_QuanLy.DAL_ChinhSuaVe;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_ChinhSuaVe
{
   public class BUS_EditChuyenBay
    {
        DAL_EditChuyenBay dalEditChuyenBay = new DAL_EditChuyenBay();
        public bool LoadEditChuyenBay(DTO_ChiTietChuyenBay dtoChiTietChuyenBay, DTO_ChuyenBay dtoChuyenBay, DTO_TuyenBay dtoTuyenBay)
        {
            if (dalEditChuyenBay.EditChuyenBay(dtoChiTietChuyenBay, dtoChuyenBay, dtoTuyenBay)) return true;
            else return false;
        }
    }
}
