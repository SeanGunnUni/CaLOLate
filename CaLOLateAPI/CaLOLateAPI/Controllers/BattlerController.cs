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
    public class BattlerController : ApiController
    {
        Battler battle = new Battler("");
        [EnableCors("*","*","*")]

        //set players
        [HttpPut]
        [Route("api/SetPlayer1/{name}")]
        public void SetPlayer1(string name)
        {
            battle.SetChampion1(name);
        }

        [HttpPut]
        [Route("api/SetPlayer2/{name}")]
        public void SetPlayer2(string name)
        {
            battle.SetChampion2(name);
        }

        //set levels
        [HttpPut]
        [Route("api/SetChamp1Level/{level}")]
        public void SetChamp1Level(int level)
        {
            battle.SetChamp1Level(level);
        }

        [HttpPut]
        [Route("api/SetChamp2Level/{level}")]
        public void SetChamp2Level(int level)
        {
            battle.SetChamp2Level(level);
        }

        //Set abilty levels down
        [HttpPut]
        [Route("api/LeveLDownAbilty1Champion1/{level}")]
        public void LeveLDownAbilty1Champion1(int level)
        {
            battle.LevelDownAbilty1Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty2Champion1/{level}")]
        public void LeveLDownAbilty2Champion1(int level)
        {
            battle.LevelDownAbilty2Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty3Champion1/{level}")]
        public void LeveLDownAbilty3Champion1(int level)
        {
            battle.LevelDownAbilty3Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty4Champion1/{level}")]
        public void LeveLDownAbilty4Champion1(int level)
        {
            battle.LevelDownAbilty4Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty1Champion2/{level}")]
        public void LeveLDownAbilty1Champion2(int level)
        {
            battle.LevelDownAbilty1Champ2(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty2Champion2/{level}")]
        public void LeveLDownAbilty2Champion2(int level)
        {
            battle.LevelDownAbilty2Champ2(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty3Champion2/{level}")]
        public void LeveLDownAbilty3Champion2(int level)
        {
            battle.LevelDownAbilty3Champ2(level);
        }
        [HttpPut]
        [Route("api/LeveLDownAbilty4Champion2/{level}")]
        public void LeveLDownAbilty4Champion2(int level)
        {
            battle.LevelDownAbilty4Champ2(level);
        }

        //Set abilty levels up
        [HttpPut]
        [Route("api/LeveLUpAbilty1Champion1/{level}")]
        public void LeveLUpAbilty1Champion1(int level)
        {
            battle.LevelUpAbilty1Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty2Champion1/{level}")]
        public void LeveLUpAbilty2Champion1(int level)
        {
            battle.LevelUpAbilty2Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty3Champion1/{level}")]
        public void LeveLUpAbilty3Champion1(int level)
        {
            battle.LevelUpAbilty3Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty4Champion1/{level}")]
        public void LeveLUpAbilty4Champion1(int level)
        {
            battle.LevelUpAbilty4Champ1(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty1Champion2/{level}")]
        public void LeveLUpAbilty1Champion2(int level)
        {
            battle.LevelUpAbilty1Champ2(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty2Champion2/{level}")]
        public void LeveLUpAbilty2Champion2(int level)
        {
            battle.LevelUpAbilty2Champ2(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty3Champion2/{level}")]
        public void LeveLUpAbilty3Champion2(int level)
        {
            battle.LevelUpAbilty3Champ2(level);
        }
        [HttpPut]
        [Route("api/LeveLUpAbilty4Champion2/{level}")]
        public void LeveLUpAbilty4Champion2(int level)
        {
            battle.LevelUpAbilty4Champ2(level);
        }

        //Set Items
        [HttpPut]
        [Route("api/SetItem1Champ1/{item}")]
        public void SetItem1Champ1(string item)
        {
            battle.SetItem1Champ1(item);
        }
        [HttpPut]
        [Route("api/SetItem2Champ1/{item}")]
        public void SetItem2Champ1(string item)
        {
            battle.SetItem2Champ1(item);
        }
        [HttpPut]
        [Route("api/SetItem3Champ1/{item}")]
        public void SetItem3Champ1(string item)
        {
            battle.SetItem3Champ1(item);
        }
        [HttpPut]
        [Route("api/SetItem4Champ1/{item}")]
        public void SetItem4Champ1(string item)
        {
            battle.SetItem4Champ1(item);
        }
        [HttpPut]
        [Route("api/SetItem5Champ1/{item}")]
        public void SetItem5Champ1(string item)
        {
            battle.SetItem5Champ1(item);
        }
        [HttpPut]
        [Route("api/SetItem6Champ1/{item}")]
        public void SetItem6Champ1(string item)
        {
            battle.SetItem6Champ1(item);
        }

        [HttpPut]
        [Route("api/SetItem1Champ2/{item}")]
        public void SetItem1Champ2(string item)
        {
            battle.SetItem1Champ2(item);
        }
        [HttpPut]
        [Route("api/SetItem2Champ2/{item}")]
        public void SetItem2Champ2(string item)
        {
            battle.SetItem2Champ2(item);
        }
        [HttpPut]
        [Route("api/SetItem3Champ2/{item}")]
        public void SetItem3Champ2(string item)
        {
            battle.SetItem3Champ2(item);
        }
        [HttpPut]
        [Route("api/SetItem4Champ2/{item}")]
        public void SetItem4Champ2(string item)
        {
            battle.SetItem4Champ2(item);
        }
        [HttpPut]
        [Route("api/SetItem5Champ2/{item}")]
        public void SetItem5Champ2(string item)
        {
            battle.SetItem5Champ2(item);
        }
        [HttpPut]
        [Route("api/SetItem6Champ2/{item}")]
        public void SetItem6Champ2(string item)
        {
            battle.SetItem6Champ2(item);
        }

        //GetOverallAnswer
        [HttpGet]
        [Route("api/GetFinalAnswer")]
        public String GetFinalResult()
        {
            if(battle.CalculateIfChampionOneWouldWin() == false)
            {
                return "No the fight isn't worthwhile";
            }
            return "Yes the fight is worthwhile";
        }
}
