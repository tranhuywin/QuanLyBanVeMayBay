using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;
using System.Data.Common;

namespace DAL_QuanLy.DAL_TimKiemKH
{
    public class DAL_TimKiemKH : ClsConnectDB
    {
        public DataTable TimKiemKH(List<DTO_KhachHang> lsObj,
            String _hoten, String _email, String _sdt, String _cmnd)
        {
            String query = String.Empty;
            query += " SELECT * ";
            query += " FROM [KhachHang]";
            query += " WHERE";
            query += " [HoTenKH] = @HotenKH OR";
            query += " [Email] = @Email OR";
            query += " [SDT] = @SDT OR";
            query += " [CMND] = @CMND";

            DataTable dt = new DataTable();

            try
            {
                OpenConection();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@HoTenKH", _hoten);
                    command.Parameters.AddWithValue("@Email", _email);
                    command.Parameters.AddWithValue("@SDT", _sdt);
                    command.Parameters.AddWithValue("@CMND", _cmnd);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        lsObj.Clear();
                        while (reader.Read())
                        {
                            DTO_KhachHang obj = new DTO_KhachHang();
                            obj.HoTenKH = reader["HoTenKH"].ToString();
                            obj.Email = reader["Email"].ToString();
                            obj.SDT = reader["SDT"].ToString();
                            obj.CMND = reader["CMND"].ToString();
                            lsObj.Add(obj);

                            dt = ShowDataInTableStoredProcedure(command, query);

                            return dt;
                        }
                        return dt;
                    }
                    else
                    {
                        return dt;
                    }
                }
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
