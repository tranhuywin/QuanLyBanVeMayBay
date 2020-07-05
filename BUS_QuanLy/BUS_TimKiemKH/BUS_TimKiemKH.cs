using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DAL_QuanLy.DAL_TimKiemKH;
using DTO_QuanLy;
using System.Data.SqlClient;
using System.Data;

namespace BUS_QuanLy.BUS_TimKiemKH
{
    public class BUS_TimKiemKH
    {
        DAL_TimKiemKH dal_TimKiemKH = new DAL_TimKiemKH();

        public DataTable LoadDataTableTimKiemKH(List<DTO_KhachHang> lsObj, String _hoten, String _email,
            String _sdt, String _cmnd)
        {
            return dal_TimKiemKH.LoadDataTableTimKiemKH(lsObj, _hoten, _email, _sdt, _cmnd);
        }
    }
}
