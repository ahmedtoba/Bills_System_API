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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        // GET: api/Company
        [HttpGet]
        public ActionResult<IEnumerable<Company>> GetCompanys()
        {
            return companyRepository.GetAll();
        }

        // GET: api/Company/5
        [HttpGet("{id}")]
        public ActionResult<Company> GetCompany(int id)
        {
            var company = companyRepository.GetById(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        #region put

        // PUT: api/Company/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCompany(int id, Company company)
        //{
        //    if (id != company.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(company).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CompanyExists(id))
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

        // POST: api/Company
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Company> PostCompany(Company company)
        {
            companyRepository.Insert(company);
            return CreatedAtAction("GetCompany", new {Id = company.Id}, company);
        }


        #region Delete
        // DELETE: api/Company/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteCompany(int id)
        //{
        //    var company = await _context.Companys.FindAsync(id);
        //    if (company == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Companys.Remove(company);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
        #endregion

        private bool CompanyExists(int id)
        {
            var company = companyRepository.GetById(id);
            
            return (company == null) ? false : true;
        }
    }
}
