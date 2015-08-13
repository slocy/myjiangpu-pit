create sequence dbo.GLSEQ
as INT

minValue 1
no maxValue
start with 1

go

/*==============================================================*/
/* Table: SystemLog                                   */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'SystemLog'
                        and type = 'U' )
    begin
        create table SystemLog ( SystemLogId int DEFAULT (NEXT value for dbo.GLSEQ) not null ,
                                 Title nVarchar(256) not null ,
                                 CustomerId int null ,
                                 [Message] nVarchar(max) null ,
                                 Url nVarchar(max) null ,
                                 [Level] nVarchar(128) null ,
                                 [Source] nVarchar(256) null ,
                                 InnerMessage nVarchar(max) null ,
                                 UpdateBy nVarchar(128) not null ,
                                 UpdateDate dateTime not null ,
                                 CreateDate dateTime not null ,
                                 CreateBy nVarchar(128) not null ,
                                 constraint PK_SystemLog primary key nonClustered ( SystemLogId ) )
    end
go

/*==============================================================*/
/* Table: Customer                                   */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Customer'
                        and type = 'U' )
    begin
        create table Customer ( CustomerId int DEFAULT (NEXT value for dbo.GLSEQ)
                                               not null ,
                                WechatId nVarchar(512) null ,
                                Name nVarchar(256) not null ,
                                Nickname nVarchar(256) not null ,
                                Gender nVarchar(16) null ,
                                Email nVarchar(256) null ,
                                Cellphone nVarchar(64) null ,
                                Token nVarchar(max) null ,
                                UpdateBy nVarchar(128) not null ,
                                UpdateDate dateTime not null ,
                                CreateDate dateTime not null ,
                                CreateBy nVarchar(128) not null ,
                                constraint PK_Customer primary key nonClustered ( CustomerId ) )
    end
go

/*==============================================================*/
/* Table:     Artisan                               */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Artisan'
                        and type = 'U' )
    begin
        create table Artisan ( ArtisanId int DEFAULT (NEXT value for dbo.GLSEQ)
                                             not null ,
                               Name nVarchar(256) not null ,
                               Fullname nVarchar(256) null ,
                               WechatId nVarchar(512) null ,
                               CellPhone nVarchar(128) null ,
                               [Description] nVarchar(max) null ,
                               City nVarchar(128) null ,
                               [Address] nVarchar(256) null ,
                               Images nVarchar(max) null ,
                               UpdateBy nVarchar(128) not null ,
                               UpdateDate dateTime not null ,
                               CreateDate dateTime not null ,
                               CreateBy nVarchar(128) not null ,
                               constraint PK_Artisan primary key nonClustered ( ArtisanId ) )
    end
go

/*==============================================================*/
/* Table:       Book                             */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Book'
                        and type = 'U' )
    begin
        create table Book ( BookId int DEFAULT (NEXT value for dbo.GLSEQ)
                                       not null ,
                            Title nVarchar(256) not null ,
                            SubTitle nVarchar(256) null ,
                            [Stuff] nVarchar(max) null ,
                            [Description] nVarchar(max) null ,
                            ArtisanId int null ,
                            PrimaryImage nVarchar(max) null ,
                            PrimaryVedio nVarchar(max) null ,
                            Images nVarchar(max) null ,
                            UpdateBy nVarchar(128) not null ,
                            UpdateDate dateTime not null ,
                            CreateDate dateTime not null ,
                            CreateBy nVarchar(128) not null ,
                            constraint PK_Book primary key nonClustered ( BookId ) )
    end
go

/*==============================================================*/
/* Table:   BookStep                                 */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'BookStep'
                        and type = 'U' )
    begin
        create table BookStep ( BookStepId int DEFAULT (NEXT value for dbo.GLSEQ)
                                               not null ,
                                Name nVarchar(256) not null ,
                                BookId int null ,
                                Content nVarchar(max) null ,
                                Images nVarchar(max) null ,
                                Videos nVarchar(max) null ,
                                UpdateBy nVarchar(128) not null ,
                                UpdateDate dateTime not null ,
                                CreateDate dateTime not null ,
                                CreateBy nVarchar(128) not null ,
                                constraint PK_BookStep primary key nonClustered ( BookStepId ) )
    end
go

/*==============================================================*/
/* Table:      Stuff                              */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Stuff'
                        and type = 'U' )
    begin
        create table Stuff ( StuffId int DEFAULT (NEXT value for dbo.GLSEQ)
                                         not null ,
                             Title nVarchar(256) not null ,
                             [Description] nVarchar(max) null ,
                             BookId int null ,
                             Price money null ,
                             Images nVarchar(max) null ,
                             UpdateBy nVarchar(128) not null ,
                             UpdateDate dateTime not null ,
                             CreateDate dateTime not null ,
                             CreateBy nVarchar(128) not null ,
                             constraint PK_Stuff primary key nonClustered ( StuffId ) )
    end
go

/*==============================================================*/
/* Table:        Utility                                */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Utility'
                        and type = 'U' )
    begin
        create table Utility ( UtilityId int DEFAULT (NEXT value for dbo.GLSEQ)
                                             not null ,
                               Name nVarchar(256) not null ,
                               [Description] nVarchar(max) null ,
                               Images nVarchar(max) null ,
                               Price money null ,
                               UpdateBy nVarchar(128) not null ,
                               UpdateDate dateTime not null ,
                               CreateDate dateTime not null ,
                               CreateBy nVarchar(128) not null ,
                               constraint PK_Utility primary key nonClustered ( UtilityId ) )
    end
go

/*==============================================================*/
/* Table:      Lesson                              */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Lesson'
                        and type = 'U' )
    begin
        create table Lesson ( LessonId int DEFAULT (NEXT value for dbo.GLSEQ)
                                           not null ,
                              Title nVarchar(256) not null ,
                              Comment nVarchar(max) null ,
                              ArtisanId int null ,
                              BookId int null ,
                              ScheduleDate dateTime null ,
                              Place nVarchar(max) null ,
                              Price money null ,
                              UpdateBy nVarchar(128) not null ,
                              UpdateDate dateTime not null ,
                              CreateDate dateTime not null ,
                              CreateBy nVarchar(128) not null ,
                              constraint PK_Lesson primary key nonClustered ( LessonId ) )
    end
go

/*==============================================================*/
/* Table:           LessonCustomer                         */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'LessonCustomer'
                        and type = 'U' )
    begin
        create table LessonCustomer ( LessonCustomerId int DEFAULT (NEXT value for dbo.GLSEQ)
                                                           not null ,
                                      LessonId int null ,
                                      CustomerId int null ,
                                      Quantity int null ,
                                      Summary money null ,
                                      Comment nVarchar(max) null ,
                                      UpdateBy nVarchar(128) not null ,
                                      UpdateDate dateTime not null ,
                                      CreateDate dateTime not null ,
                                      CreateBy nVarchar(128) not null ,
                                      constraint PK_LessonCustomer primary key nonClustered ( LessonCustomerId ) )
    end
go

/*==============================================================*/
/* Table:      Order                              */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Order'
                        and type = 'U' )
    begin
        create table [Order] ( OrderId int DEFAULT (NEXT value for dbo.GLSEQ)
                                           not null ,
                               [Type] nVarchar(128) null ,
                               Quantity int null ,
                               Summary money null ,
                               PaymentId int null ,
                               CustomerId int null ,
                               LessonId int null ,
                               UtilityId int null ,
                               StuffId int null ,
                               UpdateBy nVarchar(128) not null ,
                               UpdateDate dateTime not null ,
                               CreateDate dateTime not null ,
                               CreateBy nVarchar(128) not null ,
                               constraint PK_Order primary key nonClustered ( OrderId ) )
    end
go

/*==============================================================*/
/* Table:     Payment                               */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Payment'
                        and type = 'U' )
    begin
        create table Payment ( PaymentId int DEFAULT (NEXT value for dbo.GLSEQ)
                                             not null ,
                               Summary money null ,
                               IsPaid bit null ,
                               [Transaction] nVarchar(max) null ,
                               Method nVarchar(128) null ,
                               UpdateBy nVarchar(128) not null ,
                               UpdateDate dateTime not null ,
                               CreateDate dateTime not null ,
                               CreateBy nVarchar(128) not null ,
                               constraint PK_Payment primary key nonClustered ( PaymentId ) )
    end
go

/*==============================================================*/
/* Table:      Configuration                              */
/*==============================================================*/
if not exists ( select  1
                from    sys.sysobjects
                where   name = 'Configuration'
                        and type = 'U' )
    begin
        create table Configuration ( ConfigurationId int DEFAULT (NEXT value for dbo.GLSEQ)
                                                         not null ,
                                     KeyName nVarchar(max) not null ,
                                     Value nVarchar(max) null ,
                                     UpdateBy nVarchar(128) not null ,
                                     UpdateDate dateTime not null ,
                                     CreateDate dateTime not null ,
                                     CreateBy nVarchar(128) not null ,
                                     constraint PK_Configuration primary key nonClustered ( ConfigurationId ) )
    end
go