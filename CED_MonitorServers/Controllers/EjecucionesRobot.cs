using System.Collections.Generic;
using System.Linq;
using CEDBCN_MonitorIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace CEDBCN_MonitorIT.Controllers
{
    [Route("api/v1/[controller]")]
    public class EjecucionesRobotController : Controller
    {
        private readonly MonitorRobotsDbContext _context;

        public EjecucionesRobotController(MonitorRobotsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Ejecucion_Robot> Get()
        {
            return _context.EjecucionRobot.ToList();

        }

        //Search by ID
        [HttpGet("{id:int}")]
        public IActionResult GetEjecionesById(int id)
        {

            var ejecucion = this._context.EjecucionRobot.SingleOrDefault(ct => ct.ID_Ejecucion == id);
            if (ejecucion != null)
            {
                return Ok(ejecucion);
            }
            else
            {
                return NotFound();
            }

        }

        //Search by Name 
        [HttpGet("{name}")]
        public IActionResult GetEjecucionByName(string nameRobotBase)
        {
            var info = this._context.EjecucionRobot.SingleOrDefault(ct => ct.Nombre_Robot_Base == nameRobotBase);

            if (info == null)
            {
                return new NoContentResult();
            }
            else
            {
                return Ok(info);
            }
        }
        ////AddAuthors
        //[HttpPost]
        //public IActionResult AddAuthors([FromBody] Author author)
        //{

        //    if (!this.ModelState.IsValid)
        //    {
        //        return BadRequest();
        //    }
        //    this._context.Authors.Add(author);
        //    this._context.SaveChanges();
        //    return Created($"authors/{author.Id_Author}", author);
        //}
        //UpdateAuthors
        //[HttpPut("{id}")]
        //public IActionResult PutAuthors(int id, [FromBody] Author author)
        //{

        //    var target = _context.Authors.FirstOrDefault(ct => ct.Id_Author == id);
        //    if (target == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        target.Id_Author = author.Id_Author;
        //        target.Name = author.Name;
        //        target.Last_Name = author.Last_Name;
        //        target.Email = author.Email;

        //        _context.Authors.Update(target);
        //        _context.SaveChanges();
        //        return new NoContentResult();
        //    }

        //}

        //Delete Authors
        [HttpDelete("{id}")]
        public IActionResult DeleteAuthors(int id)
        {
            var target = _context.EjecucionRobot.FirstOrDefault(ct => ct.ID_Ejecucion == id);
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.EjecucionRobot.Remove(target);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}