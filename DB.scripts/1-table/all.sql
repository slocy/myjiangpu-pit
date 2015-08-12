/*==============================================================*/
/* Table: SystemLog                                   */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'SystemLog'
						and type = 'U' ) 
	begin
		create table SystemLog ( SystemLogId int identity(1, 1) not null ,
								Title nvarchar(256) not null ,
								CustomerId int null ,
								[Message] nvarchar(max) null ,
								Url nvarchar(max) null ,
								[Level] nvarchar(128) null ,
								[Source] nvarchar(256) null ,
								InnerMessage nvarchar(max) null,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_SystemLog primary key nonclustered ( SystemLogId ) )
	end
go

/*==============================================================*/
/* Table: Customer                                   */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Customer'
						and type = 'U' ) 
	begin
		create table Customer ( CustomerId int identity(1, 1) not null ,
								WechatId nvarchar(512) null ,
								Name nvarchar(256) not null ,
								Nickname nvarchar(256) not null ,
								Gender nvarchar(16) null ,
								Email nvarchar(256) null ,
								Cellphone nvarchar(64) null ,
								Token nvarchar(max) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Customer primary key nonclustered ( CustomerId ) )
	end
go

/*==============================================================*/
/* Table:     Artisan                               */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Artisan'
						and type = 'U' ) 
	begin
		create table Artisan ( ArtisanId int identity(1, 1) not null ,
								Name nvarchar(256) not null ,
								Fullname nvarchar(256) null ,
								WechatId nvarchar(512) null ,
								CellPhone nvarchar(128) null ,
								[Description] nvarchar(max) null ,
								City nvarchar(128) null ,
								[Address] nvarchar(256) null ,
								Images nvarchar(max) null,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Artisan primary key nonclustered ( ArtisanId ) )
	end
go

/*==============================================================*/
/* Table:       Book                             */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Book'
						and type = 'U' ) 
	begin
		create table Book ( BookId int identity(1, 1) not null ,
								Title nvarchar(256) not null ,
								SubTitle nvarchar(256) null ,
								[Stuff] nvarchar(max) null ,
								[Description] nvarchar(max) null ,
								ArtisanId int null ,
								PrimaryImage nvarchar(max) null ,
								PrimaryVedio nvarchar(max) null ,
								Images nvarchar(max) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Book primary key nonclustered ( BookId ) )
	end
go

/*==============================================================*/
/* Table:   BookStep                                 */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'BookStep'
						and type = 'U' ) 
	begin
		create table BookStep ( BookStepId int identity(1, 1) not null ,
								Name nvarchar(256) not null ,
								BookId int null ,
								Content nvarchar(max) null ,
								Images nvarchar(max) null ,
								Videos nvarchar(max) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_BookStep primary key nonclustered ( BookStepId ) )
	end
go

/*==============================================================*/
/* Table:      Stuff                              */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Stuff'
						and type = 'U' ) 
	begin
		create table Stuff ( StuffId int identity(1, 1) not null ,
								Title nvarchar(256) not null ,
								[Description] nvarchar(max) null ,
								BookId int null,
								Price money null ,
								Images nvarchar(max) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Stuff primary key nonclustered ( StuffId ) )
	end
go

/*==============================================================*/
/* Table:        Utility                            */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Utility'
						and type = 'U' ) 
	begin
		create table Utility ( UtilityId int identity(1, 1) not null ,
								Name nvarchar(256) not null ,
								[Description] nvarchar(max) null ,
								Images nvarchar(max) null ,
								Price money null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Utility primary key nonclustered ( UtilityId ) )
	end
go

/*==============================================================*/
/* Table:      Lesson                              */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Lesson'
						and type = 'U' ) 
	begin
		create table Lesson ( LessonId int identity(1, 1) not null ,
								Title nvarchar(256) not null ,
								Comment nvarchar(max) null ,
								ArtisanId int null ,
								BookId int null ,
								ScheduleDate datetime null ,
								Place nvarchar(max) null ,
								Price money null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Lesson primary key nonclustered ( LessonId ) )
	end
go

/*==============================================================*/
/* Table:           LessonCustomer                         */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'LessonCustomer'
						and type = 'U' ) 
	begin
		create table LessonCustomer ( LessonCustomerId int identity(1, 1) not null ,
								LessonId int null ,
								CustomerId int null ,
								Quantity int null ,
								Summary money null ,
								Comment nvarchar(max) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_LessonCustomer primary key nonclustered ( LessonCustomerId ) )
	end
go

/*==============================================================*/
/* Table:      Order                              */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Order'
						and type = 'U' ) 
	begin
		create table [Order] ( OrderId int identity(1, 1) not null ,
								[Type] nvarchar(128) null ,
								Quantity int null ,
								Summary money null ,
								PaymentId int null ,
								CustomerId int null ,
								LessonId int null ,
								UtilityId int null ,
								StuffId int null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Order primary key nonclustered ( OrderId ) )
	end
go

/*==============================================================*/
/* Table:     Payment                               */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Payment'
						and type = 'U' ) 
	begin
		create table Payment ( PaymentId int identity(1, 1) not null ,
								Summary money null ,
								IsPaid bit null ,
								[Transaction] nvarchar(max) null ,
								Method nvarchar(128) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Payment primary key nonclustered ( PaymentId ) )
	end
go

/*==============================================================*/
/* Table:      Configuration                              */
/*==============================================================*/
if not exists ( select	1
				from	sys.sysobjects
				where	NAME = 'Configuration'
						and type = 'U' ) 
	begin
		create table Configuration ( ConfigurationId int identity(1, 1) not null ,
								KeyName nvarchar(max) not null ,
								Value nvarchar(max) null ,
								UpdateBy nvarchar(128) not null ,
								UpdateDate datetime not null ,
								CreateDate datetime not null ,
								CreateBy nvarchar(128) not null ,
								constraint PK_Configuration primary key nonclustered ( ConfigurationId ) )
	end
go