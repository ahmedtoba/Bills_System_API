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
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        // GET: api/Item
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return itemRepository.GetAll();
        }

        // GET: api/Item/5
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = itemRepository.GetById(id);

            if (item == null)
                return NotFound();
            return item;
        }


        #region put
        //// PUT: api/Item/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutItem(int id, Item item)
        //{
        //    if (id != item.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(item).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemExists(id))
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


        // POST: api/Item
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Item> PostItem(Item item)
        {
            itemRepository.Insert(item);
            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }


        

        #region delete
        //// DELETE: api/Item/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteItem(int id)
        //{
        //    var item = await _context.Items.FindAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Items.Remove(item);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
        #endregion

        private bool ItemExists(int id)
        {
            var item = itemRepository.GetById(id);

            return (item == null) ? false : true;
        }


    }
}
