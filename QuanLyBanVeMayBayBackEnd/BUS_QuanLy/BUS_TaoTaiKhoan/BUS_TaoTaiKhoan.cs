using DAL_QuanLy.DAL_TaoTaiKhoan;
using DTO_QuanLy;

namespace BUS_QuanLy.BUS_TaoTaiKhoan
{
    public class BUS_TaoTaiKhoan
    {
        private DAL_TaoTaiKhoan dalTaoTaiKhoan = new DAL_TaoTaiKhoan();
        public bool TaoTaiKhoan(DTO_User dtoUser)
        {
            return dalTaoTaiKhoan.CreateTaiKhoan(dtoUser);
        }
    }
}
