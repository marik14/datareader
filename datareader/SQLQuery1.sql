create database BusinessDB
go

USE [BusinessDB]
GO


/****** Object:  Table [dbo].[businessss]    Script Date: 14/03/2021 22:50:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[businessss](
	[ID] [int] NULL,
	[Owner] [nvarchar](50) NULL,
	[BusinessName] [nvarchar](50) NULL,
	[Employees] [int] NULL
) ON [PRIMARY]
GO


