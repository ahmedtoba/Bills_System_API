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

        public void Insert(Client client)
        {
            if (!db.Clients.Any())
                client.Id = 1000;
            else
            {
                client.Id = db.Clients.Max(c => c.Id) + 1;
            }
            db.Clients.Add(client);
            db.SaveChanges();
        }
    }
}
