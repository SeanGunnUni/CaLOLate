USE [ChampionDB]
GO

/****** Object:  Table [dbo].[Champion]    Script Date: 18/12/2019 15:12:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Champion](
	[ChampionID] [int] NOT NULL,
	[ChampionName] [varchar](10) NOT NULL,
	[ImageOfChampion] [varchar](100) NULL,
	[PassiveName] [varchar](100) NULL,
	[Abilty1Name] [varchar](100) NULL,
	[Abilty2Name] [varchar](100) NULL,
	[Abilty3Name] [varchar](100) NULL,
	[UltimateName] [varchar](100) NULL
) ON [PRIMARY]
GO


