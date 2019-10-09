namespace CaLOLateAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Champions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Level = c.Int(nullable: false),
                        HeathFlat = c.Int(nullable: false),
                        HeathScaling = c.Double(nullable: false),
                        HealthRegFlat = c.Double(nullable: false),
                        HealthRegScaling = c.Double(nullable: false),
                        AdFlat = c.Int(nullable: false),
                        AdScaling = c.Double(nullable: false),
                        AttackSpeedFlat = c.Double(nullable: false),
                        AttackSpeedScale = c.Double(nullable: false),
                        ArmourFlat = c.Int(nullable: false),
                        ArmourScaling = c.Double(nullable: false),
                        MagicResistFlat = c.Int(nullable: false),
                        MagicResistScale = c.Double(nullable: false),
                        Movespeed = c.Int(nullable: false),
                        CooldownReduction = c.Int(nullable: false),
                        Tenacity = c.Int(nullable: false),
                        AbiltyPower = c.Double(nullable: false),
                        CritStrike = c.Int(nullable: false),
                        ArmourPenetrationFlat = c.Int(nullable: false),
                        ArmourPenetrationPecentage = c.Int(nullable: false),
                        MagicPenetrationFlat = c.Int(nullable: false),
                        MagicPenetrationPecentage = c.Int(nullable: false),
                        PassiveDescription = c.String(),
                        PassiveDamage = c.Double(nullable: false),
                        AbiltyOneDescription = c.String(),
                        AbiltyOneDamage = c.Double(nullable: false),
                        AbiltyTwoDescription = c.String(),
                        AbiltyTwoDamage = c.Double(nullable: false),
                        AbiltyThreeDescription = c.String(),
                        AbiltyThreeDamage = c.Double(nullable: false),
                        AbiltyFourDescription = c.String(),
                        AbiltyFourDamage = c.Double(nullable: false),
                        SummonerSpellOneDescription = c.String(),
                        SummonerSpellOneDamage = c.Int(nullable: false),
                        SummonerSpellTwoDescription = c.String(),
                        SummonerSpellTwoDamage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Champions");
        }
    }
}
