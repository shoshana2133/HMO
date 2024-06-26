USE [master]
GO
/****** Object:  Database [HMO_DB]    Script Date: 28/03/2024 17:41:42 ******/
CREATE DATABASE [HMO_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HMO_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HMO_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HMO_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HMO_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HMO_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HMO_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HMO_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HMO_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HMO_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HMO_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HMO_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HMO_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HMO_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HMO_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HMO_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HMO_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HMO_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HMO_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HMO_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HMO_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HMO_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HMO_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HMO_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HMO_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HMO_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HMO_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HMO_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HMO_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HMO_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HMO_DB] SET  MULTI_USER 
GO
ALTER DATABASE [HMO_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HMO_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HMO_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HMO_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HMO_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HMO_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HMO_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [HMO_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HMO_DB]
GO
/****** Object:  Table [dbo].[Corona_Patients]    Script Date: 28/03/2024 17:41:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corona_Patients](
	[cpCode] [int] IDENTITY(1,1) NOT NULL,
	[mbrCode] [int] NOT NULL,
	[cpDatePositive] [date] NOT NULL,
	[cpDateRecovery] [date] NULL,
 CONSTRAINT [PK_Corona_Patients] PRIMARY KEY CLUSTERED 
(
	[cpCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[memberHMO]    Script Date: 28/03/2024 17:41:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memberHMO](
	[mbrCode] [int] IDENTITY(1,1) NOT NULL,
	[mbrTz] [nchar](9) NOT NULL,
	[mbrFirstName] [nvarchar](15) NOT NULL,
	[mbrLastName] [nvarchar](15) NOT NULL,
	[mbrCity] [nvarchar](15) NOT NULL,
	[mbrStreet] [nvarchar](15) NOT NULL,
	[mbrNumStreet] [int] NULL,
	[mbrBirthDate] [date] NOT NULL,
	[mbrTel] [nchar](9) NULL,
	[mbrPhon] [nchar](10) NULL,
	[mbrVaccinted] [bit] NOT NULL,
	[mbrPatient] [bit] NOT NULL,
 CONSTRAINT [PK_memberHMO] PRIMARY KEY CLUSTERED 
(
	[mbrCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vaccinated_Mbr]    Script Date: 28/03/2024 17:41:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vaccinated_Mbr](
	[vmCode] [int] IDENTITY(1,1) NOT NULL,
	[mbrCode] [int] NOT NULL,
	[vcCode] [int] NOT NULL,
	[vmDate] [date] NOT NULL,
 CONSTRAINT [PK_Vaccinated_Mbr] PRIMARY KEY CLUSTERED 
(
	[vmCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vaccinations]    Script Date: 28/03/2024 17:41:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vaccinations](
	[vcCode] [int] IDENTITY(1,1) NOT NULL,
	[vcManufacturer] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Vaccinations] PRIMARY KEY CLUSTERED 
(
	[vcCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Corona_Patients] ON 

INSERT [dbo].[Corona_Patients] ([cpCode], [mbrCode], [cpDatePositive], [cpDateRecovery]) VALUES (2, 5, CAST(N'2020-06-05' AS Date), CAST(N'2020-07-06' AS Date))
INSERT [dbo].[Corona_Patients] ([cpCode], [mbrCode], [cpDatePositive], [cpDateRecovery]) VALUES (5, 10, CAST(N'2023-08-07' AS Date), CAST(N'2023-08-28' AS Date))
SET IDENTITY_INSERT [dbo].[Corona_Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[memberHMO] ON 

INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (4, N'123456782', N'ישראל', N'ישראלי', N'תל אביב', N'הפרדס', 24, CAST(N'1998-04-16' AS Date),N'089863521', N'0524561235', 1, 0)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (5, N'999651243', N'דניאל', N'לוי', N'חיפה', N'הרופא', 7, CAST(N'1954-03-10' AS Date), N'045896321', NULL, 1, 1)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (10, N'999838055', N'טליה', N'דוד', N'קרית גת', N'תאנה', 15, CAST(N'2007-03-07' AS Date), N'085656665', N'0524899654', 0, 1)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (11, N'999092026', N'מיכאל', N'אליאס', N'תל אביב', N'בגין', 53, CAST(N'2010-02-11' AS Date), N'035656565', N'0588555888', 0, 0)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (12, N'999927775', N'שרה', N'צבאג', N'טבריה', N'יפו', 55, CAST(N'1995-05-30' AS Date), N'069899855', N'0569965423', 1, 0)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (13, N'999318074', N'שרה', N'דנון', N'תל אביב', N'יסמין', 45, CAST(N'2009-06-04' AS Date), N'045555555', N'0545555555', 0, 0)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (14, N'999403264', N'דני', N'דוד', N'קרית גת', N'יסמין', 58, CAST(N'2005-03-09' AS Date), N'065353535', N'0527555555', 0, 0)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (15, N'999701667', N'יאיר', N'מיכאלוב', N'צפת', N'רמבם', 56, CAST(N'2011-06-08' AS Date), N'036262956', N'0583276219', 0, 0)
INSERT [dbo].[memberHMO] ([mbrCode], [mbrTz], [mbrFirstName], [mbrLastName], [mbrCity], [mbrStreet], [mbrNumStreet], [mbrBirthDate], [mbrTel], [mbrPhon], [mbrVaccinted], [mbrPatient]) VALUES (16, N'999983794', N'ערן', N'מורה', N'שדרות', N'צופן', 4, CAST(N'2011-07-14' AS Date), N'085252565', N'0502583455', 1, 0)
SET IDENTITY_INSERT [dbo].[memberHMO] OFF
GO
SET IDENTITY_INSERT [dbo].[Vaccinated_Mbr] ON 

INSERT [dbo].[Vaccinated_Mbr] ([vmCode], [mbrCode], [vcCode], [vmDate]) VALUES (1, 5, 4, CAST(N'2020-12-10' AS Date))
INSERT [dbo].[Vaccinated_Mbr] ([vmCode], [mbrCode], [vcCode], [vmDate]) VALUES (2, 4, 1, CAST(N'2021-01-16' AS Date))
INSERT [dbo].[Vaccinated_Mbr] ([vmCode], [mbrCode], [vcCode], [vmDate]) VALUES (3, 5, 4, CAST(N'2021-03-20' AS Date))
INSERT [dbo].[Vaccinated_Mbr] ([vmCode], [mbrCode], [vcCode], [vmDate]) VALUES (6, 12, 2, CAST(N'2022-03-28' AS Date))
INSERT [dbo].[Vaccinated_Mbr] ([vmCode], [mbrCode], [vcCode], [vmDate]) VALUES (7, 16, 4, CAST(N'2020-03-12' AS Date))
SET IDENTITY_INSERT [dbo].[Vaccinated_Mbr] OFF
GO
SET IDENTITY_INSERT [dbo].[Vaccinations] ON 

INSERT [dbo].[Vaccinations] ([vcCode], [vcManufacturer]) VALUES (1, N'פייזר')
INSERT [dbo].[Vaccinations] ([vcCode], [vcManufacturer]) VALUES (2, N'מודרנה')
INSERT [dbo].[Vaccinations] ([vcCode], [vcManufacturer]) VALUES (3, N'אסטרהזניקה')
INSERT [dbo].[Vaccinations] ([vcCode], [vcManufacturer]) VALUES (4, N'נובהווקס')
SET IDENTITY_INSERT [dbo].[Vaccinations] OFF
GO
ALTER TABLE [dbo].[Corona_Patients]  WITH CHECK ADD  CONSTRAINT [FK_Corona_Patients_memberHMO] FOREIGN KEY([mbrCode])
REFERENCES [dbo].[memberHMO] ([mbrCode])
GO
ALTER TABLE [dbo].[Corona_Patients] CHECK CONSTRAINT [FK_Corona_Patients_memberHMO]
GO
ALTER TABLE [dbo].[Vaccinated_Mbr]  WITH CHECK ADD  CONSTRAINT [FK_Vaccinated_Mbr_memberHMO] FOREIGN KEY([mbrCode])
REFERENCES [dbo].[memberHMO] ([mbrCode])
GO
ALTER TABLE [dbo].[Vaccinated_Mbr] CHECK CONSTRAINT [FK_Vaccinated_Mbr_memberHMO]
GO
ALTER TABLE [dbo].[Vaccinated_Mbr]  WITH CHECK ADD  CONSTRAINT [FK_Vaccinated_Mbr_Vaccinations] FOREIGN KEY([vcCode])
REFERENCES [dbo].[Vaccinations] ([vcCode])
GO
ALTER TABLE [dbo].[Vaccinated_Mbr] CHECK CONSTRAINT [FK_Vaccinated_Mbr_Vaccinations]
GO
USE [master]
GO
ALTER DATABASE [HMO_DB] SET  READ_WRITE 
GO
