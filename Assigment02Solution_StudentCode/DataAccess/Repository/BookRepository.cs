using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class BookRepository : IBookRepository
    {
        public BookDAO BookDAO = new BookDAO();
        public async Task Add(Book book) => BookDAO.AddBook(book);

        public async Task Delete(int id) => BookDAO.DeleteBook(id);

        public async Task<IEnumerable<Book>> GetAll() => BookDAO.GetAllBooks();

        public async Task<Book> GetById(int id) => BookDAO.GetBookById(id);

        public async Task Update(Book book) => BookDAO.UpdateBook(book);
    }
}
