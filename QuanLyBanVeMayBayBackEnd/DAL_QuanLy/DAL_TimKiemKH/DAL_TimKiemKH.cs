using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.DAL_TimKiemKH
{
    public class DAL_TimKiemKH : ClsConnectDB
    {
        public DataTable LoadKhachHang(DTO_KhachHang dtoKhachHang)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@CMND", dtoKhachHang.CMND));
                command.Parameters.Add(new SqlParameter("@HoTenKH", dtoKhachHang.HoTenKH));
                command.Parameters.Add(new SqlParameter("@Email", dtoKhachHang.Email));
                command.Parameters.Add(new SqlParameter("@SDT", dtoKhachHang.SDT));
                dt = ShowDataInTableStoredProcedure(command, "SelectKhachHang");
                return dt;
            }
            catch
            {
                return dt;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
