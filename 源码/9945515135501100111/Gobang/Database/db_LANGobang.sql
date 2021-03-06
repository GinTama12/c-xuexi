USE [master]
GO
/****** Object:  Database [db_LANGobang]    Script Date: 2016/7/4 11:33:27 ******/
CREATE DATABASE [db_LANGobang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_LANGobang_Data', FILENAME = N'D:\db_LANGobang.MDF')
 LOG ON 
( NAME = N'db_LANGobang_Log', FILENAME = N'D:\db_LANGobang_Log.LDF')
GO

USE [db_LANGobang]
GO

CREATE TABLE [dbo].[tb_Gobang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IP] [varchar](20) NULL,
	[Port] [varchar](10) NULL,
	[UserName] [varchar](50) NULL,
	[PassWord] [varchar](50) NULL,
	[Fraction] [int] NULL CONSTRAINT [DF_tb_Gobang_Fraction]  DEFAULT (2000),
	[State] [int] NULL CONSTRAINT [DF_tb_Gobang_State]  DEFAULT (0),
	[Borough] [int] NULL CONSTRAINT [DF_tb_Gobang_Area]  DEFAULT (0),
	[RoomMark] [int] NULL CONSTRAINT [DF_tb_Gobang_Apartment]  DEFAULT (0),
	[DeskMark] [varchar](20) NULL CONSTRAINT [DF_tb_Gobang_DeskMark]  DEFAULT (0),
	[SeatMark] [varchar](20) NULL CONSTRAINT [DF_tb_Gobang_SeatMark]  DEFAULT (0),
	[UserCaption] [varchar](20) NULL CONSTRAINT [DF_tb_Gobang_UserCaption]  DEFAULT (0),
	[Caput] [int] NULL CONSTRAINT [DF_tb_Gobang_Caput]  DEFAULT (0),
	[Sex] [int] NULL CONSTRAINT [DF_tb_Gobang_Sex]  DEFAULT (0),
 CONSTRAINT [PK_tb_Gobang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET IDENTITY_INSERT [dbo].[tb_Gobang] ON 

INSERT [dbo].[tb_Gobang] ([ID], [IP], [Port], [UserName], [PassWord], [Fraction], [State], [Borough], [RoomMark], [DeskMark], [SeatMark], [UserCaption], [Caput], [Sex]) VALUES (64, N'192.168.1.5', N'11025', N'明日科技', N'811129x', 2000, 30, 0, 0, N'0', N'0', N'label1_2', 3, 0)
SET IDENTITY_INSERT [dbo].[tb_Gobang] OFF

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IP地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'IP'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'端口号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'Port'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'PassWord'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'Fraction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户当前状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'区号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'Borough'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'房间号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'RoomMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'桌号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'DeskMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'坐位号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'SeatMark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户坐位名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'UserCaption'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'Caput'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tb_Gobang', @level2type=N'COLUMN',@level2name=N'Sex'
GO
