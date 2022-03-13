using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class ItemRepository : IItemRepository
    {
        private readonly BillsContext db;

        public ItemRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<Item> GetAll()
        {
            return db.Items.ToList();
        }

        public Item GetById(int id)
        {
            return db.Items.FirstOrDefault(c => c.Id == id);
        }

        public Item GetByName(string name)
        {
            return db.Items.FirstOrDefault(c => c.Name == name);
        }

        public void Insert(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
        }
    }
}
