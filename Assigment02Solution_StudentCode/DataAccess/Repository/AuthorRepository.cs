using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        public async Task AddNewAuthor(Author author) => AuthorDAO.AddNewAuthor(author);

        public async Task DeleteAuthor(int id) => AuthorDAO.DeleteAuthor(id);

        public async Task<List<Author>> GetAllAuthors() => AuthorDAO.GetAllAuthors();

        public async Task<Author> GetAuthorById(int id) => AuthorDAO.GetAuthorById(id);

        public async Task UpdateAuthor(Author author) => AuthorDAO.UpdateAuthor(author);
    }
}
