using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL_QuanLy.DAL_ChinhSuaVe
{
   public class DAL_ChinhSuaVe : ClsConnectDB
    {
        public DataTable LoadTableVeChuyenBay(DTO_ChuyenBay dtoChuyenBay)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@MaChuyenBay", dtoChuyenBay.MaChuyenBay));
                dt = ShowDataInTableStoredProcedure(command, "SelectTheoMachuyenbay");
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
