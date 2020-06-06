using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhieuDatCho
    {
        private string PhieuDatCho_MaPhieu;
        private string PhieuDatCho_NgayDat;
        private string PhieuDatCho_SoGhe;
        private string PhieuDatCho_MaKH;
        private string PhieuDatCho_MaChuyenBay;

        public DTO_PhieuDatCho(string phieuDatCho_MaPhieu, string phieuDatCho_NgayDat, string phieuDatCho_SoGhe, string phieuDatCho_MaKH, string phieuDatCho_MaChuyenBay)
        {
            PhieuDatCho_MaPhieu = phieuDatCho_MaPhieu;
            PhieuDatCho_NgayDat = phieuDatCho_NgayDat;
            PhieuDatCho_SoGhe = phieuDatCho_SoGhe;
            PhieuDatCho_MaKH = phieuDatCho_MaKH;
            PhieuDatCho_MaChuyenBay = phieuDatCho_MaChuyenBay;
        }

        public string _PhieuDatCho_MaPhieu { get => PhieuDatCho_MaPhieu; set => PhieuDatCho_MaPhieu = value; }
        public string _PhieuDatCho_NgayDat { get => PhieuDatCho_NgayDat; set => PhieuDatCho_NgayDat = value; }
        public string _PhieuDatCho_SoGhe { get => PhieuDatCho_SoGhe; set => PhieuDatCho_SoGhe = value; }
        public string _PhieuDatCho_MaKH { get => PhieuDatCho_MaKH; set => PhieuDatCho_MaKH = value; }
        public string _PhieuDatCho_MaChuyenBay { get => PhieuDatCho_MaChuyenBay; set => PhieuDatCho_MaChuyenBay = value; }
    }
}
