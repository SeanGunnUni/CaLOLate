using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Champion
    {
        public Champion(String Name, String Image)
        {
            this.Name = Name;
            this.Image = Image;
        }
        public void SetSummonerSpells()
        {
            SummonerSpells1 = new SummonerSpells();
            SummonerSpells2 = new SummonerSpells();
            SummonerSpellChampHas.Add(SummonerSpells1);
            SummonerSpellChampHas.Add(SummonerSpells2);
            //TODO: Set both SummonerSpells
        }
        public void SetChampionAbiltys( String NameOfSpell1, String DescriptionOfSpell1, String ImageOfSpell1,int LevelOfSpell1,
            String NameOfSpell2, String DescriptionOfSpell2, String ImageOfSpell2, int LevelOfSpell2,
            String NameOfSpell3, String DescriptionOfSpell3, String ImageOfSpell3, int LevelOfSpell3,
            String NameOfSpell4, String DescriptionOfSpell4, String ImageOfSpell4, int LevelOfSpell4,
            String NameOfSpell5, String DescriptionOfSpell5, String ImageOfSpell5, int LevelOfSpell5)
        {
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
        public void SetItems()
        {
            Item1 = new Items();
            Item2 = new Items();
            Item3 = new Items();
            Item4 = new Items();
            Item5 = new Items();
            Item6 = new Items();
            ItemsChampHas.Add(Item1);
            ItemsChampHas.Add(Item2);
            ItemsChampHas.Add(Item3);
            ItemsChampHas.Add(Item4);
            ItemsChampHas.Add(Item5);
            ItemsChampHas.Add(Item6);
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
        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public String GetName()
        {
            return Name;
        }
        public void SetName(String Name)
        {
            this.Name = Name;
        }
        public String GetImage()
        {
            return Image;
        }
        public void SetImagee(String Image)
        {
            this.Image = Image;
        }
        public int GetLevel()
        {
            return Level;
        }
        public void SetLevel(int Level)
        {
            this.Level = Level;
        }
        public int GetHeathFlat()
        {
            return HeathFlat;
        }
        public void SetHeathFlat(int HeathFlat)
        {
            this.HeathFlat = HeathFlat;
        }
        public double GetHeathScaling()
        {
            return HeathScaling;
        }
       public void SetHeathScaling(double HeathScaling)
        {
            this.HeathScaling = HeathScaling;
        }
        public double GetHealthRegFlat()
        {
            return HealthRegFlat;
        }
        public void SetHealthRegFlat(double HealthRegFlat)
        {
            this.HealthRegFlat = HealthRegFlat;
        }
        public double GetHealthRegScaling()
        {
            return HealthRegScaling;
        }
        public void SetHealthRegScaling(double HealthRegScaling)
        {
            this.HealthRegScaling = HealthRegScaling;
        }
        virtual public int GetManaFlat()
        {
            return ManaFlat;
        }
        public void SetManaFlat(int ManaFlat)
        {
            this.ManaFlat = ManaFlat;
        }
        public double GetManaScaling()
        {
            return ManaScaling;
        }
        public void SetManaScaling(double ManaScaling)
        {
            this.ManaScaling = ManaScaling;
        }
        public double GetManaRegFlat()
        {
            return ManaRegFlat;
        }
        public void SetManaRegFlat(double ManaRegFlat)
        {
            this.ManaRegFlat = ManaRegFlat;
        }
        public double GetManaRegScaling()
        {
            return ManaRegScaling;
        }
        public void SetManaRegScaling(double ManaRegScaling)
        {
            this.ManaRegScaling = ManaRegScaling;
        }
        public int GetRageFlat()
        {
            return RageFlat;
        }
        public void SetRageFlat(int RageFlat)
        {
            this.RageFlat = RageFlat;
        }
        public int GetEnergyFlat()
        {
            return EnergyFlat;
        }
        public void SetEnergyFlat(int EnergyFlat)
        {
            this.EnergyFlat = EnergyFlat;
        }
        public double GetEnergyRegFlat()
        {
            return EnergyRegFlat;
        }
        public void SetEnergyRegFlat(double EnergyRegFlat)
        {
            this.EnergyRegFlat = EnergyRegFlat;
        }
        public double GetEnergyRegScaling()
        {
            return EnergyRegScaling;
        }
        public void SetEnergyRegScaling(double EnergyRegScaling)
        {
            this.EnergyRegScaling = EnergyRegScaling;
        }
        public int GetAdFlat()
        {
            return AdFlat;
        }
        public void SetAdFlat(int AdFlat)
        {
            this.AdFlat = AdFlat;
        }
        public double GetAdScaling()
        {
            return AdScaling;
        }
        public void SetAdScaling(double AdScaling)
        {
            this.AdScaling = AdScaling;
        }
        public double GetAttackSpeedFlat()
        {
            return AttackSpeedFlat;
        }
        public void SetAttackSpeedFlat(double AttackSpeedFlat)
        {
            this.AttackSpeedFlat = AttackSpeedFlat;
        }
        public double GetAttackSpeedScale()
        {
            return AttackSpeedScale;
        }
        public void SetAttackSpeedScale(double AttackSpeedScale)
        {
            this.AttackSpeedScale = AttackSpeedScale;
        }
        public int GetArmourFlat()
        {
            return ArmourFlat;
        }
        public void SetArmourFlat(int ArmourFlat)
        {
            this.ArmourFlat = ArmourFlat;
        }
        public double GetArmourScaling()
        {
            return ArmourScaling;
        }
        public void SetArmourScaling(double ArmourScaling)
        {
            this.ArmourScaling = ArmourScaling;
        }
        public int GetMagicResistFlat()
        {
            return MagicResistFlat;
        }
        public void SetMagicResistFlatD(int MagicResistFlat)
        {
            this.MagicResistFlat = MagicResistFlat;
        }
        public double GetMagicResistScaling()
        {
            return MagicResistScaling;
        }
        public void SetMagicResistScaling(double MagicResistScaling)
        {
            this.MagicResistScaling = MagicResistScaling;
        }
        public int GetMovespeed()
        {
            return Movespeed;
        }
        public void SetMovespeed(int Movespeed)
        {
            this.Movespeed = Movespeed;
        }
        public int GetCooldownReduction()
        {
            return CooldownReduction;
        }
        public void SetCooldownReduction(int CooldownReduction)
        {
            this.CooldownReduction = CooldownReduction;
        }
        public int GetTenacity()
        {
            return Tenacity;
        }
        public void SetTenacity(int Tenacity)
        {
            this.Tenacity = Tenacity;
        }
        public double GetAbiltyPower()
        {
            return AbiltyPower;
        }
        public void SetAbiltyPower(double AbiltyPower)
        {
            this.AbiltyPower = AbiltyPower;
        }
        public int GetCritStrike()
        {
            return CritStrike;
        }
        public void SetCritStrike(int CritStrike)
        {
            this.CritStrike = CritStrike;
        }
        public int GetCritDamage()
        {
            return CritDamage;
        }
        public void SetCritDamage(int CritDamage)
        {
            this.CritDamage = CritDamage;
        }
        public int GetLifeSteal()
        {
            return LifeSteal;
        }
        public void SetLifeSteal(int LifeSteal)
        {
            this.LifeSteal = LifeSteal;
        }
        public int GetArmourPenetrationFlat()
        {
            return ArmourPenetrationFlat;
        }
        public void SetArmourPenetrationFlat(int ArmourPenetrationFlat)
        {
            this.ArmourPenetrationFlat = ArmourPenetrationFlat;
        }
        public int GetArmourPenetrationPecentage()
        {
            return ArmourPenetrationPecentage;
        }
        public void SetArmourPenetrationPecentage(int ArmourPenetrationPecentage)
        {
            this.ArmourPenetrationPecentage = ArmourPenetrationPecentage;
        }
        public int GetMagicPenetrationFlat()
        {
            return MagicPenetrationFlat;
        }
        public void SetMagicPenetrationFlat(int MagicPenetrationFlat)
        {
            this.MagicPenetrationFlat = MagicPenetrationFlat;
        }
        public int GetMagicPenetrationPecentage()
        {
            return MagicPenetrationPecentage;
        }
        public void SetMagicPenetrationPecentage(int MagicPenetrationPecentage)
        {
            this.MagicPenetrationPecentage = MagicPenetrationPecentage;
        }
        [Key]
        private int ID;
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