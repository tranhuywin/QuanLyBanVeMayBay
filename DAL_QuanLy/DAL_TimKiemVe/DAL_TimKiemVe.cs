using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;
using System.Data.Common;

namespace DAL_QuanLy.DAL_TimKiemVe
{
    class DAL_TimKiemVe : ClsConnectDB
    {
        public DataTable LoadDataTableTimKiemVe(List<DTO_KhachHang> lsObjKH,
            List<DTO_TuyenBay> lsObjTB, List<DTO_VeChuyenBay> lsObjVCB,String _cmnd, String _mave, 
            String _sanbaydi, String _sanbayden)
        {
            String query = String.Empty;
            query += " SELECT [HoTenKH], [CMND], [MaVeChuyenBay],";
            query += " [SanBayDi], [SanBayDen]";
            query += " FROM [ChuyenBay] JOIN [TuyenBay] ON [ChuyenBay.MaTuyenBay] = [TuyenBay.MaTuyenBay";
            query += " JOIN [VeChuyenBay] ON [VeChuyenBay.MaChuyenBay] = [ChuyenBay.MaChuyenBay]";
            query += " JOIN [PhieuDatCho] ON [PhieuDatCho.MaChuyenBay] = [ChuyenBay.MaChuyenBay]";
            query += " JOIN [KhachHang] ON [PhieuDatCho.MaKH] = [KhachHang.MaKH]";
            query += " WHERE";
            query += " [HoTenKH] LIKE CONCAT('%',@HoTenKH,'%')) OR";
            query += " [CMND] LIKE CONCAT('%',@CMND,'%')) OR";
            query += " [MaVeChuyenBay] LIKE CONCAT('%',@MaVeChuyenBay,'%')) OR";
            query += " [SanBayDi] LIKE CONCAT('%',@SanBayDi,'%'))";
            query += " [SanBayDi] LIKE CONCAT('%',@SanBayDen,'%'))";

            DataTable dt = new DataTable();

            try
            {
                OpenConection();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@CMND", _cmnd);
                    command.Parameters.AddWithValue("@MaVe", _mave);
                    command.Parameters.AddWithValue("@SanBayDi", _sanbaydi);
                    command.Parameters.AddWithValue("@SanBayDen", _sanbayden);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        lsObjKH.Clear();
                        lsObjTB.Clear();
                        while (reader.Read())
                        {
                            DTO_KhachHang objKH = new DTO_KhachHang();
                            DTO_TuyenBay objTB = new DTO_TuyenBay();
                            DTO_VeChuyenBay objVCB = new DTO_VeChuyenBay();

                            objKH.HoTenKH = reader["HoTenKH"].ToString();
                            objKH.CMND = reader["CMND"].ToString();
                            objVCB.MaVeChuyenBay = reader["MaVeChuyenBay"].ToString();    
                            objTB.SanBayDi = reader["SanBayDi"].ToString();
                            objTB.SanBayDen = reader["SanBayDen"].ToString();
                            lsObjKH.Add(objKH);
                            lsObjTB.Add(objTB);
                            lsObjVCB.Add(objVCB);

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
