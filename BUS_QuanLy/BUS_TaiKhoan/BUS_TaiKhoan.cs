using DAL_QuanLy.DAL_TaiKhoan;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_TaiKhoan
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();
        public DataTable LoadTaiKhoan(DTO_User dtoUser)
        {
            return dalTaiKhoan.LoadTaiKhoan(dtoUser);
        }
        public bool LuuTaiKhoan(DTO_User dtoUser)
        {
            return dalTaiKhoan.UpdateTaiKhoan(dtoUser);
        }
    }
}
