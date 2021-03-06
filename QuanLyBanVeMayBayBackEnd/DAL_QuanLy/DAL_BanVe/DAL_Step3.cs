﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy.DAL_BanVe
{
    public class DAL_Step3 : ClsConnectDB
    {
        public bool InsertKhachHang(DTO_KhachHang dtokhachhang)
        {
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@CMND", dtokhachhang.CMND));
                command.Parameters.Add(new SqlParameter("@HoTenKH", dtokhachhang.HoTenKH));
                command.Parameters.Add(new SqlParameter("@GioiTinh", dtokhachhang.GioiTinh));
                command.Parameters.Add(new SqlParameter("@SDT", dtokhachhang.SDT));
                command.Parameters.Add(new SqlParameter("@Email", dtokhachhang.Email));
                command.Parameters.Add(new SqlParameter("@maKH", dtokhachhang.MaKhachHang));
                ExecuteQueriesStoredProcedure(command, "INSERT_STEP3_KHACHHANG");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool ChangeTrangThaiVe(DTO_PhieuDatCho dtoPhieuDatChoXuatPhat)
        {
            try
            {
                OpenConection();
                SqlCommand command = new SqlCommand();
                command.Parameters.Add(new SqlParameter("@MaChuyenBay", dtoPhieuDatChoXuatPhat.MaChuyenBay));
                command.Parameters.Add(new SqlParameter("@MaPhieu", dtoPhieuDatChoXuatPhat.MaPhieu));
                command.Parameters.Add(new SqlParameter("@SoGhe", dtoPhieuDatChoXuatPhat.SoGhe));
                ExecuteQueriesStoredProcedure(command, "UpdateTrangThaiVeChuyenBay");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool InsertPhieu(DTO_PhieuDatCho dtoPhieuDatChoXuatPhat)
        {
            try
            {
            OpenConection();
            SqlCommand command = new SqlCommand();
            command.Parameters.Add(new SqlParameter("@MaChuyenBay", dtoPhieuDatChoXuatPhat.MaChuyenBay));
            command.Parameters.Add(new SqlParameter("@MaPhieu", dtoPhieuDatChoXuatPhat.MaPhieu.Remove(10)));
            command.Parameters.Add(new SqlParameter("@SoGhe", dtoPhieuDatChoXuatPhat.SoGhe));
            command.Parameters.Add(new SqlParameter("@MaKH", dtoPhieuDatChoXuatPhat.MaKH.Remove(10)));
            ExecuteQueriesStoredProcedure(command, "InsertPhieuDatCho");
            return true;
            }
            catch
            {
                return false;
            }
            finally
            {
            CloseConnection();
            }
        }
    }
}
