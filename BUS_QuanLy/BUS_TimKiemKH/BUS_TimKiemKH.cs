using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DAL_QuanLy.DAL_TimKiemKH;
using DTO_QuanLy;

namespace BUS_QuanLy.BUS_TimKiemKH
{
    class BUS_TimKiemKH
    {
        DAL_TimKiemKH dal_TimKiemKH = new DAL_TimKiemKH();

        public bool TimKiemKH(List<DTO_KhachHang> lsObj, String _hoten, String _email,
            String _sdt, String _cmnd)
        {
            if (dal_TimKiemKH.TimKiemKH(lsObj, _hoten, _email, _sdt, _cmnd) != null)
                return true;
            else return false;
        }
    }
}
