using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace CaLOLateAPI.Models
{
    public class Champion
    {
        public Champion(String Name, String Image)
        {
            this.Name = Name;
            this.Image = Image;
            Level = 0;
            SetItems();
            SetSummonerSpells();
            String ImageOfChampion = "";
            String PassiveN = "";
            String Abilty1N = "";
            String Abilty2N = "";
            String Abilty3N = "";
            String UltimateN = "";
            String ImageOfAbilty = "";
            String DecripOfAbilty = "";
            int MaxSpellLevel = 0;
            bool HaveADBonus = false;
            bool HaveADFull = false;
            bool HaveAP = false;
            bool HaveSpellIncreaser = false;
            String ManacostSpellN = "";
            String RADBonusSpellN = "";
            String RADFullSpellN = "";
            String RAPSpellN = "";
            String DISpellN = "";
            String NormalSpellDamageN = "";
            int ADRatioB = 0;
            int ADRatioF = 0;
            int APRatio = 0;
            int Increaser = 0;
            int ManaCost = 0;
            int NormalSpellD = 0;
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from Champion where ChampionName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Name);
                    myConnection.Open();
                    using(SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ImageOfChampion = oReader["ImageOfChampionAbilty"].ToString();
                            PassiveN = oReader["PassiveName"].ToString();
                            Abilty1N = oReader["Abilty1Name"].ToString();
                            Abilty2N = oReader["Abilty2Name"].ToString();
                            Abilty3N = oReader["Abilty3Name"].ToString();
                            UltimateN = oReader["UltimateName"].ToString();
                        }
                        myConnection.Close();
                    }
                    
                }

            }
            catch
            {
                String nope = "Wasn't able to find champion";
            }
            SetName(Name);
            SetImage(ImageOfChampion);
            ChampionAbilty1.SetNameOfSpell(PassiveN);
            ChampionAbilty1.SetLevelOfSpell(0);
            ChampionAbilty2.SetNameOfSpell(Abilty1N);
            ChampionAbilty2.SetLevelOfSpell(0);
            ChampionAbilty3.SetNameOfSpell(Abilty2N);
            ChampionAbilty3.SetLevelOfSpell(0);
            ChampionAbilty4.SetNameOfSpell(Abilty3N);
            ChampionAbilty4.SetLevelOfSpell(0);
            ChampionAbilty5.SetNameOfSpell(UltimateN);
            ChampionAbilty5.SetLevelOfSpell(0);
            ///////////////////////////////////
            ///Abilty1
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ChampionAbiltyName where ChampionName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", PassiveN);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ImageOfAbilty = oReader["ImageOfChampionAbilty"].ToString();
                            DecripOfAbilty = oReader["DescriptionOfAbilty"].ToString();
                            HaveADBonus = (bool)oReader["HaveADBonusRatio"];
                            HaveADFull = (bool)oReader["HaveADFullRatio"];
                            HaveAP = (bool)oReader["HaveAPRatio"];
                            HaveSpellIncreaser = (bool)oReader["HaveSpellIncreaser"];
                            ManacostSpellN = oReader["ManaCostSpellName"].ToString();
                            RADBonusSpellN = oReader["RatioADBonusSpellName"].ToString();
                            RADFullSpellN = oReader["RatioADFullSpellName"].ToString();
                            RAPSpellN = oReader["RatioAPSpellName"].ToString();
                            DISpellN = oReader["DamageIncreaserSpellName"].ToString();
                            MaxSpellLevel = (int)oReader["MaxSpellLevel"];
                            NormalSpellDamageN = oReader["NormalSpellDamageName"].ToString();
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            ChampionAbilty1.SetImageOfSpell(ImageOfAbilty);
            ChampionAbilty1.SetDescriptionOfSpell(DecripOfAbilty);
            ChampionAbilty1.SetMaxLevelOfSpell(MaxSpellLevel);
            ChampionAbilty1.SetSpellHaveADBonusRatio(HaveADBonus);
            ChampionAbilty1.SetSpellHaveADFullRatio(HaveADFull);
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ManaCost where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", PassiveN);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ManaCost = (int)oReader["RatioADBonus"];
                            ChampionAbilty1.SetManaCost(ManaCost);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from NormalSpellDamage where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", PassiveN);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            NormalSpellD = (int)oReader["NormalSpellDamage"];
                            ChampionAbilty1.SetNormalSpellDamage(NormalSpellD);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            if (HaveADBonus == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADBonus where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", PassiveN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADBonus"];
                                ChampionAbilty1.SetRatioADBonus(ADRatioB);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            if(HaveADFull == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADFull where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", PassiveN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADFull"];
                                ChampionAbilty1.SetRatioADFull(ADRatioF);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
                
            }
            if(HaveSpellIncreaser == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from DamageIncreaser where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", PassiveN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                Increaser = (int)oReader["DamageIncreaser"];
                                ChampionAbilty1.SetDamageIncreaser(Increaser);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
                
            }
            if(HaveAP == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioAP where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", PassiveN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                APRatio = (int)oReader["RatioAP"];
                                ChampionAbilty1.SetRatioAP(APRatio);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            ///////Abilty2
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ChampionAbiltyName where ChampionName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ImageOfAbilty = oReader["ImageOfChampionAbilty"].ToString();
                            DecripOfAbilty = oReader["DescriptionOfAbilty"].ToString();
                            HaveADBonus = (bool)oReader["HaveADBonusRatio"];
                            HaveADFull = (bool)oReader["HaveADFullRatio"];
                            HaveAP = (bool)oReader["HaveAPRatio"];
                            HaveSpellIncreaser = (bool)oReader["HaveSpellIncreaser"];
                            ManacostSpellN = oReader["ManaCostSpellName"].ToString();
                            RADBonusSpellN = oReader["RatioADBonusSpellName"].ToString();
                            RADFullSpellN = oReader["RatioADFullSpellName"].ToString();
                            RAPSpellN = oReader["RatioAPSpellName"].ToString();
                            DISpellN = oReader["DamageIncreaserSpellName"].ToString();
                            MaxSpellLevel = (int)oReader["MaxSpellLevel"];
                            NormalSpellDamageN = oReader["NormalSpellDamageName"].ToString();
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            ChampionAbilty2.SetImageOfSpell(ImageOfAbilty);
            ChampionAbilty2.SetDescriptionOfSpell(DecripOfAbilty);
            ChampionAbilty2.SetMaxLevelOfSpell(MaxSpellLevel);
            ChampionAbilty2.SetSpellHaveADBonusRatio(HaveADBonus);
            ChampionAbilty2.SetSpellHaveADFullRatio(HaveADFull);
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ManaCost where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ManaCost = (int)oReader["RatioADBonus"];
                            ChampionAbilty2.SetManaCost(ManaCost);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from NormalSpellDamage where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            NormalSpellD = (int)oReader["NormalSpellDamage"];
                            ChampionAbilty2.SetNormalSpellDamage(NormalSpellD);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            if (HaveADBonus == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADBonus where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADBonus"];
                                ChampionAbilty2.SetRatioADBonus(ADRatioB);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            if (HaveADFull == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADFull where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADFull"];
                                ChampionAbilty2.SetRatioADFull(ADRatioF);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveSpellIncreaser == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from DamageIncreaser where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                Increaser = (int)oReader["DamageIncreaser"];
                                ChampionAbilty2.SetDamageIncreaser(Increaser);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveAP == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioAP where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty1N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                APRatio = (int)oReader["RatioAP"];
                                ChampionAbilty2.SetRatioAP(APRatio);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            ///////Abilty3
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ChampionAbiltyName where ChampionName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ImageOfAbilty = oReader["ImageOfChampionAbilty"].ToString();
                            DecripOfAbilty = oReader["DescriptionOfAbilty"].ToString();
                            HaveADBonus = (bool)oReader["HaveADBonusRatio"];
                            HaveADFull = (bool)oReader["HaveADFullRatio"];
                            HaveAP = (bool)oReader["HaveAPRatio"];
                            HaveSpellIncreaser = (bool)oReader["HaveSpellIncreaser"];
                            ManacostSpellN = oReader["ManaCostSpellName"].ToString();
                            RADBonusSpellN = oReader["RatioADBonusSpellName"].ToString();
                            RADFullSpellN = oReader["RatioADFullSpellName"].ToString();
                            RAPSpellN = oReader["RatioAPSpellName"].ToString();
                            DISpellN = oReader["DamageIncreaserSpellName"].ToString();
                            MaxSpellLevel = (int)oReader["MaxSpellLevel"];
                            NormalSpellDamageN = oReader["NormalSpellDamageName"].ToString();
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            ChampionAbilty3.SetImageOfSpell(ImageOfAbilty);
            ChampionAbilty3.SetDescriptionOfSpell(DecripOfAbilty);
            ChampionAbilty3.SetMaxLevelOfSpell(MaxSpellLevel);
            ChampionAbilty3.SetSpellHaveADBonusRatio(HaveADBonus);
            ChampionAbilty3.SetSpellHaveADFullRatio(HaveADFull);
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ManaCost where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ManaCost = (int)oReader["RatioADBonus"];
                            ChampionAbilty3.SetManaCost(ManaCost);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from NormalSpellDamage where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            NormalSpellD = (int)oReader["NormalSpellDamage"];
                            ChampionAbilty3.SetNormalSpellDamage(NormalSpellD);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            if (HaveADBonus == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADBonus where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADBonus"];
                                ChampionAbilty3.SetRatioADBonus(ADRatioB);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            if (HaveADFull == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADFull where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADFull"];
                                ChampionAbilty3.SetRatioADFull(ADRatioF);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveSpellIncreaser == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from DamageIncreaser where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                Increaser = (int)oReader["DamageIncreaser"];
                                ChampionAbilty3.SetDamageIncreaser(Increaser);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveAP == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioAP where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty2N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                APRatio = (int)oReader["RatioAP"];
                                ChampionAbilty2.SetRatioAP(APRatio);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            //Abilty4
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ChampionAbiltyName where ChampionName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ImageOfAbilty = oReader["ImageOfChampionAbilty"].ToString();
                            DecripOfAbilty = oReader["DescriptionOfAbilty"].ToString();
                            HaveADBonus = (bool)oReader["HaveADBonusRatio"];
                            HaveADFull = (bool)oReader["HaveADFullRatio"];
                            HaveAP = (bool)oReader["HaveAPRatio"];
                            HaveSpellIncreaser = (bool)oReader["HaveSpellIncreaser"];
                            ManacostSpellN = oReader["ManaCostSpellName"].ToString();
                            RADBonusSpellN = oReader["RatioADBonusSpellName"].ToString();
                            RADFullSpellN = oReader["RatioADFullSpellName"].ToString();
                            RAPSpellN = oReader["RatioAPSpellName"].ToString();
                            DISpellN = oReader["DamageIncreaserSpellName"].ToString();
                            MaxSpellLevel = (int)oReader["MaxSpellLevel"];
                            NormalSpellDamageN = oReader["NormalSpellDamageName"].ToString();
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            ChampionAbilty4.SetImageOfSpell(ImageOfAbilty);
            ChampionAbilty4.SetDescriptionOfSpell(DecripOfAbilty);
            ChampionAbilty4.SetMaxLevelOfSpell(MaxSpellLevel);
            ChampionAbilty4.SetSpellHaveADBonusRatio(HaveADBonus);
            ChampionAbilty4.SetSpellHaveADFullRatio(HaveADFull);
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ManaCost where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ManaCost = (int)oReader["RatioADBonus"];
                            ChampionAbilty4.SetManaCost(ManaCost);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from NormalSpellDamage where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            NormalSpellD = (int)oReader["NormalSpellDamage"];
                            ChampionAbilty4.SetNormalSpellDamage(NormalSpellD);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            if (HaveADBonus == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADBonus where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADBonus"];
                                ChampionAbilty4.SetRatioADBonus(ADRatioB);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            if (HaveADFull == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADFull where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADFull"];
                                ChampionAbilty4.SetRatioADFull(ADRatioF);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveSpellIncreaser == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from DamageIncreaser where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                Increaser = (int)oReader["DamageIncreaser"];
                                ChampionAbilty4.SetDamageIncreaser(Increaser);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveAP == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioAP where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", Abilty3N);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                APRatio = (int)oReader["RatioAP"];
                                ChampionAbilty4.SetRatioAP(APRatio);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            //Abilty5
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ChampionAbiltyName where ChampionName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", UltimateN);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ImageOfAbilty = oReader["ImageOfChampionAbilty"].ToString();
                            DecripOfAbilty = oReader["DescriptionOfAbilty"].ToString();
                            HaveADBonus = (bool)oReader["HaveADBonusRatio"];
                            HaveADFull = (bool)oReader["HaveADFullRatio"];
                            HaveAP = (bool)oReader["HaveAPRatio"];
                            HaveSpellIncreaser = (bool)oReader["HaveSpellIncreaser"];
                            ManacostSpellN = oReader["ManaCostSpellName"].ToString();
                            RADBonusSpellN = oReader["RatioADBonusSpellName"].ToString();
                            RADFullSpellN = oReader["RatioADFullSpellName"].ToString();
                            RAPSpellN = oReader["RatioAPSpellName"].ToString();
                            DISpellN = oReader["DamageIncreaserSpellName"].ToString();
                            MaxSpellLevel = (int)oReader["MaxSpellLevel"];
                            NormalSpellDamageN = oReader["NormalSpellDamageName"].ToString();
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            ChampionAbilty5.SetImageOfSpell(ImageOfAbilty);
            ChampionAbilty5.SetDescriptionOfSpell(DecripOfAbilty);
            ChampionAbilty5.SetMaxLevelOfSpell(MaxSpellLevel);
            ChampionAbilty5.SetSpellHaveADBonusRatio(HaveADBonus);
            ChampionAbilty5.SetSpellHaveADFullRatio(HaveADFull);
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from ManaCost where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", UltimateN);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            ManaCost = (int)oReader["RatioADBonus"];
                            ChampionAbilty5.SetManaCost(ManaCost);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from NormalSpellDamage where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", UltimateN);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            NormalSpellD = (int)oReader["NormalSpellDamage"];
                            ChampionAbilty5.SetNormalSpellDamage(NormalSpellD);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            if (HaveADBonus == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADBonus where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", UltimateN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADBonus"];
                                ChampionAbilty5.SetRatioADBonus(ADRatioB);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            if (HaveADFull == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioADFull where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", UltimateN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                ADRatioB = (int)oReader["RatioADFull"];
                                ChampionAbilty5.SetRatioADFull(ADRatioF);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveSpellIncreaser == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from DamageIncreaser where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", UltimateN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                Increaser = (int)oReader["DamageIncreaser"];
                                ChampionAbilty5.SetDamageIncreaser(Increaser);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }

            }
            if (HaveAP == true)
            {
                try
                {
                    var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                    using (SqlConnection myConnection = new SqlConnection(con))
                    {
                        string oString = "Select * from RatioAP where AbiltyName=@cName";
                        SqlCommand oCmd = new SqlCommand(oString, myConnection);
                        oCmd.Parameters.AddWithValue("@cName", UltimateN);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                APRatio = (int)oReader["RatioAP"];
                                ChampionAbilty5.SetRatioAP(APRatio);
                            }
                            myConnection.Close();
                        }

                    }
                }
                catch
                {
                    String nope = "Wasn't able to find champion abilty";
                }
            }
            //TODO:display nopes to user
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from Champion where ChampionStatsName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", Name);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            AdFlat = (int)oReader["AdFlat"];
                            AdScaling = (int)oReader["AdScaling"];
                            ArmourFlat = (int)oReader["ArmourFlat"];
                            ArmourScaling = (int)oReader["ArmourScaling"];
                            AttackSpeedFlat = (int)oReader["AttackSpeedFlat"];
                            AttackSpeedScale = (int)oReader["AttackSpeedScaling"];
                            EnergyFlat = (int)oReader["EnergyFlat"];
                            EnergyRegFlat = (int)oReader["EnergyRegFlat"];
                            HealthRegScaling = (int)oReader["HealthRegScaling"];
                            HeathFlat = (int)oReader["HealthFlat"];
                            HeathScaling = (int)oReader["HealthScaling"];
                            MagicResistFlat = (int)oReader["MagicResistFlat"];
                            MagicResistScaling = (int)oReader["MagicResistScaling"];
                            ManaFlat = (int)oReader["ManaFlat"];
                            ManaRegFlat = (int)oReader["ManaRegFlat"];
                            ManaRegScaling = (int)oReader["ManaRegenScaling"];
                            ManaScaling = (int)oReader["ManaScaling"];
                            Movespeed = (int)oReader["MoveSpeed"];
                            RageFlat = (int)oReader["RageFlat"];
                        }
                        myConnection.Close();
                    }

                }

            }
            catch
            {
                String nope = "Wasn't able to find champion";
            }
        }
 

        //abiltys
        public String GetChampionAbilty(int a)
        {
            return AbitysNamesAndEffects.ElementAt(a).GetNameOfSpell();
        }
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
                        UltimateDamage = (ChampionAbilty5.GetNormalSpellDamage(Level) + AP);
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
        public void SetItem1(String item)
        {
            Items temp = new Items();
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from RatioAP where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", item);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            temp.SetAD((int)oReader["AP"]);
                            temp.SetAP( (int)oReader["AD"]);
                            temp.SetMovespeed((int)oReader["Movespeed"]);
                            temp.SetAtiveDamage( (int)oReader["ActiveDamage"]);
                            temp.SetArmour( (int)oReader["Armour"]);
                            temp.SetArmourPenetrationFlat( (int)oReader["ArmourPenetrationFlat"]);
                            temp.SetArmourPenetrationPecentage( (int)oReader["ArmourPenetrationPecentage"]);
                            temp.SetAttackSpeed( (int)oReader["AttackSpeed"]);
                            temp.SetCooldownReduction( (int)oReader["CooldownReduction"]);
                            temp.SetCritDamagea( (int)oReader["CritDamage"]);
                            temp.SetCritStrike( (int)oReader["CritStrike"]);
                            temp.SetDescription(oReader["Decription"].ToString());
                            temp.SetHaveAtive( (bool)oReader["HaveActive"]);
                            temp.SetHealth( (int)oReader["Health"]);
                            temp.SetHealthReg( (int)oReader["HealthReg"]);
                            temp.SetImage(oReader["ImageOfItem"].ToString());
                            temp.SetLifeSteal( (int)oReader["LifeSteal"]);
                            temp.SetMagicPenetrationFlat( (int)oReader["MagicPenetrationFlat"]);
                            temp.SetMagicPenetrationPecentage( (int)oReader["MagicPenetrationPecentage"]);
                            temp.SetMagicResist( (int)oReader["MagicResist"]);
                            temp.SetMana( (int)oReader["Mana"]);
                            temp.SetManaReg( (int)oReader["ManaReg"]);
                            temp.SetTenacity( (int)oReader["Tenacity"]);
                            temp.SetUnique( (bool)oReader["UniqueItem"]);
                            temp.SetUniqueAtiveADRatioBonus( (int)oReader["UniqueActiveADRatioBonus"]);
                            temp.SetUniqueAtiveADRatioFull( (int)oReader["UniqueActiveADRatioFull"]);
                            temp.SetUniqueAtiveADRatioFlat( (int)oReader["UniqueActiveADRatioFlat"]);
                            temp.SetUniqueAtiveAPRatio( (int)oReader["UniqueActiveAPRatio"]);
                            temp.SetUniqueAtiveDamage( (int)oReader["UniqueActiveDamage"]);
                            temp.SetUniqueAtiveEffect( (int)oReader["UniqueActiveEffect"]);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }


            int index = 0;
            ItemsChampHas[index] = temp;
        }
        public void SetItem2(String item)
        {
            Items temp = new Items();
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from RatioAP where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", item);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            temp.SetAD((int)oReader["AP"]);
                            temp.SetAP((int)oReader["AD"]);
                            temp.SetMovespeed((int)oReader["Movespeed"]);
                            temp.SetAtiveDamage((int)oReader["ActiveDamage"]);
                            temp.SetArmour((int)oReader["Armour"]);
                            temp.SetArmourPenetrationFlat((int)oReader["ArmourPenetrationFlat"]);
                            temp.SetArmourPenetrationPecentage((int)oReader["ArmourPenetrationPecentage"]);
                            temp.SetAttackSpeed((int)oReader["AttackSpeed"]);
                            temp.SetCooldownReduction((int)oReader["CooldownReduction"]);
                            temp.SetCritDamagea((int)oReader["CritDamage"]);
                            temp.SetCritStrike((int)oReader["CritStrike"]);
                            temp.SetDescription(oReader["Decription"].ToString());
                            temp.SetHaveAtive((bool)oReader["HaveActive"]);
                            temp.SetHealth((int)oReader["Health"]);
                            temp.SetHealthReg((int)oReader["HealthReg"]);
                            temp.SetImage(oReader["ImageOfItem"].ToString());
                            temp.SetLifeSteal((int)oReader["LifeSteal"]);
                            temp.SetMagicPenetrationFlat((int)oReader["MagicPenetrationFlat"]);
                            temp.SetMagicPenetrationPecentage((int)oReader["MagicPenetrationPecentage"]);
                            temp.SetMagicResist((int)oReader["MagicResist"]);
                            temp.SetMana((int)oReader["Mana"]);
                            temp.SetManaReg((int)oReader["ManaReg"]);
                            temp.SetTenacity((int)oReader["Tenacity"]);
                            temp.SetUnique((bool)oReader["UniqueItem"]);
                            temp.SetUniqueAtiveADRatioBonus((int)oReader["UniqueActiveADRatioBonus"]);
                            temp.SetUniqueAtiveADRatioFull((int)oReader["UniqueActiveADRatioFull"]);
                            temp.SetUniqueAtiveADRatioFlat((int)oReader["UniqueActiveADRatioFlat"]);
                            temp.SetUniqueAtiveAPRatio((int)oReader["UniqueActiveAPRatio"]);
                            temp.SetUniqueAtiveDamage((int)oReader["UniqueActiveDamage"]);
                            temp.SetUniqueAtiveEffect((int)oReader["UniqueActiveEffect"]);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            int index = 1;
            ItemsChampHas[index] = temp;
        }
        public void SetItem3(String item)
        {
            Items temp = new Items();
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from RatioAP where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", item);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            temp.SetAD((int)oReader["AP"]);
                            temp.SetAP((int)oReader["AD"]);
                            temp.SetMovespeed((int)oReader["Movespeed"]);
                            temp.SetAtiveDamage((int)oReader["ActiveDamage"]);
                            temp.SetArmour((int)oReader["Armour"]);
                            temp.SetArmourPenetrationFlat((int)oReader["ArmourPenetrationFlat"]);
                            temp.SetArmourPenetrationPecentage((int)oReader["ArmourPenetrationPecentage"]);
                            temp.SetAttackSpeed((int)oReader["AttackSpeed"]);
                            temp.SetCooldownReduction((int)oReader["CooldownReduction"]);
                            temp.SetCritDamagea((int)oReader["CritDamage"]);
                            temp.SetCritStrike((int)oReader["CritStrike"]);
                            temp.SetDescription(oReader["Decription"].ToString());
                            temp.SetHaveAtive((bool)oReader["HaveActive"]);
                            temp.SetHealth((int)oReader["Health"]);
                            temp.SetHealthReg((int)oReader["HealthReg"]);
                            temp.SetImage(oReader["ImageOfItem"].ToString());
                            temp.SetLifeSteal((int)oReader["LifeSteal"]);
                            temp.SetMagicPenetrationFlat((int)oReader["MagicPenetrationFlat"]);
                            temp.SetMagicPenetrationPecentage((int)oReader["MagicPenetrationPecentage"]);
                            temp.SetMagicResist((int)oReader["MagicResist"]);
                            temp.SetMana((int)oReader["Mana"]);
                            temp.SetManaReg((int)oReader["ManaReg"]);
                            temp.SetTenacity((int)oReader["Tenacity"]);
                            temp.SetUnique((bool)oReader["UniqueItem"]);
                            temp.SetUniqueAtiveADRatioBonus((int)oReader["UniqueActiveADRatioBonus"]);
                            temp.SetUniqueAtiveADRatioFull((int)oReader["UniqueActiveADRatioFull"]);
                            temp.SetUniqueAtiveADRatioFlat((int)oReader["UniqueActiveADRatioFlat"]);
                            temp.SetUniqueAtiveAPRatio((int)oReader["UniqueActiveAPRatio"]);
                            temp.SetUniqueAtiveDamage((int)oReader["UniqueActiveDamage"]);
                            temp.SetUniqueAtiveEffect((int)oReader["UniqueActiveEffect"]);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            int index = 2;
            ItemsChampHas[index] = temp;
        }
        public void SetItem4(String item)
        {
            Items temp = new Items();
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from RatioAP where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", item);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            temp.SetAD((int)oReader["AP"]);
                            temp.SetAP((int)oReader["AD"]);
                            temp.SetMovespeed((int)oReader["Movespeed"]);
                            temp.SetAtiveDamage((int)oReader["ActiveDamage"]);
                            temp.SetArmour((int)oReader["Armour"]);
                            temp.SetArmourPenetrationFlat((int)oReader["ArmourPenetrationFlat"]);
                            temp.SetArmourPenetrationPecentage((int)oReader["ArmourPenetrationPecentage"]);
                            temp.SetAttackSpeed((int)oReader["AttackSpeed"]);
                            temp.SetCooldownReduction((int)oReader["CooldownReduction"]);
                            temp.SetCritDamagea((int)oReader["CritDamage"]);
                            temp.SetCritStrike((int)oReader["CritStrike"]);
                            temp.SetDescription(oReader["Decription"].ToString());
                            temp.SetHaveAtive((bool)oReader["HaveActive"]);
                            temp.SetHealth((int)oReader["Health"]);
                            temp.SetHealthReg((int)oReader["HealthReg"]);
                            temp.SetImage(oReader["ImageOfItem"].ToString());
                            temp.SetLifeSteal((int)oReader["LifeSteal"]);
                            temp.SetMagicPenetrationFlat((int)oReader["MagicPenetrationFlat"]);
                            temp.SetMagicPenetrationPecentage((int)oReader["MagicPenetrationPecentage"]);
                            temp.SetMagicResist((int)oReader["MagicResist"]);
                            temp.SetMana((int)oReader["Mana"]);
                            temp.SetManaReg((int)oReader["ManaReg"]);
                            temp.SetTenacity((int)oReader["Tenacity"]);
                            temp.SetUnique((bool)oReader["UniqueItem"]);
                            temp.SetUniqueAtiveADRatioBonus((int)oReader["UniqueActiveADRatioBonus"]);
                            temp.SetUniqueAtiveADRatioFull((int)oReader["UniqueActiveADRatioFull"]);
                            temp.SetUniqueAtiveADRatioFlat((int)oReader["UniqueActiveADRatioFlat"]);
                            temp.SetUniqueAtiveAPRatio((int)oReader["UniqueActiveAPRatio"]);
                            temp.SetUniqueAtiveDamage((int)oReader["UniqueActiveDamage"]);
                            temp.SetUniqueAtiveEffect((int)oReader["UniqueActiveEffect"]);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            int index = 3;
            ItemsChampHas[index] = temp;
        }
        public void SetItem5(String item)
        {
            Items temp = new Items();
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from RatioAP where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", item);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            temp.SetAD((int)oReader["AP"]);
                            temp.SetAP((int)oReader["AD"]);
                            temp.SetMovespeed((int)oReader["Movespeed"]);
                            temp.SetAtiveDamage((int)oReader["ActiveDamage"]);
                            temp.SetArmour((int)oReader["Armour"]);
                            temp.SetArmourPenetrationFlat((int)oReader["ArmourPenetrationFlat"]);
                            temp.SetArmourPenetrationPecentage((int)oReader["ArmourPenetrationPecentage"]);
                            temp.SetAttackSpeed((int)oReader["AttackSpeed"]);
                            temp.SetCooldownReduction((int)oReader["CooldownReduction"]);
                            temp.SetCritDamagea((int)oReader["CritDamage"]);
                            temp.SetCritStrike((int)oReader["CritStrike"]);
                            temp.SetDescription(oReader["Decription"].ToString());
                            temp.SetHaveAtive((bool)oReader["HaveActive"]);
                            temp.SetHealth((int)oReader["Health"]);
                            temp.SetHealthReg((int)oReader["HealthReg"]);
                            temp.SetImage(oReader["ImageOfItem"].ToString());
                            temp.SetLifeSteal((int)oReader["LifeSteal"]);
                            temp.SetMagicPenetrationFlat((int)oReader["MagicPenetrationFlat"]);
                            temp.SetMagicPenetrationPecentage((int)oReader["MagicPenetrationPecentage"]);
                            temp.SetMagicResist((int)oReader["MagicResist"]);
                            temp.SetMana((int)oReader["Mana"]);
                            temp.SetManaReg((int)oReader["ManaReg"]);
                            temp.SetTenacity((int)oReader["Tenacity"]);
                            temp.SetUnique((bool)oReader["UniqueItem"]);
                            temp.SetUniqueAtiveADRatioBonus((int)oReader["UniqueActiveADRatioBonus"]);
                            temp.SetUniqueAtiveADRatioFull((int)oReader["UniqueActiveADRatioFull"]);
                            temp.SetUniqueAtiveADRatioFlat((int)oReader["UniqueActiveADRatioFlat"]);
                            temp.SetUniqueAtiveAPRatio((int)oReader["UniqueActiveAPRatio"]);
                            temp.SetUniqueAtiveDamage((int)oReader["UniqueActiveDamage"]);
                            temp.SetUniqueAtiveEffect((int)oReader["UniqueActiveEffect"]);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            int index = 4;
            ItemsChampHas[index] = temp;
        }
        public void SetItem6(String item)
        {
            Items temp = new Items();
            try
            {
                var connectionString = "Data Source=DESKTOP-BGM3617\\SQLEXPRESS;Initial Catalog=ChampionsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                var con = ConfigurationManager.ConnectionStrings[connectionString].ToString();
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    string oString = "Select * from RatioAP where AbiltyName=@cName";
                    SqlCommand oCmd = new SqlCommand(oString, myConnection);
                    oCmd.Parameters.AddWithValue("@cName", item);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            temp.SetAD((int)oReader["AP"]);
                            temp.SetAP((int)oReader["AD"]);
                            temp.SetMovespeed((int)oReader["Movespeed"]);
                            temp.SetAtiveDamage((int)oReader["ActiveDamage"]);
                            temp.SetArmour((int)oReader["Armour"]);
                            temp.SetArmourPenetrationFlat((int)oReader["ArmourPenetrationFlat"]);
                            temp.SetArmourPenetrationPecentage((int)oReader["ArmourPenetrationPecentage"]);
                            temp.SetAttackSpeed((int)oReader["AttackSpeed"]);
                            temp.SetCooldownReduction((int)oReader["CooldownReduction"]);
                            temp.SetCritDamagea((int)oReader["CritDamage"]);
                            temp.SetCritStrike((int)oReader["CritStrike"]);
                            temp.SetDescription(oReader["Decription"].ToString());
                            temp.SetHaveAtive((bool)oReader["HaveActive"]);
                            temp.SetHealth((int)oReader["Health"]);
                            temp.SetHealthReg((int)oReader["HealthReg"]);
                            temp.SetImage(oReader["ImageOfItem"].ToString());
                            temp.SetLifeSteal((int)oReader["LifeSteal"]);
                            temp.SetMagicPenetrationFlat((int)oReader["MagicPenetrationFlat"]);
                            temp.SetMagicPenetrationPecentage((int)oReader["MagicPenetrationPecentage"]);
                            temp.SetMagicResist((int)oReader["MagicResist"]);
                            temp.SetMana((int)oReader["Mana"]);
                            temp.SetManaReg((int)oReader["ManaReg"]);
                            temp.SetTenacity((int)oReader["Tenacity"]);
                            temp.SetUnique((bool)oReader["UniqueItem"]);
                            temp.SetUniqueAtiveADRatioBonus((int)oReader["UniqueActiveADRatioBonus"]);
                            temp.SetUniqueAtiveADRatioFull((int)oReader["UniqueActiveADRatioFull"]);
                            temp.SetUniqueAtiveADRatioFlat((int)oReader["UniqueActiveADRatioFlat"]);
                            temp.SetUniqueAtiveAPRatio((int)oReader["UniqueActiveAPRatio"]);
                            temp.SetUniqueAtiveDamage((int)oReader["UniqueActiveDamage"]);
                            temp.SetUniqueAtiveEffect((int)oReader["UniqueActiveEffect"]);
                        }
                        myConnection.Close();
                    }

                }
            }
            catch
            {
                String nope = "Wasn't able to find champion abilty";
            }
            int index = 5;
            ItemsChampHas[index] = temp;
        }
        //Get items image
        public String GetItem1Image() {
            return ItemsChampHas.ElementAt(0).GetImage();
        }
        public String GetItem2Image()
        {
            return ItemsChampHas.ElementAt(1).GetImage();
        }
        public String GetItem3Image()
        {
            return ItemsChampHas.ElementAt(2).GetImage();
        }
        public String GetItem4Image()
        {
            return ItemsChampHas.ElementAt(3).GetImage();
        }
        public String GetItem5Image()
        {
            return ItemsChampHas.ElementAt(5).GetImage();
        }
        public String GetItem6Image()
        {
            return ItemsChampHas.ElementAt(5).GetImage();
        }
        //Get items Name
        public String GetItem1Name()
        {
            return ItemsChampHas.ElementAt(0).GetName();
        }
        public String GetItem2Name()
        {
            return ItemsChampHas.ElementAt(1).GetName();
        }
        public String GetItem3Name()
        {
            return ItemsChampHas.ElementAt(2).GetName();
        }
        public String GetItem4Name()
        {
            return ItemsChampHas.ElementAt(3).GetName();
        }
        public String GetItem5Name()
        {
            return ItemsChampHas.ElementAt(5).GetName();
        }
        public String GetItem6Name()
        {
            return ItemsChampHas.ElementAt(5).GetName();
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
        //increase abilty level
        public void IncreaseAbilty1Level(int a)
        {
            ChampionAbilty2.SetLevelOfSpell(a);
        }
        public void IncreaseAbilty2Level(int a)
        {
            ChampionAbilty3.SetLevelOfSpell(a);
        }
        public void IncreaseAbilty3Level(int a)
        {
            ChampionAbilty4.SetLevelOfSpell(a);
        }
        public void IncreaseAbilty4Level(int a)
        {
            ChampionAbilty5.SetLevelOfSpell(a);
        }
        //Decrease abilty level
        public void DecreaseAbilty1Level(int a)
        {
            ChampionAbilty2.SetLevelOfSpell(a);
        }
        public void DecreaseAbilty2Level(int a)
        {
            ChampionAbilty3.SetLevelOfSpell(a);
        }
        public void DecreaseAbilty3Level(int a)
        {
            ChampionAbilty4.SetLevelOfSpell(a);
        }
        public void DecreaseAbilty4Level(int a)
        {
            ChampionAbilty5.SetLevelOfSpell(a);
        }
        //SummonerSpells
        private SummonerSpells SummonerSpells1;
        private SummonerSpells SummonerSpells2;
        private List<SummonerSpells> SummonerSpellChampHas;
        private int SummonerSpellDamage;

        void SummonerSpellDamageOutput()
        {

        }
        //Items
        private Items Item1;
        private Items Item2;
        private Items Item3;
        private Items Item4;
        private Items Item5;
        private Items Item6;
        private List<Items> ItemsChampHas;
        private double ItemsDamageFromActives;

        void ItemsDamageOutput()
        {

        }

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
        public void SetImage(String Image)
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