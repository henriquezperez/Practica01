using Microsoft.AspNetCore.Mvc;
using Practica01.Models;
using Practica01.Services;

namespace Practica01.Controllers
{
    public class EstudianteController : Controller
    {
        private IEstudiante _estudiante;

        public EstudianteController(IEstudiante estudiante)
        {
            _estudiante = estudiante;
        }

        public IActionResult Index()
        {
            //Estudiante es = new Estudiante();
            //es.Name = "Miguel";
            //es.LastName = "Pérez";
            //es.Id = 1;
            //_estudiante.DeleteEstudiante(es);
            //_estudiante.GetAllEstudiantes();
            return View();
        }
        //[HttpPost]
        public IActionResult InsertDB(Estudiante est)
        {
            _estudiante.AddEstudiante(est);
            //return RedirectToAction("Index");
            return View();
        }

        public IActionResult DeleteDB(Estudiante id){
                //int id;
            _estudiante.DeleteEstudiante(id);
            return View();
        }

        public IActionResult GetAllDataBase(){
            //List<Estudiante> lista = new List<Estudiante>();
            ViewBag.list = _estudiante.GetAllEstudiantes();
            return View();
        }
    }
}
 