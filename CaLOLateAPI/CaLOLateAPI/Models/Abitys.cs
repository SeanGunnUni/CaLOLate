using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class Abitys
    {
        public Abitys(String Name, String Image,int Level, double RatioAP, double RatioADFull, double RatioADBonus, double DamageIncreaser)
        {
            this.Name = Name;
            this.Image = Image;
            this.Level = Level;
            this.RatioAP = RatioAP;
            this.RatioADFull = RatioADFull;
            this.RatioADBonus = RatioADBonus;
            if(DamageIncreaser > 1)
            {
                this.DamageIncreaser = DamageIncreaser;
            }
        }
        public int GetLevel()
        {
            return Level;
        }
        public void SetLevel(int a)
        {
            Level = a;
        }
        public String GetName()
        {
            return Name;
        }
        public void SetName(String a)
        {
            Name = a;
        }
        public String GetImage()
        {
            return Image;
        }
        public void SetImage(String a)
        {
            Image = a;
        }

        //
        public Double GetDamageOutputtedAtIndex()
        {
            DamageOutputted = ValuesInAbilitys.IndexOf(GetLevel());
            return DamageOutputted;
        }
        public Double GetRatioAP()
        {
            return RatioAP;
        }
        public Double GetRatioADFull()
        {
            return RatioAP;
        }
        public Double GetRatioADBonus()
        {
            return RatioAP;
        }
        public Double GetDamageIncreaser()
        {
            return DamageIncreaser;
        }

        //


        private int Level = 0;
        private String Name;
        private String Image;
        private double DamageOutputted;
        private double RatioAP;
        private double RatioADFull;
        private double RatioADBonus;
        private double DamageIncreaser = 1;
        private ArrayList ValuesInAbilitys = new ArrayList();
    }
}