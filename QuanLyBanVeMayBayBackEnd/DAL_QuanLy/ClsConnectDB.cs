using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class ClsConnectDB
    {
        //string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        string ConnectionString = "Data Source=banvemaybay.database.windows.net;Initial Catalog=QuanlyLBanVeMayBay;User ID=tranhuywin;Password=122771535Win";
        SqlConnection con;
        public void OpenConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }
        public void CloseConnection()
        {
            con.Close();
        }
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }
        public void ExecuteQueriesStoredProcedure(SqlCommand cmd, string CommandText)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = CommandText;
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataReader DataReaderStoredProcedure(SqlCommand cmd, string CommandText)
        {
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = CommandText;
            SqlDataReader dta = cmd.ExecuteReader();
            return dta;
        }
        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
        public DataTable ShowDataInTableStoredProcedure(SqlCommand cmd, string CommandText) // do du lieu tu Table cua CSDL vao DataTable. Combobox va DataGridView
        {
            DataTable dt = new DataTable();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = CommandText;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
