using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IAuthorRepository
    {
        Task<List<Author>> GetAllAuthors();
        Task<Author> GetAuthorById(int id);
        Task AddNewAuthor(Author author);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(int id);
    }
}
