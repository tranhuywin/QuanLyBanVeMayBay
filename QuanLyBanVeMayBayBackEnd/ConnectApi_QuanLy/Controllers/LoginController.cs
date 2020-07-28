using BUS_QuanLy;
using DTO_QuanLy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackEndQLBanVeMayBay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly BUS_Login busLogin = new BUS_Login();

        // POST: api/Login
        public bool Post([FromBody]DTO_User dtoUser)
        {
            bool checkuser = busLogin.KiemTraUser(dtoUser); //  truyen DTO user qua BUS de xu ly thong tin
            if (checkuser == true)  // neu Bus login tra ve dung
            {
                return true; // true. neu co user
            }
            else
            {
                return false; // false. neu k co user
            }
        }

        // GET: api/Login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(string value)
        {
            return value;
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
