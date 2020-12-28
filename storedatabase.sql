USE [shop-store-system]
GO
/****** Object:  Table [dbo].[table_categories]    Script Date: 28.12.2020 г. 12:19:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[description] [text] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_table_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_dealer_customer]    Script Date: 28.12.2020 г. 12:19:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_dealer_customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[name] [varchar](150) NULL,
	[email] [varchar](150) NULL,
	[contact] [varchar](15) NULL,
	[address] [text] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_table_dealer_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_products]    Script Date: 28.12.2020 г. 12:19:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[description] [text] NULL,
	[rate] [decimal](18, 2) NULL,
	[qty] [decimal](18, 2) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_table_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_transactions]    Script Date: 28.12.2020 г. 12:19:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[dea_cust_id] [int] NULL,
	[grandTotal] [decimal](18, 2) NULL,
	[transaction_date] [datetime] NULL,
	[tax] [decimal](18, 2) NULL,
	[discount] [decimal](18, 2) NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_table_transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_transactions_detail]    Script Date: 28.12.2020 г. 12:19:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_transactions_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[rate] [decimal](18, 2) NULL,
	[qty] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[dea_cust_id] [int] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_table_transactions_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[table_users]    Script Date: 28.12.2020 г. 12:19:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[email] [varchar](150) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](15) NULL,
	[contact] [varchar](50) NULL,
	[address] [text] NULL,
	[gender] [varchar](10) NULL,
	[user_type] [varchar](15) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_table_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[table_categories] ON 

INSERT [dbo].[table_categories] ([id], [title], [description], [added_date], [added_by]) VALUES (1, N'Food', N'Chips', CAST(N'2020-12-08T11:45:53.620' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[table_categories] OFF
GO
SET IDENTITY_INSERT [dbo].[table_dealer_customer] ON 

INSERT [dbo].[table_dealer_customer] ([id], [type], [name], [email], [contact], [address], [added_date], [added_by]) VALUES (2, N'Dealer', N'aa', N'aa', N'002', N'aaa', CAST(N'2020-12-12T13:47:35.357' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[table_dealer_customer] OFF
GO
SET IDENTITY_INSERT [dbo].[table_products] ON 

INSERT [dbo].[table_products] ([id], [name], [category], [description], [rate], [qty], [added_date], [added_by]) VALUES (2, N'aa', N'Food', N'aa', CAST(20.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), CAST(N'2020-12-12T14:17:30.343' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[table_products] OFF
GO
SET IDENTITY_INSERT [dbo].[table_transactions] ON 

INSERT [dbo].[table_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (1, N'Purchase', 0, CAST(19.19 AS Decimal(18, 2)), CAST(N'2020-12-12T17:39:40.737' AS DateTime), CAST(1.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 6)
INSERT [dbo].[table_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (2, N'Sales', 0, CAST(19.19 AS Decimal(18, 2)), CAST(N'2020-12-13T15:19:14.177' AS DateTime), CAST(1.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 6)
INSERT [dbo].[table_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (3, N'Purchase', 0, CAST(183.60 AS Decimal(18, 2)), CAST(N'2020-12-13T15:22:10.627' AS DateTime), CAST(2.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 6)
SET IDENTITY_INSERT [dbo].[table_transactions] OFF
GO
SET IDENTITY_INSERT [dbo].[table_transactions_detail] ON 

INSERT [dbo].[table_transactions_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (1, 2, CAST(20.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 0, CAST(N'2020-12-12T17:39:41.053' AS DateTime), 6)
INSERT [dbo].[table_transactions_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (2, 2, CAST(20.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 0, CAST(N'2020-12-13T15:19:14.203' AS DateTime), 6)
INSERT [dbo].[table_transactions_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (3, 2, CAST(20.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), 0, CAST(N'2020-12-13T15:22:10.637' AS DateTime), 6)
SET IDENTITY_INSERT [dbo].[table_transactions_detail] OFF
GO
SET IDENTITY_INSERT [dbo].[table_users] ON 

INSERT [dbo].[table_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (4, N'bb', N'bb', N'bb', N'aaa', N'bb', N'bb', N'bb', N'Male', N'User', CAST(N'2020-12-07T13:57:16.067' AS DateTime), 5)
INSERT [dbo].[table_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (5, N'Master', N'Admin', N'admin@gmail.com', N'admin', N'admin', N'0123456789', N'Sofia Bulgariq', N'Male', N'Admin', CAST(N'2020-12-07T12:31:48.900' AS DateTime), 1)
INSERT [dbo].[table_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (6, N'Normal', N'User', N'user@gmail.com', N'user', N'user', N'0123456789', N'Sofia Bulgaria', N'Male', N'User', CAST(N'2020-12-07T12:32:25.353' AS DateTime), 1)
INSERT [dbo].[table_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (7, N'aaa', N'aaa', N'aaa', N'aaa', N'aaa', N'aaa', N'aaa', N'Male', N'User', CAST(N'2020-12-07T13:57:04.647' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[table_users] OFF
GO
