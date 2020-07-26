using DAL_QuanLy.DAL_ChinhSuaVe;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_ChinhSuaVe
{
    public class BUS_ThemChuyenBay
    {
        DAL_ThemChuyenBay dalThemChuyenBay = new DAL_ThemChuyenBay();
        public bool LoadThemMoiChuyenBay(DTO_ChiTietChuyenBay dtoChiTietChuyenBay, DTO_ChuyenBay dtoChuyenBay, DTO_TuyenBay dtoTuyenBay)
        {
            if (dalThemChuyenBay.ThemChuyenBay(dtoChiTietChuyenBay, dtoChuyenBay, dtoTuyenBay)) return true;
            else return false;
        }
    }
}
