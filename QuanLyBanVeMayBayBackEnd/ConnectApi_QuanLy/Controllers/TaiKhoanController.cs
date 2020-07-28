using System.Data;
using BUS_QuanLy.BUS_TaiKhoan;
using BUS_QuanLy.BUS_TaoTaiKhoan;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectApi_QuanLy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaiKhoanController : ControllerBase
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_TaoTaiKhoan busTaoTaiKhoan = new BUS_TaoTaiKhoan();
        [HttpPost("load-tai-khoan")]
        public string LoadTaiKhoan([FromBody] DTO_User dtoUser)
        {
            string JSONresult;
            DataTable dt = busTaiKhoan.LoadTaiKhoan(dtoUser);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        [HttpPost("luu-tai-khoan")]
        public bool LuuTaiKhoan([FromBody] DTO_User dtoUser)
        {
            bool luu;
            luu = busTaiKhoan.LuuTaiKhoan(dtoUser);
            if (luu)
                return true;
            else return false;
        }
        [HttpPost("Createtaikhoan")]
        public bool createTaiKhoan([FromBody] DTO_User dtoUser)
        {
            bool create;
            create = busTaoTaiKhoan.TaoTaiKhoan(dtoUser);
            if (create)
                return true;
            else return false;
        }
    }
}
