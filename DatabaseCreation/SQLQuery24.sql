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
           (3
           ,'
Volley'
           ,NULL
           ,NULL
           ,'ACTIVE: Ashe fires 9 arrows in a cone in the target direction, each dealing physical damage.'
           ,0
           ,1
           ,0
           ,0
           ,'Volley'
           ,0
           ,'Volley'
           ,'Volley'
           ,'Volley'
           ,'Volley')
GO