using Bills_System_API.Models;
using Bills_System_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace Bills_System_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitRepository UnitRepo;

        public UnitController(IUnitRepository unitRepo)
        {
            this.UnitRepo = unitRepo;

        }
        //Get All Units
        [HttpGet]
        public ActionResult<IEnumerable<Unit>> GetUnits()
        {
            return UnitRepo.GetAll();
        }


        //Get All Units by id
        [HttpGet("{id}")]
        public ActionResult<Unit> GetUnit(int id)
        {
            var Unit = UnitRepo.GetById(id);
            if (Unit == null)
                return NotFound();
            return Ok(Unit);
        }

        //Get All Units by Name
        [HttpGet("{name}")]
        public ActionResult<Unit> GetUnitByName(string name)
        {
            var Unit = UnitRepo.GetByName(name);
            if (Unit == null)
                return NotFound();
            return Ok(Unit);
        }
        //post Unit

        [HttpPost]
        public ActionResult<Unit> PostUnit(Unit Units)
        {
            UnitRepo.Insert(Units);
            return CreatedAtAction("GetUnit", new { Id = Units.Id }, Units);
        }
    }

    

}