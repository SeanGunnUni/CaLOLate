USE [ChampionDB]
GO

/****** Object:  Table [dbo].[RatioADFull]    Script Date: 18/12/2019 15:13:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RatioADFull](
	[RatioADFullID] [int] NOT NULL,
	[AbiltyName] [varchar](100) NOT NULL,
	[RatioADFull] [int] NULL,
	[AbiltyLevel] [int] NULL
) ON [PRIMARY]
GO


