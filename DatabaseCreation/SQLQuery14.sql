USE [SummonerSpellsDB]
GO

/****** Object:  Table [dbo].[SummonerSpell]    Script Date: 18/12/2019 15:14:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SummonerSpell](
	[SummonerSpellID] [int] NOT NULL,
	[SummonerSpellName] [varchar](10) NOT NULL,
	[SummonerSpellDecription] [varchar](100) NULL,
	[SummonerSpellImage] [varchar](100) NULL,
	[DamagePerLevel] [int] NULL
) ON [PRIMARY]
GO


