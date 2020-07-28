using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BUS_QuanLy.BUS_ChinhSuaVe;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectApi_QuanLy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChínhuaVeController : ControllerBase
    {
        BUS_ThemChuyenBay busThemChuyenBay = new BUS_ThemChuyenBay();
        BUS_ChinhSuaVe busChinhSuaVe = new BUS_ChinhSuaVe();
        BUS_EditChuyenBay busEditChuyenBay = new BUS_EditChuyenBay();

        public class ObjectChuyenBay
        {
            public DTO_TuyenBay dtoTuyenBay { get; set; }
            public DTO_ChiTietChuyenBay dtoChiTieTChuyenBay { get; set; }
            public DTO_ChuyenBay dtoChuyenBay { get; set; }
        }
        [HttpPost("chinhsuachuyenbay")]
        public bool PostThemChuyenBay([FromBody] ObjectChuyenBay obj)
        {
            bool Update = busThemChuyenBay.LoadThemMoiChuyenBay(obj.dtoChiTieTChuyenBay,obj.dtoChuyenBay, obj.dtoTuyenBay);
            if (Update)
                return true;
            else
                return false;
        }
        [HttpPost("GetTableVe")]
        public string PostXuatPhat([FromBody] DTO_ChuyenBay dtoChuyenBay)
        {
            string JSONresult;
            DataTable dt = busChinhSuaVe.LoadTableVe(dtoChuyenBay);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }
        [HttpPost("LoadEditChuyenBay")]
        public bool PostLoadEditChuyenBay([FromBody] ObjectChuyenBay obj)
        {
            bool Update = busEditChuyenBay.LoadEditChuyenBay(obj.dtoChiTieTChuyenBay, obj.dtoChuyenBay, obj.dtoTuyenBay);
            if (Update)
                return true;
            else
                return false;
        }
    }
}
