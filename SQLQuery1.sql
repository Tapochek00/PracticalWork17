USE [master]
GO

/****** Object:  Database [Accounting]    Script Date: 13.01.2023 10:17:32 ******/
CREATE DATABASE [Accounting]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'�����������', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\�����������.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'�����������_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\�����������_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
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

ALTER DATABASE [Accounting] SET  READ_WRITE 
GO


