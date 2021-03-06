USE [master]
GO
/****** Object:  Database [TBP.Projekt]    Script Date: 7/3/2022 10:29:27 PM ******/
CREATE DATABASE [TBP.Projekt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TBP.Projekt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TBP.Projekt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TBP.Projekt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TBP.Projekt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TBP.Projekt] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TBP.Projekt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TBP.Projekt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TBP.Projekt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TBP.Projekt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TBP.Projekt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TBP.Projekt] SET ARITHABORT OFF 
GO
ALTER DATABASE [TBP.Projekt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TBP.Projekt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TBP.Projekt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TBP.Projekt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TBP.Projekt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TBP.Projekt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TBP.Projekt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TBP.Projekt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TBP.Projekt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TBP.Projekt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TBP.Projekt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TBP.Projekt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TBP.Projekt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TBP.Projekt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TBP.Projekt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TBP.Projekt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TBP.Projekt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TBP.Projekt] SET RECOVERY FULL 
GO
ALTER DATABASE [TBP.Projekt] SET  MULTI_USER 
GO
ALTER DATABASE [TBP.Projekt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TBP.Projekt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TBP.Projekt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TBP.Projekt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TBP.Projekt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TBP.Projekt] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TBP.Projekt', N'ON'
GO
ALTER DATABASE [TBP.Projekt] SET QUERY_STORE = OFF
GO
USE [TBP.Projekt]
GO
/****** Object:  Table [dbo].[Beba]    Script Date: 7/3/2022 10:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beba](
	[IdBebe] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NULL,
	[Spol] [varchar](50) NULL,
	[IdKorisnika] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBebe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korisnici]    Script Date: 7/3/2022 10:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KorisnickoIme] [varchar](50) NOT NULL,
	[Lozinka] [varchar](50) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Godine] [int] NOT NULL,
	[PrvaTrudnoca] [bit] NOT NULL,
	[DueDate] [date] NOT NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registar]    Script Date: 7/3/2022 10:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Vrijeme] [datetime] NULL,
	[VrstaPromjene] [varchar](50) NULL,
	[IdKorisnika] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Udarci]    Script Date: 7/3/2022 10:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Udarci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DatumPocetak] [datetime] NOT NULL,
	[DatumKraj] [datetime] NOT NULL,
	[Udarci] [int] NULL,
	[IdKorisnika] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Velicina]    Script Date: 7/3/2022 10:29:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Velicina](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PocetniMjesec] [int] NOT NULL,
	[ZavrsniMjesec] [int] NOT NULL,
	[Naziv] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Beba] ON 

INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (1, NULL, N'Neodredeno', NULL)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (2, N'Zrinka', N'Žensko', 17)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (3, N'Nika', N'Žensko', 18)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (4, N'Mirko', N'Žensko', 19)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (5, N'Idemo2', N'Muško', 20)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (6, NULL, N'Neodredeno', 21)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (7, N'Maja', N'Žensko', 22)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (8, NULL, N'Neodredeno', 23)
INSERT [dbo].[Beba] ([IdBebe], [Naziv], [Spol], [IdKorisnika]) VALUES (9, N'Ema', N'Žensko', 24)
SET IDENTITY_INSERT [dbo].[Beba] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnici] ON 

INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (1, N'prvikorisnik', N'prva', N'Nika', 24, 1, CAST(N'2022-12-22' AS Date), N'prvimail@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (2, N'drugiKorisnik', N'123456', N'Maja', 35, 0, CAST(N'2022-09-24' AS Date), N'drugi@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (3, N'miha', N'miha', N'mima', 28, 1, CAST(N'2023-02-01' AS Date), N'treci@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (4, N'fff', N'fffff', N'ffffff', 18, 0, CAST(N'2022-07-10' AS Date), N'cet@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (6, N'ddfd', N'dfdf', N'dfdf', 17, 1, CAST(N'2022-06-30' AS Date), N'ss@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (7, N'sdsdsd', N'sdsds', N'ddddd', 19, 1, CAST(N'2022-06-30' AS Date), N'sesese@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (8, N'zeljo', N'zeljo', N'Zeljana', 27, 0, CAST(N'2023-01-12' AS Date), N'ssssesese@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (9, N'zeljo2', N'222', N'222', 19, 0, CAST(N'2022-07-01' AS Date), N'osmi@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (10, N'novi', N'novi', N'gg', 18, 1, CAST(N'2022-11-05' AS Date), N'sedaaam@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (11, N'testerPromjena', N'123', N'1234', 30, 1, CAST(N'2022-12-07' AS Date), N'deveeet@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (12, N'tester2', N'123', N'1234', 17, 1, CAST(N'2022-12-27' AS Date), N'nikada@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (13, N'tester3', N'123', N'22', 15, 1, CAST(N'2022-12-30' AS Date), N'idemoooo@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (14, N'jastuk', N'123', N'lozinka', 18, 1, CAST(N'2022-11-26' AS Date), N'jastuk@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (15, N'testtest', N'123', N'ime', 20, 0, CAST(N'2022-07-10' AS Date), N'email@email.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (16, N'novaBeba', N'123', N'222', 16, 1, CAST(N'2022-08-26' AS Date), N'mail@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (17, N'tko', N'123', N'fghf', 17, 1, CAST(N'2022-07-30' AS Date), N'fddd@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (18, N'hrc', N'123', N'hrcc', 26, 1, CAST(N'2023-05-01' AS Date), N'hrc@hrc.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (19, N'tester66', N'11111', N'11111', 19, 1, CAST(N'2022-07-02' AS Date), N's@s.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (20, N'ffff', N'122', N'vds', 16, 1, CAST(N'2022-07-02' AS Date), N'hrvoje@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (21, N'testDanas', N'123', N'tester', 17, 1, CAST(N'2023-03-17' AS Date), N'a@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (22, N'bile', N'123', N'bile', 18, 1, CAST(N'2022-11-19' AS Date), N'bile@vile.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (23, N'admin', N'admin', N'admin', 27, 1, CAST(N'2023-01-20' AS Date), N'hrvoje.pavic994@gmail.com')
INSERT [dbo].[Korisnici] ([Id], [KorisnickoIme], [Lozinka], [Ime], [Godine], [PrvaTrudnoca], [DueDate], [Email]) VALUES (24, N'Final', N'123', N'Finalni', 33, 0, CAST(N'2023-04-11' AS Date), N'f@ffff.com')
SET IDENTITY_INSERT [dbo].[Korisnici] OFF
GO
SET IDENTITY_INSERT [dbo].[Registar] ON 

INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (1, CAST(N'2022-07-03T20:16:37.117' AS DateTime), N'Azuriranje', 17)
INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (2, CAST(N'2022-07-03T20:35:44.537' AS DateTime), N'Azuriranje bebe', 22)
INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (3, CAST(N'2022-07-03T20:44:46.490' AS DateTime), N'Azuriranje bebe', 22)
INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (4, CAST(N'2022-07-03T22:23:06.933' AS DateTime), N'Dodavanje udarca', 24)
INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (5, CAST(N'2022-07-03T22:23:15.003' AS DateTime), N'Dodavanje udarca', 24)
INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (6, CAST(N'2022-07-03T22:25:03.083' AS DateTime), N'Azuriranje bebe', 24)
INSERT [dbo].[Registar] ([Id], [Vrijeme], [VrstaPromjene], [IdKorisnika]) VALUES (7, CAST(N'2022-07-03T22:25:17.963' AS DateTime), N'Azuriranje bebe', 24)
SET IDENTITY_INSERT [dbo].[Registar] OFF
GO
SET IDENTITY_INSERT [dbo].[Udarci] ON 

INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (1, CAST(N'2022-07-03T03:32:35.107' AS DateTime), CAST(N'2022-07-03T03:32:36.913' AS DateTime), 10, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (2, CAST(N'2022-07-03T03:34:40.857' AS DateTime), CAST(N'2022-07-03T03:34:41.800' AS DateTime), 5, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (3, CAST(N'2022-07-03T03:35:44.890' AS DateTime), CAST(N'2022-07-03T03:35:46.323' AS DateTime), 3, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (4, CAST(N'2022-07-03T03:36:26.557' AS DateTime), CAST(N'2022-07-03T03:36:27.670' AS DateTime), 5, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (5, CAST(N'2022-07-03T03:44:24.963' AS DateTime), CAST(N'2022-07-03T03:44:26.140' AS DateTime), 4, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (6, CAST(N'2022-07-03T03:44:45.047' AS DateTime), CAST(N'2022-07-03T03:44:47.880' AS DateTime), 6, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (7, CAST(N'2022-07-03T03:47:22.097' AS DateTime), CAST(N'2022-07-03T03:47:23.630' AS DateTime), 5, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (8, CAST(N'2022-07-03T03:50:30.613' AS DateTime), CAST(N'2022-07-03T03:50:39.457' AS DateTime), 5, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (9, CAST(N'2022-07-03T03:53:34.990' AS DateTime), CAST(N'2022-07-03T03:53:44.433' AS DateTime), 5, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (10, CAST(N'2022-07-03T04:05:14.370' AS DateTime), CAST(N'2022-07-03T04:05:30.697' AS DateTime), 4, 18)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (11, CAST(N'2022-07-03T16:11:59.463' AS DateTime), CAST(N'2022-07-03T16:12:05.487' AS DateTime), 2, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (12, CAST(N'2022-07-03T16:18:42.003' AS DateTime), CAST(N'2022-07-03T16:18:47.327' AS DateTime), 2, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (13, CAST(N'2022-07-03T16:18:52.250' AS DateTime), CAST(N'2022-07-03T16:18:57.957' AS DateTime), 3, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (14, CAST(N'2022-07-03T16:20:14.147' AS DateTime), CAST(N'2022-07-03T16:21:15.363' AS DateTime), 3, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (15, CAST(N'2022-07-03T16:21:26.247' AS DateTime), CAST(N'2022-07-03T16:21:42.377' AS DateTime), 3, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (16, CAST(N'2022-07-03T16:21:46.593' AS DateTime), CAST(N'2022-07-03T16:21:56.517' AS DateTime), 3, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (17, CAST(N'2022-07-03T16:21:59.183' AS DateTime), CAST(N'2022-07-03T16:22:03.153' AS DateTime), 19, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (18, CAST(N'2022-07-03T16:29:39.283' AS DateTime), CAST(N'2022-07-03T16:29:42.193' AS DateTime), 3, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (19, CAST(N'2022-07-03T16:29:45.050' AS DateTime), CAST(N'2022-07-03T16:29:57.273' AS DateTime), 4, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (20, CAST(N'2022-07-03T16:37:07.993' AS DateTime), CAST(N'2022-07-03T16:37:10.450' AS DateTime), 1, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (21, CAST(N'2022-07-03T17:22:58.403' AS DateTime), CAST(N'2022-07-03T17:23:01.463' AS DateTime), 1, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (22, CAST(N'2022-07-03T20:20:30.960' AS DateTime), CAST(N'2022-07-03T20:20:36.603' AS DateTime), 14, 17)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (23, CAST(N'2022-07-03T20:54:58.657' AS DateTime), CAST(N'2022-07-03T20:55:02.353' AS DateTime), 2, 22)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (24, CAST(N'2022-07-03T22:23:00.763' AS DateTime), CAST(N'2022-07-03T22:23:06.917' AS DateTime), 2, 24)
INSERT [dbo].[Udarci] ([Id], [DatumPocetak], [DatumKraj], [Udarci], [IdKorisnika]) VALUES (25, CAST(N'2022-07-03T22:23:10.140' AS DateTime), CAST(N'2022-07-03T22:23:15.003' AS DateTime), 2, 24)
SET IDENTITY_INSERT [dbo].[Udarci] OFF
GO
SET IDENTITY_INSERT [dbo].[Velicina] ON 

INSERT [dbo].[Velicina] ([Id], [PocetniMjesec], [ZavrsniMjesec], [Naziv]) VALUES (1, 0, 1, N'zrno Sezama')
INSERT [dbo].[Velicina] ([Id], [PocetniMjesec], [ZavrsniMjesec], [Naziv]) VALUES (2, 2, 3, N'zelena Maslina')
INSERT [dbo].[Velicina] ([Id], [PocetniMjesec], [ZavrsniMjesec], [Naziv]) VALUES (3, 4, 5, N'mala Paprika')
INSERT [dbo].[Velicina] ([Id], [PocetniMjesec], [ZavrsniMjesec], [Naziv]) VALUES (4, 6, 7, N'Patlidzan')
INSERT [dbo].[Velicina] ([Id], [PocetniMjesec], [ZavrsniMjesec], [Naziv]) VALUES (5, 8, 9, N'Lubenica')
SET IDENTITY_INSERT [dbo].[Velicina] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Cons_email]    Script Date: 7/3/2022 10:29:27 PM ******/
ALTER TABLE [dbo].[Korisnici] ADD  CONSTRAINT [Cons_email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Korisnic__992E6F925CA5CB35]    Script Date: 7/3/2022 10:29:27 PM ******/
ALTER TABLE [dbo].[Korisnici] ADD UNIQUE NONCLUSTERED 
(
	[KorisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Beba]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[Registar]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[Udarci]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
USE [master]
GO
ALTER DATABASE [TBP.Projekt] SET  READ_WRITE 
GO
