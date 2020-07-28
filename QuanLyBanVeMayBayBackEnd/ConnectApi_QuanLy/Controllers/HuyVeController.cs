using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BUS_QuanLy.BUS_HuyVe;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectApi_QuanLy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HuyVeController : ControllerBase
    {
        BUS_HuyVe busHuyVe = new BUS_HuyVe();
        public class ObjectPostHuyVe
        {
            public DTO_KhachHang dtoKhachHang { get; set; }
            public DTO_VeChuyenBay dtoVeChuyenBay { get; set; }
        }

        [HttpPost("huy-ve")]
        public bool PostPhieuHuy([FromBody] DTO_VeChuyenBay dtoVeChuyenBay)
        {
            bool delete = busHuyVe.DeleteVeChuyenBay(dtoVeChuyenBay);
            if (delete)
                return true;
            else
                return false;
        }

        [HttpPost("load-ve-may-bay-huy")]
        public string PostLoadVe(ObjectPostHuyVe objhuyve)
        {
            string JSONresult;
            DataTable dt = busHuyVe.LoadDataGridViewHuyVe(objhuyve.dtoKhachHang, objhuyve.dtoVeChuyenBay);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }
    }
}
