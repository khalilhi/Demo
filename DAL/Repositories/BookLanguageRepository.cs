using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class BookLanguageRepository
    {
        public IEnumerable<BookLanguage> GetAllLanguages()
        {
            using (var context = new BookStoreContext())
            {
                return context.BookLanguage.ToList();
            }
        }
        public IEnumerable<BookLanguage> GetLanguageByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.BookLanguage.Where(book => book.LanguageId == id).ToList();
            }
        }
        public void AddLanguage(BookLanguage book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new BookLanguage();
                _book.LanguageCode = book.LanguageCode;
                _book.LanguageName = book.LanguageName;
                context.BookLanguage.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveLanguage(int id)
        {
            using (var context = new BookStoreContext())
            {
                BookLanguage book_ = context.BookLanguage.Where(book => book.LanguageId == id).First();
                context.BookLanguage.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateLanguage(BookLanguage book)
        {
            using (var context = new BookStoreContext())
            {
                BookLanguage _book = context.BookLanguage.Where(bk => bk.LanguageId == book.LanguageId).First();
                _book.LanguageCode = book.LanguageCode;
                _book.LanguageName = book.LanguageName;
                context.SaveChanges();
            }
        }
    }
}
