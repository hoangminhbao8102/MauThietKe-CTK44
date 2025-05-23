USE [Template_RealWorld]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 13/05/2025 17:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 13/05/2025 17:33:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Beverages')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Condiments')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Confections')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Dairy Products')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Grains/Cereals')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Meat/Poultry')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Produce')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Seafood')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (1, N'Chai', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (2, N'Chang', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (3, N'Aniseed Syrup', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (4, N'Chef Anton''s Cajun Seasoning', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (5, N'Chef Anton''s Gumbo Mix', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (6, N'Grandma''s Boysenberry Spread', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (7, N'Uncle Bob''s Organic Dried Pears', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (8, N'Northwoods Cranberry Sauce', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID]) VALUES (9, N'Mishi Kobe Niku', 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
