USE [ChampionDB]
GO

/****** Object:  Table [dbo].[ManaCost]    Script Date: 18/12/2019 15:12:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ManaCost](
	[ManacostID] [int] NOT NULL,
	[AbiltyName] [varchar](100) NOT NULL,
	[Manacost] [int] NULL,
	[AbiltyLevel] [int] NULL
) ON [PRIMARY]
GO


