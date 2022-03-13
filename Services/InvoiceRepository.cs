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

        public void Insert(Invoice Invoice)
        {
            if (!db.Invoices.Any())
                Invoice.Id = 1000;
            Invoice.Id = db.Invoices.Max(c => c.Id) + 1;

            db.Invoices.Add(Invoice);
            db.SaveChanges();
        }
    }
}
