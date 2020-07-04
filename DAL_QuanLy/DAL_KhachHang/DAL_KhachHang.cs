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
    public class DAL_KhachHang : ClsConnectDB
    {
        public DataTable LoadKhachHangDataGridView(DTO_KhachHang dtoKhachHang)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@CMND", dtoKhachHang.CMND));
                command.Parameters.Add(new SqlParameter("@HoTenKH", dtoKhachHang.HoTenKH));
                dt = ShowDataInTableStoredProcedure(command, "SelectKhachHangTheoTenVaCMND");
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
    }

}
