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
    public class TypeController : ControllerBase
    {
        private readonly ITypeRepository typeRepository;

        public TypeController(ITypeRepository typeRepository)
        {
            this.typeRepository = typeRepository;
        }

        // GET: api/Type
        [HttpGet]
        public ActionResult<IEnumerable<Species>> GetTypes()
        {
            return typeRepository.GetAll();
        }

        // GET: api/Type/5
        [HttpGet("{id}")]
        public ActionResult<Species> GetType(int id)
        {
            var type = typeRepository.GetById(id);

            if (type == null)
                return NotFound();
            return type;
        }

        #region put

        // PUT: api/Type/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutType(int id, Type type)
        //{
        //    if (id != type.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(type).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TypeExists(id))
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

        // POST: api/Type
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Type> PostType(Species type)
        {
            typeRepository.Insert(type);
            return CreatedAtAction("GetType", new {Id = type.Id}, type);
        }


        #region Delete
        // DELETE: api/Type/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteType(int id)
        //{
        //    var company = await _context.types.FindAsync(id);
        //    if (type == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Types.Remove(type);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
        #endregion

        private bool TypeExists(int id)
        {
            var type = typeRepository.GetById(id);
            
            return (type == null) ? false : true;
        }
    }
}
