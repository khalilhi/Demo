using DAL.DBContext;
using Models;

namespace DAL.Repositories
{
    public class CountryRepository
    {
        public IEnumerable<Country> GetAllCountries()
        {
            using (var context = new BookStoreContext())
            {
                return context.Countries.ToList();
            }
        }
        public IEnumerable<Country> GetCountryByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Countries.Where(book => book.CountryId == id).ToList();
            }
        }
        public void AddCountryk(Country book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Country();
                _book.CountryName = book.CountryName;
                context.Countries.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveCountry(int id)
        {
            using (var context = new BookStoreContext())
            {
                Country book_ = context.Countries.Where(book => book.CountryId == id).First();
                context.Countries.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateCountry(Country book)
        {
            using (var context = new BookStoreContext())
            {
                Country _book = context.Countries.Where(bk => bk.CountryId == book.CountryId).First();
                _book.CountryName = book.CountryName;
                context.SaveChanges();
            }
        }
    }
}
