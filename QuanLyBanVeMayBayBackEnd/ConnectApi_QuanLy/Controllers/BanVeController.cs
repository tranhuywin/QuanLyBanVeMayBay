using System.Data;
using BUS_QuanLy.BUS_BanVe;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConnectApi_QuanLy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BanVeController : ControllerBase
    {
        BUS_Step1 busStep1 = new BUS_Step1();
        BUS_Step2 busStep2 = new BUS_Step2();
        BUS_Step3 busStep3 = new BUS_Step3();
        public class ObjectPostLoadVe
        {
            public DTO_ChuyenBay dtochuyenbay { get; set; }
            public DTO_TuyenBay dtoTuyenBay { get; set; }
        }

        [HttpGet("Step1/Load-San-Bay-ComboBox")]
        public string Get()
        {
            string JSONresult;
            DataTable dt = busStep1.LoadSanBayComboBox();
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        [HttpPost("Step2/load-ve-may-bay-xuat-phat")]
        public string PostXuatPhat([FromBody] ObjectPostLoadVe objLoadVe)
        {
            string JSONresult;
            DataTable dt = busStep2.LoadVeMayBayDatagridViewXuatPhat(objLoadVe.dtochuyenbay, objLoadVe.dtoTuyenBay);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        [HttpPost("Step2/load-ve-may-bay-khu-hoi")]
        public string PostKhuHoi([FromBody] ObjectPostLoadVe objLoadVe)
        {
            string JSONresult;
            DataTable dt = busStep2.LoadVeMayBayDatagridViewKhuHoi(objLoadVe.dtochuyenbay, objLoadVe.dtoTuyenBay);
            JSONresult = JsonConvert.SerializeObject(dt);
            return JSONresult;
        }

        [HttpPost("Step3/insert-khach-hang")]
        public bool PostKhachHang([FromBody] DTO_KhachHang dtoKhachHang)
        {
            bool Insert = busStep3.InsertKhachHang(dtoKhachHang);
            if (Insert)
                return true;
            else
                return false;
        }

        [HttpPost("Step3/change-trang-thai")]
        public bool PostPhieuDatCho([FromBody] DTO_PhieuDatCho dtoPhieuDatCho)
        {
            bool change = busStep3.ChangeTrangThaiVe(dtoPhieuDatCho);
            if (change)
                return true;
            else
                return false;
        }
    }
    
}
