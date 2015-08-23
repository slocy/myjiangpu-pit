using System.Collections.Generic;
using Jbook.Base;
using Jbook.Models;

namespace Jbook.Pipeline {
    public class BookPipeline : BasePipeline {
        private BookPipeline() {
        }

        public static BookPipeline _() {
            return new BookPipeline();
        }

        public Book Get(int bookId) {
            var book = Ctx.Sql("select * from book where bookid = @0", bookId).QuerySingle<Book>();

            return book;
        }

        public List<Book> GetAllBooks() {
            var books = Ctx.Sql("select * from book").QueryMany<Book>();

            return books;
        }

        public List<Book> GetByArtisanId(int artisanId) {
            var books =
                Ctx.Sql(
                    "select BookId, Title, SubTitle, [Stuff], [Description], ArtisanId, PrimaryImage, PrimaryVideo from dbo.Book where ArtisanId = @0",
                    artisanId).QueryMany<Book>();

            return books;
        }

        public List<BookStep> GetStepsByBookId(int bookId) {
            var bookSteps = Ctx.Sql("select * from BookStep where bookid = @0", bookId).QueryMany<BookStep>();

            return bookSteps;
        } 
    }
}