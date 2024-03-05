using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        public PublisherDAO PublisherDAO =  new PublisherDAO();
        public async Task Add(Publisher publisher) => PublisherDAO.AddPublisher(publisher);

        public async Task Delete(int id) => PublisherDAO.DeletePublisher(id);

        public async Task<IEnumerable<Publisher>> GetAll() => PublisherDAO.GetAllPublishers();

        public async Task<Publisher> GetById(int id) => PublisherDAO.GetPublisherById(id);

        public async Task Update(Publisher publisher) => PublisherDAO.UpdatePublisher(publisher);
    }
}
