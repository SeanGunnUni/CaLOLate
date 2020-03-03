USE [ChampionDB]
GO

INSERT INTO [dbo].[Champion]
           ([ChampionID]
           ,[ChampionName]
           ,[ImageOfChampion]
           ,[PassiveName]
           ,[Abilty1Name]
           ,[Abilty2Name]
           ,[Abilty3Name]
           ,[UltimateName])
     VALUES
           (4
           ,'Zilean'
           ,NULL
           ,'Time in a Bottle'
           ,'
Time Bomb'
           ,'Rewind'
           ,'Time Warp'
           ,'Chronoshift')
GO