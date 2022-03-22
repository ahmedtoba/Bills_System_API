using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bills_System_API.Models;
using Bills_System_API.Services;

namespace Bills_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        // GET: api/Client
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetClients()
        {
            return clientRepository.GetAll();
        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public ActionResult<Client> GetClient(int id)
        {
            var client = clientRepository.GetById(id);

            if (client == null)
                return NotFound();
            return client;
        }

        #region put

        // PUT: api/Client/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutClient(int id, Client client)
        //{
        //    if (id != client.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(client).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ClientExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        #endregion

        // POST: api/Client
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Client> PostClient(Client client)
        {
            clientRepository.Insert(client);
            return CreatedAtAction("GetClient", new {Id = client.Id}, client);
        }
    }
}
