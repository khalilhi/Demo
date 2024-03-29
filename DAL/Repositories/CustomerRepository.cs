﻿using DAL.Models;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            using (var context = new BookStoreContext())
            {
                return context.Customer.ToList();
            }
        }
        public IEnumerable<Customer> GetCustomerByID(int id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Customer.Where(book => book.CustomerId == id).ToList();
            }
        }
        public void AddCustomer(Customer book)
        {
            using (var context = new BookStoreContext())
            {
                var _book = new Customer();
                _book.FirstName = book.FirstName;
                _book.LastName = book.LastName;
                _book.Email = book.Email;
                _book.UtilisateurId = book.UtilisateurId;
                context.Customer.Add(_book);
                context.SaveChanges();

            }
        }
        public void RemoveCustomer(int id)
        {
            using (var context = new BookStoreContext())
            {
                Customer book_ = context.Customer.Where(book => book.CustomerId == id).First();
                context.Customer.Remove(book_);
                context.SaveChanges();


            }
        }
        public void UpdateCustomer(Customer book)
        {
            using (var context = new BookStoreContext())
            {
                Customer _book = context.Customer.Where(bk => bk.CustomerId == book.CustomerId).First();
                _book.FirstName = book.FirstName;
                _book.LastName = book.LastName;
                _book.Email = book.Email;
                _book.UtilisateurId = book.UtilisateurId;
                context.SaveChanges();
            }
        }
    }
}
