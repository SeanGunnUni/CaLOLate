USE [ItemsDB]
GO

/****** Object:  Table [dbo].[Item]    Script Date: 17/03/2020 11:44:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Item](
	[ItemID] [int] NOT NULL,
	[ItemName] [varchar](10) NOT NULL,
	[AP] [int] NULL,
	[AD] [int] NULL,
	[Movespeed] [int] NULL,
	[ActiveDamage] [int] NULL,
	[Armour] [int] NULL,
	[ArmourPenetrationFlat] [int] NULL,
	[ArmourPenetrationPecentage] [int] NULL,
	[AttackSpeed] [int] NULL,
	[CooldownReduction] [int] NULL,
	[CritDamage] [int] NULL,
	[CritStrike] [int] NULL,
	[Decription] [varchar](100) NULL,
	[HaveActive] [bit] NOT NULL,
	[Health] [int] NULL,
	[HealthReg] [float] NULL,
	[ImageOfItem] [varchar](100) NULL,
	[LifeSteal] [int] NULL,
	[MagicPenetrationFlat] [int] NULL,
	[MagicPenetrationPecentage] [int] NULL,
	[MagicResist] [int] NULL,
	[Mana] [int] NULL,
	[ManaReg] [float] NULL,
	[Tenacity] [int] NULL,
	[UniqueItem] [bit] NOT NULL,
	[UniqueActiveADRatioBonus] [int] NULL,
	[UniqueActiveADRatioFull] [int] NULL,
	[UniqueActiveADRatioFlat] [int] NULL,
	[UniqueActiveAPRatio] [int] NULL,
	[UniqueActiveDamage] [int] NULL,
	[UniqueActiveEffect] [int] NULL
) ON [PRIMARY]
GO


