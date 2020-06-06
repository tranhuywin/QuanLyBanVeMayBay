using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChuyenBay
    {
        private string ChuyenBay_MaChuyenBay;
        private string Chuyenbay_NgayGio;
        private string Chuyenbay_ThoiGianBay;
        private int Chuyenbay_SoGheHang1;
        private int ChuyenBay_SoGheHang2;
        private string ChuyenBay_MaTuyenBay;
        private string ChuyenBay_MaChiTietChuyenBay;

        public DTO_ChuyenBay(string chuyenBay_MaChuyenBay, string chuyenbay_NgayGio, string chuyenbay_ThoiGianBay, int chuyenbay_SoGheHang1, int chuyenBay_SoGheHang2, string chuyenBay_MaTuyenBay, string chuyenBay_MaChiTietChuyenBay)
        {
            ChuyenBay_MaChuyenBay = chuyenBay_MaChuyenBay;
            Chuyenbay_NgayGio = chuyenbay_NgayGio;
            Chuyenbay_ThoiGianBay = chuyenbay_ThoiGianBay;
            Chuyenbay_SoGheHang1 = chuyenbay_SoGheHang1;
            ChuyenBay_SoGheHang2 = chuyenBay_SoGheHang2;
            ChuyenBay_MaTuyenBay = chuyenBay_MaTuyenBay;
            ChuyenBay_MaChiTietChuyenBay = chuyenBay_MaChiTietChuyenBay;
        }

        public string _ChuyenBay_MaChuyenBay { get => ChuyenBay_MaChuyenBay; set => ChuyenBay_MaChuyenBay = value; }
        public string _Chuyenbay_NgayGio { get => Chuyenbay_NgayGio; set => Chuyenbay_NgayGio = value; }
        public string _Chuyenbay_ThoiGianBay { get => Chuyenbay_ThoiGianBay; set => Chuyenbay_ThoiGianBay = value; }
        public int _Chuyenbay_SoGheHang1 { get => Chuyenbay_SoGheHang1; set => Chuyenbay_SoGheHang1 = value; }
        public int _ChuyenBay_SoGheHang2 { get => ChuyenBay_SoGheHang2; set => ChuyenBay_SoGheHang2 = value; }
        public string _ChuyenBay_MaTuyenBay { get => ChuyenBay_MaTuyenBay; set => ChuyenBay_MaTuyenBay = value; }
        public string _ChuyenBay_MaChiTietChuyenBay { get => ChuyenBay_MaChiTietChuyenBay; set => ChuyenBay_MaChiTietChuyenBay = value; }
    }
}
