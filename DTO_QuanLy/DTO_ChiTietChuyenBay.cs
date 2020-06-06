using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietChuyenBay
    {
        private string CTChuyenBay_SanBayTrungGian;
        private string CTChuyenBay_ThoiGianDung;

        public DTO_ChiTietChuyenBay(string cTChuyenBay_SanBayTrungGian, string cTChuyenBay_ThoiGianDung)
        {
            CTChuyenBay_SanBayTrungGian = cTChuyenBay_SanBayTrungGian;
            CTChuyenBay_ThoiGianDung = cTChuyenBay_ThoiGianDung;
        }

        public string _CTChuyenBay_SanBayTrungGian { get => CTChuyenBay_SanBayTrungGian; set => CTChuyenBay_SanBayTrungGian = value; }
        public string _CTChuyenBay_ThoiGianDung { get => CTChuyenBay_ThoiGianDung; set => CTChuyenBay_ThoiGianDung = value; }
    }
}
