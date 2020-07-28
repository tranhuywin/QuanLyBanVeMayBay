using DAL_QuanLy.DAL_BanVe;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy.BUS_BanVe
{
    public class BUS_Step3
    {
        private DAL_Step3 dalstep3 = new DAL_Step3();
        public bool InsertKhachHang(DTO_KhachHang dtokhachhang)
        {
            if (dalstep3.InsertKhachHang(dtokhachhang))
                return true;
            else
                return false;
        }
        public bool ChangeTrangThaiVe(DTO_PhieuDatCho dtoPhieuDatChoXuatPhat)
        {
            bool insert = dalstep3.InsertPhieu(dtoPhieuDatChoXuatPhat);
            if (!insert)
            {
                return false;
            }
            return (dalstep3.ChangeTrangThaiVe(dtoPhieuDatChoXuatPhat));
        }
    }
}
