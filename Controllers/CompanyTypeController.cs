using Bills_System_API.Models;
using Bills_System_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bills_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTypeController : ControllerBase
    {
        #region DI
        private readonly ICompanyTypeRepository companytypeRepo;

        public CompanyTypeController(ICompanyTypeRepository companytypeRepo)
        {
            this.companytypeRepo = companytypeRepo;
        }
        #endregion

        #region GetAll CompanyType
        [HttpGet]
        public IActionResult CompanyTypes()
        {
            var companytype = companytypeRepo.GetAll();
            return Ok(companytype);
        }
        #endregion

        #region GetById
        [HttpGet("{id}")]
        public IActionResult companytype(int id)
        {
            var companytype = companytypeRepo.GetById(id);
            if(companytype == null)
                return NotFound();
            return Ok(companytype);
        }
        #endregion

        #region Insert
        [HttpPost]
        public IActionResult Insert(CompanyType companyType)
        {
            companytypeRepo.Insert(companyType);
            return CreatedAtAction("companytype", new { Id = companyType.Id }, companyType);
        }
        #endregion



    }
}
