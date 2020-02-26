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
    public class ServerController : Controller
    {
        private readonly MonitorRobotsDbContext _context;

        public IActionResult Index()
        {
            return View();
        }        

        public ServerController(MonitorRobotsDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<MonitorServers> GetAllServers()
        {
            return _context.MonitorServers.Include(c => c.MonitorServersID).ToList();
        }

        [HttpGet]
        public List<MonitorServers> GetAllServersFiltered()
        {
            //sql = "select MonitorServersID,UsuarioID,Usuario, Servidor,TipoServidor,fecha,cpu,memoria,usuarios,red,sms,mail,discos from dbo.MonitorServers where fecha >= '" + diaHoy + "' AND Servidor not like 'ESW%' ORDER BY Servidor ASC";
            //var result = this._context.MonitorServers.Include(c => c.MonitorServersID).FromSql<ConsultaServers(sql));


            return _context.MonitorServers.Include(c => c.MonitorServersID).ToList();
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