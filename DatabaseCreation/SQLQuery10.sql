USE [ChampionDB]
GO

/****** Object:  Table [dbo].[RatioAP]    Script Date: 18/12/2019 15:13:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RatioAP](
	[RatioAPID] [int] NOT NULL,
	[AbiltyName] [varchar](100) NOT NULL,
	[RatioAP] [int] NULL,
	[AbiltyLevel] [int] NULL
) ON [PRIMARY]
GO


