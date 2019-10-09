namespace CaLOLateAPI.Migrations
{
    using CaLOLateAPI.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CaLOLateAPI.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CaLOLateAPI.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Champions.Add(new Champion() { Name = "Ashe", Image = "", Level = 1, HeathFlat = 539, HeathScaling = 85, HealthRegFlat = 3.5, HealthRegScaling = 0.55, AdFlat = 61, AdScaling = 2.96, AttackSpeedFlat = 0.658, AttackSpeedScale = 0.333, ArmourFlat = 26, ArmourScaling = 3.4, MagicResistFlat = 30, MagicResistScale = 0.5, Movespeed = 325, CooldownReduction = 0, Tenacity = 0, AbiltyPower = 0, CritStrike = 0, ArmourPenetrationFlat = 0, ArmourPenetrationPecentage = 0, MagicPenetrationFlat = 0, MagicPenetrationPecentage = 0, PassiveDescription = "FROST SHOT: Ashe's basic attacks and abilities apply Frost to enemies, Slow icon slowing them by 20% − 30% (based on level) for 2 seconds and causing subsequent basic attacks against them to deal 10% (+ (100% + Infinity Edge item 25%) critical strike chance) AD Attack damage bonus physical damage while they remain Slow icon slowed.  CRITICAL SLOW: Ashe's Critical strike icon critical strikes deal no additional damage, but double Frost's slow strength to 40% − 60% (based on level), decaying over 1 second to its normal strength.", PassiveDamage = 0, AbiltyOneDescription = "PASSIVE - FOCUS: While Ranger's Focus is inactive, Ashe's basic attacks grant Focus for 4 seconds on attack, stacking up to 4 times. After 4 seconds, each stack there after will fall off every second. Rangers Focus ACTIVE: Ashe gains Attack speed icon bonus attack speed for 4 seconds and causes each of her basic attacks to fire a flurry of five arrows. BONUS ATTACK SPEED: 20 / 25 / 30 / 35 / 40 Rangers Focus 2 Flurries trigger on - hit effects only once, and each arrow deals modified physical damage that benefits from Frost Shot Frost Shots and Life steal icon life steal. «TOTAL DAMAGE PER FLURRY: 105 / 110 / 115 / 120 / 125 % AD Ranger's Focus resets Ashe's basic attack timer.", AbiltyOneDamage = 0, AbiltyTwoDescription = "Volley COST: 50 MANACOOLDOWN: 14 / 11.5 / 9 / 6.5 / 4 Volley ACTIVE: Ashe fires 9 arrows in a cone in the target direction, dealing physical damage to enemies, and applying Frost Shot 2 Critical Slow to enemy Champion icon champions. PHYSICAL DAMAGE: 20 / 35 / 50 / 65 / 80(+100 % AD) Enemies do not take damage from arrows beyond the first.", AbiltyTwoDamage = 0, AbiltyThreeDescription = "Hawkshot COST: 1 CHARGECOOLDOWN: 5RECHARGE: 90 / 80 / 70 / 60 / 50 Hawkshot PASSIVE: Ashe periodically stocks a Hawkshot charge, up to a maximum of 2. ACTIVE: Ashe sends a hawk spirit toward the target location, Exposed icon exposing the area along its path for 2 seconds and in a large radius at its destination for 5 seconds.", AbiltyThreeDamage = 0, AbiltyFourDescription = "Enchanted Crystal Arrow COST: 100 MANACOOLDOWN: 100 / 90 / 80Enchanted Crystal Arrow ACTIVE: Ashe fires a Enchanted Crystal Arrow Minimap missile of ice in the target direction.The arrow shatters upon hitting an enemy champion, dealing Magic damage magic damage and Stun icon stunning them for 1 − 3.5(based on distance traveled) seconds. MAGIC DAMAGE:200 / 400 / 600(+100 % AP) Enemies surrounding the main target also take 50 % damage. SECONDARY MAGIC DAMAGE:100 / 200 / 300(+50 % AP)", AbiltyFourDamage = 0, SummonerSpellOneDescription = "Flash", SummonerSpellOneDamage = 0, SummonerSpellTwoDescription = "Ignites an enemy champion, dealing 70 − 410 (based on level) true damage over 5 seconds, with the first tick of damage occurring on-cast and subsequent ticks occurring each 1.2 seconds. This also applies Grievous Wounds icon Grievous Wounds and reveals them for the duration. The Sight icon sight will not reveal stealth champions.", SummonerSpellTwoDamage = 0 });
        }
    }
}
