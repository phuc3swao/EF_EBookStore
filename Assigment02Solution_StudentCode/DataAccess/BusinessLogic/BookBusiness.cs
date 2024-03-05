using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BusinessLogic
{
    public class BookBusiness
    {
        public string Message = null;
        public bool isUpdateSuccess = true;
        public readonly BookRepository bookrepo = new BookRepository(); 
        
        public async Task<bool> UpdateBook(int id, Book book)
        {
            if(id != book.Bookid)
            {
                isUpdateSuccess= false;
                return true;
            }
            try
            {
                bookrepo.Update(book);
                return true;
            } catch(Exception ex)
            {
                Message = "Fail when update data to server";
            }

            return false;
        }
    }
}
