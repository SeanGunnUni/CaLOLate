using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Champion
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }

        private StatsOfChampions ChampionStats = new StatsOfChampions();
        private ChampionAbiltys ChampionAbiltys = new ChampionAbiltys();
        private SummonerSpells SummonerSpells = new SummonerSpells();
    }
}