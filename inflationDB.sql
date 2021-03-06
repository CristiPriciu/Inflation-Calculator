USE [master]
GO
/****** Object:  Database [InflationCalc]    Script Date: 8/6/2018 6:07:16 PM ******/
CREATE DATABASE [InflationCalc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InflationCalc', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\InflationCalc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InflationCalc_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\InflationCalc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InflationCalc] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InflationCalc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InflationCalc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InflationCalc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InflationCalc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InflationCalc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InflationCalc] SET ARITHABORT OFF 
GO
ALTER DATABASE [InflationCalc] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [InflationCalc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InflationCalc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InflationCalc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InflationCalc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InflationCalc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InflationCalc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InflationCalc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InflationCalc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InflationCalc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InflationCalc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InflationCalc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InflationCalc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InflationCalc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InflationCalc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InflationCalc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InflationCalc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InflationCalc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InflationCalc] SET  MULTI_USER 
GO
ALTER DATABASE [InflationCalc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InflationCalc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InflationCalc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InflationCalc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InflationCalc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InflationCalc] SET QUERY_STORE = OFF
GO
USE [InflationCalc]
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
USE [InflationCalc]
GO
/****** Object:  Table [dbo].[CountryList]    Script Date: 8/6/2018 6:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[Percentage] [float] NOT NULL,
 CONSTRAINT [PK_CountryList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CountryList] ON 

INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (6, N'Romania', 1990, 5.1)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (7, N'Romania', 1991, 170.2)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (8, N'Romania', 1992, 210.4)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (9, N'Romania', 1993, 256.1)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (10, N'Romania', 1994, 136.7)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (11, N'Romania', 1995, 32.3)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (12, N'Romania', 1996, 38.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (13, N'Romania', 1997, 154.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (14, N'Romania', 1998, 59.1)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (15, N'Romania', 1999, 45.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (16, N'Romania', 2000, 45.7)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (17, N'Romania', 2001, 34.5)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (18, N'Romania', 2002, 22.5)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (19, N'Romania', 2003, 15.3)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (20, N'Romania', 2004, 11.9)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (21, N'Chad', 2012, 7.7)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (22, N'Chad', 2013, 0.23)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (23, N'Chad', 2014, 1.68)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (24, N'Chad', 2015, 6.76)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (25, N'Chad', 2016, -1.12)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (26, N'Chad', 2017, -0.92)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (27, N'Chad', 2018, 2.12)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (28, N'United Kingdom', 2008, 3.6)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (29, N'United Kingdom', 2009, 2.2)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (30, N'United Kingdom', 2010, 3.3)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (31, N'United Kingdom', 2011, 4.5)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (32, N'United Kingdom', 2012, 2.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (33, N'United Kingdom', 2013, 2.6)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (34, N'United States', 1917, 17.4)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (35, N'United States', 1918, 18)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (36, N'United States', 1919, 14.6)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (37, N'United States', 1920, 15.6)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (38, N'United States', 1921, -10.5)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (39, N'United States', 1922, -6.1)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (40, N'United States', 1923, 1.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (41, N'United States', 1924, 0)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (42, N'Venezuela', 2012, 21.07)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (43, N'Venezuela', 2013, 43.53)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (44, N'Venezuela', 2014, 57.31)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (45, N'Venezuela', 2015, 111.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (46, N'Venezuela', 2016, 254.39)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (47, N'Venezuela', 2017, 1087.53)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (48, N'Venezuela', 2018, 13864.59)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (49, N'Venezuela', 2019, 12874.63)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (50, N'Venezuela', 2020, 12874.63)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (51, N'Venezuela', 2021, 12874.63)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (52, N'Zimbabwe', 1996, 16)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (53, N'Zimbabwe', 1997, 20)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (54, N'Zimbabwe', 1998, 48)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (55, N'Zimbabwe', 1999, 56.9)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (56, N'Zimbabwe', 2000, 55.22)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (57, N'Zimbabwe', 2001, 112.1)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (58, N'Zimbabwe', 2002, 198.93)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (59, N'Zimbabwe', 2003, 598.75)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (60, N'Zimbabwe', 2004, 132.75)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (61, N'Zimbabwe', 2005, 585.84)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (62, N'Zimbabwe', 2006, 1281.11)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (63, N'Zimbabwe', 2007, 66212.3)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (64, N'Zimbabwe', 2008, 79600000000)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (65, N'Romania', 2005, 9)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (66, N'Romania', 2006, 6.6)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (67, N'Romania', 2007, 4.8)
INSERT [dbo].[CountryList] ([Id], [Country], [Year], [Percentage]) VALUES (68, N'Romania', 2008, 6.2)
SET IDENTITY_INSERT [dbo].[CountryList] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CountryYear]    Script Date: 8/6/2018 6:07:16 PM ******/
CREATE NONCLUSTERED INDEX [IX_CountryYear] ON [dbo].[CountryList]
(
	[Country] ASC,
	[Year] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SpDdlCountry]    Script Date: 8/6/2018 6:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpDdlCountry]
	@act	nvarchar(50),
	@country   nvarchar(40)='ND',
	@year      int=0,
	@percentage float=0,
	@startYear	int=0,
	@endYear	int = 0

AS
BEGIN
	IF(LOWER(@act) = 'get')
		BEGIN
			select distinct Country from CountryList ORDER BY Country
		END
	IF LOWER(@act)='getyears'
	    BEGIN
			select distinct [Year] from CountryList
			where Country = @country
			order by [Year]
		END
    IF LOWER(@act)='getpercentagebyinterval'
	    BEGIN
		    select [Percentage] from CountryList
			where Country = @country
			AND [Year] between @startYear and @endYear
        END
    IF lower(@act)='insert'
		BEGIN
			INSERT INTO CountryList(Country, Year, [Percentage])
			VALUES(@country, @year, @percentage)
		END


		
END
GO
USE [master]
GO
ALTER DATABASE [InflationCalc] SET  READ_WRITE 
GO
