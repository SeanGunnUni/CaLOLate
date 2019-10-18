using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class StatsOfChampions
    {
        //TODO: make get and sets that edit
        public int Level { get; set; }
        public int HeathFlat { get; set; }
        public double HeathScaling { get; set; }
        public double HealthRegFlat { get; set; }
        public double HealthRegScaling { get; set; }
        //TODO:Mana/Mana regen/HpCost/Rage
        public int AdFlat { get; set; }
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

        //TODO: make private variables to store data members
    }
}