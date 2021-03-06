USE [studentsDB]
GO
/****** Object:  Table [dbo].[eval_items]    Script Date: 31-3-2015 12:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[eval_items](
	[eval_item_ID] [varchar](10) NOT NULL,
	[eval_descrip] [varchar](35) NOT NULL,
 CONSTRAINT [pk_eval_items_id] PRIMARY KEY CLUSTERED 
(
	[eval_item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[eval_items_scores]    Script Date: 31-3-2015 12:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[eval_items_scores](
	[eval_score_ID] [int] IDENTITY(1000,1) NOT NULL,
	[eval_ID] [int] NOT NULL,
	[eval_item_ID] [varchar](10) NOT NULL,
	[score] [int] NOT NULL,
 CONSTRAINT [pk_eval_item_score] PRIMARY KEY CLUSTERED 
(
	[eval_score_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[evaluations]    Script Date: 31-3-2015 12:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[evaluations](
	[eval_ID] [int] NOT NULL,
	[evaluatorID] [varchar](10) NOT NULL,
	[evaluateeID] [varchar](10) NOT NULL,
	[evalsemester] [varchar](10) NULL,
	[evalyear] [int] NULL,
 CONSTRAINT [pk_eval] PRIMARY KEY CLUSTERED 
(
	[eval_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[students]    Script Date: 31-3-2015 12:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[students](
	[stdid] [varchar](10) NOT NULL,
	[stdfname] [varchar](12) NOT NULL,
	[stdlname] [varchar](13) NOT NULL,
	[stdmajor] [varchar](6) NULL,
	[std_teamID] [varchar](8) NULL,
 CONSTRAINT [pk_stdid] PRIMARY KEY CLUSTERED 
(
	[stdid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teams]    Script Date: 31-3-2015 12:40:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teams](
	[teamid] [varchar](8) NOT NULL,
	[team_name] [varchar](30) NOT NULL,
	[project] [varchar](45) NULL,
 CONSTRAINT [pk_teamid] PRIMARY KEY CLUSTERED 
(
	[teamid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[eval_items] ([eval_item_ID], [eval_descrip]) VALUES (N'CONTRIBUTE', N'Quality and amount of work done.')
INSERT [dbo].[eval_items] ([eval_item_ID], [eval_descrip]) VALUES (N'INTERPERS', N'Works well with others.')
INSERT [dbo].[eval_items] ([eval_item_ID], [eval_descrip]) VALUES (N'RELIABLE', N'Reliably meets deadlines.')
SET IDENTITY_INSERT [dbo].[eval_items_scores] ON 

INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1000, 200, N'RELIABLE', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1001, 200, N'CONTRIBUTE', 75)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1002, 200, N'INTERPERS', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1003, 201, N'RELIABLE', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1004, 201, N'CONTRIBUTE', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1005, 201, N'INTERPERS', 100)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1006, 202, N'RELIABLE', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1007, 202, N'CONTRIBUTE', 88)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1008, 202, N'INTERPERS', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1009, 203, N'RELIABLE', 100)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1010, 203, N'CONTRIBUTE', 100)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1011, 203, N'INTERPERS', 100)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1012, 205, N'RELIABLE', 88)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1013, 205, N'CONTRIBUTE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1014, 205, N'INTERPERS', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1015, 206, N'RELIABLE', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1016, 206, N'CONTRIBUTE', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1017, 206, N'INTERPERS', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1018, 207, N'RELIABLE', 92)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1019, 207, N'CONTRIBUTE', 98)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1020, 207, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1021, 210, N'RELIABLE', 75)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1022, 210, N'CONTRIBUTE', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1023, 210, N'INTERPERS', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1024, 211, N'RELIABLE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1025, 211, N'CONTRIBUTE', 92)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1026, 211, N'INTERPERS', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1027, 212, N'RELIABLE', 75)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1028, 212, N'CONTRIBUTE', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1029, 212, N'INTERPERS', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1030, 215, N'RELIABLE', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1031, 215, N'CONTRIBUTE', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1032, 215, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1033, 216, N'RELIABLE', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1034, 216, N'CONTRIBUTE', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1035, 216, N'INTERPERS', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1036, 218, N'RELIABLE', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1037, 218, N'CONTRIBUTE', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1038, 218, N'INTERPERS', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1039, 219, N'RELIABLE', 98)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1040, 219, N'CONTRIBUTE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1041, 219, N'INTERPERS', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1042, 220, N'RELIABLE', 100)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1043, 220, N'CONTRIBUTE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1044, 220, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1045, 224, N'RELIABLE', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1046, 224, N'CONTRIBUTE', 66)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1047, 224, N'INTERPERS', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1048, 225, N'RELIABLE', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1049, 225, N'CONTRIBUTE', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1050, 225, N'INTERPERS', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1051, 226, N'RELIABLE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1052, 226, N'CONTRIBUTE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1053, 226, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1054, 227, N'RELIABLE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1055, 227, N'CONTRIBUTE', 92)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1056, 227, N'INTERPERS', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1057, 228, N'RELIABLE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1058, 228, N'CONTRIBUTE', 98)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1059, 228, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1060, 230, N'RELIABLE', 78)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1061, 230, N'CONTRIBUTE', 70)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1062, 230, N'INTERPERS', 75)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1063, 232, N'RELIABLE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1064, 232, N'CONTRIBUTE', 95)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1065, 232, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1066, 233, N'RELIABLE', 75)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1067, 233, N'CONTRIBUTE', 80)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1068, 233, N'INTERPERS', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1069, 235, N'RELIABLE', 85)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1070, 235, N'CONTRIBUTE', 90)
INSERT [dbo].[eval_items_scores] ([eval_score_ID], [eval_ID], [eval_item_ID], [score]) VALUES (1071, 235, N'INTERPERS', 95)
SET IDENTITY_INSERT [dbo].[eval_items_scores] OFF
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (200, N'tdouglas', N'cmoya', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (201, N'tdouglas', N'wcronan', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (202, N'bkry', N'lkomp', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (203, N'bkry', N'sdavis', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (205, N'calvarez', N'bsmith', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (206, N'calvarez', N'doliver', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (207, N'wcronan', N'tdouglas', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (210, N'wcronan', N'cmoya', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (211, N'bsmith', N'doliver', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (212, N'doliver', N'calvarez', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (215, N'bsmith', N'calvarez', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (216, N'lkomp', N'bkry', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (218, N'lkomp', N'sdavis', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (219, N'akry', N'kalt', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (220, N'kalt', N'akry', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (224, N'doliver', N'bsmith', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (225, N'sdavis', N'lkomp', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (226, N'sdavis', N'bkry', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (227, N'cmoya', N'wcronan', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (228, N'cmoya', N'tdouglas', N'Fall', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (230, N'aagassi', N'bkry', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (232, N'aagassi', N'lkomp', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (233, N'aagassi', N'rfederer', N'Spring', 2009)
INSERT [dbo].[evaluations] ([eval_ID], [evaluatorID], [evaluateeID], [evalsemester], [evalyear]) VALUES (235, N'bkry', N'rfederer', N'Spring', 2009)
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'aagassi', N'ANDREW', N'aagassi', N'MKTG', N'ITPROS')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'akry', N'ADRIENNE', N'kry', N'ISYS', N'DEVELOP')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'bkry', N'BARBARA', N'kry', N'ISYS', N'ITPROS')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'bsmith', N'BOB', N'SMITH', N'ISYS', N'SYSDES')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'calvarez', N'CARLOS', N'ALVAREZ', N'ISYS', N'SYSDES')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'cmoya', N'CYNTHIA', N'moya', N'ISYS', N'TECHSO')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'csanchez', N'CARLA', N'SANCHEZ', N'ISYS', NULL)
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'doliver', N'DON', N'BAHO', N'ISYS', N'SYSDES')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'kalt', N'KENNETH', N'ALT', N'ISYS', N'DEVELOP')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'lkomp', N'LANCE', N'KOMP', N'ISYS', N'ITPROS')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'rfederer', N'RYAN', N'rfederer', N'COMPSC', N'ITPROS')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'sdavis', N'SARA', N'DAVIS', N'ISYS', N'ITPROS')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'tdouglas', N'TWYLA', N'DOUGLAS', N'ISYS', N'TECHSO')
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'troberts', N'TERRENCE', N'ROBERTS', N'ACCT', NULL)
INSERT [dbo].[students] ([stdid], [stdfname], [stdlname], [stdmajor], [std_teamID]) VALUES (N'wcronan', N'WALTER', N'CRONAN', N'ISYS', N'TECHSO')
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'DBMS', N'DBMS Associates', N'Art gallery inventory')
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'DEVELOP', N'Developers, Inc.', NULL)
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'DIGSOL', N'Digital Solutions', NULL)
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'ITPROS', N'IT Professionals', N'Project management and activity tracking')
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'SOFTCON', N'Software Consultants', N'Sales order processing for retail business')
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'SWDES', N'Southwest Designers', N'Inventory tracking for tire company')
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'SYSDES', N'System Designers', N'Work order processing for auto shop')
INSERT [dbo].[teams] ([teamid], [team_name], [project]) VALUES (N'TECHSO', N'Technology Solutions', N'Production management')
SET ANSI_PADDING ON

GO
/****** Object:  Index [uniq_team]    Script Date: 31-3-2015 12:40:47 ******/
ALTER TABLE [dbo].[teams] ADD  CONSTRAINT [uniq_team] UNIQUE NONCLUSTERED 
(
	[team_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[eval_items_scores]  WITH CHECK ADD  CONSTRAINT [fk_eval_id] FOREIGN KEY([eval_ID])
REFERENCES [dbo].[evaluations] ([eval_ID])
GO
ALTER TABLE [dbo].[eval_items_scores] CHECK CONSTRAINT [fk_eval_id]
GO
ALTER TABLE [dbo].[eval_items_scores]  WITH CHECK ADD  CONSTRAINT [fk_eval_item_id] FOREIGN KEY([eval_item_ID])
REFERENCES [dbo].[eval_items] ([eval_item_ID])
GO
ALTER TABLE [dbo].[eval_items_scores] CHECK CONSTRAINT [fk_eval_item_id]
GO
ALTER TABLE [dbo].[evaluations]  WITH CHECK ADD  CONSTRAINT [fk_evaluateeID] FOREIGN KEY([evaluateeID])
REFERENCES [dbo].[students] ([stdid])
GO
ALTER TABLE [dbo].[evaluations] CHECK CONSTRAINT [fk_evaluateeID]
GO
ALTER TABLE [dbo].[evaluations]  WITH CHECK ADD  CONSTRAINT [fk_evaluatorID] FOREIGN KEY([evaluatorID])
REFERENCES [dbo].[students] ([stdid])
GO
ALTER TABLE [dbo].[evaluations] CHECK CONSTRAINT [fk_evaluatorID]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [fk_teamid] FOREIGN KEY([std_teamID])
REFERENCES [dbo].[teams] ([teamid])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [fk_teamid]
GO
