using CaLOLateAPI.Data;
using CaLOLateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace CaLOLateAPI.Controllers
{
    [RoutePrefix("battler")]
    [EnableCors("*", "*", "*")]
    public class BattlerController : ApiController
    {
        Battler battle = new Battler("");

        [HttpPut]
        [Route("api/SetPlayer1/{name}")]
        public IHttpActionResult UpdatePlayer1(string name, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetChampion1(name);
                return Ok("Champion 1 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetPlayer2/{name}")]
        public IHttpActionResult UpdatePlayer2(string name)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetChampion2(name);
                return Ok("Champion 2 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetChamp2HealthPer/{healthPer}")]
        public IHttpActionResult SetChamp2HealthPer(int healthPer)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetChamp2HealthPer(healthPer);
                return Ok("Champion 2 Health per set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetChamp1Level/{level}")]
        public IHttpActionResult SetChamp1Level(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetChamp1Level(level);
                return Ok("Champion 1 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetChamp2Level/{level}")]
        public IHttpActionResult SetChamp2Level(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetChamp2Level(level);
                return Ok("Champion 2 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty1Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty1Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty1Champ1(level);
                return Ok("Champion 1 abilty 1 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty2Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty2Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty2Champ1(level);
                return Ok("Champion 1 abilty 2 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty3Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty3Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty3Champ1(level);
                return Ok("Champion 1 abilty 3 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty4Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty4Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty4Champ1(level);
                return Ok("Champion 1 abilty 4 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty1Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty1Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty1Champ2(level);
                return Ok("Champion 2 abilty 1 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty2Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty2Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty2Champ2(level);
                return Ok("Champion 2 abilty 2 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty3Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty3Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty3Champ2(level);
                return Ok("Champion 2 abilty 3 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLDownAbilty4Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty4Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelDownAbilty4Champ2(level);
                return Ok("Champion 2 abilty 4 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLUpAbilty1Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty1Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty1Champ1(level);
                return Ok("Champion 1 abilty 1 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("api/LeveLUpAbilty2Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty2Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty2Champ1(level);
                return Ok("Champion 1 abilty 2 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("api/LeveLUpAbilty3Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty3Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty3Champ1(level);
                return Ok("Champion 1 abilty 3 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("api/LeveLUpAbilty4Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty4Champion1(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty4Champ1(level);
                return Ok("Champion 1 abilty 4 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("api/LeveLUpAbilty1Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty1Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty1Champ2(level);
                return Ok("Champion 2 abilty 1 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLUpAbilty2Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty2Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty2Champ2(level);
                return Ok("Champion 2 abilty 2 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLUpAbilty3Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty3Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty3Champ2(level);
                return Ok("Champion 2 abilty 3 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/LeveLUpAbilty4Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty4Champion2(int level)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.LevelUpAbilty4Champ2(level);
                return Ok("Champion 2 abilty 4 level set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //
        [HttpPut]
        [Route("api/SetItem1Champ1/{item}")]
        public IHttpActionResult SetItem1Champ1(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem1Champ1(item);
                return Ok("Champion 1 item 1 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem2Champ1/{item}")]
        public IHttpActionResult SetItem2Champ1(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem2Champ1(item);
                return Ok("Champion 1 item 2 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem3Champ1/{item}")]
        public IHttpActionResult SetItem3Champ1(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem3Champ1(item);
                return Ok("Champion 1 item 3 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem4Champ1/{item}")]
        public IHttpActionResult SetItem4Champ1(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem4Champ1(item);
                return Ok("Champion 1 item 4 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem5Champ1/{item}")]
        public IHttpActionResult SetItem5Champ1(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem5Champ1(item);
                return Ok("Champion 1 item 5 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem6Champ1/{item}")]
        public IHttpActionResult SetItem6Champ1(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem6Champ1(item);
                return Ok("Champion 1 item 6 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //
        [HttpPut]
        [Route("api/SetItem1Champ2/{item}")]
        public IHttpActionResult SetItem1Champ2(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem1Champ2(item);
                return Ok("Champion 2 item 1 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem2Champ2/{item}")]
        public IHttpActionResult SetItem2Champ2(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem2Champ2(item);
                return Ok("Champion 2 item 2 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem3Champ2/{item}")]
        public IHttpActionResult SetItem3Champ2(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem3Champ2(item);
                return Ok("Champion 2 item 3 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem4Champ2/{item}")]
        public IHttpActionResult SetItem4Champ2(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem4Champ2(item);
                return Ok("Champion 2 item 4 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem5Champ2/{item}")]
        public IHttpActionResult SetItem5Champ2(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem5Champ2(item);
                return Ok("Champion 2 item 5 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("api/SetItem6Champ2/{item}")]
        public IHttpActionResult SetItem6Champ2(string item)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.SetItem6Champ2(item);
                return Ok("Champion 2 item 6 set");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetFinalAnswer")]
        public IHttpActionResult GetFinalResult()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                if (battle.CalculateIfChampionOneWouldWin() == false)
                {
                    return Ok("No the fight isn't worthwhile");
                }
                return Ok("Yes the fight is worthwhile");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1Abilty1Des/")]
        public IHttpActionResult GetChamp1Abilty1Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC1Abilty1Des();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Abilty1Des/")]
        public IHttpActionResult GetChamp2Abilty1Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC2Abilty1Des();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1Abilty2Des/")]
        public IHttpActionResult GetChamp1Abilty2Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC1Abilty2Des();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Abilty2Des/")]
        public IHttpActionResult GetChamp2Abilty2Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC2Abilty2Des();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1Abilty3Des/")]
        public IHttpActionResult GetChamp1Abilty3Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC1Abilty3Des();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Abilty3Des/")]
        public IHttpActionResult GetChamp2Abilty3Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC2Abilty3Des();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1Abilty4Des/")]
        public IHttpActionResult GetChamp1Abilty4Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC1Abilty4Des();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Abilty4Des/")]
        public IHttpActionResult GetChamp2Abilty4Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC2Abilty4Des();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp1Abilty5Des/")]
        public IHttpActionResult GetChamp1Abilty5Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC1Abilty5Des();
                return Ok("Champion 1 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetChamp2Abilty5Des/")]
        public IHttpActionResult GetChamp2Abilty5Des()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battle.GetC2Abilty5Des();
                return Ok("Champion 2 Mana gotten");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
