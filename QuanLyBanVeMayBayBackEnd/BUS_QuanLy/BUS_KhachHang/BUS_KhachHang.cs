using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy.DAL_KhachHang1;
using DTO_QuanLy;

namespace BUS_QuanLy.BUS_KhachHang
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable LoadKhachHangComboBox(DTO_KhachHang dtoKhachHang)
        {
            return dalKhachHang.LoadKhachHangDataGridView(dtoKhachHang);
        }
    }
}
