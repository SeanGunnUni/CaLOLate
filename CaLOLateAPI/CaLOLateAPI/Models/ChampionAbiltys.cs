using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace CaLOLateAPI.Models
{
    public class ChampionAbiltys
    {
        public ChampionAbiltys()
        {
        }

        public void SetRatioAP(Double RatioAP1)
        {
            RatioAP.Add(RatioAP1);
        }

        public void SetRatioADFull(Double RatioADFull1)
        {
            RatioADFull.Add(RatioADFull1);
        }

        public void SetRatioADBonus(Double RatioADBonus1)
        {
            RatioADBonus.Add(RatioADBonus1);
        }
  
        public void SetDamageIncreaser(Double Increaser1)
        {
            DamageIncreaser.Add(Increaser1);

        }

        public void SetManaCost(Double Abilty1ManaCost)
        {
            ManaCost.Add(Abilty1ManaCost);

        }
        public void SetNormalSpellDamage(Double Abilty1NormalSpellDamage)
        {
            NormalSpellDamage.Add(Abilty1NormalSpellDamage);

        }


        public double GetNormalSpellDamage(int a)
        {
            return NormalSpellDamage.ElementAt(a);
        }
        public double GetADRatioBonus(int a)
        {
            return RatioADBonus.ElementAt(a);
        }
        public double GetADRatioFull(int a)
        {
            return RatioADFull.ElementAt(a);
        }
        public double GetAPRatio(int a)
        {
            return RatioAP.ElementAt(a);
        }
        public double GetDamageIncreaser(int a)
        {
            return DamageIncreaser.ElementAt(a);
        }


        public int GetID()
        {
            return ID;
        }
        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public String GetNameOfSpell()
        {
            return NameOfSpell;
        }
        public void SetNameOfSpell(String NameOfSpell)
        {
            this.NameOfSpell = NameOfSpell;
        }
        public int GetLevelOfSpell()
        {
            return SpellLevel;
        }
        public void SetLevelOfSpell(int SpellLevel)
        {
           this.SpellLevel = SpellLevel;
        }
        public int GetMaxLevelOfSpell()
        {
            return MaxSpellLevel;
        }
        public void SetMaxLevelOfSpell(int MaxSpellLevel)
        {
            this.MaxSpellLevel = MaxSpellLevel;
        }
        public String GetDescriptionOfSpell()
        {
            return DescriptionOfSpell;
        }
        public void SetDescriptionOfSpell(String DescriptionOfSpell)
        {
            this.DescriptionOfSpell = DescriptionOfSpell;
        }
        public String GetImageOfSpell()
        {
            return ImageOfSpell;
        }
        public void SetImageOfSpell(String ImageOfSpell)
        {
            this.ImageOfSpell = ImageOfSpell;
        }

        public Boolean GetSpellHaveAPRatio()
        {
            return SpellHaveAPRatio;
        }
        public void SetSpellHaveAPRatio(bool SpellHaveAPRatio)
        {
            this.SpellHaveAPRatio = SpellHaveAPRatio;
        }
        public Boolean GetSpellHaveADFullRatio()
        {
            return SpellHaveADFullRatio;
        }
        public void SetSpellHaveADFullRatio(bool SpellHaveADFullRatio)
        {
            this.SpellHaveADFullRatio = SpellHaveADFullRatio;
        }
        public Boolean GetSpellHaveADBonusRatio()
        {
            return SpellHaveADBonusRatio;
        }
        public void SetSpellHaveADBonusRatio(bool SpellHaveADBonusRatio)
        {
            this.SpellHaveADBonusRatio = SpellHaveADBonusRatio;
        }
        public Boolean GetSpellHaveDamageIncreaser()
        {
            return SpellHaveDamageIncreaser;
        }
        public void SetSpellHaveDamageIncreaser(bool SpellHaveDamageIncreaser)
        {
            this.SpellHaveDamageIncreaser = SpellHaveDamageIncreaser;
        }
  
        private List<Double> RatioAP = new List<Double>();
        private List<Double> RatioADFull = new List<Double>();
        private List<Double> RatioADBonus = new List<Double>();
        private List<Double> DamageIncreaser = new List<Double>();
        private List<Double> ManaCost = new List<Double>();
        private List<Double> NormalSpellDamage = new List<Double>();
        //
        [Key]
        private int ID;
        private int MaxSpellLevel;
        private int SpellLevel;
        private String NameOfSpell;
        private String DescriptionOfSpell;
        private String ImageOfSpell;
        private bool SpellHaveAPRatio;
        private bool SpellHaveADFullRatio;
        private bool SpellHaveADBonusRatio;
        private bool SpellHaveDamageIncreaser;

    }
}