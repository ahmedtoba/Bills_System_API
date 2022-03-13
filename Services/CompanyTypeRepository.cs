using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class CompanyTypeRepository : ICompanyTypeRepository
    {
        private readonly BillsContext db;

        public CompanyTypeRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<CompanyType> GetAll()
        {
            return db.CompanyTypes.ToList();
        }

        public CompanyType GetById(int id)
        {
            return db.CompanyTypes.FirstOrDefault(c => c.Id == id);
        }

        public void Insert(CompanyType CompanyType)
        {
            db.CompanyTypes.Add(CompanyType);
            db.SaveChanges();
        }
    }
}
