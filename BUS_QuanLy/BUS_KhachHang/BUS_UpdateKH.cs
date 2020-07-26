using DAL_QuanLy.DAL_KhachHang1;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Eventing.Reader;

namespace BUS_QuanLy.BUS_KhachHang
{

       public class BUS_UpdateKH
        {
            DAL_UpdateKH dalUpdateKH = new DAL_UpdateKH();
            public DataTable LoadThongTinKhachHang(DTO_KhachHang dtoKhachHang)
            {
            return dalUpdateKH.LoadDuLieuKH(dtoKhachHang);
            }
            public bool LoadUpdateKhachHang(DTO_KhachHang dtoKhachHang)
            {
                if (dalUpdateKH.UpdateKhachHang(dtoKhachHang)) return true;
                else return false;
            }
        }
    }

