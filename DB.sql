USE [master]
GO
/****** Object:  Database [Accounting]    Script Date: 21.03.2023 11:48:29 ******/
CREATE DATABASE [Accounting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'УчетИзделий', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\УчетИзделий.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'УчетИзделий_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\УчетИзделий_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Accounting] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Accounting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Accounting] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Accounting] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Accounting] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Accounting] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Accounting] SET ARITHABORT OFF 
GO
ALTER DATABASE [Accounting] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Accounting] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Accounting] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Accounting] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Accounting] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Accounting] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Accounting] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Accounting] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Accounting] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Accounting] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Accounting] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Accounting] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Accounting] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Accounting] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Accounting] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Accounting] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Accounting] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Accounting] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Accounting] SET  MULTI_USER 
GO
ALTER DATABASE [Accounting] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Accounting] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Accounting] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Accounting] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Accounting] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Accounting] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Accounting] SET QUERY_STORE = OFF
GO
USE [Accounting]
GO
/****** Object:  Table [dbo].[Accounting]    Script Date: 21.03.2023 11:48:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NULL,
	[QuantityMon] [int] NULL,
	[QuantityTue] [int] NULL,
	[QuantityWed] [int] NULL,
	[QuantityThu] [int] NULL,
	[QuantityFri] [int] NULL,
	[QuantitySat] [int] NULL,
	[QuantitySun] [int] NULL,
	[WorkshopName] [nvarchar](50) NOT NULL,
	[ProductType] [nvarchar](50) NOT NULL,
	[Cost] [float] NOT NULL,
 CONSTRAINT [PK_Accounting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounting] ON 

INSERT [dbo].[Accounting] ([id], [Surname], [Name], [Patronymic], [QuantityMon], [QuantityTue], [QuantityWed], [QuantityThu], [QuantityFri], [QuantitySat], [QuantitySun], [WorkshopName], [ProductType], [Cost]) VALUES (1, N'Васильев', N'Василий', N'Васильевич', 24, 0, 0, 0, 0, 0, 0, N'Цех 1', N'Тип изделия', 123)
INSERT [dbo].[Accounting] ([id], [Surname], [Name], [Patronymic], [QuantityMon], [QuantityTue], [QuantityWed], [QuantityThu], [QuantityFri], [QuantitySat], [QuantitySun], [WorkshopName], [ProductType], [Cost]) VALUES (2, N'Евгеньева', N'Евгения', N'Евгеньевна', 0, 23, 0, 54, 0, 11, 0, N'Цех 1', N'Тип изделия', 123)
INSERT [dbo].[Accounting] ([id], [Surname], [Name], [Patronymic], [QuantityMon], [QuantityTue], [QuantityWed], [QuantityThu], [QuantityFri], [QuantitySat], [QuantitySun], [WorkshopName], [ProductType], [Cost]) VALUES (3, N'Александр', N'Сергеевич', N'Пушкин', 29, 22, 23, 53, 26, 0, 0, N'Цех 2', N'Тип изделия 2', 450)
INSERT [dbo].[Accounting] ([id], [Surname], [Name], [Patronymic], [QuantityMon], [QuantityTue], [QuantityWed], [QuantityThu], [QuantityFri], [QuantitySat], [QuantitySun], [WorkshopName], [ProductType], [Cost]) VALUES (4, N'Александров', N'Александр', N'Александрович', 23, 32, 26, 25, 28, 0, 0, N'Цех 2', N'Тип изделия 2', 450)
INSERT [dbo].[Accounting] ([id], [Surname], [Name], [Patronymic], [QuantityMon], [QuantityTue], [QuantityWed], [QuantityThu], [QuantityFri], [QuantitySat], [QuantitySun], [WorkshopName], [ProductType], [Cost]) VALUES (5, N'Варварова', N'Варвара', N'Варваровна', 23, 21, 22, 24, 28, 0, 0, N'Цех 1', N'Тип изделия 2', 123)
SET IDENTITY_INSERT [dbo].[Accounting] OFF
GO
USE [master]
GO
ALTER DATABASE [Accounting] SET  READ_WRITE 
GO
