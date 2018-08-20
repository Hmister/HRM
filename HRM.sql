--HRM数据库安装脚本

--判断数据库是否存在
use master
go
if exists(select * from sysdatabases where name='HRM')
drop database HRM
go

--创建数据库
use master
go

create database HRM
go

use HRM
go


--建表

--管理员用户表
create table Users
(
UserID int PRIMARY KEY IDENTITY(10000,1),
UName  nvarchar(50) NOT NULL,
UMail nvarchar(20) not null,
UPwd nvarchar(50) NOT NULL,
USex char(2) not null,
UAge int not null,
ULogo nvarchar(10) not null,
Ustate nvarchar(20),
ULTime datetime
)
go


--部门表
create table Department
(
DepID int PRIMARY KEY IDENTITY(10000,1),
DepName nvarchar(50) NOT NULL
)
go


--岗位表
create table Job
(
JID int PRIMARY KEY IDENTITY(10000,1),
JName nvarchar(50) NOT NULL,
DepID int references Department(DepID)
)
go


--人员信息表
create table Person
(
PID int PRIMARY KEY IDENTITY(10000,1) NOT NULL,
PPass nvarchar(20) not null,
PState nvarchar(20) NOT NULL,
PName  nvarchar (50) NOT NULL,
PSex char(2) NOT NULL,
PEthnic nvarchar(20) NOT NULL,
PAges int NOT NULL,
PPic nvarchar(20) NOT NULL,
PPhone nvarchar (20) NOT NULL,
PQQ nvarchar (20) NOT NULL,
PMail nvarchar(20) NOT NULL,
PInTime datetime NOT NULL,
PSubject nvarchar(50) NOT NULL,
PSchool nvarchar(50) NOT NULL,
PFaction nvarchar(20) NOT NULL,
PMarry nvarchar(20) NOT NULL,
PInteresting nvarchar(100) NOT NULL,
PBirthday datetime NOT NULL,
PCardID nvarchar(30) NOT NULL,
JID int references Job(JID)NOT NULL,
PLTime datetime not null,
)
go


--招聘计划表
create table JobPlan
(
JPID int IDENTITY(1000,1) NOT NULL,
JID int references Job(JID)NOT NULL,
JPCount int NOT NULL,
JPNeed text NOT NULL,
JPStart datetime NOT NULL,
JPStop datetime NOT NULL,
JPCall nvarchar(20) NOT NULL,
JPPhone nvarchar(20) NOT NULL
)
go


--考勤表
create table Work
(
WID int IDENTITY(10000,1) NOT NULL,
PID int references Person(PID) NOT NULL,
WTime datetime NOT NULL,
WState nvarchar(20) NOT NULL
)
go


--请假表
create table Leave
(
LID int primary key identity(10000,1),	
PID int references 	Person(PID),  
LWhy text not null,		
LStart datetime not null,		
LStop datetime  not null,
LBoss nvarchar(20) not null,		
LState nvarchar(20) not null
)
go


--人员评价表
create table Appraise
(
AID int	 primary key identity(10000,1),	
PID int	references Person(PID),	
ATime datetime not null,		
ABoss nvarchar(20) not null,		
AText text not null,
AType nvarchar(20),
ARate nvarchar(20) not null	
)
go


--合同表 
create table  AgreeMent
(
AMID int primary key identity(10000,1),	
PID int	references Person(PID),
AMStart datetime not null,		
AMStop datetime not null,		
AMText text not null,	
AMBase money not null,	
AMState nvarchar(20) not null
)
go

--培训课程表
create table Lesson
(
LeID int primary key identity(10000,1),
LeName nvarchar(50),
LeType nvarchar(20),
LeText text
)
go


--培训计划表
create table TrainPlan
(
TPID int PRIMARY KEY IDENTITY(10000,1) NOT NULL,
LeID int references Lesson(LeID)NOT NULL,
TPTeacher nvarchar(50) NOT NULL,
TPAdr nvarchar(100) NOT NULL,
TPCount int NOT NULL,
TPStart datetime NOT NULL,
TPStop datetime NOT NULL,
)
go


--培训纪录表
create table TPNotes
(
NID int PRIMARY KEY IDENTITY(10000,1) NOT NULL,
PID int references Person(PID) NOT NULL,
TPID int references TrainPlan(TPID) NOT NULL,
NResult nvarchar(20) NOT NULL,
NTexts nvarchar(500) NOT NULL
)
go


--工资表
create table Pay
(
PayID int primary key IDENTITY(10000,1) NOT NULL,
PID int references Person(PID)NOT NULL,
PayAll money NOT NULL,
PayBase money NOT NULL,
PayAllDay int NOT NULL,
PayDay int NOT NULL,
PayAdd money NOT NULL,
PayDel money NOT NULL,
PayIn money NOT NULL,
PayTime datetime NOT NULL
)
go


--奖惩表
create table Express
(
EID int primary key IDENTITY(10000,1) NOT NULL,
PID int NOT NULL references Person(PID),
EType nvarchar(20) NOT NULL,
EMoney money NOT NULL,
EWhy text NOT NULL,
ETime datetime NOT NULL,
EBoss nvarchar(20) NOT NULL
)
go

--软件使用反馈表
create table FindBug
(
FBID int primary key identity(10000,1),
FBTitle nvarchar(100) not null,
FBType nvarchar(20) not null,
FBCall nvarchar(50) ,
FBText ntext not null
)
go

--系统消息表
create table Message
(
MID int primary key IDENTITY(10000,1) NOT NULL,
MSend int  NOT NULL references Users(UserID),
MText text not null,
MTime datetime,
MState nvarchar(20),
PID int NOT NULL references Person(PID)
)
go


--物资表
create table Goods
(
GID int primary key IDENTITY(10000,1) NOT NULL, 
GName nvarchar(100) ,
GCount int,
GPrice money
)
go

--物资领取记录表
create table GoodsCode
(
GCID int primary key IDENTITY(10000,1) NOT NULL, 
PID int NOT NULL references Person(PID),
GID int NOT NULL references Goods(GID),
GCCount int not null,
GCTime datetime not null,
GCState nvarchar(20)
)
go

--辞职记录表
create table Resignation
(
RID int primary key IDENTITY(10000,1) NOT NULL, 
PID int NOT NULL references Person(PID),
RText text,
RTime datetime,
RState nvarchar(20)
)
go





--插入测试数据


--系统用户表
INSERT INTO Users  VALUES ( N'admin',N'50966256@qq.com', N'123456', N'男', 20, N'1', N'启用', CAST(0x0000A77500C2B488 AS DateTime))


--部门表
INSERT INTO Department  VALUES ( N'人事部')
INSERT INTO Department  VALUES ( N'开发部')
INSERT INTO Department  VALUES ( N'销售部')
INSERT INTO Department  VALUES ( N'财务部')


--岗位表
INSERT INTO Job  VALUES ( N'招募', 10000)
INSERT INTO Job  VALUES ( N'软件架构师', 10001)
INSERT INTO Job  VALUES ( N'销售经理', 10002)
INSERT INTO Job  VALUES ( N'出纳', 10003)
INSERT INTO Job  VALUES ( N'薪酬', 10000)
INSERT INTO Job  VALUES ( N'考勤', 10000)
INSERT INTO Job  VALUES ( N'培训', 10000)
INSERT INTO Job  VALUES ( N'合同', 10000)
INSERT INTO Job  VALUES ( N'前端工程师', 10001)
INSERT INTO Job  VALUES ( N'数据库管理', 10001)
INSERT INTO Job  VALUES ( N'后端开发', 10001)
INSERT INTO Job  VALUES ( N'销售员', 10002)
INSERT INTO Job  VALUES ( N'销售主管', 10002)
INSERT INTO Job  VALUES ( N'会计', 10003)
INSERT INTO Job  VALUES ( N'核算员', 10003)



--人员信息表
INSERT INTO Person  VALUES (N'123',N'正式', N'张三', N'男', N'汉', 20, N'11007', N'12345678910', N'1710042052', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10000, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'正式', N'李四', N'男', N'汉', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008AC100000000 AS DateTime), N'421125199706264617', 10000, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'正式', N'王五', N'男', N'汉', 20, N'11007', N'12345678910', N'1196192447', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008AE800000000 AS DateTime), N'421125199706264617', 10001, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'正式', N'赵六', N'男', N'汉', 20, N'11007', N'12345678910', N'956495971', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008AD500000000 AS DateTime), N'421125199706264617', 10001, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'休假', N'钱七', N'女', N'土家族', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A70D00000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008AD800000000 AS DateTime), N'421125199706264617', 10002, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'正式', N'余八', N'女', N'苗族', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A6F000000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10002, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'实习', N'宋酒', N'女', N'维吾尔族', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A74800000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10003, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'实习', N'周十', N'女', N'蒙古族', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A76600000000 AS DateTime), N'.Net', N'荆州职业技术学院', N'团员', N'未婚', N'乒乓球，羽毛球，看书', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10003, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'待审核', N'周八', N'男', N'汉', 18, N'11007', N'18333333333', N'50966256', N'50966256@qq.com', CAST(0x0000A775009D2B28 AS DateTime), N'计算机应用', N'荆州职业技术学院', N'团员', N'未婚', N'打篮球', CAST(0x0000A775009D2B28 AS DateTime), N'42062519999999999', 10003, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'待审核', N'久离', N'男', N'汉', 19, N'11007', N'180000000000', N'50966256', N'50966256@qq.com', CAST(0x0000A77500A2CA38 AS DateTime), N'网络安全', N'长江大学', N'团员', N'未婚', N'看书 骑行', CAST(0x0000A77500A2CA38 AS DateTime), N'42000000000000000', 10002, CAST(0x00008B1500000000 AS DateTime))

--招聘计划表
INSERT INTO JobPlan  VALUES ( 10000, 3, N'能吃苦耐劳，服从管理，有集体观念，遵守纪律', CAST(0x0000A76600000000 AS DateTime), CAST(0x0000A78500000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10001, 3, N'能吃苦耐劳，服从管理，有集体观念，遵守纪律', CAST(0x0000A78500000000 AS DateTime), CAST(0x0000A7A300000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10002, 3, N'能吃苦耐劳，服从管理，有集体观念，遵守纪律', CAST(0x0000A7A300000000 AS DateTime), CAST(0x0000A7C200000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10003, 3, N'能吃苦耐劳，服从管理，有集体观念，遵守纪律', CAST(0x0000A7C200000000 AS DateTime), CAST(0x0000A7E100000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10001, 3, N'能吃苦耐劳，服从管理，有集体观念，遵守纪律', CAST(0x0000A7E100000000 AS DateTime), CAST(0x0000A7FF00000000 AS DateTime), N'admin', N'12345678910')


--考勤表
INSERT INTO Work  VALUES ( 10000, CAST(0x0000A73800B62F74 AS DateTime), N'迟到')
INSERT INTO Work  VALUES ( 10001, CAST(0x0000A73800B63B2C AS DateTime), N'迟到')
INSERT INTO Work  VALUES ( 10003, CAST(0x0000A73800B65BFC AS DateTime), N'迟到')
INSERT INTO Work  VALUES ( 10001, CAST(0x0000A77500B6A4A4 AS DateTime), N'迟到')
INSERT INTO Work  VALUES ( 10002, CAST(0x0000A77500B6AA80 AS DateTime), N'迟到')
INSERT INTO Work  VALUES ( 10003, CAST(0x0000A77500B6B764 AS DateTime), N'迟到')
INSERT INTO Work  VALUES ( 10000, CAST(0x0000A77500C43AC4 AS DateTime), N'迟到')


--请假表
INSERT INTO Leave  VALUES ( 10000, N'回家', CAST(0x0000A76A00000000 AS DateTime), CAST(0x0000A76D00000000 AS DateTime), N'周十', N'待审核')
INSERT INTO Leave  VALUES ( 10001, N'开会', CAST(0x0000A78900000000 AS DateTime), CAST(0x0000A78C00000000 AS DateTime), N'周十', N'通过')
INSERT INTO Leave  VALUES ( 10002, N'生病', CAST(0x0000A7A700000000 AS DateTime), CAST(0x0000A7AA00000000 AS DateTime), N'周十', N'驳回')
INSERT INTO Leave  VALUES ( 10003, N'结婚', CAST(0x0000A7C600000000 AS DateTime), CAST(0x0000A7C900000000 AS DateTime), N'周十', N'通过')
INSERT INTO Leave  VALUES ( 10004, N'生小孩', CAST(0x0000A7E500000000 AS DateTime), CAST(0x0000A7E800000000 AS DateTime), N'周十', N'待审核')
INSERT INTO Leave  VALUES ( 10002, N'搞事情', CAST(0x0000A77000000000 AS DateTime), CAST(0x0000A774008F442C AS DateTime), N'admin', N'通过')


--人员评价表
INSERT INTO Appraise  VALUES ( 10000, CAST(0x0000A78800000000 AS DateTime), N'admin', N'此人积极工作，任劳任怨，具有极强集体观念，是一个难得的人才',N'直属领导', N'优秀')
INSERT INTO Appraise  VALUES ( 10001, CAST(0x0000A7A600000000 AS DateTime), N'admin', N'此人积极工作，任劳任怨，具有极强集体观念，是一个难得的人才',N'直属领导', N'良好')
INSERT INTO Appraise  VALUES ( 10002, CAST(0x0000A7C500000000 AS DateTime), N'萧十一', N'此人积极工作，任劳任怨，具有极强集体观念，是一个难得的人才',N'直属领导', N'一般')
INSERT INTO Appraise  VALUES ( 10003, CAST(0x0000A7E400000000 AS DateTime), N'萧十一', N'此人积极工作，任劳任怨，具有极强集体观念，是一个难得的人才',N'直属领导', N'良好')
INSERT INTO Appraise  VALUES ( 10004, CAST(0x0000A80200000000 AS DateTime), N'萧十一', N'此人积极工作，任劳任怨，具有极强集体观念，是一个难得的人才',N'直属领导', N'差')


--劳动合同表
INSERT INTO AgreeMent  VALUES ( 10000, CAST(0x0000A76600000000 AS DateTime), CAST(0x0000A8D300000000 AS DateTime), N'劳动合同', 5000.0000, N'已生效')
INSERT INTO AgreeMent  VALUES ( 10001, CAST(0x0000A76A00000000 AS DateTime), CAST(0x0000A8D700000000 AS DateTime), N'劳动合同', 5000.0000, N'已生效')
INSERT INTO AgreeMent  VALUES ( 10002, CAST(0x0000A76B00000000 AS DateTime), CAST(0x0000A8D800000000 AS DateTime), N'劳动合同', 5000.0000, N'已生效')
INSERT INTO AgreeMent  VALUES ( 10003, CAST(0x0000A76C00000000 AS DateTime), CAST(0x0000A8D900000000 AS DateTime), N'劳动合同', 5000.0000, N'已生效')
INSERT INTO AgreeMent  VALUES ( 10004, CAST(0x0000A76D00000000 AS DateTime), CAST(0x0000A8DA00000000 AS DateTime), N'劳动合同', 4000.0000, N'已生效')
INSERT INTO AgreeMent  VALUES ( 10005, CAST(0x0000A76600000000 AS DateTime), CAST(0x0000A8D300000000 AS DateTime), N'劳动合同', 5000.0000, N'已生效')

--培训课程表
INSERT INTO Lesson  VALUES ( N'计算机基础', N'全新课程', N'这里是课程简介1111')
INSERT INTO Lesson  VALUES ( N'HTML网页设计', N'全新课程', N'这里是课程简介222')
INSERT INTO Lesson  VALUES ( N'美工PS', N'强化课程', N'这里是课程简介333')
INSERT INTO Lesson  VALUES ( N'Java编程基础', N'补充课程', N'这里是课程简介444')
INSERT INTO Lesson  VALUES ( N'SQL Server数据库', N'全新课程', N'这里是课程简介555')
INSERT INTO Lesson  VALUES ( N'网页设计中的PS', N'强化课程', N'通过学习掌握基本的PS技巧，提高界面设计的美观。')


--培训计划表
INSERT INTO TrainPlan  VALUES ( 10000, N'张三', N'2-1301', 5, CAST(0x0000A76B00000000 AS DateTime), CAST(0x0000A77200000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10001, N'李四', N'2-1302', 5, CAST(0x0000A76C00000000 AS DateTime), CAST(0x0000A77300000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10002, N'王五', N'2-1303', 5, CAST(0x0000A76D00000000 AS DateTime), CAST(0x0000A77400000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10003, N'赵六', N'2-1304', 5, CAST(0x0000A76E00000000 AS DateTime), CAST(0x0000A77500000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10004, N'钱七', N'2-1305', 5, CAST(0x0000A76F00000000 AS DateTime), CAST(0x0000A77600000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10005, N'张三', N'图书馆六楼', 25, CAST(0x0000A73800A74900 AS DateTime), CAST(0x0000A73800A74900 AS DateTime))


--培训记录表
INSERT INTO TPNotes  VALUES ( 10000, 10000, N'良好', N'暂无评价')
INSERT INTO TPNotes  VALUES ( 10000, 10000, N'优秀', N'表现好')
INSERT INTO TPNotes  VALUES ( 10000, 10000, N'一般', N'哼好')

--员工奖惩详情表
INSERT INTO Express  VALUES ( 10000, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A73800B62F74 AS DateTime), N'终端自动处罚')
INSERT INTO Express  VALUES ( 10001, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A73800B63B2C AS DateTime), N'终端自动处罚')
INSERT INTO Express  VALUES ( 10003, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A73800B65BFC AS DateTime), N'终端自动处罚')
INSERT INTO Express  VALUES ( 10001, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A77500B6A4A4 AS DateTime), N'终端自动处罚')
INSERT INTO Express  VALUES ( 10002, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A77500B6AA80 AS DateTime), N'终端自动处罚')
INSERT INTO Express  VALUES ( 10003, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A77500B6B764 AS DateTime), N'终端自动处罚')
INSERT INTO Express  VALUES ( 10000, N'处罚', 240.0000, N'上班迟到处罚', CAST(0x0000A77500C43AC4 AS DateTime), N'终端自动处罚')


--物资表
USE [HRM]
GO
SET IDENTITY_INSERT [dbo].[Goods] ON 

INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10000, N'0.5mm黑色签字笔', 500, 2.0000)
INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10001, N'盒装A4打印纸', 100, 15.0000)
INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10002, N'小号笔记本', 500, 5.0000)
INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10003, N'文件夹', 100, 3.0000)
SET IDENTITY_INSERT [dbo].[Goods] OFF

--5.6月资表
USE [HRM]
GO
SET IDENTITY_INSERT [dbo].[Pay] ON 

INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10000, 10000, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A77400000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10001, 10001, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A77400000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10002, 10002, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A77400000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10003, 10003, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A77400000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10004, 10005, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A77400000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10005, 10000, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A79300000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10006, 10001, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A79300000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10007, 10002, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A79300000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10008, 10003, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A79300000000 AS DateTime))
INSERT [dbo].[Pay] ([PayID], [PID], [PayAll], [PayBase], [PayAllDay], [PayDay], [PayAdd], [PayDel], [PayIn], [PayTime]) VALUES (10009, 10005, 0.0000, 5000.0000, 28, 0, 0.0000, 0.0000, 0.0000, CAST(0x0000A79300000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Pay] OFF



