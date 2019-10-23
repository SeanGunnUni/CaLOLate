using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CaLOLateAPI.Models
{
    public class ChampionAbiltys
    {
        //TODO: make get and sets that edit
        //Abiltys
        /* public String PassiveDescription { get; set; }
         public double PassiveDamage { get; set; }
         public String AbiltyOneDescription { get; set; }
         public double AbiltyOneDamage { get; set; }
         public String AbiltyTwoDescription { get; set; }
         public double AbiltyTwoDamage { get; set; }
         public String AbiltyThreeDescription { get; set; }
         public double AbiltyThreeDamage { get; set; }
         public String AbiltyFourDescription { get; set; }
         public double AbiltyFourDamage { get; set; }*/
        //TODO: make private variables to store data members

        public ChampionAbiltys(List<String> NameOfSpell, List<String> DescriptionOfSpell, List<String> ImageOfSpell, List<int> Levels, List<Double> RatioAP, List<Double> RatioADFull, List<Double> RatioADBonus, List<Double> DamageIncreaser,List<Double> ManaCost)
        {
            //TODO: Add parameters to passdown from upper class
            /*Passive = new Abitys(Name,Image,Level,RatioAP,RatioADFull,RatioADBonus,1);
            Abity1 = new Abitys();
            Abity2 = new Abitys();
            Abity3 = new Abitys();
            Uitmate = new Abitys();*/
        }

        //TODO:FIX THIS
        public Double GetPassiveDamage()
        {
            PassiveDamage = Passive.GetDamageOutputtedAtIndex();
           // PassiveDamage = PassiveDamage + ((Passive.GetRatio() + AP)+();
            PassiveDamage = PassiveDamage * Passive.GetDamageIncreaser();
            return PassiveDamage;
        }

        private Abitys Passive;
        private Abitys Abity1;
        private Abitys Abity2;
        private Abitys Abity3;
        private Abitys Uitmate;
        private Double PassiveDamage;
        private Double AP;
        private Double ADFull;
        private Double ADBonus;
        private Double ManaCost;
        private ArrayList Levels = new ArrayList();
    }
}