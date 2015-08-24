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
            var sql =
                "SELECT BookId, Title, SubTitle, StuffInfo, [Description], ArtisanId, PrimaryImage, PrimaryVideo FROM dbo.Book where BookId = @0";

            var book = Ctx.Sql(sql, bookId).QuerySingle<Book>();
            book.Artisan = ArtisanPipeline._().Get(book.ArtisanId);
            book.Stuffs = StuffPipeline._().GetByBook(book.BookId);
            book.Utilities = UtilityPipeline._().GetByBook(book.BookId);
            book.Steps = GetStepsByBookId(book.BookId);

            return book;
        }

        public List<Book> GetAllBooks() {
            var books = Ctx.Sql("SELECT top 10 BookId, Title, SubTitle, StuffInfo, [Description], ArtisanId, IsHidden, PrimaryImage, PrimaryVideo, UpdateDate, CreateDate FROM dbo.Book where IsHidden = 0 order by CreateDate desc").QueryMany<Book>();

            foreach (var book in books) {
                book.Artisan = ArtisanPipeline._().Get(book.ArtisanId);
            }

            return books;
        }

        public List<Book> GetByArtisanId(int artisanId) {
            var books =
                Ctx.Sql(
                    "select BookId, Title, SubTitle, [StuffInfo], [Description], ArtisanId, PrimaryImage, PrimaryVideo from dbo.Book where ArtisanId = @0",
                    artisanId).QueryMany<Book>();

            return books;
        }

        public List<BookStep> GetStepsByBookId(int bookId) {
            var bookSteps = Ctx.Sql("SELECT BookStepId, Name, BookId, Content FROM dbo.BookStep where BookId = @0", bookId).QueryMany<BookStep>();

            return bookSteps;
        }
    }
}