using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.BusinessLogic
{
    public class AuthBussiness
    {

        public async Task<User> GetUser(string mail, string pass)
        {
            var _db = new ApplicationDbContext();
            var user = await _db.Users.Where(x => x.EmailAddress.Equals(mail) && (x.Password == pass)).Include(x=>x.Role).FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> RegisterU(User user)
        {
            var _db = new ApplicationDbContext();
            var Euser = await _db.Users.Where(x => x.EmailAddress.Equals(user.EmailAddress)).FirstOrDefaultAsync();
            if(Euser != null || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.EmailAddress))
            {
                return false;
            }
            else
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return true;
            }


        }
    }
}
