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
    [RoutePrefix("champ")]
    [EnableCors("*", "*", "*")]
    public class ChampionController : ApiController
    {
        [HttpGet]
        [Route("api/GetChamp1Health/")]
        public IHttpActionResult GetChamp1Health([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetHealthOutput();
                return Ok("Champion 1 health gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Health/")]
        public IHttpActionResult GetChamp2Health([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetHealthOutput();
                return Ok("Champion 2 health gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1Mana/")]
        public IHttpActionResult GetChamp1Mana([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetManaOutput();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Mana/")]
        public IHttpActionResult GetChamp2Mana([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetManaOutput();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1AP/")]
        public IHttpActionResult GetChamp1AP([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetAbiltyPowerOutput();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2AP/")]
        public IHttpActionResult GetChamp2AP([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetAbiltyPowerOutput();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1AD/")]
        public IHttpActionResult GetChamp1AD([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetADOutput();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2AD/")]
        public IHttpActionResult GetChamp2AD([FromBody]Champion champ)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                champ.GetADOutput();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
