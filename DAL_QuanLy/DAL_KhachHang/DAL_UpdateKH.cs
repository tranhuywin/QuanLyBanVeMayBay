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
    public class DAL_UpdateKH: ClsConnectDB
    {
        public DataTable LoadDuLieuKH(DTO_KhachHang dtoKhachHang)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@MaKH", dtoKhachHang.MaKhachHang));
                command.Parameters.Add(new SqlParameter("@CMND", dtoKhachHang.CMND));
                command.Parameters.Add(new SqlParameter("@HoTenKH", dtoKhachHang.HoTenKH));
                command.Parameters.Add(new SqlParameter("@Email", dtoKhachHang.Email));
                command.Parameters.Add(new SqlParameter("@SDT", dtoKhachHang.SDT));
                command.Parameters.Add(new SqlParameter("@GioiTinh", dtoKhachHang.GioiTinh));
                DataReaderStoredProcedure(command, "LoadDuLieuKH");
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
        public bool UpdateKhachHang(DTO_KhachHang dtoKhachHang)
        {

            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@MaKH", dtoKhachHang.MaKhachHang));
                command.Parameters.Add(new SqlParameter("@CMND", dtoKhachHang.CMND));
                command.Parameters.Add(new SqlParameter("@HoTenKH", dtoKhachHang.HoTenKH));
                command.Parameters.Add(new SqlParameter("@Email", dtoKhachHang.Email));
                command.Parameters.Add(new SqlParameter("@SDT", dtoKhachHang.SDT));
                command.Parameters.Add(new SqlParameter("@GioiTinh", dtoKhachHang.GioiTinh));
                ExecuteQueriesStoredProcedure(command, "UpdateKhachHang");
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
