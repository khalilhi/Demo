using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class BookRepository
    {
        public IEnumerable<BookDto> GetAllBooks()
        {
            using (var context = new BookStoreContext())
            {


                var bookResponse = context.Book.Include(x => x.BookAuthor)
                                      .Include(x => x.Language)
                                      .Include(x => x.Publisher)
                                      .Take(20)
                                      .Select(bk => new BookDto()
                                      {
                                          BookId = bk.BookId,
                                          Title = bk.Title,
                                          Isbn13 = bk.Isbn13,
                                          NumPages = bk.NumPages,
                                          LanguageId = bk.LanguageId,
                                          LanguageCode = bk.Language == null ? string.Empty : bk.Language.LanguageCode,
                                          Authors = bk.BookAuthor.Select(ba=> ba.Author).Select(auth=> new AuthorDto()
                                                    {
                                                        AuthorId = auth.AuthorId,
                                                        AuthorName = auth.AuthorName
                                                    }).ToList(),
                                          //Authors = GetAuthorsListByListIds(bk.BookAuthor),
                                          PublisherId = bk.PublisherId,
                                          PublisherName = bk.Publisher == null ? string.Empty : bk.Publisher.PublisherName,
                                          PublicationDate = bk.PublicationDate

                                      }).ToList();
                return bookResponse;
            }
        }

        private List<AuthorDto> GetAuthorsListByListIds(ICollection<BookAuthor> bookAuthor)
        {
            List<AuthorDto> res = new List<AuthorDto>();
            return res;
            //foreach()
            //using (var context = new BookStoreContext())
            //{
            //    var authorIdList = bookAuthor.Select(ba => ba.AuthorId);
            //    var authorsList = context.Author.Where(auth => authorIdList.Contains(auth.AuthorId))
            //        .Select (auth => new AuthorDto()
            //        {
            //            AuthorId = auth.AuthorId,
            //            AuthorName = auth.AuthorName
            //        })
            //        .ToList();
            //    return authorsList;
            //}
        }

        public IEnumerable<BookDto> GetBookByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Book.Where(book => book.BookId == id)
                   .Select(x => new BookDto
                   {
                       BookId = x.BookId,
                       Title = x.Title,
                       NumPages = x.NumPages,
                       PublicationDate = x.PublicationDate,
                       PublisherId = x.PublisherId,
                       //Authors = SetAuthorDtoProprties(x.auth)
                   }
                    ).ToList();
            }
        }
        public void AddBook(BookDto book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Book();
                _book.Title = book.Title;
                _book.Isbn13 = book.Isbn13;
                _book.LanguageId = book.LanguageId;
                _book.NumPages = book.NumPages;
                _book.PublicationDate = book.PublicationDate;
                _book.PublisherId = book.PublisherId;
                context.Book.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveBook(int id)
        {
            using (var context = new BookStoreContext())
            {
                Book book_ = context.Book.Where(book => book.BookId == id).First();
                context.Book.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateBook(BookDto book)
        {
            using (var context = new BookStoreContext())
            {
                Book _book = context.Book.Where(bk => bk.BookId == book.BookId).First();
                _book.Title = book.Title;
                _book.Isbn13 = book.Isbn13;
                _book.LanguageId = book.LanguageId;
                _book.NumPages = book.NumPages;
                _book.PublicationDate = book.PublicationDate;
                _book.PublisherId = book.PublisherId;
                context.SaveChanges();
            }
        }


    }
}
