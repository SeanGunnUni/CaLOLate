using CaLOLateAPI.Data;
using CaLOLateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CaLOLateAPI.Controllers
{
    public class BattlerController : ApiController
    {
        [EnableCors("*","*","*")]
        public IHttpActionResult GetBattler()
        {
            try
            {
                return Ok("Getting data");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            
        }
    }
}
