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


        //Stats
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
        public int CritDamage { get; set; }
        public int LifeSteal { get; set; }
        public int ArmourPenetrationFlat { get; set; }
        public int ArmourPenetrationPecentage { get; set; }
        public int MagicPenetrationFlat { get; set; }
        public int MagicPenetrationPecentage { get; set; }

        public void SetAbilysLevels(int Abilty1Level, int Abilty2Level, int Abilty3Level, int UitmateLevel)
        {
            PassiveLevel = 0;
            this.Abilty1Level = Abilty1Level;
            this.Abilty2Level = Abilty2Level;
            this.Abilty3Level = Abilty3Level;
            this.UitmateLevel = UitmateLevel;
            LevelOfSpell.Add(PassiveLevel);
            LevelOfSpell.Add(Abilty1Level);
            LevelOfSpell.Add(Abilty2Level);
            LevelOfSpell.Add(Abilty3Level);
            LevelOfSpell.Add(UitmateLevel);
        }
        public void SetAbilysNames(String PassiveName, String Abilty1Name, String Abilty2Name, String Abilty3Name, String UitmateName)
        {
            NameOfSpell.Add(PassiveName);
            NameOfSpell.Add(Abilty1Name);
            NameOfSpell.Add(Abilty2Name);
            NameOfSpell.Add(Abilty3Name);
            NameOfSpell.Add(UitmateName);
        }
        public void SetAbilysDescription(String PassiveDescription, String Abilty1Description, String Abilty2Description, String Abilty3Description, String UitmateDescription)
        {
            DescriptionOfSpell.Add(PassiveDescription);
            DescriptionOfSpell.Add(Abilty1Description);
            DescriptionOfSpell.Add(Abilty2Description);
            DescriptionOfSpell.Add(Abilty3Description);
            DescriptionOfSpell.Add(UitmateDescription);
        }
        public void SetAbilysImages(String PassiveImage, String Abilty1Image, String Abilty2Image, String Abilty3Image, String UitmateImage)
        {
            ImageOfSpell.Add(PassiveImage);
            ImageOfSpell.Add(Abilty1Image);
            ImageOfSpell.Add(Abilty2Image);
            ImageOfSpell.Add(Abilty3Image);
            ImageOfSpell.Add(UitmateImage);
        }
        public void SetRatioAP(Double PassiveRatioAP, Double Abilty1RatioAP, Double Abilty2RatioAP, Double Abilty3RatioAP, Double UitmateRatioAP)
        {
            RatioAP.Add(PassiveRatioAP);
            RatioAP.Add(Abilty1RatioAP);
            RatioAP.Add(Abilty2RatioAP);
            RatioAP.Add(Abilty3RatioAP);
            RatioAP.Add(UitmateRatioAP);
        }
        public void SetRatioADFull(Double PassiveRatioADFull, Double Abilty1RatioADFull, Double Abilty2RatioADFull, Double Abilty3RatioADFull, Double UitmateRatioADFull)
        {
            RatioADFull.Add(PassiveRatioADFull);
            RatioADFull.Add(Abilty1RatioADFull);
            RatioADFull.Add(Abilty2RatioADFull);
            RatioADFull.Add(Abilty3RatioADFull);
            RatioADFull.Add(UitmateRatioADFull);
        }
        public void SetRatioADBonus(Double PassiveRatioADBonus, Double Abilty1RatioADBonus, Double Abilty2RatioADBonus, Double Abilty3RatioADBonus, Double UitmateRatioADBonus)
        {
            RatioADBonus.Add(PassiveRatioADBonus);
            RatioADBonus.Add(Abilty1RatioADBonus);
            RatioADBonus.Add(Abilty2RatioADBonus);
            RatioADBonus.Add(Abilty3RatioADBonus);
            RatioADBonus.Add(UitmateRatioADBonus);
        }
        public void SetDamageIncreaser(Double PassiveDamageIncreaser, Double Abilty1DamageIncreaser, Double Abilty2DamageIncreaser, Double Abilty3DamageIncreaser, Double UitmateDamageIncreaser)
        {
            DamageIncreaser.Add(PassiveDamageIncreaser);
            DamageIncreaser.Add(Abilty1DamageIncreaser);
            DamageIncreaser.Add(Abilty2DamageIncreaser);
            DamageIncreaser.Add(Abilty3DamageIncreaser);
            DamageIncreaser.Add(UitmateDamageIncreaser);
        }
        public void SetManaCost(Double Abilty1ManaCost, Double Abilty2ManaCost, Double Abilty3ManaCost, Double UitmateManaCost)
        {
            ManaCost.Add(Abilty1ManaCost);
            ManaCost.Add(Abilty2ManaCost);
            ManaCost.Add(Abilty3ManaCost);
            ManaCost.Add(UitmateManaCost);
        }

        //Setting the lists into lower classes
        public void SetChampionAbiltys()
        {
            ChampionAbilty = new ChampionAbiltys(NameOfSpell, DescriptionOfSpell, ImageOfSpell, LevelOfSpell, RatioAP, RatioADFull, RatioADBonus, DamageIncreaser, ManaCost);
        }
        public void SetSummonerSpells()
        {
            SummonerSpells = new SummonerSpells();
        }
        public void SetItems()
        {
            Items = new Items();
            Items.GetName();
        }
        private ChampionAbiltys ChampionAbilty;
        private SummonerSpells SummonerSpells;
        private Items Items;
        private List<String> NameOfSpell = new List<String>();
        private List<String> DescriptionOfSpell = new List<String>();
        private List<String> ImageOfSpell = new List<String>();
        private List<int> LevelOfSpell = new List<int>();
        private List<Double> RatioAP = new List<Double>();
        private List<Double> RatioADFull = new List<Double>();
        private List<Double> RatioADBonus = new List<Double>();
        private List<Double> DamageIncreaser = new List<Double>();
        private List<Double> ManaCost = new List<Double>();
        private int PassiveLevel;
        private int Abilty1Level;
        private int Abilty2Level;
        private int Abilty3Level;
        private int UitmateLevel;
    }
}