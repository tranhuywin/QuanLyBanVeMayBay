using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DTO_QuanLy
{
    public class DTO_TuyenBay
    {
        private string TuyenBay_MaTuyenBay;
        private string TuyenBay_SanBayDi;
        private string TuyenBay_SanBayDen;
        private string TuyenBay_MaSanBay;

        public DTO_TuyenBay(string tuyenBay_MaTuyenBay, string tuyenBay_SanBayDi, string tuyenBay_SanBayDen, string tuyenBay_MaSanBay)
        {
            TuyenBay_MaTuyenBay = tuyenBay_MaTuyenBay;
            TuyenBay_SanBayDi = tuyenBay_SanBayDi;
            TuyenBay_SanBayDen = tuyenBay_SanBayDen;
            TuyenBay_MaSanBay = tuyenBay_MaSanBay;
        }

        public string _TuyenBay_MaTuyenBay { get => TuyenBay_MaTuyenBay; set => TuyenBay_MaTuyenBay = value; }
        public string _TuyenBay_SanBayDi { get => TuyenBay_SanBayDi; set => TuyenBay_SanBayDi = value; }
        public string _TuyenBay_SanBayDen { get => TuyenBay_SanBayDen; set => TuyenBay_SanBayDen = value; }
        public string _TuyenBay_MaSanBay { get => TuyenBay_MaSanBay; set => TuyenBay_MaSanBay = value; }
    }
}
