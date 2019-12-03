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
        public ChampionAbiltys(String NameOfSpell, String DescriptionOfSpell, String ImageOfSpell, int MaxLevels, bool SpellHaveAPRatio, bool SpellHaveADFullRatio, bool SpellHaveADBonusRatio, bool SpellHaveDamageIncreaser)
        {
            this.NameOfSpell = NameOfSpell;
            this.DescriptionOfSpell = DescriptionOfSpell;
            this.ImageOfSpell = ImageOfSpell;
            this.MaxSpellLevel = MaxLevels;
            this.SpellHaveAPRatio = SpellHaveAPRatio;
            this.SpellHaveADFullRatio = SpellHaveADFullRatio;
            this.SpellHaveADBonusRatio = SpellHaveADBonusRatio;
            this.SpellHaveDamageIncreaser = SpellHaveDamageIncreaser;
        }
        //TODO:Change to check amout of max levels
        public void SetRatioAP(Double RatioAP1, Double RatioAP2, Double RatioAP3, Double RatioAP4)
        {
            RatioAP.Add(RatioAP1);
            RatioAP.Add(RatioAP2);
            RatioAP.Add(RatioAP3);
            RatioAP.Add(RatioAP4);

        }
        //TODO:Change to check amout of max levels
        public void SetRatioADFull(Double RatioADFull1, Double RatioADFull2, Double RatioADFull3, Double RatioADFull4, Double RatioADFull5)
        {
            RatioADFull.Add(RatioADFull1);
            RatioADFull.Add(RatioADFull2);
            RatioADFull.Add(RatioADFull3);
            RatioADFull.Add(RatioADFull4);
            RatioADFull.Add(RatioADFull5);
        }
        //TODO:Change to check amout of max levels
        public void SetRatioADBonus(Double RatioADBonus1, Double RatioADBonus2, Double RatioADBonus3, Double RatioADBonus4, Double RatioADBonus5)
        {
            RatioADBonus.Add(RatioADBonus1);
            RatioADBonus.Add(RatioADBonus2);
            RatioADBonus.Add(RatioADBonus3);
            RatioADBonus.Add(RatioADBonus4);
            RatioADBonus.Add(RatioADBonus4);
        }
        //TODO:Change to check amout of max levels
        public void SetDamageIncreaser(Double Increaser1, Double Increaser2, Double Increaser3, Double Increaser4, Double Increaser5)
        {
            DamageIncreaser.Add(Increaser1);
            DamageIncreaser.Add(Increaser2);
            DamageIncreaser.Add(Increaser3);
            DamageIncreaser.Add(Increaser4);
            DamageIncreaser.Add(Increaser5);
        }
        //TODO:Change to check amout of max levels
        public void SetManaCost(Double Abilty1ManaCost, Double Abilty2ManaCost, Double Abilty3ManaCost, Double Abilty4ManaCost, Double Abilty5ManaCost)
        {
            ManaCost.Add(Abilty1ManaCost);
            ManaCost.Add(Abilty2ManaCost);
            ManaCost.Add(Abilty3ManaCost);
            ManaCost.Add(Abilty4ManaCost);
            ManaCost.Add(Abilty5ManaCost);
        }
        public void SetNormalSpellDamage(Double Abilty1NormalSpellDamage, Double Abilty2NormalSpellDamage, Double Abilty3NormalSpellDamage, Double Abilty4NormalSpellDamage, Double Abilty5NormalSpellDamage)
        {
            NormalSpellDamage.Add(Abilty1NormalSpellDamage);
            NormalSpellDamage.Add(Abilty2NormalSpellDamage);
            NormalSpellDamage.Add(Abilty3NormalSpellDamage);
            NormalSpellDamage.Add(Abilty4NormalSpellDamage);
            NormalSpellDamage.Add(Abilty5NormalSpellDamage);
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