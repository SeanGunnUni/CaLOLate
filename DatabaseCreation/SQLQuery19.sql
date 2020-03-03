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
           ,'Ashe'
           ,NULL
           ,'Frost Shot'
           ,'Rangers Focus'
           ,'Volley'
           ,'Hawkshot'
           ,'Enchanted Crystal Arrow')
GO