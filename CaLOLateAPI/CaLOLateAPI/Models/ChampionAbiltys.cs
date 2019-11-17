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
        public ChampionAbiltys(String NameOfSpell, String DescriptionOfSpell, String ImageOfSpell, int MaxLevels)
        {
            this.NameOfSpell = NameOfSpell;
            this.DescriptionOfSpell = DescriptionOfSpell;
            this.ImageOfSpell = ImageOfSpell;
            this.MaxSpellLevel = MaxLevels;
        }
        //TODO:Change to check amout of max levels
        public void SetRatioAP(Double PassiveRatioAP, Double Abilty1RatioAP, Double Abilty2RatioAP, Double Abilty3RatioAP, Double UitmateRatioAP)
        {
            RatioAP.Add(PassiveRatioAP);
            RatioAP.Add(Abilty1RatioAP);
            RatioAP.Add(Abilty2RatioAP);
            RatioAP.Add(Abilty3RatioAP);
            RatioAP.Add(UitmateRatioAP);
        }
        //TODO:Change to check amout of max levels
        public void SetRatioADFull(Double PassiveRatioADFull, Double Abilty1RatioADFull, Double Abilty2RatioADFull, Double Abilty3RatioADFull, Double UitmateRatioADFull)
        {
            RatioADFull.Add(PassiveRatioADFull);
            RatioADFull.Add(Abilty1RatioADFull);
            RatioADFull.Add(Abilty2RatioADFull);
            RatioADFull.Add(Abilty3RatioADFull);
            RatioADFull.Add(UitmateRatioADFull);
        }
        //TODO:Change to check amout of max levels
        public void SetRatioADBonus(Double PassiveRatioADBonus, Double Abilty1RatioADBonus, Double Abilty2RatioADBonus, Double Abilty3RatioADBonus, Double UitmateRatioADBonus)
        {
            RatioADBonus.Add(PassiveRatioADBonus);
            RatioADBonus.Add(Abilty1RatioADBonus);
            RatioADBonus.Add(Abilty2RatioADBonus);
            RatioADBonus.Add(Abilty3RatioADBonus);
            RatioADBonus.Add(UitmateRatioADBonus);
        }
        //TODO:Change to check amout of max levels
        public void SetDamageIncreaser(Double PassiveDamageIncreaser, Double Abilty1DamageIncreaser, Double Abilty2DamageIncreaser, Double Abilty3DamageIncreaser, Double UitmateDamageIncreaser)
        {
            DamageIncreaser.Add(PassiveDamageIncreaser);
            DamageIncreaser.Add(Abilty1DamageIncreaser);
            DamageIncreaser.Add(Abilty2DamageIncreaser);
            DamageIncreaser.Add(Abilty3DamageIncreaser);
            DamageIncreaser.Add(UitmateDamageIncreaser);
        }
        //TODO:Change to check amout of max levels
        public void SetManaCost(Double Abilty1ManaCost, Double Abilty2ManaCost, Double Abilty3ManaCost, Double UitmateManaCost)
        {
            ManaCost.Add(Abilty1ManaCost);
            ManaCost.Add(Abilty2ManaCost);
            ManaCost.Add(Abilty3ManaCost);
            ManaCost.Add(UitmateManaCost);
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
        //TODO:Fix/Add damage calculator (decided if champion controls or spell controls damageout)
         /*
        public double GetManaCost(int a)
        {
            return ManaCost.ElementAt(a);
        }
        public double GetDamageIncreaser(int a)
        {
            return DamageIncreaser.ElementAt(a);
        }
        public double GetRatioAP(int a)
        {
            return RatioAP.ElementAt(a);
        }
        public double GetRatioADFull(int a)
        {
            return RatioADFull.ElementAt(a);
        }
        public double GetRatioADBonus(int a)
        {
            return RatioADBonus.ElementAt(a);
        }
        public Double GetPassiveDamage()
        {
            return PassiveDamageOutput;
        }
        public Double GetAbilty1Damage()
        {
            return Abilty1DamageOutput;
        }
        public Double GetAbilty2Damage()
        {
            return Abilty2DamageOutput;
        }
        public Double GetAbilty3Damage()
        {
            return Abilty3DamageOutput;
        }
        public Double GetAbilty4Damage()
        {
            return Abilty4DamageOutput;
        }
        */
        //
        private List<Double> RatioAP = new List<Double>();
        private List<Double> RatioADFull = new List<Double>();
        private List<Double> RatioADBonus = new List<Double>();
        private List<Double> DamageIncreaser = new List<Double>();
        private List<Double> ManaCost = new List<Double>();
        //
        [Key]
        private int ID;
        private int MaxSpellLevel;
        private int SpellLevel;
        private String NameOfSpell;
        private String DescriptionOfSpell;
        private String ImageOfSpell;
        private double PassiveDamageOutput;
        private double Abilty1DamageOutput;
        private double Abilty2DamageOutput;
        private double Abilty3DamageOutput;
        private double Abilty4DamageOutput;

    }
}