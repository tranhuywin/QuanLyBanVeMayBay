using DAL_QuanLy.DAL_KhachHang;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BUS_QuanLy.BUS_ChinhSuaKH
{
    public class BUS_ChinhSuaKH
    {
        DAL_ChinhSuaKH dalKhachHang1 = new DAL_ChinhSuaKH();
        public bool LoadThemMoiKhachHang(DTO_KhachHang dtoKhachHang)
        {
            if (dalKhachHang1.ThemMoiKhachHang(dtoKhachHang)) return true;
            else return false;
        }
    }
}
