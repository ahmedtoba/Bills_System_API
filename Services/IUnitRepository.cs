using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface IUnitRepository
    {
        List<Unit> GetAll();
        Unit GetById(int id);
        Unit GetByName(string name);
        void Insert(Unit Unit);
    }
}
