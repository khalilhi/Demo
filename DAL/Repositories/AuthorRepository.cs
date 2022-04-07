using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class AuthorRepository
    {
        public IEnumerable<Author> GetAllAuthors()
        {
            using (var context = new BookStoreContext())
            {
                return context.Author.ToList();
            }
        }
        public IEnumerable<Author> GetAuthorByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Author.Where(book => book.AuthorId == id).ToList();
            }
        }
        public void AddAuthor(Author book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Author();
                _book.AuthorName = book.AuthorName;
                _book.UtilisateurId = book.UtilisateurId;
                context.Author.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveAuthor(int id)
        {
            using (var context = new BookStoreContext())
            {
                Author book_ = context.Author.Where(book => book.AuthorId == id).First();
                context.Author.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateAuthor(Author book)
        {
            using (var context = new BookStoreContext())
            {
                Author _book = context.Author.Where(bk => bk.AuthorId == book.AuthorId).First();
                _book.AuthorName = book.AuthorName;
                _book.UtilisateurId = book.UtilisateurId;
                context.SaveChanges();
            }
        }
    }
}
