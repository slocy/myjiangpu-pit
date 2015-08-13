declare @currentArtisanId int
declare @currentBookId int

insert  into dbo.Artisan ( Name, Fullname, WechatId, CellPhone, Description, City, Address, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'茹茹萍', -- Name - nvarchar(256)
          N'陈茹萍', -- Fullname - nvarchar(256)
          N'', -- WechatId - nvarchar(512)
          N'', -- CellPhone - nvarchar(128)
          N'毕业于中央美术学院，捣腾在植物与手工之间，坚持做喜欢的事情，努力让喜欢的事情有价值。', -- Description - nvarchar(max)
          N'厦门', -- City - nvarchar(128)
          N'厦门市思明区旧物仓', -- Address - nvarchar(256)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          );

SELECT @currentArtisanId = CONVERT(int, current_value) FROM sys.sequences WHERE name = 'GLSEQ'
SELECT @currentArtisanId

insert into dbo.Book ( Title, SubTitle, Stuff, Description, ArtisanId, PrimaryImage, PrimaryVedio, Images, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'蔷薇胸花', -- Title - nvarchar(256)
          N'来自茹萍的胸针设计', -- SubTitle - nvarchar(256)
          N'干燥植物：黄蔷薇（1）、银叶菊（1）、冬菇草（3～5）、珊瑚果（2）<br/>其他工具：胸针（1）、草绳、剪刀、热熔胶枪', -- Stuff - nvarchar(max)
          N'自然风干的蔷薇和银叶菊，嵌有星星点点的冬菇草，跟着匠谱，你手中的植物就会有新的可能。如果你在夏天喜欢穿浅色裙子，那你需要这样一枚胸针。', -- Description - nvarchar(max)
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
values  ( N'步骤一', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'以银叶菊为底，挑选三五根冬菇草，具体可根据银叶菊的大小选择合适的冬菇草数量，以视觉舒适为佳。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/1.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤二', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'将挑好的冬菇草长度剪至与银叶菊等齐。整个手作过程的剪枝都尽量遵循宁长勿短原则，毕竟长了我们最后可以剪，短了很可能会要损失一枝花材。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/2.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤三', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'开始加入黄蔷薇，根据黄蔷薇的大小和银叶菊的关系，调整冬菇草的位置，避免多根配草一个高度，尽量达到高低不一错落有致的搭配效果。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/3.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤四', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'加入珊瑚果。配草的选择要注意形状与颜色在整个花束中的搭配程度。这里选择圆形灰色的珊瑚果，一是因为珊瑚果可爱的圆形可以和另一配草“冬菇草”形成呼应，二来淡雅的灰色珊瑚果有符合整个胸针的基调，不至于颜色过于鲜艳，影响黄蔷薇的主体视觉效果。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/4.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤五', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'左手拇指与食指紧握花束，无名指与中指夹住草绳一端，右手握住草绳另一端，绕花束大概三圈，每绕一圈均要用力缠紧加固再绕下一圈。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/5.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤六', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'然后在花束背面将草绳打结，可以选择蝴蝶结或其他样式的打结方式，但是考虑到花束与胸针的粘合度，建议尽量选择像“死结”这种牢固又简单的打结方式。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/6.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤七', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'找好胸针与花束的位置。建议尽量让胸针（金属部分）处于花束的中部偏上，尤其是较大的花束。防止佩戴时胸花头重脚轻左右摇晃。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/7.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤八', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'在确定好的大概胸针位置挤上热熔胶，粘上胸针，稍微按住五秒左右。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤九', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'从多个角度（主要是正面）观察胸花，将多余的草绳、花材枝干、胸针延长部分剪掉。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )
		  		  
insert into dbo.BookStep ( Name, BookId, Content, Images, Videos, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'步骤十', -- Name - nvarchar(256)
          @currentBookId, -- BookId - int
          N'黄蔷薇胸花完成。', -- Content - nvarchar(max)
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/8.jpg', -- Images - nvarchar(max)
          N'', -- Videos - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.Stuff ( Title, [Description], BookId, Price, Images, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'蔷薇胸花原材料包', -- Title - nvarchar(256)
          N'干燥植物：黄蔷薇（1）、银叶菊（1）、冬菇草（3～5）、珊瑚果（2）<br/>其他工具：胸针（1）、草绳、剪刀、热熔胶枪', -- Description - nvarchar(max)
		  @currentBookId,
          35, -- Price - money
          N'http://wx-ast.slocy.cn/image/step/adore-xiongzhen/7.jpg', -- Images - nvarchar(max)
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )

insert into dbo.Lesson ( Title, Comment, ArtisanId, BookId, ScheduleDate, Place, Price, UpdateBy, UpdateDate, CreateDate, CreateBy )
values  ( N'蔷薇胸花O2O教学', -- Title - nvarchar(256)
          N'自然风干的蔷薇和银叶菊，嵌有星星点点的冬菇草，跟着匠谱，你手中的植物就会有新的可能。如果你在夏天喜欢穿浅色裙子，那你需要这样一枚胸针。', -- Comment - nvarchar(max)
          @currentArtisanId, -- ArtisanId - int
          @currentBookId, -- BookId - int
          getDate(), -- ScheduleDate - datetime
          N'厦门市思明区旧物仓', -- Place - nvarchar(max)
          210, -- Price - money
          N'Kris', -- UpdateBy - nvarchar(128)
          getDate(), -- UpdateDate - datetime
          getDate(), -- CreateDate - datetime
          N'Kris'  -- CreateBy - nvarchar(128)
          )