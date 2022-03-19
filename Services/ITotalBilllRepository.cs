using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface ITotalBilllRepository
    {
        public List<TotalBill> GetAll();
        public void Insert(TotalBill Bill);

    }
}