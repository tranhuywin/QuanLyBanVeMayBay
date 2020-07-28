using DTO_QuanLy;
using System;
using System.Data.SqlClient;

namespace DAL_QuanLy.DAL_TaoTaiKhoan
{
    public class DAL_TaoTaiKhoan : ClsConnectDB
    {
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public bool CreateTaiKhoan(DTO_User dtoUser)
        {
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@ID", generateID()));
                command.Parameters.Add(new SqlParameter("@User", dtoUser.User));
                command.Parameters.Add(new SqlParameter("@Password", dtoUser.Password));
                command.Parameters.Add(new SqlParameter("@HoTen", dtoUser.HoTen));
                command.Parameters.Add(new SqlParameter("@CMND", dtoUser.CMND));
                command.Parameters.Add(new SqlParameter("@NgaySinh", dtoUser.NgaySinh));
                command.Parameters.Add(new SqlParameter("@DiaChi", dtoUser.DiaChi));
                ExecuteQueriesStoredProcedure(command, "CreateTaiKhoan");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
