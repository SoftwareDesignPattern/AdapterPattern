
USE [DevTest]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 11/8/2017 1:27:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[Location] [nchar](100) NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Designation]    Script Date: 11/8/2017 1:27:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](100) NULL,
	[Description] [nchar](100) NULL,
 CONSTRAINT [PK_Designation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/8/2017 1:27:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NULL,
	[Contact] [nchar](100) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Branch] ON 

GO
INSERT [dbo].[Branch] ([ID], [Name], [Location]) VALUES (1, N'Head Office                                                                                         ', N'Dhaka                                                                                               ')
GO
INSERT [dbo].[Branch] ([ID], [Name], [Location]) VALUES (2, N'Local Office                                                                                        ', N'Khulna                                                                                              ')
GO
INSERT [dbo].[Branch] ([ID], [Name], [Location]) VALUES (3, N'Regional Office                                                                                     ', N'Sylhet                                                                                              ')
GO
SET IDENTITY_INSERT [dbo].[Branch] OFF
GO
SET IDENTITY_INSERT [dbo].[Designation] ON 

GO
INSERT [dbo].[Designation] ([ID], [Title], [Description]) VALUES (1, N'Jr. Officer                                                                                         ', N'Local client management                                                                             ')
GO
INSERT [dbo].[Designation] ([ID], [Title], [Description]) VALUES (2, N'Sr. Officer                                                                                         ', N'Office Management                                                                                   ')
GO
INSERT [dbo].[Designation] ([ID], [Title], [Description]) VALUES (3, N'Manager                                                                                             ', N'Head Office Management                                                                              ')
GO
SET IDENTITY_INSERT [dbo].[Designation] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

GO
INSERT [dbo].[Employee] ([ID], [Name], [Contact]) VALUES (1, N'Rahim                                                                                               ', N'987654321                                                                                           ')
GO
INSERT [dbo].[Employee] ([ID], [Name], [Contact]) VALUES (2, N'Karim                                                                                               ', N'123456789                                                                                           ')
GO
INSERT [dbo].[Employee] ([ID], [Name], [Contact]) VALUES (3, N'Jamal                                                                                               ', N'5678904321                                                                                          ')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
