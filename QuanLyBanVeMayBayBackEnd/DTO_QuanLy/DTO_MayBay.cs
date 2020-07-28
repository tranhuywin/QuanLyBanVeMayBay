using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_MayBay
    {
        private string Maybay_MaMayBay;
        private string MayBay_MaChuyenBay;
        private string Maybay_TenMayBay;

        public DTO_MayBay(string maybay_MaMayBay, string mayBay_MaChuyenBay, string maybay_TenMayBay)
        {
            Maybay_MaMayBay = maybay_MaMayBay;
            MayBay_MaChuyenBay = mayBay_MaChuyenBay;
            Maybay_TenMayBay = maybay_TenMayBay;
        }

        public string _Maybay_MaMayBay { get => Maybay_MaMayBay; set => Maybay_MaMayBay = value; }
        public string _MayBay_MaChuyenBay { get => MayBay_MaChuyenBay; set => MayBay_MaChuyenBay = value; }
        public string _Maybay_TenMayBay { get => Maybay_TenMayBay; set => Maybay_TenMayBay = value; }
    }
}
