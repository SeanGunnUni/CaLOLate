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
           (1
           ,'Garen'
           ,NULL
           ,'Perseverance'
           ,'
Decisive Strike'
           ,'Courage'
           ,'Judgment'
           ,'Demacian Justice')
GO