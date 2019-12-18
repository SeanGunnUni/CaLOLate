USE [ChampionDB]
GO

/****** Object:  Table [dbo].[ChampionStats]    Script Date: 18/12/2019 15:12:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChampionStats](
	[ChampionStatsID] [int] NOT NULL,
	[ChampionStatsName] [varchar](100) NOT NULL,
	[AdFlat] [int] NULL,
	[AdScaling] [float] NULL,
	[ArmourFlat] [int] NULL,
	[ArmourScaling] [float] NULL,
	[AttackSpeedFlat] [int] NULL,
	[AttackSpeedScaling] [float] NULL,
	[EnergyFlat] [int] NULL,
	[EnergyRegFlat] [int] NULL,
	[HealthRegScaling] [float] NULL,
	[HealthFlat] [int] NULL,
	[HealthScaling] [float] NULL,
	[MagicResistFlat] [int] NULL,
	[MagicResistScaling] [float] NULL,
	[ManaFlat] [int] NULL,
	[ManaRegFlat] [int] NULL,
	[ManaRegenScaling] [float] NULL,
	[ManaScaling] [float] NULL,
	[MoveSpeed] [int] NULL,
	[RageFlat] [int] NULL
) ON [PRIMARY]
GO


