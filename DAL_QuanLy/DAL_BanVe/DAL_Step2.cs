using DTO_QuanLy;
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
        public DataTable LoadVeMayBayDataGridView(DTO_ChuyenBay dtoChuyenBay, DTO_TuyenBay dtoTuyenBay)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@NgayGio", dtoChuyenBay.NgayGio));
                command.Parameters.Add(new SqlParameter("@ThoiGianBay", dtoChuyenBay.ThoiGianBay));
                command.Parameters.Add(new SqlParameter("@SogheHang1", dtoChuyenBay.SoGheHang1));
                command.Parameters.Add(new SqlParameter("@SoGheHang2", dtoChuyenBay.SoGheHang2));
                command.Parameters.Add(new SqlParameter("@SanBayDi", dtoTuyenBay.SanBayDi));
                command.Parameters.Add(new SqlParameter("@SanBayDen", dtoTuyenBay.SanBayDen));
                dt = ShowDataInTableStoredProcedure(command, "SelectVeMayBayXuatPhat");
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
    }
}
