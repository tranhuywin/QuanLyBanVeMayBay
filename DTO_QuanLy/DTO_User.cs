using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_User
    {
        private string User_User;
        private string User_Password;
        private string User_ChucVu;

        public DTO_User(string user_User, string user_Password, string user_ChucVu)
        {
            User_User = user_User;
            User_Password = user_Password;
            User_ChucVu = user_ChucVu;
        }

        public string _User_User { get => User_User; set => User_User = value; }
        public string _User_Password { get => User_Password; set => User_Password = value; }
        public string _User_ChucVu { get => User_ChucVu; set => User_ChucVu = value; }
    }
}
