using Bills_System_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bills_System_API.Services
{
    public class TotalBillRepository:ITotalBilllRepository
    {
        private readonly BillsContext db;

        public  TotalBillRepository(BillsContext db)
        {
            this.db = db;
        }
            public List<TotalBill> GetAll()
            {
                return db.TotalBills.ToList(); 
            }  
          public void Insert(TotalBill Bill)
            {
                db.TotalBills.Add(Bill);
                db.SaveChanges();
            }
    }
}
