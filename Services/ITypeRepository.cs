using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface ITypeRepository
    {
        List<Type> GetAll();
        Type GetById(int id);
        Type GetByName(string name);
        void Insert(Type Type);
    }
}
