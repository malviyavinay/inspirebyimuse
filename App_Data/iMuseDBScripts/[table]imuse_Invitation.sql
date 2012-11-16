USE [imuse]
GO

/****** Object:  Table [dbo].[imuse_Invitation]    Script Date: 11/08/2012 18:34:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[imuse_Invitation](
	[InvitationID] [int] IDENTITY(1,1) NOT NULL,
	[InvitationEMailID] [nvarchar](100) NULL,
	[InvitationSatus] [bit] NULL
) ON [PRIMARY]

GO


