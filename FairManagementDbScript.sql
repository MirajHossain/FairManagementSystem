CREATE DATABASE FairManagementDB
GO
ALTER DATABASE [FairManagementDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FairManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FairManagementDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [FairManagementDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [FairManagementDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [FairManagementDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [FairManagementDB] SET ARITHABORT OFF
GO
ALTER DATABASE [FairManagementDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [FairManagementDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [FairManagementDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [FairManagementDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [FairManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [FairManagementDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [FairManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [FairManagementDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [FairManagementDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [FairManagementDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [FairManagementDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [FairManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [FairManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [FairManagementDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [FairManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [FairManagementDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [FairManagementDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [FairManagementDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [FairManagementDB] SET  READ_WRITE
GO
ALTER DATABASE [FairManagementDB] SET RECOVERY FULL
GO
ALTER DATABASE [FairManagementDB] SET  MULTI_USER
GO
ALTER DATABASE [FairManagementDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [FairManagementDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'FairManagementDB', N'ON'
GO
USE [FairManagementDB]
GO
/****** Object:  User [myaxo]    Script Date: 06/23/2015 11:37:38 ******/
CREATE USER [myaxo] FOR LOGIN [myaxo] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tbl_visitor]    Script Date: 06/23/2015 11:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_visitor](
	[visitorId] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[email] [varchar](50) NULL,
	[number] [varchar](15) NULL,
 CONSTRAINT [PK_tbl_visitor] PRIMARY KEY CLUSTERED 
(
	[visitorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_visitor] ON
INSERT [dbo].[tbl_visitor] ([visitorId], [name], [email], [number]) VALUES (1, N'Miraj', N'mirajhossaincse@gmail.com', N'01796606437    ')
INSERT [dbo].[tbl_visitor] ([visitorId], [name], [email], [number]) VALUES (2, N'Riaz', N'r@gmail.com', N'01786606437    ')
INSERT [dbo].[tbl_visitor] ([visitorId], [name], [email], [number]) VALUES (4, N'as', N'sd', N'345')
INSERT [dbo].[tbl_visitor] ([visitorId], [name], [email], [number]) VALUES (12, N'Miraj', N'mirajhossaincse@gmail.com', N'014556')
INSERT [dbo].[tbl_visitor] ([visitorId], [name], [email], [number]) VALUES (19, N'Emon', N'e@gmail.com', N'0167834354456')
INSERT [dbo].[tbl_visitor] ([visitorId], [name], [email], [number]) VALUES (20, N'Rana', N'r@gmail.com', N'01718793016')
SET IDENTITY_INSERT [dbo].[tbl_visitor] OFF
/****** Object:  Table [dbo].[tbl_zone]    Script Date: 06/23/2015 11:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_zone](
	[zoneId] [int] IDENTITY(1,1) NOT NULL,
	[zoneName] [varchar](200) NULL,
 CONSTRAINT [PK_tbl_zone] PRIMARY KEY CLUSTERED 
(
	[zoneId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_zone] ON
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (1, N'Enterprise Application Zone')
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (2, N'Mobile Apps Zone')
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (3, N'Game & Multimedia Zone')
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (4, N'Telecom Software Zone')
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (5, N'Digital Bangladesh Zone')
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (8, N'Exibition Zone')
INSERT [dbo].[tbl_zone] ([zoneId], [zoneName]) VALUES (9, N'Conference Zone')
SET IDENTITY_INSERT [dbo].[tbl_zone] OFF
/****** Object:  Table [dbo].[tbl_VisitorZone]    Script Date: 06/23/2015 11:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_VisitorZone](
	[visitorZoneId] [int] IDENTITY(1,1) NOT NULL,
	[zoneId] [int] NOT NULL,
	[visitorId] [int] NOT NULL,
 CONSTRAINT [PK_tbl_VisitorZone_1] PRIMARY KEY CLUSTERED 
(
	[visitorZoneId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_VisitorZone] ON
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (1, 1, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (2, 1, 2)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (3, 2, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (4, 2, 2)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (5, 3, 4)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (6, 4, 4)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (7, 1, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (8, 2, 2)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (11, 1, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (12, 2, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (13, 3, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (14, 4, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (15, 5, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (16, 8, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (17, 1, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (18, 2, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (19, 1, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (20, 2, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (21, 3, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (22, 4, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (23, 5, 1)
INSERT [dbo].[tbl_VisitorZone] ([visitorZoneId], [zoneId], [visitorId]) VALUES (24, 8, 1)
SET IDENTITY_INSERT [dbo].[tbl_VisitorZone] OFF
/****** Object:  View [dbo].[VisitZone]    Script Date: 06/23/2015 11:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VisitZone] AS
SELECT tbl_visitor.visitorId ,tbl_visitor.name AS VisitorName, tbl_visitor.email AS VisitorEmail,tbl_visitor.number AS VisitorContactNumber, tbl_zone.zoneId , tbl_zone.zoneName 
FROM tbl_visitor
INNER JOIN tbl_VisitorZone
ON tbl_visitor.visitorId=tbl_VisitorZone.VisitorId
INNER JOIN tbl_zone
ON tbl_VisitorZone.ZoneId=tbl_zone.zoneId
GO
/****** Object:  View [dbo].[VisitorZone]    Script Date: 06/23/2015 11:37:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VisitorZone]
AS
SELECT tbl_visitor.visitorId,tbl_visitor.name, tbl_visitor.email,tbl_visitor.number FROM tbl_visitor inner join tbl_VisitorZone ON tbl_visitor.visitorId= tbl_VisitorZone.visitorId INNER JOIN tbl_zone ON tbl_VisitorZone.zoneId= tbl_zone.zoneId
GO
/****** Object:  ForeignKey [FK_tbl_visitor_tbl_visitor]    Script Date: 06/23/2015 11:37:38 ******/
ALTER TABLE [dbo].[tbl_visitor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_visitor_tbl_visitor] FOREIGN KEY([visitorId])
REFERENCES [dbo].[tbl_visitor] ([visitorId])
GO
ALTER TABLE [dbo].[tbl_visitor] CHECK CONSTRAINT [FK_tbl_visitor_tbl_visitor]
GO
/****** Object:  ForeignKey [FK_tbl_zone_tbl_zone]    Script Date: 06/23/2015 11:37:38 ******/
ALTER TABLE [dbo].[tbl_zone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_zone_tbl_zone] FOREIGN KEY([zoneId])
REFERENCES [dbo].[tbl_zone] ([zoneId])
GO
ALTER TABLE [dbo].[tbl_zone] CHECK CONSTRAINT [FK_tbl_zone_tbl_zone]
GO
/****** Object:  ForeignKey [FK_tbl_VisitorZone_tbl_visitor1]    Script Date: 06/23/2015 11:37:38 ******/
ALTER TABLE [dbo].[tbl_VisitorZone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VisitorZone_tbl_visitor1] FOREIGN KEY([visitorId])
REFERENCES [dbo].[tbl_visitor] ([visitorId])
GO
ALTER TABLE [dbo].[tbl_VisitorZone] CHECK CONSTRAINT [FK_tbl_VisitorZone_tbl_visitor1]
GO
/****** Object:  ForeignKey [FK_tbl_VisitorZone_tbl_zone]    Script Date: 06/23/2015 11:37:38 ******/
ALTER TABLE [dbo].[tbl_VisitorZone]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VisitorZone_tbl_zone] FOREIGN KEY([zoneId])
REFERENCES [dbo].[tbl_zone] ([zoneId])
GO
ALTER TABLE [dbo].[tbl_VisitorZone] CHECK CONSTRAINT [FK_tbl_VisitorZone_tbl_zone]
GO
