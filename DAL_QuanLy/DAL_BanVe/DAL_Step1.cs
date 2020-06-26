using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QuanLy;
using System.Data;

namespace DAL_QuanLy.DAL_BanVe
{
    public class DAL_Step1: ClsConnectDB
    {
        public DataTable LoadSanBayComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                dt = ShowDataInGridViewStoredProcedure(command, "SelectAllSanBay");
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
