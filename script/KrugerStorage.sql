USE [master]
GO
/****** Object:  Database [KrugerStorage]    Script Date: 22/05/2019 20:09:00 ******/
CREATE DATABASE [KrugerStorage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BodegaKruger', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BodegaKruger.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BodegaKruger_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BodegaKruger_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KrugerStorage] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KrugerStorage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KrugerStorage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KrugerStorage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KrugerStorage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KrugerStorage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KrugerStorage] SET ARITHABORT OFF 
GO
ALTER DATABASE [KrugerStorage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KrugerStorage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KrugerStorage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KrugerStorage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KrugerStorage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KrugerStorage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KrugerStorage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KrugerStorage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KrugerStorage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KrugerStorage] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KrugerStorage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KrugerStorage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KrugerStorage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KrugerStorage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KrugerStorage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KrugerStorage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KrugerStorage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KrugerStorage] SET RECOVERY FULL 
GO
ALTER DATABASE [KrugerStorage] SET  MULTI_USER 
GO
ALTER DATABASE [KrugerStorage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KrugerStorage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KrugerStorage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KrugerStorage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KrugerStorage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KrugerStorage] SET QUERY_STORE = OFF
GO
USE [KrugerStorage]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [KrugerStorage]
GO
/****** Object:  Schema [Operations]    Script Date: 22/05/2019 20:09:00 ******/
CREATE SCHEMA [Operations]
GO
/****** Object:  Schema [Sales]    Script Date: 22/05/2019 20:09:00 ******/
CREATE SCHEMA [Sales]
GO
/****** Object:  Table [Operations].[Product]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Operations].[Product](
	[ProductID] [int] NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Description] [varchar](250) NOT NULL,
	[Size] [nvarchar](5) NOT NULL,
	[SizeUnitMeasureCode] [nchar](3) NOT NULL,
	[Weight] [decimal](8, 2) NOT NULL,
	[WeightUnitMeasureCode] [nchar](3) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Operations].[ProductCategory]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Operations].[ProductCategory](
	[ProductCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Operations].[Rack]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Operations].[Rack](
	[RackID] [int] IDENTITY(1,1) NOT NULL,
	[StorageID] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[ColumnQty] [int] NOT NULL,
	[RowQty] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
 CONSTRAINT [PK_Rack] PRIMARY KEY CLUSTERED 
(
	[RackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Operations].[Storage]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Operations].[Storage](
	[StorageID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Lenght] [int] NOT NULL,
	[MinTemperature] [int] NOT NULL,
	[MaxTemperature] [int] NOT NULL,
	[RacksWidthQty] [int] NOT NULL,
	[RacksLenghtQty] [int] NOT NULL,
 CONSTRAINT [PK_Storage] PRIMARY KEY CLUSTERED 
(
	[StorageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Operations].[StorageOrder]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Operations].[StorageOrder](
	[StorageOrderID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[RackID] [int] NOT NULL,
	[OrderQty] [smallint] NOT NULL,
	[ColumnNumber] [int] NOT NULL,
	[RowNumber] [int] NOT NULL,
	[EntryDate] [datetime] NOT NULL,
	[DepartureDate] [datetime] NULL,
	[DiscontinuedDate] [date] NOT NULL,
 CONSTRAINT [PK_StorageOrder] PRIMARY KEY CLUSTERED 
(
	[StorageOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Operations].[UnitMeasure]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Operations].[UnitMeasure](
	[UnitMeasureCode] [nchar](3) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UnitMeasure] PRIMARY KEY CLUSTERED 
(
	[UnitMeasureCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Sales].[Customer]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerTypeID] [int] NOT NULL,
	[DocumentNumber] [varchar](50) NOT NULL,
	[DocumentTypeID] [int] NOT NULL,
	[FirstName] [varchar](500) NOT NULL,
	[LastName] [varchar](500) NULL,
	[Address] [varchar](200) NOT NULL,
	[Email] [varchar](200) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Sales].[CustomerType]    Script Date: 22/05/2019 20:09:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Sales].[CustomerType](
	[CustomerTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[ShortDescription] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CustomerType] PRIMARY KEY CLUSTERED 
(
	[CustomerTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [Operations].[Product] ([ProductID], [ProductCategoryID], [CustomerID], [Description], [Size], [SizeUnitMeasureCode], [Weight], [WeightUnitMeasureCode]) VALUES (1, 1, 1, N'Botella de Coca Cola 1L', N'1', N'BTL', CAST(1.00 AS Decimal(8, 2)), N'L  ')
INSERT [Operations].[Product] ([ProductID], [ProductCategoryID], [CustomerID], [Description], [Size], [SizeUnitMeasureCode], [Weight], [WeightUnitMeasureCode]) VALUES (2, 2, 2, N'LG Display Screen Modelo LP156WHB', N'1', N'CJ ', CAST(3.00 AS Decimal(8, 2)), N'KG ')
SET IDENTITY_INSERT [Operations].[ProductCategory] ON 

INSERT [Operations].[ProductCategory] ([ProductCategoryID], [Name]) VALUES (1, N'Bebidas')
INSERT [Operations].[ProductCategory] ([ProductCategoryID], [Name]) VALUES (2, N'Electrónico')
SET IDENTITY_INSERT [Operations].[ProductCategory] OFF
SET IDENTITY_INSERT [Operations].[Rack] ON 

INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (1, 1, N'Estante 1', 5, 5, 1)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (3, 1, N'Estante 2', 5, 5, 2)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (4, 1, N'Estante 3', 5, 5, 3)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (5, 1, N'Estante 4', 5, 5, 4)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (6, 1, N'Estante 5', 5, 5, 5)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (7, 2, N'Estante 1', 3, 3, 1)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (8, 2, N'Estante 2', 4, 4, 2)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (9, 2, N'Estante 3', 3, 2, 3)
INSERT [Operations].[Rack] ([RackID], [StorageID], [Description], [ColumnQty], [RowQty], [OrderNumber]) VALUES (10, 2, N'Estante 4', 3, 3, 4)
SET IDENTITY_INSERT [Operations].[Rack] OFF
SET IDENTITY_INSERT [Operations].[Storage] ON 

INSERT [Operations].[Storage] ([StorageID], [ProductCategoryID], [Width], [Lenght], [MinTemperature], [MaxTemperature], [RacksWidthQty], [RacksLenghtQty]) VALUES (1, 1, 2, 2, 10, 15, 1, 1)
INSERT [Operations].[Storage] ([StorageID], [ProductCategoryID], [Width], [Lenght], [MinTemperature], [MaxTemperature], [RacksWidthQty], [RacksLenghtQty]) VALUES (2, 2, 5, 1, 30, 35, 3, 1)
INSERT [Operations].[Storage] ([StorageID], [ProductCategoryID], [Width], [Lenght], [MinTemperature], [MaxTemperature], [RacksWidthQty], [RacksLenghtQty]) VALUES (3, 2, 6, 1, 30, 35, 4, 1)
INSERT [Operations].[Storage] ([StorageID], [ProductCategoryID], [Width], [Lenght], [MinTemperature], [MaxTemperature], [RacksWidthQty], [RacksLenghtQty]) VALUES (5, 2, 5, 2, 30, 35, 7, 1)
INSERT [Operations].[Storage] ([StorageID], [ProductCategoryID], [Width], [Lenght], [MinTemperature], [MaxTemperature], [RacksWidthQty], [RacksLenghtQty]) VALUES (6, 2, 29, 5, 10, 20, 3, 4)
SET IDENTITY_INSERT [Operations].[Storage] OFF
SET IDENTITY_INSERT [Operations].[StorageOrder] ON 

INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (1, 1, 1, 1, 1, 1, CAST(N'2019-05-11T13:13:00.000' AS DateTime), CAST(N'2019-05-25T11:11:00.000' AS DateTime), CAST(N'2019-07-25' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (2, 1, 3, 5, 5, 3, CAST(N'2019-05-09T00:00:00.000' AS DateTime), NULL, CAST(N'2019-05-31' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (3, 1, 3, 50, 3, 2, CAST(N'2019-05-04T00:00:00.000' AS DateTime), NULL, CAST(N'2019-06-21' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (4, 2, 3, 5, 5, 4, CAST(N'2019-05-08T00:00:00.000' AS DateTime), NULL, CAST(N'2019-05-31' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (5, 2, 3, 10, 5, 4, CAST(N'2019-05-08T00:00:00.000' AS DateTime), NULL, CAST(N'2019-07-26' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (6, 1, 3, 20, 3, 4, CAST(N'2019-05-22T00:00:00.000' AS DateTime), NULL, CAST(N'2019-06-15' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (7, 1, 1, 20, 5, 4, CAST(N'2019-05-22T00:00:00.000' AS DateTime), NULL, CAST(N'2019-06-15' AS Date))
INSERT [Operations].[StorageOrder] ([StorageOrderID], [ProductID], [RackID], [OrderQty], [ColumnNumber], [RowNumber], [EntryDate], [DepartureDate], [DiscontinuedDate]) VALUES (8, 2, 9, 5, 1, 3, CAST(N'2019-05-22T00:00:00.000' AS DateTime), NULL, CAST(N'2024-07-18' AS Date))
SET IDENTITY_INSERT [Operations].[StorageOrder] OFF
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'BTL', N'Botellas')
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'C  ', N'Celcius')
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'CJ ', N'Cajas')
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'G  ', N'Gramo')
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'KG ', N'Kilogramo')
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'L  ', N'Litro')
INSERT [Operations].[UnitMeasure] ([UnitMeasureCode], [Name]) VALUES (N'M2 ', N'Metro cuadrado')
SET IDENTITY_INSERT [Sales].[Customer] ON 

INSERT [Sales].[Customer] ([CustomerID], [CustomerTypeID], [DocumentNumber], [DocumentTypeID], [FirstName], [LastName], [Address], [Email]) VALUES (1, 1, N'70326161', 1, N'Eduardo', N'Naquira   ', N'Calle Pablo Usandizaga 263', N'eduardo.naquira@gmail.com')
INSERT [Sales].[Customer] ([CustomerID], [CustomerTypeID], [DocumentNumber], [DocumentTypeID], [FirstName], [LastName], [Address], [Email]) VALUES (2, 2, N'20600698584', 2, N'IBELLA S.R.L', NULL, N'Av. Benavides 1597', N'hola@ibella.pe')
SET IDENTITY_INSERT [Sales].[Customer] OFF
SET IDENTITY_INSERT [Sales].[CustomerType] ON 

INSERT [Sales].[CustomerType] ([CustomerTypeID], [Description], [ShortDescription]) VALUES (1, N'Persona autónoma', N'PA        ')
INSERT [Sales].[CustomerType] ([CustomerTypeID], [Description], [ShortDescription]) VALUES (2, N'Empresa', N'EM        ')
SET IDENTITY_INSERT [Sales].[CustomerType] OFF
ALTER TABLE [Operations].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Customer] FOREIGN KEY([CustomerID])
REFERENCES [Sales].[Customer] ([CustomerID])
GO
ALTER TABLE [Operations].[Product] CHECK CONSTRAINT [FK_Product_Customer]
GO
ALTER TABLE [Operations].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductCategory] FOREIGN KEY([ProductCategoryID])
REFERENCES [Operations].[ProductCategory] ([ProductCategoryID])
GO
ALTER TABLE [Operations].[Product] CHECK CONSTRAINT [FK_Product_ProductCategory]
GO
ALTER TABLE [Operations].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_UnitMeasure] FOREIGN KEY([SizeUnitMeasureCode])
REFERENCES [Operations].[UnitMeasure] ([UnitMeasureCode])
GO
ALTER TABLE [Operations].[Product] CHECK CONSTRAINT [FK_Product_UnitMeasure]
GO
ALTER TABLE [Operations].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_UnitMeasure1] FOREIGN KEY([WeightUnitMeasureCode])
REFERENCES [Operations].[UnitMeasure] ([UnitMeasureCode])
GO
ALTER TABLE [Operations].[Product] CHECK CONSTRAINT [FK_Product_UnitMeasure1]
GO
ALTER TABLE [Operations].[Rack]  WITH CHECK ADD  CONSTRAINT [FK_Rack_Storage] FOREIGN KEY([StorageID])
REFERENCES [Operations].[Storage] ([StorageID])
GO
ALTER TABLE [Operations].[Rack] CHECK CONSTRAINT [FK_Rack_Storage]
GO
ALTER TABLE [Operations].[StorageOrder]  WITH CHECK ADD  CONSTRAINT [FK_StorageOrder_Product] FOREIGN KEY([ProductID])
REFERENCES [Operations].[Product] ([ProductID])
GO
ALTER TABLE [Operations].[StorageOrder] CHECK CONSTRAINT [FK_StorageOrder_Product]
GO
ALTER TABLE [Operations].[StorageOrder]  WITH CHECK ADD  CONSTRAINT [FK_StorageOrder_Rack] FOREIGN KEY([RackID])
REFERENCES [Operations].[Rack] ([RackID])
GO
ALTER TABLE [Operations].[StorageOrder] CHECK CONSTRAINT [FK_StorageOrder_Rack]
GO
ALTER TABLE [Sales].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_CustomerType] FOREIGN KEY([CustomerTypeID])
REFERENCES [Sales].[CustomerType] ([CustomerTypeID])
GO
ALTER TABLE [Sales].[Customer] CHECK CONSTRAINT [FK_Customer_CustomerType]
GO
USE [master]
GO
ALTER DATABASE [KrugerStorage] SET  READ_WRITE 
GO
