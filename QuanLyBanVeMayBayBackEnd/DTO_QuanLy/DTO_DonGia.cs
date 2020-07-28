using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_DonGia
    {
        private string DonGia_MaDonGia;
        private int DonGia_USD;
        private int DonGia_VND;

        public DTO_DonGia(string donGia_MaDonGia, int donGia_USD, int donGia_VND)
        {
            DonGia_MaDonGia = donGia_MaDonGia;
            DonGia_USD = donGia_USD;
            DonGia_VND = donGia_VND;
        }

        public string _DonGia_MaDonGia { get => DonGia_MaDonGia; set => DonGia_MaDonGia = value; }
        public int _DonGia_USD { get => DonGia_USD; set => DonGia_USD = value; }
        public int _DonGia_VND { get => DonGia_VND; set => DonGia_VND = value; }
    }
}
