using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface ICompanyRepository
    {
        List<Company> GetAll();
        Company GetById(int id);
        Company GetByName(string name);
        void Insert(Company company);
    }
}
