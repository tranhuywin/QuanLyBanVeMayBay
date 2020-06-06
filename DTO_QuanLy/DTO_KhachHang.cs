using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {
        private string KhachHang_MaKhachHang;
        private string KhachHang_HoTenKH;
        private string KhachHang_SDT;
        private string KhachHang_Email;
        private string KhachHang_GioiTinh;
        private string KhachHang_CMND;

        public DTO_KhachHang(string khachHang_MaKhachHang, string khachHang_HoTenKH, string khachHang_SDT, string khachHang_Email, string khachHang_GioiTinh, string khachHang_CMND)
        {
            KhachHang_MaKhachHang = khachHang_MaKhachHang;
            KhachHang_HoTenKH = khachHang_HoTenKH;
            KhachHang_SDT = khachHang_SDT;
            KhachHang_Email = khachHang_Email;
            KhachHang_GioiTinh = khachHang_GioiTinh;
            KhachHang_CMND = khachHang_CMND;
        }

        public string _KhachHang_MaKhachHang { get => KhachHang_MaKhachHang; set => KhachHang_MaKhachHang = value; }
        public string _KhachHang_HoTenKH { get => KhachHang_HoTenKH; set => KhachHang_HoTenKH = value; }
        public string _KhachHang_SDT { get => KhachHang_SDT; set => KhachHang_SDT = value; }
        public string _KhachHang_Email { get => KhachHang_Email; set => KhachHang_Email = value; }
        public string _KhachHang_GioiTinh { get => KhachHang_GioiTinh; set => KhachHang_GioiTinh = value; }
        public string _KhachHang_CMND { get => KhachHang_CMND; set => KhachHang_CMND = value; }
    }
}
