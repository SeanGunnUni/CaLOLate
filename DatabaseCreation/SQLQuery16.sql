USE [UsersDB]
GO

/****** Object:  Table [dbo].[SavedAccounts]    Script Date: 18/12/2019 15:14:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SavedAccounts](
	[SavedAccountsID] [int] NOT NULL,
	[UserName] [varchar](10) NOT NULL,
	[SavedAccount] [varchar](10) NULL
) ON [PRIMARY]
GO


