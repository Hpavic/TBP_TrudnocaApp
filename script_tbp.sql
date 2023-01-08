USE [TBP.Projekt]
GO
/****** Object:  Table [dbo].[MedicinaPovijest]    Script Date: 1/8/2023 7:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicinaPovijest](
	[IdMedicine] [int] NOT NULL,
	[IdKorisnika] [int] NULL,
	[Naziv] [varchar](50) NULL,
	[Opis] [varchar](50) NULL,
	[Cijena] [decimal](10, 2) NOT NULL,
	[VrijediOd] [datetime2](7) NOT NULL,
	[VrijediDo] [datetime2](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicina]    Script Date: 1/8/2023 7:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicina](
	[IdMedicine] [int] IDENTITY(1,1) NOT NULL,
	[IdKorisnika] [int] NULL,
	[Naziv] [varchar](50) NULL,
	[Opis] [varchar](50) NULL,
	[Cijena] [decimal](10, 2) NOT NULL,
	[VrijediOd] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[VrijediDo] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMedicine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
	PERIOD FOR SYSTEM_TIME ([VrijediOd], [VrijediDo])
) ON [PRIMARY]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [dbo].[MedicinaPovijest])
)
GO
/****** Object:  Table [dbo].[RekreacijaPovijest]    Script Date: 1/8/2023 7:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RekreacijaPovijest](
	[IdSetnja] [int] NOT NULL,
	[IdKorisnika] [int] NULL,
	[Opis] [varchar](50) NULL,
	[Setnja] [int] NULL,
	[KodKuce] [bit] NOT NULL,
	[SysStartTime] [datetime2](7) NOT NULL,
	[SysEndTime] [datetime2](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rekreacija]    Script Date: 1/8/2023 7:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rekreacija](
	[IdSetnja] [int] IDENTITY(1,1) NOT NULL,
	[IdKorisnika] [int] NULL,
	[Opis] [varchar](50) NULL,
	[Setnja] [int] NULL,
	[KodKuce] [bit] NOT NULL,
	[SysStartTime] [datetime2](7) GENERATED ALWAYS AS ROW START NOT NULL,
	[SysEndTime] [datetime2](7) GENERATED ALWAYS AS ROW END NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSetnja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
	PERIOD FOR SYSTEM_TIME ([SysStartTime], [SysEndTime])
) ON [PRIMARY]
WITH
(
SYSTEM_VERSIONING = ON (HISTORY_TABLE = [dbo].[RekreacijaPovijest])
)
GO
/****** Object:  Table [dbo].[Beba]    Script Date: 1/8/2023 7:37:34 PM ******/
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
/****** Object:  Table [dbo].[Korisnici]    Script Date: 1/8/2023 7:37:34 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Cons_email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[KorisnickoIme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NajdraziUdarci]    Script Date: 1/8/2023 7:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NajdraziUdarci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdIntervala] [int] NOT NULL,
	[Datum] [date] NOT NULL,
	[PocetakIntervala] [time](7) NULL,
	[RedniBrojUdarca] [int] NULL,
	[VrijemeUdarca] [time](7) NULL,
	[KrajIntervala] [time](7) NULL,
	[IdKorisnika] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registar]    Script Date: 1/8/2023 7:37:34 PM ******/
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
/****** Object:  Table [dbo].[Udarci]    Script Date: 1/8/2023 7:37:34 PM ******/
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
/****** Object:  Table [dbo].[Velicina]    Script Date: 1/8/2023 7:37:34 PM ******/
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
ALTER TABLE [dbo].[Rekreacija] ADD  DEFAULT ((1)) FOR [KodKuce]
GO
ALTER TABLE [dbo].[Beba]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[Medicina]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[NajdraziUdarci]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[Registar]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[Rekreacija]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
ALTER TABLE [dbo].[Udarci]  WITH CHECK ADD FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[Korisnici] ([Id])
GO
