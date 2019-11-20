using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Battler
    {
        public Battler(String Name, String Image)
        {
            Champion1 = new Champion(Name, Image);
        }
        public void SetChampion2(String Name, String Image)
        {
            Champion2 = new Champion(Name, Image);
        }
        public Champion GetChampion1()
        {
            return Champion1;
        }
        public Champion GetChampion2()
        {
            return Champion2;
        }
        public void SetChamp1Level(int Level)
        {
            Champion1.SetLevel(Level);
        }
        public void SetChamp2Level(int Level)
        {
            Champion2.SetLevel(Level);
        }
        public void SetPassiveDamageChamp1()
        {
            PassiveDamageChamp1 = Champion1.
        }
        private Champion Champion1;
        private Champion Champion2;
        private double PassiveDamageChamp1;
        private double PassiveDamageChamp2;
        private double Abilty1DamageChamp1;
        private double Abilty1DamageChamp2;
        private double Abilty2DamageChamp1;
        private double Abilty2DamageChamp2;
        private double Abilty3DamageChamp1;
        private double Abilty3DamageChamp2;

    }
}