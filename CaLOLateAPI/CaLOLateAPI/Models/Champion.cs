using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CaLOLateAPI.Models
{
    public class Champion
    {
        public Champion(String Name, String Image)
        {
            this.Name = Name;
            this.Image = Image;
        }
 

        //abiltys
        public void SetChampionAbiltys( String NameOfSpell1, String DescriptionOfSpell1, String ImageOfSpell1,int LevelOfSpell1, bool SpellHaveAPRatio1, bool SpellHaveADFullRatio1, bool SpellHaveADBonusRatio1, bool SpellHaveDamageIncreaser1,
            String NameOfSpell2, String DescriptionOfSpell2, String ImageOfSpell2, int LevelOfSpell2, bool SpellHaveAPRatio2, bool SpellHaveADFullRatio2, bool SpellHaveADBonusRatio2, bool SpellHaveDamageIncreaser2,
            String NameOfSpell3, String DescriptionOfSpell3, String ImageOfSpell3, int LevelOfSpell3, bool SpellHaveAPRatio3, bool SpellHaveADFullRatio3, bool SpellHaveADBonusRatio3, bool SpellHaveDamageIncreaser3,
            String NameOfSpell4, String DescriptionOfSpell4, String ImageOfSpell4, int LevelOfSpell4, bool SpellHaveAPRatio4, bool SpellHaveADFullRatio4, bool SpellHaveADBonusRatio4, bool SpellHaveDamageIncreaser4,
            String NameOfSpell5, String DescriptionOfSpell5, String ImageOfSpell5, int LevelOfSpell5, bool SpellHaveAPRatio5, bool SpellHaveADFullRatio5, bool SpellHaveADBonusRatio5, bool SpellHaveDamageIncreaser5)
        {
            ChampionAbilty1 = new ChampionAbiltys(NameOfSpell1, DescriptionOfSpell1, ImageOfSpell1, LevelOfSpell1, SpellHaveAPRatio1, SpellHaveADFullRatio1, SpellHaveADBonusRatio1, SpellHaveDamageIncreaser1);
            ChampionAbilty2 = new ChampionAbiltys(NameOfSpell2, DescriptionOfSpell2, ImageOfSpell2, LevelOfSpell2, SpellHaveAPRatio2, SpellHaveADFullRatio2, SpellHaveADBonusRatio2, SpellHaveDamageIncreaser2);
            ChampionAbilty3 = new ChampionAbiltys(NameOfSpell3, DescriptionOfSpell3, ImageOfSpell3, LevelOfSpell3, SpellHaveAPRatio3, SpellHaveADFullRatio3, SpellHaveADBonusRatio3, SpellHaveDamageIncreaser3);
            ChampionAbilty4 = new ChampionAbiltys(NameOfSpell4, DescriptionOfSpell4, ImageOfSpell4, LevelOfSpell4, SpellHaveAPRatio4, SpellHaveADFullRatio4, SpellHaveADBonusRatio4, SpellHaveDamageIncreaser4);
            ChampionAbilty5 = new ChampionAbiltys(NameOfSpell5, DescriptionOfSpell5, ImageOfSpell5, LevelOfSpell5, SpellHaveAPRatio5, SpellHaveADFullRatio5, SpellHaveADBonusRatio5, SpellHaveDamageIncreaser5);
            AbitysNamesAndEffects.Add(ChampionAbilty1);
            AbitysNamesAndEffects.Add(ChampionAbilty2);
            AbitysNamesAndEffects.Add(ChampionAbilty3);
            AbitysNamesAndEffects.Add(ChampionAbilty4);
            AbitysNamesAndEffects.Add(ChampionAbilty5);
        }
        public String GetChampionAbilty(int a)
        {
            return AbitysNamesAndEffects.ElementAt(a).GetNameOfSpell();
        }
        //TODO:Forgot to add the itens into calculations
        public double GetPassiveDamage()
        {
            return PassiveDamage;
        }
        public void SetPassiveDamage()
        {
            bool ADRatioB, ADRatioF, APRatio, DamIn;
            ADRatioB = ChampionAbilty1.GetSpellHaveADBonusRatio();
            ADRatioF = ChampionAbilty1.GetSpellHaveADFullRatio();
            APRatio = ChampionAbilty1.GetSpellHaveAPRatio();
            DamIn = ChampionAbilty1.GetSpellHaveDamageIncreaser();
            int Level = ChampionAbilty1.GetLevelOfSpell();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ChampionAbilty1.GetADRatioBonus(Level));
            }
            else
            {
                if(ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ChampionAbilty1.GetADRatioFull(Level));
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ChampionAbilty1.GetAPRatio(Level));
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ChampionAbilty1.GetAPRatio(Level) + ChampionAbilty1.GetADRatioBonus(Level));
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ChampionAbilty1.GetAPRatio(Level) + ChampionAbilty1.GetADRatioFull(Level));
                            }
                        }
                    }
                }
            }
            if(DamIn == true)
            {
                PassiveDamage = PassiveDamage * (ChampionAbilty1.GetDamageIncreaser(Level));
            }
        }
        public double GetAbilty1Damage()
        {
            return Abilty1Damage;
        }
        public void SetAbilty1Damage()
        {
            bool ADRatioB, ADRatioF, APRatio, DamIn;
            ADRatioB = ChampionAbilty2.GetSpellHaveADBonusRatio();
            ADRatioF = ChampionAbilty2.GetSpellHaveADFullRatio();
            APRatio = ChampionAbilty2.GetSpellHaveAPRatio();
            DamIn = ChampionAbilty2.GetSpellHaveDamageIncreaser();
            int Level = ChampionAbilty2.GetLevelOfSpell();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ChampionAbilty2.GetADRatioBonus(Level));
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ChampionAbilty2.GetADRatioFull(Level));
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ChampionAbilty2.GetAPRatio(Level));
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ChampionAbilty2.GetAPRatio(Level) + ChampionAbilty2.GetADRatioBonus(Level));
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ChampionAbilty2.GetAPRatio(Level) + ChampionAbilty2.GetADRatioFull(Level));
                            }
                        }
                    }
                }
            }
            if (DamIn == true)
            {
                Abilty1Damage = Abilty1Damage * (ChampionAbilty2.GetDamageIncreaser(Level));
            }
        }
        public double GetAbilty2Damage()
        {
            return Abilty2Damage;
        }
        public void SetAbilty2Damage()
        {
            bool ADRatioB, ADRatioF, APRatio, DamIn;
            ADRatioB = ChampionAbilty3.GetSpellHaveADBonusRatio();
            ADRatioF = ChampionAbilty3.GetSpellHaveADFullRatio();
            APRatio = ChampionAbilty3.GetSpellHaveAPRatio();
            DamIn = ChampionAbilty3.GetSpellHaveDamageIncreaser();
            int Level = ChampionAbilty3.GetLevelOfSpell();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ChampionAbilty3.GetADRatioBonus(Level));
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ChampionAbilty3.GetADRatioFull(Level));
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ChampionAbilty3.GetAPRatio(Level));
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ChampionAbilty3.GetAPRatio(Level) + ChampionAbilty3.GetADRatioBonus(Level));
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ChampionAbilty3.GetAPRatio(Level) + ChampionAbilty3.GetADRatioFull(Level));
                            }
                        }
                    }
                }
            }
            if (DamIn == true)
            {
                Abilty2Damage = Abilty2Damage * (ChampionAbilty3.GetDamageIncreaser(Level));
            }
        }
        public double GetAbilty3Damage()
        {
            return Abilty3Damage;
        }
        public void SetAbilty3Damage()
        {
            bool ADRatioB, ADRatioF, APRatio, DamIn;
            ADRatioB = ChampionAbilty4.GetSpellHaveADBonusRatio();
            ADRatioF = ChampionAbilty4.GetSpellHaveADFullRatio();
            APRatio = ChampionAbilty4.GetSpellHaveAPRatio();
            DamIn = ChampionAbilty4.GetSpellHaveDamageIncreaser();
            int Level = ChampionAbilty4.GetLevelOfSpell();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ChampionAbilty4.GetADRatioBonus(Level));
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ChampionAbilty4.GetADRatioFull(Level));
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ChampionAbilty4.GetAPRatio(Level));
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ChampionAbilty4.GetAPRatio(Level) + ChampionAbilty4.GetADRatioBonus(Level));
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ChampionAbilty4.GetAPRatio(Level) + ChampionAbilty4.GetADRatioFull(Level));
                            }
                        }
                    }
                }
            }
            if (DamIn == true)
            {
                Abilty3Damage = Abilty3Damage * (ChampionAbilty4.GetDamageIncreaser(Level));
            }
        }
        public double GetUltimateDamage()
        {
            return UltimateDamage;
        }
        public void SetUltimateDamage()
        {
            bool ADRatioB, ADRatioF, APRatio, DamIn;
            ADRatioB = ChampionAbilty5.GetSpellHaveADBonusRatio();
            ADRatioF = ChampionAbilty5.GetSpellHaveADFullRatio();
            APRatio = ChampionAbilty5.GetSpellHaveAPRatio();
            DamIn = ChampionAbilty5.GetSpellHaveDamageIncreaser();
            int Level = ChampionAbilty5.GetLevelOfSpell();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ChampionAbilty5.GetADRatioBonus(Level));
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ChampionAbilty5.GetADRatioFull(Level));
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ChampionAbilty5.GetAPRatio(Level));
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ChampionAbilty5.GetAPRatio(Level) + ChampionAbilty5.GetADRatioBonus(Level));
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ChampionAbilty5.GetAPRatio(Level) + ChampionAbilty5.GetADRatioFull(Level));
                            }
                        }
                    }
                }
            }
            if (DamIn == true)
            {
                UltimateDamage = UltimateDamage * (ChampionAbilty5.GetDamageIncreaser(Level));
            }
        }
        //items
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

        //SummonerSpells
        public void SetSummonerSpells()
        {
            SummonerSpells1 = new SummonerSpells();
            SummonerSpells2 = new SummonerSpells();
            SummonerSpellChampHas.Add(SummonerSpells1);
            SummonerSpellChampHas.Add(SummonerSpells2);
        }

        //ChampionAbiltys
        private ChampionAbiltys ChampionAbilty1;
        private ChampionAbiltys ChampionAbilty2;
        private ChampionAbiltys ChampionAbilty3;
        private ChampionAbiltys ChampionAbilty4;
        private ChampionAbiltys ChampionAbilty5;
        private List<ChampionAbiltys> AbitysNamesAndEffects;
        private double PassiveDamage;
        private double Abilty1Damage;
        private double Abilty2Damage;
        private double Abilty3Damage;
        private double UltimateDamage;
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
        //TODO:Set Stats based on items then call in calculator part
        public void SetCooldownReduction(int CooldownReduction)
        {
            int a = 0;
            foreach(Items item in ItemsChampHas)
            {
                a = a + item.GetAP();
            }
            this.CooldownReduction = a;
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
        public double GetCritDamage()
        {
            return CritDamage;
        }
        public void SetCritDamage(double CritDamage)
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
        private double HeathOutput;
        private double HealthRegFlat;
        private double HealthRegScaling;
        private double HeathRegOutput;
        private int ManaFlat;
        private double ManaScaling;
        private double ManaOutput;
        private double ManaRegFlat;
        private double ManaRegScaling;
        private double ManaRegOutput;
        private int RageFlat;
        private double RageOutput;
        private int EnergyFlat;
        private double EnergyOutput;
        private double EnergyRegFlat;
        private double EnergyRegScaling;
        private double EnergyRegOutput;
        private int AdFlat;
        private double AdScaling;
        private double ADOutput;
        private double AttackSpeedFlat;
        private double AttackSpeedScale;
        private double AttackSpeedOutput;
        private int ArmourFlat;
        private double ArmourScaling;
        private double ArmourOutput;
        private int MagicResistFlat;
        private double MagicResistScaling;
        private double MagicResistOutput;
        private int Movespeed;
        private double MovespeedOutput;
        private int CooldownReduction = 0;
        private double CooldownReductionOutput;
        private int Tenacity = 0;
        private double TenacityOutput;
        private double AbiltyPower = 0;
        private double AbiltyPowerOutput;
        private int CritStrike = 0;
        private double CritStrikeOutput;
        private double CritDamage = 1.5;
        private double CritDamageOutput;
        private int LifeSteal = 0;
        private double LifeStealOutput;
        private int ArmourPenetrationFlat = 0;
        private double ArmourPenetrationOutput;
        private int ArmourPenetrationPecentage = 0;
        private double ArmourPenetrationPecentageOutput;
        private int MagicPenetrationFlat = 0;
        private double MagicPenetrationOutput;
        private int MagicPenetrationPecentage = 0;
        private double MagicPenetrationPecentageOutput;
        private int MaxLevel = 18;
        //TODO: Add champion stat calculators
    }
}