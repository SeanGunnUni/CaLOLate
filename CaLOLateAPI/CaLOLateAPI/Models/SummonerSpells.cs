using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaLOLateAPI.Models
{
    public class SummonerSpells
    {
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
        public int GetSpellLevel()
        {
            return SpellLevel;
        }
        public void SetSpellLevel(int SpellLevel)
        {
            this.SpellLevel = SpellLevel;
        }
        public int GetDamageOutput()
        {
            return DamageOutput;
        }
        public void SetDamageOutput(int DamageOutput)
        {
            this.DamageOutput = DamageOutput;
        }
        [Key]
        private int ID;
        private String Name;
        private String Image;
        private String Description;
        private int SpellLevel;
        private int DamageOutput;
    }
}