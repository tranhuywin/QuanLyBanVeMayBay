using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_VeChuyenBay
    {
        private string VeChuyenBay_MaVeChuyenBay;
        private string VeChuyenBay_TinhTrangVe;
        private string VeChuyenBay_MaChuyenBay;
        private string VeChuyenBay_MaDonGia;

        public DTO_VeChuyenBay(string veChuyenBay_MaVeChuyenBay, string veChuyenBay_TinhTrangVe, string veChuyenBay_MaChuyenBay, string veChuyenBay_MaDonGia)
        {
            VeChuyenBay_MaVeChuyenBay = veChuyenBay_MaVeChuyenBay;
            VeChuyenBay_TinhTrangVe = veChuyenBay_TinhTrangVe;
            VeChuyenBay_MaChuyenBay = veChuyenBay_MaChuyenBay;
            VeChuyenBay_MaDonGia = veChuyenBay_MaDonGia;
        }

        public string _VeChuyenBay_MaVeChuyenBay { get => VeChuyenBay_MaVeChuyenBay; set => VeChuyenBay_MaVeChuyenBay = value; }
        public string _VeChuyenBay_TinhTrangVe { get => VeChuyenBay_TinhTrangVe; set => VeChuyenBay_TinhTrangVe = value; }
        public string _VeChuyenBay_MaChuyenBay { get => VeChuyenBay_MaChuyenBay; set => VeChuyenBay_MaChuyenBay = value; }
        public string _VeChuyenBay_MaDonGia { get => VeChuyenBay_MaDonGia; set => VeChuyenBay_MaDonGia = value; }
    }
}
