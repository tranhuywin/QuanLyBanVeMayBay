using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_HangVe
    {
        private string HangVe_MaHangVe;
        private string HangVe_TenHangVe;
        private string HangVe_MaVeChuyenBay;
        private string HangVe_MaPhieu;

        public DTO_HangVe(string hangVe_MaHangVe, string hangVe_TenHangVe, string hangVe_MaVeChuyenBay, string hangVe_MaPhieu)
        {
            HangVe_MaHangVe = hangVe_MaHangVe;
            HangVe_TenHangVe = hangVe_TenHangVe;
            HangVe_MaVeChuyenBay = hangVe_MaVeChuyenBay;
            HangVe_MaPhieu = hangVe_MaPhieu;
        }

        public string _HangVe_MaHangVe { get => HangVe_MaHangVe; set => HangVe_MaHangVe = value; }
        public string _HangVe_TenHangVe { get => HangVe_TenHangVe; set => HangVe_TenHangVe = value; }
        public string _HangVe_MaVeChuyenBay { get => HangVe_MaVeChuyenBay; set => HangVe_MaVeChuyenBay = value; }
        public string _HangVe_MaPhieu { get => HangVe_MaPhieu; set => HangVe_MaPhieu = value; }
    }
}
