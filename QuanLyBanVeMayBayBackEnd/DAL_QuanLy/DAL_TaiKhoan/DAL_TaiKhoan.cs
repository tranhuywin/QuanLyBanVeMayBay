using DTO_QuanLy;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy.DAL_TaiKhoan
{
    public class DAL_TaiKhoan : ClsConnectDB
    {
        public DataTable LoadTaiKhoan(DTO_User dtoUser)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@User", dtoUser.User));
                command.Parameters.Add(new SqlParameter("@Password", dtoUser.Password));
                dt = ShowDataInTableStoredProcedure(command, "SelectChiTietTaiKhoan");
                return dt;
            }
            catch
            {
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public bool UpdateTaiKhoan(DTO_User dtoUser)
        {
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@User", dtoUser.User));
                command.Parameters.Add(new SqlParameter("@Password", dtoUser.Password));
                command.Parameters.Add(new SqlParameter("@HoTen", dtoUser.HoTen));
                command.Parameters.Add(new SqlParameter("@CMND", dtoUser.CMND));
                command.Parameters.Add(new SqlParameter("@NgaySinh", dtoUser.NgaySinh));
                command.Parameters.Add(new SqlParameter("@DiaChi", dtoUser.DiaChi));
                ExecuteQueriesStoredProcedure(command, "UpdateChiTietTaiKhoan");
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
