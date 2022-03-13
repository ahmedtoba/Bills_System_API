using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int id);
        Client GetByName(string name);
        void Insert(Client Client);
    }
}
