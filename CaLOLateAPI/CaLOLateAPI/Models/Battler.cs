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

        private Champion Champion1;
        private Champion Champion2;
        private int ChampionOneDamage;
        private int ChampionTwoDamage;
        private bool WouldChampionOneComeOutWithAWin;
        //TODO:Player output as whole
        void ChampionOneDamageOutput()
        {

        }

        void ChampionTwoDamageOutput()
        {

        }
        //TODO:Would he win?
        void CalculateIfChampionOneWouldWin()
        {

        }
    }
}