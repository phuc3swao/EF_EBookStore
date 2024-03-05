using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public static class AuthorDAO
    {
        public static List<Author> GetAllAuthors()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Author.ToList();
            }
        }

        public static Author GetAuthorById(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Author.FirstOrDefault(a => a.Author_Id == id);
            }
        }

        public static void AddNewAuthor(Author author)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Author.Add(author);
                dbContext.SaveChanges();
            }
        }

        public static void UpdateAuthor(Author author)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var existingAuthor = GetAuthorById(author.Author_Id);
                if (existingAuthor != null)
                {
                    dbContext.Author.Update(author);
                    dbContext.SaveChanges();
                }
            }
        }

        public static void DeleteAuthor(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var authorToDelete = GetAuthorById(id);
                if (authorToDelete != null)
                {
                    dbContext.Author.Remove(authorToDelete);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
