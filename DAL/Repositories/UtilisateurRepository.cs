using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.LoginModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UtilisateurRepository
    {
        public IEnumerable<Utilisateur> GetAllUtilisateurs()
        {
            using (var context = new BookStoreContext())
            {
                return context.Utilisateur.ToList();
            }
        }
        public IEnumerable<Utilisateur> GetUtilisateurByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Utilisateur.Where(book => book.Id == id).ToList();
            }
        }
        public void AddUtilisateur(Utilisateur book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Utilisateur();
                _book.FirstName = book.FirstName;
                _book.LastName = book.LastName;
                _book.Tel = book.Tel;
                _book.Email = book.Email;
                _book.MotPasse = book.MotPasse;
                _book.IsRealPerson = book.IsRealPerson;
                _book.IsHidden = book.IsHidden;
                _book.CanBeDeleted = book.CanBeDeleted;
                _book.Annuler = book.Annuler;
                context.Utilisateur.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveUtilisateurk(int id)
        {
            using (var context = new BookStoreContext())
            {
                Utilisateur book_ = context.Utilisateur.Where(book => book.Id == id).First();
                context.Utilisateur.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateUtilisateur(Utilisateur book)
        {
            using (var context = new BookStoreContext())
            {
                Utilisateur _book = context.Utilisateur.Where(bk => bk.Id == book.Id).First();
                _book.FirstName = book.FirstName;
                _book.LastName = book.LastName;
                _book.Tel = book.Tel;
                _book.Email = book.Email;
                _book.MotPasse = book.MotPasse;
                _book.IsRealPerson = book.IsRealPerson;
                _book.IsHidden = book.IsHidden;
                _book.CanBeDeleted = book.CanBeDeleted;
                _book.Annuler = book.Annuler;
                context.SaveChanges();
            }
        }

        public async Task<UtilisateurDto> GetUtilisateurByIname(string firstname)
        {
            using (var context = new BookStoreContext())
            {
                var result =  await context.Utilisateur.Where(user => user.FirstName == firstname 
               )
                    .Select (u=> new UtilisateurDto
                    {
                        Id = u.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Tel = u.Tel,
                        Email = u.Email,
                        IsRealPerson = u.IsRealPerson,
                        IsHidden = u.IsHidden,
                        CanBeDeleted = u.CanBeDeleted, 
                        Annuler = u.Annuler

                    }
                    )   
                    .FirstOrDefaultAsync();

                return result;
            }
        }

        public async Task<UtilisateurDto> GetUtilisateurByIname(RequestUserAuth requestedItem)
        {
            using (var context = new BookStoreContext())
            {
                var result =  await context.Utilisateur.Where(user => user.FirstName == requestedItem.FirstName 
                && user.MotPasse ==requestedItem.Password )
                    .Select (u=> new UtilisateurDto
                    {
                        Id = u.Id,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Tel = u.Tel,
                        Email = u.Email,
                        IsRealPerson = u.IsRealPerson,
                        IsHidden = u.IsHidden,
                        CanBeDeleted = u.CanBeDeleted, 
                        Annuler = u.Annuler

                    }
                    )   
                    .FirstOrDefaultAsync();

                return result;
            }
        }
    }
}
