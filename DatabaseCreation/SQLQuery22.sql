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
           (1
           ,'Frost Shot'
           ,NULL
           ,NULL
           ,'INNATE - FROST SHOT: Ashes basic attacks and abilities apply Frost to enemies.'
           ,1
           ,0
           ,0
           ,0
           ,'Frost Shot'
           ,0
           ,'Frost Shot'
           ,'Frost Shot'
           ,'Frost Shot'
           ,'Frost Shot')
GO


