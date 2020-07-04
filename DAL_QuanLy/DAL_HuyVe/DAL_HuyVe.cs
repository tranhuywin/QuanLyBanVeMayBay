using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.DAL_HuyVe
{
    public class DAL_HuyVe : ClsConnectDB
    {
        public DataTable LoadDataTableHuyVe(DTO_KhachHang dtoKhachHang, DTO_VeChuyenBay dtoVeChuyenbay)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@CMND", dtoKhachHang.CMND));
                command.Parameters.Add(new SqlParameter("@MaVeChuyenBay", dtoVeChuyenbay.MaVeChuyenBay));
                dt = ShowDataInTableStoredProcedure(command, "SelectKhachHangVaVeChuyenBay");
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
        public bool DeleteVeChuyenBay(DTO_VeChuyenBay dtoVeChuyenBay)
        {
            return true;
        }
    }
}
