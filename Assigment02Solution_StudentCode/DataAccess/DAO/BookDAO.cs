using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
     public class BookDAO
    {

        public IEnumerable<Book> GetAllBooks()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Books.ToList();
            }
        }

        public Book GetBookById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Books.FirstOrDefault(b => b.Bookid == id);
            }
        }

        public void AddBook(Book book)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void UpdateBook(Book book)
        {
            using (var context = new ApplicationDbContext())
            {
                var existingBook = GetBookById(book.Bookid);
                if (existingBook != null)
                {
                    context.Books.Update(book);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteBook(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var bookToDelete = GetBookById(id);
                if (bookToDelete != null)
                {
                    context.Books.Remove(bookToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
