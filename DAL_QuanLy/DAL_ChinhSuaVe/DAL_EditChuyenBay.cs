using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy.DAL_ChinhSuaVe
{
    public class DAL_EditChuyenBay: ClsConnectDB
    {
        public bool EditChuyenBay(DTO_ChiTietChuyenBay dtoChiTietChuyenBay, DTO_ChuyenBay dtoChuyenBay, DTO_TuyenBay dtoTuyenBay)
        {

            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                /*command.Parameters.Add(new SqlParameter("@cttbMaChiTietChuyenBay", dtoChiTietChuyenBay.MaChiTietChuyenBay));///
                command.Parameters.Add(new SqlParameter("@tbMaTuyenBay", dtoTuyenBay.MaTuyenBay));//*/
                command.Parameters.Add(new SqlParameter("@MaChuyenBay", dtoChuyenBay.MaChuyenBay));
                command.Parameters.Add(new SqlParameter("@SanBayDi", dtoTuyenBay.SanBayDi));
                command.Parameters.Add(new SqlParameter("@SanBayDen", dtoTuyenBay.SanBayDen));
                command.Parameters.Add(new SqlParameter("@NgayGio", dtoChuyenBay.NgayGio));
                command.Parameters.Add(new SqlParameter("@ThoiGianBay", dtoChuyenBay.ThoiGianBay));
                command.Parameters.Add(new SqlParameter("@ThoiGianDung", dtoChiTietChuyenBay.ThoiGianDung));
                command.Parameters.Add(new SqlParameter("@SanBayTrungGian", dtoChiTietChuyenBay.SanBayTrungGian));
                command.Parameters.Add(new SqlParameter("@TenMayBay", dtoChuyenBay.TenMayBay));
                ExecuteQueriesStoredProcedure(command, "EditChuyenBay");
                return (true);
            }
            catch
            {
                return (false);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
