using Bills_System_API.Models;
using Bills_System_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bills_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalBillController : ControllerBase
    {
        private readonly ITotalBilllRepository totalBillRepository;

        public TotalBillController(ITotalBilllRepository totalBillRepository)
        {
            this.totalBillRepository = totalBillRepository;
        }
        // GET: api/<TotalBillController>
        [HttpGet]
        public IEnumerable<TotalBill> Get()
        {
            return totalBillRepository.GetAll();
        }

        // GET api/<TotalBillController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<TotalBillController>
        [HttpPost]
        public void Post([FromBody] TotalBill Bill)
        {
            totalBillRepository.Insert(Bill);
        }

        // PUT api/<TotalBillController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TotalBillController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
