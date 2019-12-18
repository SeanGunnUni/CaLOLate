USE [ChampionDB]
GO

/****** Object:  Table [dbo].[ChampionAbilty]    Script Date: 18/12/2019 15:12:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChampionAbilty](
	[ChampionAbiltysID] [int] NOT NULL,
	[ChampionAbiltyName] [varchar](100) NOT NULL,
	[ImageOfChampionAbilty] [varchar](100) NULL,
	[DamageIncreaserSpellName] [varchar](100) NULL,
	[DescriptionOfAbilty] [varchar](100) NULL,
	[HaveADBonusRatio] [bit] NOT NULL,
	[HaveADFullRatio] [bit] NOT NULL,
	[HaveAPRatio] [bit] NOT NULL,
	[HaveSpellIncreaser] [bit] NOT NULL,
	[ManaCostSpellName] [varchar](100) NOT NULL,
	[MaxSpellLevel] [int] NULL,
	[RatioADBonusSpellName] [varchar](100) NOT NULL,
	[RatioADFullSpellName] [varchar](100) NOT NULL,
	[NormalSpellDamageName] [varchar](100) NOT NULL,
	[RatioAPSpellName] [varchar](100) NOT NULL
) ON [PRIMARY]
GO


