USE [master]
GO
/****** Object:  Database [AE-Assignment]    Script Date: 10/25/2020 11:26:54 AM ******/
CREATE DATABASE [AE-Assignment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AE-Assignment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\AE-Assignment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AE-Assignment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER01\MSSQL\DATA\AE-Assignment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AE-Assignment] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AE-Assignment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AE-Assignment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AE-Assignment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AE-Assignment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AE-Assignment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AE-Assignment] SET ARITHABORT OFF 
GO
ALTER DATABASE [AE-Assignment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AE-Assignment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AE-Assignment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AE-Assignment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AE-Assignment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AE-Assignment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AE-Assignment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AE-Assignment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AE-Assignment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AE-Assignment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AE-Assignment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AE-Assignment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AE-Assignment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AE-Assignment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AE-Assignment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AE-Assignment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AE-Assignment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AE-Assignment] SET RECOVERY FULL 
GO
ALTER DATABASE [AE-Assignment] SET  MULTI_USER 
GO
ALTER DATABASE [AE-Assignment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AE-Assignment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AE-Assignment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AE-Assignment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AE-Assignment] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AE-Assignment', N'ON'
GO
ALTER DATABASE [AE-Assignment] SET QUERY_STORE = OFF
GO
USE [AE-Assignment]
GO
/****** Object:  Table [dbo].[auction]    Script Date: 10/25/2020 11:26:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auction](
	[id] [int] NOT NULL,
	[bids] [nvarchar](50) NULL,
	[currency] [nvarchar](50) NULL,
	[endDate] [date] NULL,
	[currentPrice] [int] NULL,
	[minIncrement] [int] NULL,
	[lot] [int] NULL,
	[priority] [int] NULL,
	[vatIncrement] [int] NULL,
	[isModified] [bit] NULL,
	[itemId] [int] NULL,
	[icarId] [int] NULL,
	[ivinNumber] [int] NULL,
 CONSTRAINT [PK_auction] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[car]    Script Date: 10/25/2020 11:26:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car](
	[carId] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](50) NULL,
	[description] [nvarchar](50) NULL,
	[imgCount] [int] NULL,
	[sharingLink] [nvarchar](50) NULL,
	[sharingMsg] [nvarchar](50) NULL,
	[milage] [int] NULL,
	[makeId] [int] NULL,
	[bodyId] [int] NULL,
	[year] [int] NULL,
	[body] [nvarchar](50) NULL,
	[make] [nvarchar](50) NULL,
	[model] [nvarchar](50) NULL,
	[auctionId] [int] NULL,
 CONSTRAINT [PK_car] PRIMARY KEY CLUSTERED 
(
	[carId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[car]  WITH CHECK ADD  CONSTRAINT [FK_car_auction] FOREIGN KEY([carId])
REFERENCES [dbo].[car] ([carId])
GO
ALTER TABLE [dbo].[car] CHECK CONSTRAINT [FK_car_auction]
GO
USE [master]
GO
ALTER DATABASE [AE-Assignment] SET  READ_WRITE 
GO
