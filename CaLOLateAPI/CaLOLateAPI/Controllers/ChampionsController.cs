using CaLOLateAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CaLOLateAPI.Controllers
{
    public class ChampionsController : ApiController
    {
        [EnableCors("*","*","*")]
        public IHttpActionResult GetChampions()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var champions = context.Champions.ToList();
                    return Ok(champions);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            
        }
    }
}
