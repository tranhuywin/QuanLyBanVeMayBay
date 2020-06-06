using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HoaDon
    {
        private string HoaDon_MaHoaDon;
        private string HoaDon_NgayLap;
        private int HoaDon_ThanhTien;
        private string HoaDon_Id;
        private string HoaDon_MaKH;

        public DTO_HoaDon(string hoaDon_MaHoaDon, string hoaDon_NgayLap, int hoaDon_ThanhTien, string hoaDon_Id, string hoaDon_MaKH)
        {
            HoaDon_MaHoaDon = hoaDon_MaHoaDon;
            HoaDon_NgayLap = hoaDon_NgayLap;
            HoaDon_ThanhTien = hoaDon_ThanhTien;
            HoaDon_Id = hoaDon_Id;
            HoaDon_MaKH = hoaDon_MaKH;
        }

        public string _HoaDon_MaHoaDon { get => HoaDon_MaHoaDon; set => HoaDon_MaHoaDon = value; }
        public string _HoaDon_NgayLap { get => HoaDon_NgayLap; set => HoaDon_NgayLap = value; }
        public int _HoaDon_ThanhTien { get => HoaDon_ThanhTien; set => HoaDon_ThanhTien = value; }
        public string _HoaDon_Id { get => HoaDon_Id; set => HoaDon_Id = value; }
        public string _HoaDon_MaKH { get => HoaDon_MaKH; set => HoaDon_MaKH = value; }
    }
}
