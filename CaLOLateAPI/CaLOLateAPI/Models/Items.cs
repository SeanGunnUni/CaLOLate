using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Items
    {

        [Key]
        public int Id { get; set; }
        public String Description { get; set; }
        public int AD { get; set; }
        public int AP { get; set; }
        public int Armour { get; set; }
        public int MagicResist { get; set; }
        public int Health { get; set; }
        public int HealthReg { get; set; }
        public int Mana { get; set; }
        public int ManaReg { get; set; }
        public int Movespeed { get; set; }
        public int CooldownReduction { get; set; }
        public int Tenacity { get; set; }
        public double AbiltyPower { get; set; }
        public int CritStrike { get; set; }
        public int CritDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int LifeSteal { get; set; }
        public int ArmourPenetrationFlat { get; set; }
        public int ArmourPenetrationPecentage { get; set; }
        public int MagicPenetrationFlat { get; set; }
        public int MagicPenetrationPecentage { get; set; }
        public int AtiveDamage { get; set; }
        public bool Unique { get; set; }
        public bool HaveAtive { get; set; }
        public int UniqueAtiveDamage { get; set; }
        public int UniqueAtiveEffect { get; set; }
        //TODO:Create correct version ps the type isnt correct for a lot
        public String GetName()
        {
            return Name;
        }
        public void SetName(String Name)
        {
            this.Name = Name;
        }
        private String Name;
    }
}