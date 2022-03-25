using Microsoft.AspNetCore.Mvc;
using Practica01.BusinessLogic;
using Practica01.Models;
using System.Diagnostics;

namespace Practica01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Suma(Acciones acciones) {

            //if(acciones.Dato1>10 || acciones.Dato2 > 10) {
            //    return View("NoMayores");
            //}
            //Double resultado = acciones.Dato1 + acciones.Dato2;
            //ViewBag.DatoN1V = acciones.Dato1;
            //ViewBag.DatoN2V = acciones.Dato2;
            //ViewBag.VariableAEnviar = resultado;
            OperacionesBL op = new OperacionesBL();
            Double resultado = op.Suma(acciones);
            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult Resta(Acciones acciones)
        {
            if (acciones.Dato1 > 10 || acciones.Dato2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = acciones.Dato1 - acciones.Dato2;
            ViewBag.DatoN1V = acciones.Dato1;
            ViewBag.DatoN2V = acciones.Dato2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult Multiplicacion(Acciones acciones)
        {
            if (acciones.Dato1 > 10 || acciones.Dato2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = acciones.Dato1 * acciones.Dato2;
            ViewBag.DatoN1V = acciones.Dato1;
            ViewBag.DatoN2V = acciones.Dato2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult Division(Acciones acciones)
        {
            if (acciones.Dato1 > 10 || acciones.Dato2 > 10)
            {
                return View("NoMayores");
            }
            Double resultado = acciones.Dato1 / acciones.Dato2;
            ViewBag.DatoN1V = acciones.Dato1;
            ViewBag.DatoN2V = acciones.Dato2;
            ViewBag.VariableAEnviar = resultado;
            return View();
        }

        public IActionResult NoMayores() {
            return View();
        }

        //[HttpGet] decorador
        public IActionResult PeticionTypeGet() {
            return View();
        }

    }
}