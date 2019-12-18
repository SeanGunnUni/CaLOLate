USE [UsersDB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 18/12/2019 15:14:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[UserName] [varchar](10) NOT NULL,
	[UserPassword] [varchar](10) NOT NULL,
	[SavedAccounts] [bit] NOT NULL
) ON [PRIMARY]
GO


