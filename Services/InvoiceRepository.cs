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

        public void Insert(List<Invoice> Invoices)
        {
            foreach (var invoice in Invoices)
            {
                var newInvoice = new Invoice()
                {
                    Id = invoice.Id,
                    Date = invoice.Date,
                    Quantity = invoice.Quantity,
                    ClientId = invoice.ClientId,
                    Total = invoice.Total,
                    ItemId = invoice.ItemId,
                    SellingPrice = invoice.SellingPrice
                    
                };
                var item = db.Items.FirstOrDefault(i => i.Id == invoice.ItemId);
                item.RemainingQuantity -= invoice.Quantity;
                db.Invoices.Add(newInvoice);
            }
            db.SaveChanges();
        }
    }
}
