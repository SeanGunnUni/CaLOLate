using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Items
    {
        public Items()
        {
        }
        public Items(String Name, String Image, String Description)
        {
            this.Name = Name;
            this.Image = Image;
            this.Description = Description;
        }
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
        public void SetImage(String Image)
        {
            this.Image = Image;
        }
        public String GetDescription()
        {
            return Description;
        }
        public void SetDescription(String Description)
        {
            this.Description = Description;
        }
        public int GetAP()
        {
            return AP;
        }
        public void SetAP(int AP)
        {
            this.AP = AP;
        }
        public int GetAD()
        {
            return AD;
        }
        public void SetAD(int AD)
        {
            this.AD = AD;
        }
        public int GetArmour()
        {
            return Armour;
        }
        public void SetArmour(int Armour)
        {
            this.Armour = Armour;
        }
        public int GetMagicResist()
        {
            return MagicResist;
        }
        public void SetMagicResist(int MagicResist)
        {
            this.MagicResist = MagicResist;
        }
        public int GetHealth()
        {
            return Health;
        }
        public void SetHealth(int Health)
        {
            this.Health = Health;
        }
        public int GetHealthReg()
        {
            return HealthReg;
        }
        public void SetHealthReg(int HealthReg)
        {
            this.HealthReg = HealthReg;
        }
        public int GetMana()
        {
            return Mana;
        }
        public void SetMana(int Mana)
        {
            this.Mana = Mana;
        }
        public int GetManaReg()
        {
            return ManaReg;
        }
        public void SetManaReg(int ManaReg)
        {
            this.ManaReg = ManaReg;
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
        public void SetCritDamagea(int CritDamage)
        {
            this.CritDamage = CritDamage;
        }
        public int GetAttackSpeed()
        {
            return AttackSpeed;
        }
        public void SetAttackSpeed(int AttackSpeed)
        {
            this.AttackSpeed = AttackSpeed;
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
        public int GetAtiveDamage()
        {
            return AtiveDamage;
        }
        public void SetAtiveDamage(int AtiveDamage)
        {
            this.AtiveDamage = AtiveDamage;
        }
        public bool GetUnique()
        {
            return Unique;
        }
        public void SetUnique(bool Unique)
        {
            this.Unique = Unique;
        }
        public bool GetHaveAtive()
        {
            return HaveAtive;
        }
        public void SetHaveAtive(bool HaveAtive)
        {
            this.HaveAtive = HaveAtive;
        }
        public int GetUniqueAtiveDamage()
        {
            return UniqueAtiveDamage;
        }
        public void SetUniqueAtiveDamage(int UniqueAtiveDamage)
        {
            this.UniqueAtiveDamage = UniqueAtiveDamage;
        }
        public int GetUniqueAtiveEffect()
        {
            return UniqueAtiveEffect;
        }
        public void SetUniqueAtiveEffect(int UniqueAtiveEffect)
        {
            this.UniqueAtiveEffect = UniqueAtiveEffect;
        }
        public int GetUniqueAtiveADRatioFlat()
        {
            return UniqueAtiveADRatioFlat;
        }
        public void SetUniqueAtiveADRatioFlat(int UniqueAtiveADRatioFlat)
        {
            this.UniqueAtiveADRatioFlat = UniqueAtiveADRatioFlat;
        }
        public int GetUniqueAtiveADRatioFull()
        {
            return UniqueAtiveADRatioFull;
        }
        public void SetUniqueAtiveADRatioFull(int UniqueAtiveADRatioFull)
        {
            this.UniqueAtiveADRatioFull = UniqueAtiveADRatioFull;
        }
        public int GetUniqueAtiveADRatioBonus()
        {
            return UniqueAtiveADRatioBonus;
        }
        public void SetUniqueAtiveADRatioBonus(int UniqueAtiveADRatioBonus)
        {
            this.UniqueAtiveADRatioBonus = UniqueAtiveADRatioBonus;
        }
        public int GetUniqueAtiveAPRatio()
        {
            return UniqueAtiveAPRatio;
        }
        public void SetUniqueAtiveAPRatio(int UniqueAtiveAPRatio)
        {
            this.UniqueAtiveAPRatio = UniqueAtiveAPRatio;
        }
        [Key]
        private int ID;
        private String Name;
        private String Image;
        private String Description;
        private int AD;
        private int AP;
        private int Armour;
        private int MagicResist;
        private int Health;
        private int HealthReg;
        private int Mana;
        private int ManaReg;
        private int Movespeed;
        private int CooldownReduction;
        private int Tenacity;
        private int CritStrike;
        private int CritDamage;
        private int AttackSpeed;
        private int LifeSteal;
        private int ArmourPenetrationFlat;
        private int ArmourPenetrationPecentage;
        private int MagicPenetrationFlat;
        private int MagicPenetrationPecentage;
        private int AtiveDamage;
        private bool Unique;
        private bool HaveAtive;
        private int UniqueAtiveDamage;
        private int UniqueAtiveEffect;
        private int UniqueAtiveADRatioFlat;
        private int UniqueAtiveADRatioFull;
        private int UniqueAtiveADRatioBonus;
        private int UniqueAtiveAPRatio;
    }
}