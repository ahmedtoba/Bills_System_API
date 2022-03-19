using Bills_System_API.Models;
using Bills_System_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bills_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceRepository invoiceRepository;

        public InvoiceController(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Invoice>> GetInvoice()
        {
            return invoiceRepository.GetAll();
        }
        [HttpGet("{itemId}")]
        public ActionResult<IEnumerable<Invoice>> GetByItem(int itemId)
        {
            return invoiceRepository.GetByItemId(itemId);
        }
        [HttpPost]
        public void PostClient(List<Invoice> invoice)
        {
            invoiceRepository.Insert(invoice);
        }
    }
}
