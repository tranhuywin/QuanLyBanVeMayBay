using DAL_QuanLy.DAL_HuyVe;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_HuyVe
{
    public class BUS_HuyVe
    {
        private DAL_HuyVe dalHuyVe = new DAL_HuyVe();
        public DataTable LoadDataGridViewHuyVe(DTO_KhachHang dtoKhachHang, DTO_VeChuyenBay dtoVeChuyenBay)
        {
            return dalHuyVe.LoadDataTableHuyVe(dtoKhachHang, dtoVeChuyenBay);
        }
        public bool DeleteVeChuyenBay(DTO_VeChuyenBay dtoVeChuyenBay)
        {
            return dalHuyVe.DeleteVeChuyenBay(dtoVeChuyenBay);
        }
    }
}
