using System.Data;
using BUS_QuanLy.BUS_TimKiemKH;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectApi_QuanLy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimKiemKHController : ControllerBase
    {
        BUS_TimKiemKH busTimKiemKH = new BUS_TimKiemKH();
        [HttpPost("tim-khach-hang")]
        public string PostXuatPhat([FromBody] DTO_KhachHang dtoKhachHang)
        {
            string JSONresult;
            DataTable dt = busTimKiemKH.LoadKhachHang(dtoKhachHang);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }
    }
}
