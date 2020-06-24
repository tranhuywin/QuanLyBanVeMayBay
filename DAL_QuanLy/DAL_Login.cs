using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_Login : ClsConnectDB
    {
        public bool Kiemtrauser(DTO_User user) // nhan DTO user tu BUS va tra ket qua dung sai ve lai BUS
        {
            try
            {
                OpenConection(); // open connection
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@User", user.User));         //them parameter vao command.parameter
                command.Parameters.Add(new SqlParameter("@Password", user.Password));
                command.Parameters.Add(new SqlParameter("@ChucVu", "0"));
                SqlDataReader dta = DataReaderStoredProcedure(command, "SelectTaiKhoan");   //su dung command.parameter va ExecuteReader de tra ve gia tri DateReader
                if (dta.Read())         // neu co gia tri tra ve
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();  // close connection
            }
           
        }
    }
}
