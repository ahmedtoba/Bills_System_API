using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class ClientRepository : IClientRepository
    {
        private readonly BillsContext db;

        public ClientRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<Client> GetAll()
        {
            return db.Clients.ToList();
        }

        public Client GetById(int id)
        {
            return db.Clients.FirstOrDefault(c => c.Id == id);
        }

        public Client GetByName(string name)
        {
            return db.Clients.FirstOrDefault(c => c.Name == name);
        }

        public void Insert(Client Client)
        {
            if (!db.Clients.Any())
                Client.Id = 1000;
            Client.Id = db.Clients.Max(c => c.Id) + 1;

            db.Clients.Add(Client);
            db.SaveChanges();
        }
    }
}
