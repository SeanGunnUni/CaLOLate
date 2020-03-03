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
           (2
           ,'Rangers Focus'
           ,NULL
           ,NULL
           ,'PASSIVE - FOCUS: Ashes basic attacks grant Focus for 4 seconds, stacking up to 4 times.'
           ,1
           ,0
           ,0
           ,0
           ,'Rangers Focus'
           ,0
           ,'Rangers Focus'
           ,'Rangers Focus'
           ,'Rangers Focus'
           ,'Rangers Focus')
GO