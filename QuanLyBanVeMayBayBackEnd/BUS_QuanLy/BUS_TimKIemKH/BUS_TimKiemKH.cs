using DAL_QuanLy.DAL_TimKiemKH;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_TimKiemKH
{
    public class BUS_TimKiemKH
    {
        DAL_TimKiemKH dalTimKiemKH = new DAL_TimKiemKH();
        public DataTable LoadKhachHang(DTO_KhachHang dtoKhachHang)
        {
            return dalTimKiemKH.LoadKhachHang(dtoKhachHang);
        }
    }
}
