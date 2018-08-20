--HRM���ݿⰲװ�ű�

--�ж����ݿ��Ƿ����
use master
go
if exists(select * from sysdatabases where name='HRM')
drop database HRM
go

--�������ݿ�
use master
go

create database HRM
go

use HRM
go


--����

--����Ա�û���
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


--���ű�
create table Department
(
DepID int PRIMARY KEY IDENTITY(10000,1),
DepName nvarchar(50) NOT NULL
)
go


--��λ��
create table Job
(
JID int PRIMARY KEY IDENTITY(10000,1),
JName nvarchar(50) NOT NULL,
DepID int references Department(DepID)
)
go


--��Ա��Ϣ��
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


--��Ƹ�ƻ���
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


--���ڱ�
create table Work
(
WID int IDENTITY(10000,1) NOT NULL,
PID int references Person(PID) NOT NULL,
WTime datetime NOT NULL,
WState nvarchar(20) NOT NULL
)
go


--��ٱ�
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


--��Ա���۱�
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


--��ͬ�� 
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

--��ѵ�γ̱�
create table Lesson
(
LeID int primary key identity(10000,1),
LeName nvarchar(50),
LeType nvarchar(20),
LeText text
)
go


--��ѵ�ƻ���
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


--��ѵ��¼��
create table TPNotes
(
NID int PRIMARY KEY IDENTITY(10000,1) NOT NULL,
PID int references Person(PID) NOT NULL,
TPID int references TrainPlan(TPID) NOT NULL,
NResult nvarchar(20) NOT NULL,
NTexts nvarchar(500) NOT NULL
)
go


--���ʱ�
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


--���ͱ�
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

--���ʹ�÷�����
create table FindBug
(
FBID int primary key identity(10000,1),
FBTitle nvarchar(100) not null,
FBType nvarchar(20) not null,
FBCall nvarchar(50) ,
FBText ntext not null
)
go

--ϵͳ��Ϣ��
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


--���ʱ�
create table Goods
(
GID int primary key IDENTITY(10000,1) NOT NULL, 
GName nvarchar(100) ,
GCount int,
GPrice money
)
go

--������ȡ��¼��
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

--��ְ��¼��
create table Resignation
(
RID int primary key IDENTITY(10000,1) NOT NULL, 
PID int NOT NULL references Person(PID),
RText text,
RTime datetime,
RState nvarchar(20)
)
go





--�����������


--ϵͳ�û���
INSERT INTO Users  VALUES ( N'admin',N'50966256@qq.com', N'123456', N'��', 20, N'1', N'����', CAST(0x0000A77500C2B488 AS DateTime))


--���ű�
INSERT INTO Department  VALUES ( N'���²�')
INSERT INTO Department  VALUES ( N'������')
INSERT INTO Department  VALUES ( N'���۲�')
INSERT INTO Department  VALUES ( N'����')


--��λ��
INSERT INTO Job  VALUES ( N'��ļ', 10000)
INSERT INTO Job  VALUES ( N'����ܹ�ʦ', 10001)
INSERT INTO Job  VALUES ( N'���۾���', 10002)
INSERT INTO Job  VALUES ( N'����', 10003)
INSERT INTO Job  VALUES ( N'н��', 10000)
INSERT INTO Job  VALUES ( N'����', 10000)
INSERT INTO Job  VALUES ( N'��ѵ', 10000)
INSERT INTO Job  VALUES ( N'��ͬ', 10000)
INSERT INTO Job  VALUES ( N'ǰ�˹���ʦ', 10001)
INSERT INTO Job  VALUES ( N'���ݿ����', 10001)
INSERT INTO Job  VALUES ( N'��˿���', 10001)
INSERT INTO Job  VALUES ( N'����Ա', 10002)
INSERT INTO Job  VALUES ( N'��������', 10002)
INSERT INTO Job  VALUES ( N'���', 10003)
INSERT INTO Job  VALUES ( N'����Ա', 10003)



--��Ա��Ϣ��
INSERT INTO Person  VALUES (N'123',N'��ʽ', N'����', N'��', N'��', 20, N'11007', N'12345678910', N'1710042052', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10000, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'��ʽ', N'����', N'��', N'��', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008AC100000000 AS DateTime), N'421125199706264617', 10000, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'��ʽ', N'����', N'��', N'��', 20, N'11007', N'12345678910', N'1196192447', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008AE800000000 AS DateTime), N'421125199706264617', 10001, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'��ʽ', N'����', N'��', N'��', 20, N'11007', N'12345678910', N'956495971', N'50966256@qq.com', CAST(0x0000A6EE00000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008AD500000000 AS DateTime), N'421125199706264617', 10001, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'�ݼ�', N'Ǯ��', N'Ů', N'������', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A70D00000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008AD800000000 AS DateTime), N'421125199706264617', 10002, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'��ʽ', N'���', N'Ů', N'����', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A6F000000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10002, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'ʵϰ', N'�ξ�', N'Ů', N'ά�����', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A74800000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10003, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'ʵϰ', N'��ʮ', N'Ů', N'�ɹ���', 20, N'11007', N'12345678910', N'50966256', N'50966256@qq.com', CAST(0x0000A76600000000 AS DateTime), N'.Net', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'ƹ������ë�򣬿���', CAST(0x00008B1500000000 AS DateTime), N'421125199706264617', 10003, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'�����', N'�ܰ�', N'��', N'��', 18, N'11007', N'18333333333', N'50966256', N'50966256@qq.com', CAST(0x0000A775009D2B28 AS DateTime), N'�����Ӧ��', N'����ְҵ����ѧԺ', N'��Ա', N'δ��', N'������', CAST(0x0000A775009D2B28 AS DateTime), N'42062519999999999', 10003, CAST(0x00008B1500000000 AS DateTime))
INSERT INTO Person  VALUES (N'123',N'�����', N'����', N'��', N'��', 19, N'11007', N'180000000000', N'50966256', N'50966256@qq.com', CAST(0x0000A77500A2CA38 AS DateTime), N'���簲ȫ', N'������ѧ', N'��Ա', N'δ��', N'���� ����', CAST(0x0000A77500A2CA38 AS DateTime), N'42000000000000000', 10002, CAST(0x00008B1500000000 AS DateTime))

--��Ƹ�ƻ���
INSERT INTO JobPlan  VALUES ( 10000, 3, N'�ܳԿ����ͣ����ӹ����м��������ؼ���', CAST(0x0000A76600000000 AS DateTime), CAST(0x0000A78500000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10001, 3, N'�ܳԿ����ͣ����ӹ����м��������ؼ���', CAST(0x0000A78500000000 AS DateTime), CAST(0x0000A7A300000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10002, 3, N'�ܳԿ����ͣ����ӹ����м��������ؼ���', CAST(0x0000A7A300000000 AS DateTime), CAST(0x0000A7C200000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10003, 3, N'�ܳԿ����ͣ����ӹ����м��������ؼ���', CAST(0x0000A7C200000000 AS DateTime), CAST(0x0000A7E100000000 AS DateTime), N'admin', N'12345678910')
INSERT INTO JobPlan  VALUES ( 10001, 3, N'�ܳԿ����ͣ����ӹ����м��������ؼ���', CAST(0x0000A7E100000000 AS DateTime), CAST(0x0000A7FF00000000 AS DateTime), N'admin', N'12345678910')


--���ڱ�
INSERT INTO Work  VALUES ( 10000, CAST(0x0000A73800B62F74 AS DateTime), N'�ٵ�')
INSERT INTO Work  VALUES ( 10001, CAST(0x0000A73800B63B2C AS DateTime), N'�ٵ�')
INSERT INTO Work  VALUES ( 10003, CAST(0x0000A73800B65BFC AS DateTime), N'�ٵ�')
INSERT INTO Work  VALUES ( 10001, CAST(0x0000A77500B6A4A4 AS DateTime), N'�ٵ�')
INSERT INTO Work  VALUES ( 10002, CAST(0x0000A77500B6AA80 AS DateTime), N'�ٵ�')
INSERT INTO Work  VALUES ( 10003, CAST(0x0000A77500B6B764 AS DateTime), N'�ٵ�')
INSERT INTO Work  VALUES ( 10000, CAST(0x0000A77500C43AC4 AS DateTime), N'�ٵ�')


--��ٱ�
INSERT INTO Leave  VALUES ( 10000, N'�ؼ�', CAST(0x0000A76A00000000 AS DateTime), CAST(0x0000A76D00000000 AS DateTime), N'��ʮ', N'�����')
INSERT INTO Leave  VALUES ( 10001, N'����', CAST(0x0000A78900000000 AS DateTime), CAST(0x0000A78C00000000 AS DateTime), N'��ʮ', N'ͨ��')
INSERT INTO Leave  VALUES ( 10002, N'����', CAST(0x0000A7A700000000 AS DateTime), CAST(0x0000A7AA00000000 AS DateTime), N'��ʮ', N'����')
INSERT INTO Leave  VALUES ( 10003, N'���', CAST(0x0000A7C600000000 AS DateTime), CAST(0x0000A7C900000000 AS DateTime), N'��ʮ', N'ͨ��')
INSERT INTO Leave  VALUES ( 10004, N'��С��', CAST(0x0000A7E500000000 AS DateTime), CAST(0x0000A7E800000000 AS DateTime), N'��ʮ', N'�����')
INSERT INTO Leave  VALUES ( 10002, N'������', CAST(0x0000A77000000000 AS DateTime), CAST(0x0000A774008F442C AS DateTime), N'admin', N'ͨ��')


--��Ա���۱�
INSERT INTO Appraise  VALUES ( 10000, CAST(0x0000A78800000000 AS DateTime), N'admin', N'���˻���������������Թ�����м�ǿ��������һ���ѵõ��˲�',N'ֱ���쵼', N'����')
INSERT INTO Appraise  VALUES ( 10001, CAST(0x0000A7A600000000 AS DateTime), N'admin', N'���˻���������������Թ�����м�ǿ��������һ���ѵõ��˲�',N'ֱ���쵼', N'����')
INSERT INTO Appraise  VALUES ( 10002, CAST(0x0000A7C500000000 AS DateTime), N'��ʮһ', N'���˻���������������Թ�����м�ǿ��������һ���ѵõ��˲�',N'ֱ���쵼', N'һ��')
INSERT INTO Appraise  VALUES ( 10003, CAST(0x0000A7E400000000 AS DateTime), N'��ʮһ', N'���˻���������������Թ�����м�ǿ��������һ���ѵõ��˲�',N'ֱ���쵼', N'����')
INSERT INTO Appraise  VALUES ( 10004, CAST(0x0000A80200000000 AS DateTime), N'��ʮһ', N'���˻���������������Թ�����м�ǿ��������һ���ѵõ��˲�',N'ֱ���쵼', N'��')


--�Ͷ���ͬ��
INSERT INTO AgreeMent  VALUES ( 10000, CAST(0x0000A76600000000 AS DateTime), CAST(0x0000A8D300000000 AS DateTime), N'�Ͷ���ͬ', 5000.0000, N'����Ч')
INSERT INTO AgreeMent  VALUES ( 10001, CAST(0x0000A76A00000000 AS DateTime), CAST(0x0000A8D700000000 AS DateTime), N'�Ͷ���ͬ', 5000.0000, N'����Ч')
INSERT INTO AgreeMent  VALUES ( 10002, CAST(0x0000A76B00000000 AS DateTime), CAST(0x0000A8D800000000 AS DateTime), N'�Ͷ���ͬ', 5000.0000, N'����Ч')
INSERT INTO AgreeMent  VALUES ( 10003, CAST(0x0000A76C00000000 AS DateTime), CAST(0x0000A8D900000000 AS DateTime), N'�Ͷ���ͬ', 5000.0000, N'����Ч')
INSERT INTO AgreeMent  VALUES ( 10004, CAST(0x0000A76D00000000 AS DateTime), CAST(0x0000A8DA00000000 AS DateTime), N'�Ͷ���ͬ', 4000.0000, N'����Ч')
INSERT INTO AgreeMent  VALUES ( 10005, CAST(0x0000A76600000000 AS DateTime), CAST(0x0000A8D300000000 AS DateTime), N'�Ͷ���ͬ', 5000.0000, N'����Ч')

--��ѵ�γ̱�
INSERT INTO Lesson  VALUES ( N'���������', N'ȫ�¿γ�', N'�����ǿγ̼��1111')
INSERT INTO Lesson  VALUES ( N'HTML��ҳ���', N'ȫ�¿γ�', N'�����ǿγ̼��222')
INSERT INTO Lesson  VALUES ( N'����PS', N'ǿ���γ�', N'�����ǿγ̼��333')
INSERT INTO Lesson  VALUES ( N'Java��̻���', N'����γ�', N'�����ǿγ̼��444')
INSERT INTO Lesson  VALUES ( N'SQL Server���ݿ�', N'ȫ�¿γ�', N'�����ǿγ̼��555')
INSERT INTO Lesson  VALUES ( N'��ҳ����е�PS', N'ǿ���γ�', N'ͨ��ѧϰ���ջ�����PS���ɣ���߽�����Ƶ����ۡ�')


--��ѵ�ƻ���
INSERT INTO TrainPlan  VALUES ( 10000, N'����', N'2-1301', 5, CAST(0x0000A76B00000000 AS DateTime), CAST(0x0000A77200000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10001, N'����', N'2-1302', 5, CAST(0x0000A76C00000000 AS DateTime), CAST(0x0000A77300000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10002, N'����', N'2-1303', 5, CAST(0x0000A76D00000000 AS DateTime), CAST(0x0000A77400000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10003, N'����', N'2-1304', 5, CAST(0x0000A76E00000000 AS DateTime), CAST(0x0000A77500000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10004, N'Ǯ��', N'2-1305', 5, CAST(0x0000A76F00000000 AS DateTime), CAST(0x0000A77600000000 AS DateTime))
INSERT INTO TrainPlan  VALUES ( 10005, N'����', N'ͼ�����¥', 25, CAST(0x0000A73800A74900 AS DateTime), CAST(0x0000A73800A74900 AS DateTime))


--��ѵ��¼��
INSERT INTO TPNotes  VALUES ( 10000, 10000, N'����', N'��������')
INSERT INTO TPNotes  VALUES ( 10000, 10000, N'����', N'���ֺ�')
INSERT INTO TPNotes  VALUES ( 10000, 10000, N'һ��', N'�ߺ�')

--Ա�����������
INSERT INTO Express  VALUES ( 10000, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A73800B62F74 AS DateTime), N'�ն��Զ�����')
INSERT INTO Express  VALUES ( 10001, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A73800B63B2C AS DateTime), N'�ն��Զ�����')
INSERT INTO Express  VALUES ( 10003, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A73800B65BFC AS DateTime), N'�ն��Զ�����')
INSERT INTO Express  VALUES ( 10001, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A77500B6A4A4 AS DateTime), N'�ն��Զ�����')
INSERT INTO Express  VALUES ( 10002, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A77500B6AA80 AS DateTime), N'�ն��Զ�����')
INSERT INTO Express  VALUES ( 10003, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A77500B6B764 AS DateTime), N'�ն��Զ�����')
INSERT INTO Express  VALUES ( 10000, N'����', 240.0000, N'�ϰ�ٵ�����', CAST(0x0000A77500C43AC4 AS DateTime), N'�ն��Զ�����')


--���ʱ�
USE [HRM]
GO
SET IDENTITY_INSERT [dbo].[Goods] ON 

INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10000, N'0.5mm��ɫǩ�ֱ�', 500, 2.0000)
INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10001, N'��װA4��ӡֽ', 100, 15.0000)
INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10002, N'С�űʼǱ�', 500, 5.0000)
INSERT [dbo].[Goods] ([GID], [GName], [GCount], [GPrice]) VALUES (10003, N'�ļ���', 100, 3.0000)
SET IDENTITY_INSERT [dbo].[Goods] OFF

--5.6���ʱ�
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



