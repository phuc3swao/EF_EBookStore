using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IPublisherRepository
    {
        Task Add(Publisher publisher);
        Task<IEnumerable<Publisher>> GetAll();
        Task<Publisher> GetById(int id);
        Task Update(Publisher publisher);
        Task Delete(int id);
    }
}
