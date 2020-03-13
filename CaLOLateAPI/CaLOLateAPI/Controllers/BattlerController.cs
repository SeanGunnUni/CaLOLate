using CaLOLateAPI.Models;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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
        [HttpPut]
        [Route("SetPlayer1/{name}")]
        public IHttpActionResult UpdatePlayer1(string name, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetChampion1(name);
                return Ok(CreateTokenBattler(battler, "Champion 1 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetPlayer2/{name}")]
        public IHttpActionResult UpdatePlayer2(string name, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetChampion2(name);
                return Ok(CreateTokenBattler(battler, "Champion 2 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetChamp2HealthPer/{healthPer}")]
        public IHttpActionResult SetChamp2HealthPer(int healthPer, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetChamp2HealthPer(healthPer);
                return Ok(CreateTokenBattler(battler, "Champion 2 Health per set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetChamp1Level/{level}")]
        public IHttpActionResult SetChamp1Level(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetChamp1Level(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetChamp2Level/{level}")]
        public IHttpActionResult SetChamp2Level(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetChamp2Level(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty1Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty1Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty1Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 1 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty2Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty2Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty2Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 2 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty3Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty3Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty3Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 3 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty4Champion1/{level}")]
        public IHttpActionResult LeveLDownAbilty4Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty4Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 4 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty1Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty1Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty1Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 1 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty2Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty2Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty2Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 2 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty3Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty3Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty3Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 3 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLDownAbilty4Champion2/{level}")]
        public IHttpActionResult LeveLDownAbilty4Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelDownAbilty4Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 4 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLUpAbilty1Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty1Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty1Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 1 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("LeveLUpAbilty2Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty2Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty2Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 2 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("LeveLUpAbilty3Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty3Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty3Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 3 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("LeveLUpAbilty4Champion1/{level}")]
        public IHttpActionResult LeveLUpAbilty4Champion1(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty4Champ1(level);
                return Ok(CreateTokenBattler(battler, "Champion 1 abilty 4 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        [Route("LeveLUpAbilty1Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty1Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty1Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 1 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLUpAbilty2Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty2Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty2Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 2 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLUpAbilty3Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty3Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty3Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 3 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("LeveLUpAbilty4Champion2/{level}")]
        public IHttpActionResult LeveLUpAbilty4Champion2(int level, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.LevelUpAbilty4Champ2(level);
                return Ok(CreateTokenBattler(battler, "Champion 2 abilty 4 level set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //
        [HttpPut]
        [Route("SetItem1Champ1/{item}")]
        public IHttpActionResult SetItem1Champ1(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem1Champ1(item);
                return Ok(CreateTokenBattler(battler, "Champion 1 item 1 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem2Champ1/{item}")]
        public IHttpActionResult SetItem2Champ1(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem2Champ1(item);
                return Ok(CreateTokenBattler(battler, "Champion 1 item 2 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem3Champ1/{item}")]
        public IHttpActionResult SetItem3Champ1(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem3Champ1(item);
                return Ok(CreateTokenBattler(battler, "Champion 1 item 3 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem4Champ1/{item}")]
        public IHttpActionResult SetItem4Champ1(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem4Champ1(item);
                return Ok(CreateTokenBattler(battler, "Champion 1 item 4 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem5Champ1/{item}")]
        public IHttpActionResult SetItem5Champ1(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem5Champ1(item);
                return Ok(CreateTokenBattler(battler, "Champion 1 item 5 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem6Champ1/{item}")]
        public IHttpActionResult SetItem6Champ1(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem6Champ1(item);
                return Ok(CreateTokenBattler(battler, "Champion 1 item 6 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //
        [HttpPut]
        [Route("SetItem1Champ2/{item}")]
        public IHttpActionResult SetItem1Champ2(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem1Champ2(item);
                return Ok(CreateTokenBattler(battler, "Champion 2 item 1 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem2Champ2/{item}")]
        public IHttpActionResult SetItem2Champ2(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem2Champ2(item);
                return Ok(CreateTokenBattler(battler, "Champion 2 item 2 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem3Champ2/{item}")]
        public IHttpActionResult SetItem3Champ2(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem3Champ2(item);
                return Ok(CreateTokenBattler(battler, "Champion 2 item 3 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem4Champ2/{item}")]
        public IHttpActionResult SetItem4Champ2(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem4Champ2(item);
                return Ok(CreateTokenBattler(battler, "Champion 2 item 4 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem5Champ2/{item}")]
        public IHttpActionResult SetItem5Champ2(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem5Champ2(item);
                return Ok(CreateTokenBattler(battler, "Champion 2 item 5 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("SetItem6Champ2/{item}")]
        public IHttpActionResult SetItem6Champ2(string item, [FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                battler.SetItem6Champ2(item);
                return Ok(CreateTokenBattler(battler, "Champion 2 item 6 set"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetFinalAnswer")]
        public IHttpActionResult GetFinalResult([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                if (battler.CalculateIfChampionOneWouldWin() == false)
                {

                    return Ok(CreateTokenBattler(battler, "No the fight isn't worthwhile"));
                }
                return Ok(CreateTokenBattler(battler, "Yes the fight is worthwhile"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1Abilty1Des/")]
        public IHttpActionResult GetChamp1Abilty1Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC1Abilty1Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Abilty1Des/")]
        public IHttpActionResult GetChamp2Abilty1Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC2Abilty1Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        

        [HttpGet]
        [Route("GetChamp1Abilty2Des/")]
        public IHttpActionResult GetChamp1Abilty2Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC1Abilty2Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Abilty2Des/")]
        public IHttpActionResult GetChamp2Abilty2Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC2Abilty2Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1Abilty3Des/")]
        public IHttpActionResult GetChamp1Abilty3Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC1Abilty3Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Abilty3Des/")]
        public IHttpActionResult GetChamp2Abilty3Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC2Abilty3Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1Abilty4Des/")]
        public IHttpActionResult GetChamp1Abilty4Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC1Abilty4Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Abilty4Des/")]
        public IHttpActionResult GetChamp2Abilty4Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC2Abilty4Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1Abilty5Des/")]
        public IHttpActionResult GetChamp1Abilty5Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC1Abilty5Des().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Abilty5Des/")]
        public IHttpActionResult GetChamp2Abilty5Des([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetC2Abilty5Des().ToString();
                
                return Ok(CreateTokenBattler(battler,json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1Health/")]
        public IHttpActionResult GetChamp1Health([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp1HeathOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Health/")]
        public IHttpActionResult GetChamp2Health([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp2HeathOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1Mana/")]
        public IHttpActionResult GetChamp1Mana([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp1ManaOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2Mana/")]
        public IHttpActionResult GetChamp2Mana([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp2ManaOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1AP/")]
        public IHttpActionResult GetChamp1AP([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp1APOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2AP/")]
        public IHttpActionResult GetChamp2AP([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp2APOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp1AD/")]
        public IHttpActionResult GetChamp1AD([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp1AdOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetChamp2AD/")]
        public IHttpActionResult GetChamp2AD([FromBody]Battler battler)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                string json = battler.GetChamp2AdOutput().ToString();
                return Ok(CreateTokenBattler(battler, json));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private JwtPackageBattler CreateTokenBattler(Battler battle, string returnValue)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, battle.Username)
        });

            const string secretKey = "141324123";
            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(secretKey));
            var signinCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = (JwtSecurityToken)tokenHandler.CreateJwtSecurityToken(
                    subject: claims,
                    signingCredentials: signinCredentials
                );

            var tokenString = tokenHandler.WriteToken(token);

            return new JwtPackageBattler()
            {
                UserName = battle.Username,
                Token = tokenString,
                Return = returnValue
            };
        }
    }
}

public class JwtPackageBattler
{
    public string Token { get; set; }
    public string UserName { get; set; }
    public string Return { get; set; }
}
