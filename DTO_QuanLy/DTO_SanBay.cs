using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_SanBay
    {
        private string SanBay_MaSanBay;
        private string SanBay_TenSanBay;

        public DTO_SanBay(string sanBay_MaSanBay, string sanBay_TenSanBay)
        {
            SanBay_MaSanBay = sanBay_MaSanBay;
            SanBay_TenSanBay = sanBay_TenSanBay;
        }

        public string _SanBay_MaSanBay { get => SanBay_MaSanBay; set => SanBay_MaSanBay = value; }
        public string _SanBay_TenSanBay { get => SanBay_TenSanBay; set => SanBay_TenSanBay = value; }
    }
}
