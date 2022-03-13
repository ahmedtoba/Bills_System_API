using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class UnitRepository : IUnitRepository
    {
        private readonly BillsContext db;

        public UnitRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<Unit> GetAll()
        {
            return db.Units.ToList();
        }

        public Unit GetById(int id)
        {
            return db.Units.FirstOrDefault(c => c.Id == id);
        }

        public Unit GetByName(string name)
        {
            return db.Units.FirstOrDefault(c => c.Name == name);
        }

        public void Insert(Unit unit)
        {
            db.Units.Add(unit);
            db.SaveChanges();
        }
    }
}
