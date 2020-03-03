USE [ChampionDB]
GO

INSERT INTO [dbo].[ChampionStats]
           ([ChampionStatsID]
           ,[ChampionStatsName]
           ,[AdFlat]
           ,[AdScaling]
           ,[ArmourFlat]
           ,[ArmourScaling]
           ,[AttackSpeedFlat]
           ,[AttackSpeedScaling]
           ,[EnergyFlat]
           ,[EnergyRegFlat]
           ,[HealthRegScaling]
           ,[HealthFlat]
           ,[HealthScaling]
           ,[MagicResistFlat]
           ,[MagicResistScaling]
           ,[ManaFlat]
           ,[ManaRegFlat]
           ,[ManaRegenScaling]
           ,[ManaScaling]
           ,[MoveSpeed]
           ,[RageFlat])
     VALUES
           (1
           ,'Ashe'
           ,61
           ,2.96
           ,26
           ,0.55
           ,0.658
           ,3.33
           ,0
           ,0
           ,0.55
           ,539
           ,85
           ,30
           ,0.5
           ,280
           ,6.972
           ,0.4
           ,32
           ,325
           ,0)
GO


