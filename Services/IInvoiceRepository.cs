using Bills_System_API.Models;
using System.Collections.Generic;

namespace Bills_System_API.Services
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAll();
        Invoice GetById(int id);
        List<Invoice> GetByItemId(int itemId);
        void Insert(List<Invoice> Invoice);
    }
}
