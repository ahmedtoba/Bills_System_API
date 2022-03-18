using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly BillsContext db;

        public InvoiceRepository(BillsContext db)
        {
            this.db = db;
        }

        public List<Invoice> GetAll()
        {
            return db.Invoices.ToList();
        }

        public Invoice GetById(int id)
        {
            return db.Invoices.FirstOrDefault(c => c.Id == id);
        }

        public List<Invoice> GetByItemId(int itemId)
        {
            var invoice = db.Invoices.Where(w => w.ItemId == itemId).ToList();
            return invoice;
        }

        public void Insert(List<Invoice> Invoice)
        {
            foreach (var item in Invoice)
            {

                db.Invoices.Add(item);
            }
            db.SaveChanges();
        }
    }
}
