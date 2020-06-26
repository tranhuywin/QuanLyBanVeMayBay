using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.DAL_BanVe
{
    public class DAL_Step2: ClsConnectDB
    {
        public DataTable LoadVeMayBayDataGridView()
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                dt = ShowDataInTableStoredProcedure(command, "SelectAllSanBay");
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
