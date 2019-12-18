USE [ChampionDB]
GO

/****** Object:  Table [dbo].[DamageIncreaser]    Script Date: 18/12/2019 15:12:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DamageIncreaser](
	[DamageIncreaserID] [int] NOT NULL,
	[AbiltyName] [varchar](100) NOT NULL,
	[DamageIncreaser] [int] NULL,
	[AbiltyLevel] [int] NULL
) ON [PRIMARY]
GO


