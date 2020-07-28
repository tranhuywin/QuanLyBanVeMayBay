using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.DAL_KhachHang
{
    public class DAL_ChinhSuaKH : ClsConnectDB
    {
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        public bool ThemMoiKhachHang(DTO_KhachHang dtoKhachHang)
        {
           
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@MaKH", generateID()));
                command.Parameters.Add(new SqlParameter("@CMND", dtoKhachHang.CMND));
                command.Parameters.Add(new SqlParameter("@HoTenKH", dtoKhachHang.HoTenKH));
                command.Parameters.Add(new SqlParameter("@Email", dtoKhachHang.Email));
                command.Parameters.Add(new SqlParameter("@SDT", dtoKhachHang.SDT));
                command.Parameters.Add(new SqlParameter("@GioiTinh", dtoKhachHang.GioiTinh));
                ExecuteQueriesStoredProcedure(command, "ThemMoiKhachHang");
                return (true);
            }
            catch
            {
                return (false);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
