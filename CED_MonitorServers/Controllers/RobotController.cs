using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEDBCN_MonitorIT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CEDBCN_MonitorIT.Controllers
{
    [Route("api/v1/[controller]")]
    public class RobotController : Controller
    {
        private readonly MonitorRobotsDbContext _context;

        public IActionResult Index()
        {
            return View();
        }        

        public RobotController(MonitorRobotsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Estado_Robot> GetAllRobots()
        {

            return _context.EstadoRobot.Include(c => c.IDRobot).ToList();
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdRobot(int id)
        {

            var result = this._context.EstadoRobot.Include(c => c.IDRobot).SingleOrDefault(t => t.IDRobot == id);
            if (id == 0)
            {
                return BadRequest();
            }
            else if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }
        [HttpPost]
        public IActionResult AddCaso([FromBody] Estado_Robot robots)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }

            this._context.EstadoRobot.Add(robots);
            this._context.SaveChanges();
            return Created($"books/{robots.IDRobot}", robots);
        }
    }
}