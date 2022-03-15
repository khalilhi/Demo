using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class UtilisateurRepository
    {
        public IEnumerable<Utilisateur> GetAllUtilisateurs()
        {
            using (var context = new BookStoreContext())
            {
                return context.Utilisateurs.ToList();
            }
        }
        public IEnumerable<Utilisateur> GetUtilisateurByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Utilisateurs.Where(book => book.Id == id).ToList();
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
                context.Utilisateurs.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveUtilisateurk(int id)
        {
            using (var context = new BookStoreContext())
            {
                Utilisateur book_ = context.Utilisateurs.Where(book => book.Id == id).First();
                context.Utilisateurs.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateUtilisateur(Utilisateur book)
        {
            using (var context = new BookStoreContext())
            {
                Utilisateur _book = context.Utilisateurs.Where(bk => bk.Id == book.Id).First();
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
    }
}
