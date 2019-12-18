USE [ChampionDB]
GO

/****** Object:  Table [dbo].[RatioADBonus]    Script Date: 18/12/2019 15:13:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RatioADBonus](
	[RatioADBonusID] [int] NOT NULL,
	[AbiltyName] [varchar](100) NOT NULL,
	[RatioADBonus] [int] NULL,
	[AbiltyLevel] [int] NULL
) ON [PRIMARY]
GO


