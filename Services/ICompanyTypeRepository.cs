using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface ICompanyTypeRepository
    {
        List<CompanyType> GetAll();
        CompanyType GetById(int id);
        void Insert(CompanyType CompanyType);
    }
}
