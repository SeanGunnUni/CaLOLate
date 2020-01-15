using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Battler
    {
        public Battler(String Name)
        {
            Champion1 = new Champion(Name);
        }
        public void SetChampion1(String Name)
        {
            Champion1 = new Champion(Name);
            Champion1.SetPlayersInformation();
        }
        public void SetChampion2(String Name)
        {
            Champion2 = new Champion(Name);
            Champion2.SetPlayersInformation();
        }
        public void SetChamp1Level(int Level)
        {
            Champion1.SetLevel(Level);
        }
        public void SetChamp2Level(int Level)
        {
            Champion2.SetLevel(Level);
        }
        //level up abiltys
        public void LevelUpAbilty1Champ1(int a)
        {
            Champion1.IncreaseAbilty1Level(a);
        }
        public void LevelUpAbilty2Champ1(int a)
        {
            Champion1.IncreaseAbilty2Level(a);
        }
        public void LevelUpAbilty3Champ1(int a)
        {
            Champion1.IncreaseAbilty3Level(a);
        }
        public void LevelUpAbilty4Champ1(int a)
        {
            Champion1.IncreaseAbilty4Level(a);
        }
        public void LevelUpAbilty1Champ2(int a)
        {
            Champion2.IncreaseAbilty1Level(a);
        }
        public void LevelUpAbilty2Champ2(int a)
        {
            Champion2.IncreaseAbilty2Level(a);
        }
        public void LevelUpAbilty3Champ2(int a)
        {
            Champion2.IncreaseAbilty3Level(a);
        }
        public void LevelUpAbilty4Champ2(int a)
        {
            Champion2.IncreaseAbilty4Level(a);
        }
        //Level down abiltys
        public void LevelDownAbilty1Champ1(int a)
        {
            Champion1.DecreaseAbilty1Level(a);
        }
        public void LevelDownAbilty2Champ1(int a)
        {
            Champion1.DecreaseAbilty2Level(a);
        }
        public void LevelDownAbilty3Champ1(int a)
        {
            Champion1.DecreaseAbilty3Level(a);
        }
        public void LevelDownAbilty4Champ1(int a)
        {
            Champion1.DecreaseAbilty4Level(a);
        }
        public void LevelDownAbilty1Champ2(int a)
        {
            Champion2.DecreaseAbilty1Level(a);
        }
        public void LevelDownAbilty2Champ2(int a)
        {
            Champion2.DecreaseAbilty2Level(a);
        }
        public void LevelDownAbilty3Champ2(int a)
        {
            Champion2.DecreaseAbilty3Level(a);
        }
        public void LevelDownAbilty4Champ2(int a)
        {
            Champion2.DecreaseAbilty4Level(a);
        }
        //Set items Champ1
        public void SetItem1Champ1(String item)
        {
            Champion1.SetItem1(item);
        }
        public void SetItem2Champ1(String item)
        {
            Champion1.SetItem2(item);
        }
        public void SetItem3Champ1(String item)
        {
            Champion1.SetItem3(item);
        }
        public void SetItem4Champ1(String item)
        {
            Champion1.SetItem4(item);
        }
        public void SetItem5Champ1(String item)
        {
            Champion1.SetItem5(item);
        }
        public void SetItem6Champ1(String item)
        {
            Champion1.SetItem6(item);

        }
        //Set items Champ2
        public void SetItem1Champ2(String item)
        {
            Champion2.SetItem1(item);
        }
        public void SetItem2Champ2(String item)
        {
            Champion2.SetItem2(item);
        }
        public void SetItem3Champ2(String item)
        {
            Champion2.SetItem3(item);
        }
        public void SetItem4Champ2(String item)
        {
            Champion2.SetItem4(item);
        }
        public void SetItem5Champ2(String item)
        {
            Champion2.SetItem5(item);
        }
        public void SetItem6Champ2(String item)
        {
            Champion2.SetItem6(item);
        }

        public string GetC1Abilty1Des()
        {
            return Champion1.GetAbilty1Des();
        }
        public string GetC1Abilty2Des()
        {
            return Champion1.GetAbilty1Des();
        }
        public string GetC1Abilty3Des()
        {
            return Champion1.GetAbilty1Des();
        }
        public string GetC1Abilty4Des()
        {
            return Champion1.GetAbilty1Des();
        }
        public string GetC1Abilty5Des()
        {
            return Champion1.GetAbilty1Des();
        }


        public string GetC2Abilty1Des()
        {
            return Champion2.GetAbilty1Des();
        }
        public string GetC2Abilty2Des()
        {
            return Champion2.GetAbilty1Des();
        }
        public string GetC2Abilty3Des()
        {
            return Champion2.GetAbilty1Des();
        }
        public string GetC2Abilty4Des()
        {
            return Champion2.GetAbilty1Des();
        }
        public string GetC2Abilty5Des()
        {
            return Champion2.GetAbilty1Des();
        }
        //Get champ1 Items

        private Champion Champion1;
        private Champion Champion2;
        private double ChampionOneDamage;
        private double ChampionTwoDamage;
        private bool WouldChampionOneComeOutWithAWin;

        void ChampionOneDamageOutput()
        {
            Champion1.SetPassiveDamage();
            Champion1.SetAbilty1Damage();
            Champion1.SetAbilty2Damage();
            Champion1.SetAbilty3Damage();
            Champion1.SetUltimateDamage();
            ChampionOneDamage = (Champion1.GetPassiveDamage() + Champion1.GetAbilty1Damage() + Champion1.GetAbilty2Damage() + Champion1.GetAbilty3Damage() + Champion1.GetUltimateDamage());
        }

        void ChampionTwoDamageOutput()
        {
            Champion2.SetPassiveDamage();
            Champion2.SetAbilty1Damage();
            Champion2.SetAbilty2Damage();
            Champion2.SetAbilty3Damage();
            Champion2.SetUltimateDamage();
            ChampionTwoDamage = (Champion2.GetPassiveDamage() + Champion2.GetAbilty1Damage() + Champion2.GetAbilty2Damage() + Champion2.GetAbilty3Damage() + Champion2.GetUltimateDamage());
        }

        public bool CalculateIfChampionOneWouldWin()
        {
            ChampionOneDamageOutput();
            ChampionTwoDamageOutput();
            double HPChamp1 = (Champion1.GetHealthOutput() - ChampionTwoDamage);
            double HPChamp2 = (Champion2.GetHealthOutput() - ChampionOneDamage);
            if ((HPChamp1 >= 0) && (HPChamp2 <= 0))
            {
                return WouldChampionOneComeOutWithAWin = true;
            }
            else
            {
                return WouldChampionOneComeOutWithAWin = false;
            }
        }
    }
}