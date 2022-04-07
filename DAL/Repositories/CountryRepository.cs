using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CountryRepository
    {
        public IEnumerable<Country> GetAllCountries()
        {
            using (var context = new BookStoreContext())
            {
                return context.Country.ToList();
            }
        }
        public IEnumerable<Country> GetCountryByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Country.Where(book => book.CountryId == id).ToList();
            }
        }
        public void AddCountryk(Country book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Country();
                _book.CountryName = book.CountryName;
                context.Country.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveCountry(int id)
        {
            using (var context = new BookStoreContext())
            {
                Country book_ = context.Country.Where(book => book.CountryId == id).First();
                context.Country.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateCountry(Country book)
        {
            using (var context = new BookStoreContext())
            {
                Country _book = context.Country.Where(bk => bk.CountryId == book.CountryId).First();
                _book.CountryName = book.CountryName;
                context.SaveChanges();
            }
        }
    }
}
