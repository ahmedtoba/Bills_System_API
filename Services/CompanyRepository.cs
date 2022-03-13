using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BillsContext db;

        public CompanyRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<Company> GetAll()
        {
            return db.Companys.ToList();
        }

        public Company GetById(int id)
        {
            return db.Companys.FirstOrDefault(c => c.Id == id);
        }

        public Company GetByName(string name)
        {
            return db.Companys.FirstOrDefault(c => c.Name == name);
        }

        public void Insert(Company company)
        {
            db.Companys.Add(company);
            db.SaveChanges();
        }
    }
}
