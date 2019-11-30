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
            double AP = GetAbiltyPowerOutput();
            double ADF = GetADOutput();
            double ADB = GetADBonusOutput();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                double a = ChampionAbilty1.GetADRatioBonus(Level) * ADB;
                PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + a);
            }
            else
            {
                if(ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    double a = ChampionAbilty1.GetADRatioFull(Level) * ADF;
                    PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + a);
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        double a = ChampionAbilty1.GetAPRatio(Level) * AP;
                        PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + a);
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            double ad = ChampionAbilty1.GetADRatioBonus(Level) * ADB;
                            double ap = ChampionAbilty1.GetAPRatio(Level) * AP;
                            PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ap + ad);
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                double ad = ChampionAbilty1.GetADRatioFull(Level) * ADF;
                                double ap = ChampionAbilty1.GetAPRatio(Level) * AP;
                                PassiveDamage = (ChampionAbilty1.GetNormalSpellDamage(Level) + ap + ad);
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
            double AP = GetAbiltyPowerOutput();
            double ADF = GetADOutput();
            double ADB = GetADBonusOutput();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                double a = ChampionAbilty2.GetADRatioBonus(Level) * ADB;
                Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + a);
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    double a = ChampionAbilty2.GetADRatioFull(Level) * ADF;
                    Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + a);
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        double a = ChampionAbilty2.GetAPRatio(Level) * AP;
                        Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + a);
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            double ad = ChampionAbilty2.GetADRatioBonus(Level) * ADB;
                            double ap = ChampionAbilty2.GetAPRatio(Level) * AP;
                            Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ap + ad);
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                double ad = ChampionAbilty2.GetADRatioFull(Level) * ADF;
                                double ap = ChampionAbilty2.GetAPRatio(Level) * AP;
                                Abilty1Damage = (ChampionAbilty2.GetNormalSpellDamage(Level) + ap + ad);
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
            double AP = GetAbiltyPowerOutput();
            double ADF = GetADOutput();
            double ADB = GetADBonusOutput();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                double a = ChampionAbilty3.GetADRatioBonus(Level) * ADB;
                Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + a);
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    double a = ChampionAbilty3.GetADRatioFull(Level) * ADF;
                    Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + a);
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        double a = ChampionAbilty3.GetAPRatio(Level) * AP;
                        Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + a);
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            double ad = ChampionAbilty3.GetADRatioBonus(Level) * ADB;
                            double ap = ChampionAbilty3.GetAPRatio(Level) * AP;
                            Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ad + ap);
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                double ad = ChampionAbilty3.GetADRatioFull(Level) * ADF;
                                double ap = ChampionAbilty3.GetAPRatio(Level) * AP;
                                Abilty2Damage = (ChampionAbilty3.GetNormalSpellDamage(Level) + ap + ad);
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
            double AP = GetAbiltyPowerOutput();
            double ADF = GetADOutput();
            double ADB = GetADBonusOutput();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                double a = ChampionAbilty4.GetADRatioBonus(Level) * ADB;
                Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + a);
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    double a = ChampionAbilty4.GetADRatioFull(Level) * ADF;
                    Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + a);
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        double a = ChampionAbilty4.GetAPRatio(Level) * AP;
                        Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + a);
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            double ad = ChampionAbilty4.GetADRatioBonus(Level) * ADB;
                            double ap = ChampionAbilty4.GetAPRatio(Level) * AP;
                            Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ad + ap);
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                double ad = ChampionAbilty4.GetADRatioFull(Level) * ADF;
                                double ap = ChampionAbilty4.GetAPRatio(Level) * AP;
                                Abilty3Damage = (ChampionAbilty4.GetNormalSpellDamage(Level) + ap + ad);
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
            double AP = GetAbiltyPowerOutput();
            double ADF = GetADOutput();
            double ADB = GetADBonusOutput();
            if (ADRatioB == true && ADRatioF == false && APRatio == false)
            {
                double a = ChampionAbilty5.GetADRatioBonus(Level) * ADB;
                UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + a);
            }
            else
            {
                if (ADRatioB == false && ADRatioF == true && APRatio == false)
                {
                    double a = ChampionAbilty5.GetADRatioFull(Level) * ADF;
                    UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + a);
                }
                else
                {
                    if (ADRatioB == false && ADRatioF == false && APRatio == true)
                    {
                        double a = ChampionAbilty5.GetAPRatio(Level) * AP;
                        UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ap);
                    }
                    else
                    {
                        if (ADRatioB == true && ADRatioF == false && APRatio == true)
                        {
                            double ad = ChampionAbilty5.GetADRatioBonus(Level) * ADB;
                            double ap = ChampionAbilty5.GetAPRatio(Level) * AP;
                            UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ap + ad);
                        }
                        else
                        {
                            if (ADRatioB == false && ADRatioF == true && APRatio == true)
                            {
                                double ad = ChampionAbilty5.GetADRatioFull(Level) * ADF;
                                double ap = ChampionAbilty5.GetAPRatio(Level) * AP;
                                UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + ap + ad);
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
        private double HealthRegFlat;
        private double HealthRegScaling;
        private int ManaFlat;
        private double ManaScaling;
        private double ManaRegFlat;
        private double ManaRegScaling;
        private int RageFlat;
        private int EnergyFlat;
        private double EnergyRegFlat;
        private int AdFlat;
        private double AdScaling;
        private double AttackSpeedFlat;
        private double AttackSpeedScale;
        private int ArmourFlat;
        private double ArmourScaling;
        private int MagicResistFlat;
        private double MagicResistScaling;
        private int Movespeed;
        private int CooldownReduction = 0;
        private int Tenacity = 0;
        private double AbiltyPower = 0;
        private int CritStrike = 0;
        private double CritDamage = 1.5;
        private int LifeSteal = 0;
        private int ArmourPenetrationFlat = 0;
        private int ArmourPenetrationPecentage = 0;
        private int MagicPenetrationFlat = 0;
        private int MagicPenetrationPecentage = 0;
        private int MaxLevel = 18;
        //TODO: Add champion stat calculators
        //Outputs
        private readonly double HealthOutput;
        private readonly double HealthRegOutput;
        private readonly double ManaOutput;
        private readonly double ManaRegOutput;
        private readonly double RageOutput;
        private readonly double EnergyOutput;
        private readonly double EnergyRegOutput;
        private readonly double ADOutput;
        private readonly double ADBonusOutput;
        private readonly double AttackSpeedOutput;
        private readonly double ArmourOutput;
        private readonly double MagicResistOutput;
        private readonly double CooldownReductionOutput;
        private readonly double TenacityOutput;
        private readonly double AbiltyPowerOutput;
        private readonly double CritStrikeOutput;
        private readonly double CritDamageOutput;
        private readonly double LifeStealOutput;
        private readonly double ArmourPenetrationFlatOutput;
        private readonly double ArmourPenetrationPecentageOutput;
        private readonly double MagicPenetrationFlatOutput;
        private readonly double MagicPenetrationPecentageOutput;

        //Gets/Sets outputs
        public double GetHealthOutput()
        {
            double HealthOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                HealthOutput = + items.GetHealth();
            }
            HealthOutput =+ (level * GetHeathScaling()) + GetHeathFlat(); 
            return HealthOutput;
        }
        public double GetHealthRegOutput()
        {
            double HealthRegOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                HealthRegOutput = +items.GetHealthReg();
            }
            HealthRegOutput = +(level * GetHealthRegScaling()) + GetHealthRegFlat();
            return HealthRegOutput;
        }
        public double GetManaOutput()
        {
            double ManaOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ManaOutput = +items.GetMana();
            }
            ManaOutput = +(level * GetManaScaling()) + GetManaFlat();
            return ManaOutput;
        }
        public double GetManaRegOutput()
        {
            double ManaRegOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ManaRegOutput = +items.GetManaReg();
            }
            ManaRegOutput = +(level * GetManaRegScaling()) + GetManaRegFlat();
            return ManaRegOutput;
        }
        public double GetRageOutput()
        {
            double RageOutput;
            RageOutput = GetRageFlat();
            return RageOutput;
        }
        public double GetEnergyOutput()
        {
            double EnergyOutput;
            EnergyOutput = GetEnergyFlat();
            return EnergyOutput;
        }
        public double GetEnergyRegOutput()
        {
            double EnergyRegOutput;
            EnergyRegOutput = GetEnergyRegFlat();
            return EnergyRegOutput;
        }
        public double GetADOutput()
        {
            double ADOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ADOutput =+ items.GetAD();
            }
            ADOutput = + (level * GetAdScaling()) + GetAdFlat();
            return ADOutput;
        }

        public double GetADBonusOutput()
        {
            double ADBonusOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ADBonusOutput = +items.GetAD();
            }
            ADBonusOutput = +(level * GetAdScaling());
            return ADBonusOutput;
        }

        public double GetAttackSpeedOutput()
        {
            //TODO: this is wrong but doesn't exactly matter atm since program doesnt work like that
            double AttackSpeedOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                AttackSpeedOutput = +items.GetAttackSpeed();
            }
            AttackSpeedOutput = +(level * GetAttackSpeedScale()) + GetAttackSpeedFlat();
            return AttackSpeedOutput;
        }
        public double GetArmourOutput()
        {
            double ArmourOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ArmourOutput = +items.GetArmour();
            }
            ArmourOutput = +(level * GetArmourScaling()) + GetArmourFlat();
            return ArmourOutput;
        }
        public double GetMagicResistOutput()
        {
            double MagicResistOutput;
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                MagicResistOutput = +items.GetMagicResist();
            }
            MagicResistOutput = +(level * GetMagicResistScaling()) + GetMagicResistFlat();
            return MagicResistOutput;
        }
        public double GetCooldownReductionOutput()
        {
            double CooldownReductionOutput = GetCooldownReduction();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                CooldownReductionOutput = +items.GetMagicResist();
            }
            return CooldownReductionOutput;
        }
        public double GetTenacityOutput()
        {
            double TenacityOutput = GetTenacity();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                TenacityOutput = +items.GetTenacity();
            }
            return TenacityOutput;
        }
        public double GetAbiltyPowerOutput()
        {
            double AbiltyPowerOutput = GetAbiltyPower();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                AbiltyPowerOutput = +items.GetAP();
            }
            return AbiltyPowerOutput;
        }
        public double GetCritStrikeOutput()
        {
            double CritStrikeOutput = GetCritStrike();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                CritStrikeOutput = +items.GetCritStrike();
            }
            return CritStrikeOutput;
        }
        public double GetCritDamageOutput()
        {
            double CritDamageOutput = GetCritDamage();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                CritDamageOutput = +items.GetCritDamage();
            }
            return CritDamageOutput;
        }
        public double GetLifeStealOutput()
        {
            double LifeStealOutput = GetLifeSteal();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                LifeStealOutput = +items.GetLifeSteal();
            }
            return LifeStealOutput;
        }
        public double GetArmourPenetrationFlatOutput()
        {
            double ArmourPenetrationFlatOutput = GetArmourPenetrationFlat();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ArmourPenetrationFlatOutput = +items.GetArmourPenetrationFlat();
            }
            return ArmourPenetrationFlatOutput;
        }
        public double GetArmourPenetrationPecentageOutput()
        {
            double ArmourPenetrationPecentageOutput = GetArmourPenetrationPecentage();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                ArmourPenetrationPecentageOutput = +items.GetArmourPenetrationPecentage();
            }
            return ArmourPenetrationPecentageOutput;
        }
        public double GetMagicPenetrationFlatOutput()
        {
            double MagicPenetrationFlatOutput = GetMagicPenetrationFlat();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                MagicPenetrationFlatOutput = +items.GetMagicPenetrationFlat();
            }
            return MagicPenetrationFlatOutput;
        }
        public double GetMagicPenetrationPecentageOutput()
        {
            double MagicPenetrationPecentageOutput = GetMagicPenetrationPecentage();
            int level = GetLevel();
            foreach (Items items in ItemsChampHas)
            {
                MagicPenetrationPecentageOutput = +items.GetMagicPenetrationPecentage();
            }
            return MagicPenetrationPecentageOutput;
        }
    }
}