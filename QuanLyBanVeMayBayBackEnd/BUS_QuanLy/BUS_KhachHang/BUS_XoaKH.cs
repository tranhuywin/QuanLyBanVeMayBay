using DAL_QuanLy.DAL_KhachHang1;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace BUS_QuanLy.BUS_KhachHang
{
   public class BUS_XoaKH
    {
        DAL_XoaKH dalKhachHang1 = new DAL_XoaKH();
        public bool XoaKhachHang(DTO_KhachHang dtoKhachHang)
        {
            if (dalKhachHang1.XoaDuLieuKH(dtoKhachHang)) return true;
            else return false;
        }
    }
}
