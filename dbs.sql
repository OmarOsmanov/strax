USE [straxsDB]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'travel')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'footbal')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'spor')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'carrasing')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'wwwww')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (7, N'mnnnmkj')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [Surname], [Email]) VALUES (1, N'Omar', N'Osmanov', N'OSmanovOmar494@gmail.com')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
