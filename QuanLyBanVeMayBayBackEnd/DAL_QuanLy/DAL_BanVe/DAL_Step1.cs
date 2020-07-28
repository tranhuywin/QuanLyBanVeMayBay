using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLy.DAL_BanVe
{
    public class DAL_Step1 : ClsConnectDB
    {
        public DataTable LoadSanBayComboBox()
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
