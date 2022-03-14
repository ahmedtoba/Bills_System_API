using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class TypeRepository : ITypeRepository
    {
        private readonly BillsContext db;

        public TypeRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<Species> GetAll()
        {
            return db.Types.ToList();
        }

        public Species GetById(int id)
        {
            return db.Types.FirstOrDefault(c => c.Id == id);
        }

        public Species GetByName(string name)
        {
            return db.Types.FirstOrDefault(c => c.Name == name);
        }

        public void Insert(Species type)
        {
            db.Types.Add(type);
            db.SaveChanges();
        }
    }
}
