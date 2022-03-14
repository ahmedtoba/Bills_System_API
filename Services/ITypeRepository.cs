using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface ITypeRepository
    {
        List<Species> GetAll();
        Species GetById(int id);
        Species GetByName(string name);
        void Insert(Species Type);
    }
}
