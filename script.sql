USE [pocketdoctordb]
GO
/****** Object:  Table [dbo].[tbl_Appointment]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Appointment](
	[appt_id] [int] IDENTITY(1,1) NOT NULL,
	[dr_id] [nvarchar](15) NOT NULL,
	[p_id] [nvarchar](20) NOT NULL,
	[visiting_date] [date] NOT NULL,
 CONSTRAINT [PK_tbl_Appointment] PRIMARY KEY CLUSTERED 
(
	[appt_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Doctor]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Doctor](
	[info_id] [int] IDENTITY(1,1) NOT NULL,
	[dr_catagory] [nvarchar](50) NOT NULL,
	[dr_id] [nvarchar](15) NOT NULL,
	[earnings] [float] NULL,
	[edu_background] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Doctor] PRIMARY KEY CLUSTERED 
(
	[info_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Medicine]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Medicine](
	[med_id] [int] IDENTITY(901,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_tbl_Medicine] PRIMARY KEY CLUSTERED 
(
	[med_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Patient]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Patient](
	[p_id] [nvarchar](20) NOT NULL,
	[name] [nvarchar](30) NOT NULL,
	[age] [int] NOT NULL,
	[gender] [nvarchar](6) NOT NULL,
	[mobilenumber] [nvarchar](15) NOT NULL,
	[bloodgroup] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_Patient] PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_PatientHistory]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_PatientHistory](
	[hist_id] [int] IDENTITY(10001,1) NOT NULL,
	[p_id] [nvarchar](20) NULL,
	[prescription] [varbinary](max) NULL,
	[p_filename] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_PatientHistory] PRIMARY KEY CLUSTERED 
(
	[hist_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Report]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Report](
	[rep_id] [int] IDENTITY(101,1) NOT NULL,
	[t_id] [int] NULL,
	[p_id] [nvarchar](20) NULL,
	[issue_date] [date] NULL,
	[due_date] [date] NULL,
	[report] [varbinary](max) NULL,
	[rep_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Report] PRIMARY KEY CLUSTERED 
(
	[rep_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Test]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Test](
	[t_id] [int] IDENTITY(1001,1) NOT NULL,
	[tname] [nvarchar](50) NOT NULL,
	[cost] [float] NULL,
 CONSTRAINT [PK_tbl_Test] PRIMARY KEY CLUSTERED 
(
	[t_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 5/18/2020 4:27:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[userid] [nvarchar](15) NOT NULL,
	[username] [nvarchar](30) NOT NULL,
	[mobilenumber] [nvarchar](15) NOT NULL,
	[password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_User_1] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbl_Appointment]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Appointment_tbl_Patient] FOREIGN KEY([p_id])
REFERENCES [dbo].[tbl_Patient] ([p_id])
GO
ALTER TABLE [dbo].[tbl_Appointment] CHECK CONSTRAINT [FK_tbl_Appointment_tbl_Patient]
GO
ALTER TABLE [dbo].[tbl_Appointment]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Appointment_tbl_User] FOREIGN KEY([dr_id])
REFERENCES [dbo].[tbl_User] ([userid])
GO
ALTER TABLE [dbo].[tbl_Appointment] CHECK CONSTRAINT [FK_tbl_Appointment_tbl_User]
GO
ALTER TABLE [dbo].[tbl_Doctor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Doctor_tbl_User] FOREIGN KEY([dr_id])
REFERENCES [dbo].[tbl_User] ([userid])
GO
ALTER TABLE [dbo].[tbl_Doctor] CHECK CONSTRAINT [FK_tbl_Doctor_tbl_User]
GO
ALTER TABLE [dbo].[tbl_PatientHistory]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PatientHistory_tbl_Patient] FOREIGN KEY([p_id])
REFERENCES [dbo].[tbl_Patient] ([p_id])
GO
ALTER TABLE [dbo].[tbl_PatientHistory] CHECK CONSTRAINT [FK_tbl_PatientHistory_tbl_Patient]
GO
ALTER TABLE [dbo].[tbl_Report]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Report_tbl_Patient] FOREIGN KEY([p_id])
REFERENCES [dbo].[tbl_Patient] ([p_id])
GO
ALTER TABLE [dbo].[tbl_Report] CHECK CONSTRAINT [FK_tbl_Report_tbl_Patient]
GO
ALTER TABLE [dbo].[tbl_Report]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Report_tbl_Tset] FOREIGN KEY([t_id])
REFERENCES [dbo].[tbl_Test] ([t_id])
GO
ALTER TABLE [dbo].[tbl_Report] CHECK CONSTRAINT [FK_tbl_Report_tbl_Tset]
GO
