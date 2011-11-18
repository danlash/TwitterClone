SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clam](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [varchar](max) NULL,
	[Pearl] [varchar](max) NULL,
	[Timestamp] [datetime] NULL
) ON [PRIMARY]

GO

