USE [ChampionDB]
GO

/****** Object:  Table [dbo].[NormalSpellDamage]    Script Date: 18/12/2019 15:12:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NormalSpellDamage](
	[NormalSpellDamageID] [int] NOT NULL,
	[AbiltyName] [varchar](100) NOT NULL,
	[NormalSpellDamage] [int] NULL,
	[AbiltyLevel] [int] NULL
) ON [PRIMARY]
GO


