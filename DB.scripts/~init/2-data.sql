declare @currentArtisanId int
declare @currentBookId int

insert  into dbo.Artisan ( Name, Fullname, WechatId, CellPhone, Description, City, Address, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'����Ƽ', -- Name - nvarchar(256)
          N'����Ƽ', -- Fullname - nvarchar(256)
          N'', -- WechatId - nvarchar(512)
          N'', -- CellPhone - nvarchar(128)
          N'��ҵ����������ѧԺ��������ֲ�����ֹ�֮�䣬�����ϲ�������飬Ŭ����ϲ���������м�ֵ��', -- Description - nvarchar(max)
          N'����', -- City - nvarchar(128)
          N'������˼���������', -- Address - nvarchar(256)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          );

SELECT @currentArtisanId = CONVERT(int, current_value) FROM sys.sequences WHERE name = 'GLSEQ'
SELECT @currentArtisanId

insert into dbo.Book ( Title, SubTitle, Stuff, Description, ArtisanId, PrimaryImage, PrimaryVedio, Images, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'Ǿޱ�ػ�', -- Title - nvarchar(256)
          N'������Ƽ���������', -- SubTitle - nvarchar(256)
          N'����ֲ���Ǿޱ��1������Ҷ�գ�1���������ݣ�3��5����ɺ������2��<br/>�������ߣ����루1�������������������۽�ǹ', -- Stuff - nvarchar(max)
          N'��Ȼ��ɵ�Ǿޱ����Ҷ�գ�Ƕ�����ǵ��Ķ����ݣ����Ž��ף������е�ֲ��ͻ����µĿ��ܡ������������ϲ����ǳɫȹ�ӣ�������Ҫ����һö���롣', -- Description - nvarchar(max)
          @currentArtisanId, -- ArtisanId - int
          N'http://wx-ast.slocy.cn/image/book/adore-xiongzhen/primary.jpg', -- PrimaryImage - nvarchar(max)
          N'', -- PrimaryVedio - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/book/adore-xiongzhen/1.jpg|http://wx-ast.slocy.cn/image/book/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

SELECT @currentBookId = CONVERT(int, current_value) FROM sys.sequences WHERE name = 'GLSEQ'
SELECT @currentBookId

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'����һ', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'����Ҷ��Ϊ�ף���ѡ����������ݣ�����ɸ�����Ҷ�յĴ�Сѡ����ʵĶ��������������Ӿ�����Ϊ�ѡ�', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/1.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'�����', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'�����õĶ����ݳ��ȼ�������Ҷ�յ��롣�����������̵ļ�֦��������ѭ�������ԭ�򣬱Ͼ��������������Լ������˺ܿ��ܻ�Ҫ��ʧһ֦���ġ�', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/2.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'������', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'��ʼ�����Ǿޱ�����ݻ�Ǿޱ�Ĵ�С����Ҷ�յĹ�ϵ�����������ݵ�λ�ã����������һ���߶ȣ������ﵽ�ߵͲ�һ�������µĴ���Ч����', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/3.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'������', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'����ɺ��������ݵ�ѡ��Ҫע����״����ɫ�����������еĴ���̶ȡ�����ѡ��Բ�λ�ɫ��ɺ������һ����Ϊɺ�����ɰ���Բ�ο��Ժ���һ��ݡ������ݡ��γɺ�Ӧ���������ŵĻ�ɫɺ�����з�����������Ļ�������������ɫ�������ޣ�Ӱ���Ǿޱ�������Ӿ�Ч����', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/4.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'������', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'����Ĵָ��ʳָ���ջ���������ָ����ָ��ס����һ�ˣ�������ס������һ�ˣ��ƻ��������Ȧ��ÿ��һȦ��Ҫ���������ӹ�������һȦ��', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/5.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'������', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'Ȼ���ڻ������潫������ᣬ����ѡ��������������ʽ�Ĵ�᷽ʽ�����ǿ��ǵ������������ճ�϶ȣ����龡��ѡ�������ᡱ�����ι��ּ򵥵Ĵ�᷽ʽ��', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/6.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'������', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'�Һ������뻨����λ�á����龡�������루�������֣����ڻ������в�ƫ�ϣ������ǽϴ�Ļ�������ֹ���ʱ�ػ�ͷ�ؽ�������ҡ�Ρ�', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/7.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'�����', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'��ȷ���õĴ������λ�ü������۽���ճ�����룬��΢��ס�������ҡ�', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'�����', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'�Ӷ���Ƕȣ���Ҫ�����棩�۲��ػ���������Ĳ���������֦�ɡ������ӳ����ּ�����', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'����ʮ', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'��Ǿޱ�ػ���ɡ�', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.Stuff ( Title, [Description], BookId, Price, Images, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'Ǿޱ�ػ�ԭ���ϰ�', -- Title - nvarchar(256)
          N'����ֲ���Ǿޱ��1������Ҷ�գ�1���������ݣ�3��5����ɺ������2��<br/>�������ߣ����루1�������������������۽�ǹ', -- Description - nvarchar(max)
		  @currentBookId,
          35, -- Price - money
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/7.jpg', -- Images - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.Lesson ( Title, Comment, ArtisanId, BookId, ScheduleDate, Place, Price, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'Ǿޱ�ػ�O2O��ѧ', -- Title - nvarchar(256)
          N'��Ȼ��ɵ�Ǿޱ����Ҷ�գ�Ƕ�����ǵ��Ķ����ݣ����Ž��ף������е�ֲ��ͻ����µĿ��ܡ������������ϲ����ǳɫȹ�ӣ�������Ҫ����һö���롣', -- Comment - nvarchar(max)
          @currentArtisanId, -- ArtisanId - int
          @currentBookId, -- BookId - int
          getDate(), -- ScheduleDate - datetime
          N'������˼���������', -- Place - nvarchar(max)
          210, -- Price - money
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )