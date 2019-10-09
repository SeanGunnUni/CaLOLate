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
        //stats of champion
        public int Level { get; set; }
        public int HeathFlat { get; set; }
        public double HeathScaling { get; set; }
        public double HealthRegFlat { get; set; }
        public double HealthRegScaling { get; set; }
        //TODO:Mana/Mana regen/HpCost/Rage
        public int AdFlat { get; set;}
        public double AdScaling { get; set; }
        public double AttackSpeedFlat { get; set; }
        public double AttackSpeedScale { get; set; }
        public int ArmourFlat { get; set; }
        public double ArmourScaling { get; set; }
        public int MagicResistFlat { get; set; }
        public double MagicResistScale { get; set; }
        public int Movespeed { get; set; }
        public int CooldownReduction { get; set; }
        public int Tenacity { get; set; }
        public double AbiltyPower { get; set; }
        public int CritStrike { get; set; }
        public int ArmourPenetrationFlat { get; set; }
        public int ArmourPenetrationPecentage { get; set; }
        public int MagicPenetrationFlat { get; set; }
        public int MagicPenetrationPecentage { get; set; }

        //Abiltys
        public String PassiveDescription { get; set; }
        public double PassiveDamage { get; set; }
        public String AbiltyOneDescription { get; set; }
        public double AbiltyOneDamage { get; set; }
        public String AbiltyTwoDescription { get; set; }
        public double AbiltyTwoDamage { get; set; }
        public String AbiltyThreeDescription { get; set; }
        public double AbiltyThreeDamage { get; set; }
        public String AbiltyFourDescription { get; set; }
        public double AbiltyFourDamage { get; set; }

        //SummonerSpells
        public String SummonerSpellOneDescription { get; set; }
        public int SummonerSpellOneDamage { get; set; }
        public String SummonerSpellTwoDescription { get; set; }
        public int SummonerSpellTwoDamage { get; set; }
    }
}