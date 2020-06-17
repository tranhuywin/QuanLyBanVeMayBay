using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public class BUS_Login
    {
        DAL_Login dalLogin = new DAL_Login();
        public bool KiemTraUser(DTO_User user)  // nhan du lieu DTO tu GUI tra ve du lieu dung sai sau  khi lay du lieu tu DAL
        {
            return dalLogin.Kiemtrauser(user);
        }
    }
}
