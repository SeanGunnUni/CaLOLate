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
        //TODO:Add rest
        public Champion(String Name, String Image)
        {
            this.Name = Name;
            this.Image = Image;
        }
        /*
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
             */
       

        //Setting the lists into lower classes
        public void SetChampionAbiltys( String NameOfSpell1, String DescriptionOfSpell1, String ImageOfSpell1,int LevelOfSpell1,
            String NameOfSpell2, String DescriptionOfSpell2, String ImageOfSpell2, int LevelOfSpell2,
            String NameOfSpell3, String DescriptionOfSpell3, String ImageOfSpell3, int LevelOfSpell3,
            String NameOfSpell4, String DescriptionOfSpell4, String ImageOfSpell4, int LevelOfSpell4,
            String NameOfSpell5, String DescriptionOfSpell5, String ImageOfSpell5, int LevelOfSpell5)
        {//TODO:PASS IN
            //TODO: PUT IN CTOR
            ChampionAbilty1 = new ChampionAbiltys(NameOfSpell1, DescriptionOfSpell1, ImageOfSpell1, LevelOfSpell1);
            ChampionAbilty2 = new ChampionAbiltys(NameOfSpell2, DescriptionOfSpell2, ImageOfSpell2, LevelOfSpell2);
            ChampionAbilty3 = new ChampionAbiltys(NameOfSpell3, DescriptionOfSpell3, ImageOfSpell3, LevelOfSpell3);
            ChampionAbilty4 = new ChampionAbiltys(NameOfSpell4, DescriptionOfSpell4, ImageOfSpell4, LevelOfSpell4);
            ChampionAbilty5 = new ChampionAbiltys(NameOfSpell5, DescriptionOfSpell5, ImageOfSpell5, LevelOfSpell5);
            AbitysNamesAndEffects.Add(ChampionAbilty1);
            AbitysNamesAndEffects.Add(ChampionAbilty2);
            AbitysNamesAndEffects.Add(ChampionAbilty3);
            AbitysNamesAndEffects.Add(ChampionAbilty4);
            AbitysNamesAndEffects.Add(ChampionAbilty5);
        }
        public void SetSummonerSpells()
        {
            //TODO: Set both SummonerSpells
        }
        public void SetItems()
        {
            //TODO: Set items sum starts with
        }
        //ChampionAbiltys
        private ChampionAbiltys ChampionAbilty1;
        private ChampionAbiltys ChampionAbilty2;
        private ChampionAbiltys ChampionAbilty3;
        private ChampionAbiltys ChampionAbilty4;
        private ChampionAbiltys ChampionAbilty5;
        private List<ChampionAbiltys> AbitysNamesAndEffects;
        private int PassiveLevel;
        private int Abilty1Level;
        private int Abilty2Level;
        private int Abilty3Level;
        private int UitmateLevel;
        //SummonerSpells
        private SummonerSpells SummonerSpells1;
        private SummonerSpells SummonerSpells2;
        private List<SummonerSpells> SummonerSpellChampHas;
        //Items
        private Items Item1;
        private Items Item2;
        private Items Item3;
        private Items Item4;
        private Items Item5;
        private Items Item6;
        private List<Items> ItemsChampHas;
        //ChampionInformation
        private String Name;
        private String Image;
        private int Level;
        private int HeathFlat;
        private double HeathScaling;
        private double HealthRegFlat;
        private double HealthRegScaling;
        private int ManaFlat;
        private double ManaScaling;
        private double ManaRegFlat;
        private double ManaRegScaling;
        private int RageFlat;
        private int EnergyFlat;
        private double EnergyRegFlat;
        private double EnergyRegScaling;
        private int AdFlat;
        private double AdScaling;
        private double AttackSpeedFlat;
        private double AttackSpeedScale;
        private int ArmourFlat;
        private double ArmourScaling;
        private int MagicResistFlat;
        private double MagicResistScaling;
        private int Movespeed;
        private int CooldownReduction;
        private int Tenacity;
        private double AbiltyPower;
        private int CritStrike;
        private int CritDamage;
        private int LifeSteal;
        private int ArmourPenetrationFlat;
        private int ArmourPenetrationPecentage;
        private int MagicPenetrationFlat;
        private int MagicPenetrationPecentage;
        //TODO: ADD Current Values And Add Max Values
    }
}