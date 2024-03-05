using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class PublisherDAO 
    {
        public void AddPublisher(Publisher publisher)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Publisher.Add(publisher);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Publisher.ToList();
            }
        }

        public Publisher GetPublisherById(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext.Publisher.FirstOrDefault(p => p.Pub_id == id);
            }
        }

        public void UpdatePublisher(Publisher publisher)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var existingPublisher = GetPublisherById(publisher.Pub_id);
                if (existingPublisher != null)
                {
                    dbContext.Publisher.Update(publisher);
                    dbContext.SaveChanges();
                }
            }
        }

        public void DeletePublisher(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var publisherToDelete = dbContext.Publisher.Find(id);
                if (publisherToDelete != null)
                {
                    dbContext.Publisher.Remove(publisherToDelete);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
