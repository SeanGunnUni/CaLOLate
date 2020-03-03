USE [ChampionDB]
GO

INSERT INTO [dbo].[ChampionAbilty]
           ([ChampionAbiltysID]
           ,[ChampionAbiltyName]
           ,[ImageOfChampionAbilty]
           ,[DamageIncreaserSpellName]
           ,[DescriptionOfAbilty]
           ,[HaveADBonusRatio]
           ,[HaveADFullRatio]
           ,[HaveAPRatio]
           ,[HaveSpellIncreaser]
           ,[ManaCostSpellName]
           ,[MaxSpellLevel]
           ,[RatioADBonusSpellName]
           ,[RatioADFullSpellName]
           ,[NormalSpellDamageName]
           ,[RatioAPSpellName])
     VALUES
           (4
           ,'
Enchanted Crystal Arrow'
           ,NULL
           ,NULL
           ,'ACTIVE: Ashe fires a Arrow of ice in the target direction.'
           ,0
           ,0
           ,1
           ,0
           ,'Enchanted Crystal Arrow'
           ,0
           ,'Enchanted Crystal Arrow'
           ,'Enchanted Crystal Arrow'
           ,'Enchanted Crystal Arrow'
           ,'Enchanted Crystal Arrow')
GO