using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CEDBCN_MonitorIT.Models;

namespace CEDBCN_MonitorIT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Nuestra pagina de descripción de la aplicación.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Nuestra página de contacto.";

            return View();
        }

        public IActionResult EstadoRobots()
        {
            ViewData["Message"] = "Pagina con el Estado de los Robots.";

            ConsultaEstadoRobots ce = new ConsultaEstadoRobots();
            return View(ce.RecuperarTodos());
            //return View(GetAllRobots());

            //return View();
        }

        public IActionResult EstadoCasos()
        {
            ViewData["Message"] = "Pagina con el Estado de los Casos.";

            ConsultaCasosRobots cr = new ConsultaCasosRobots();
            return View(cr.RecuperarTodosCasosNoAperturados());

            //return View();
        }

        public IActionResult EstadoServers()
        {
            ViewData["Message"] = "Pagina con el Estado de los Servidores y Servicios.";

            ConsultaServers cs = new ConsultaServers();
            return View(cs.RecuperarTodos());

            //return View();
        }

        //public ViewResult DetalleCaso(int idCaso)
        //{
        //    ViewData["Message"] = "Pagina con el Estado de un caso fallido.";

        //    ConsultaCasosRobots cr = new ConsultaCasosRobots();
        //    return View(cr.RecuperarCasoFallido(idCaso));

        //    //return View();
        //}



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
