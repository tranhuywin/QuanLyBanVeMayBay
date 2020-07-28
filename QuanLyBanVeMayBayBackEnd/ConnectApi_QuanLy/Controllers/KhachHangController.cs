using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BUS_QuanLy.BUS_ChinhSuaKH;
using BUS_QuanLy.BUS_KhachHang;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectApi_QuanLy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KhachHangController : ControllerBase
    {
        BUS_ChinhSuaKH busChinhSuaKH = new BUS_ChinhSuaKH();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_XoaKH busXoaKH = new BUS_XoaKH();
        BUS_UpdateKH busUpdateKH = new BUS_UpdateKH();

        [HttpPost("chinhsuakhachhang")]
        public bool PostKhachHang([FromBody] DTO_KhachHang dtoKhachHang)
        {
            bool Update = busChinhSuaKH.LoadThemMoiKhachHang(dtoKhachHang);
            if (Update)
                return true;
            else
                return false;
        }
        [HttpPost("loadKhachHangCombobox")]
        public string PostloadKHConbobox([FromBody] DTO_KhachHang dtoKhachHang1)
        {
            string JSONresult;
            DataTable dt = busKhachHang.LoadKhachHangComboBox(dtoKhachHang1);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }
        [HttpPost("xoakhachhang")]
        public bool PostXoaKhachHang([FromBody] DTO_KhachHang dtoKhachHang)
        {
            bool Delete = busXoaKH.XoaKhachHang(dtoKhachHang);
            if (Delete)
                return true;
            else
                return false;
        }
        [HttpPost("updatekhachhang")]
        public bool PostupdateKhachHang([FromBody] DTO_KhachHang dtoKhachHang)
        {
            bool update = busUpdateKH.LoadUpdateKhachHang(dtoKhachHang);
            if (update)
                return true;
            else
                return false;
        }
    }
}
