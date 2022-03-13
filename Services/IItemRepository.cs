using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        Item GetById(int id);
        Item GetByName(string name);
        void Insert(Item Item);
    }
}
