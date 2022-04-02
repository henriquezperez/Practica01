using Microsoft.AspNetCore.Mvc;
using Practica01.BusinessLogic;
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
            //var lista = EstudianteCL.GetAllEstudiantes();
            return View();
        }
        //[HttpPost]
        public IActionResult InsertDB(Estudiante est)
        {
            _estudiante.AddEstudiante(est);
            //return RedirectToAction("Index");
            return View();
        }

        public IActionResult DeleteDB(int id){
            //Estudiante id
            //int id;
            //estudiante.DeleteEstudiante(id);
            Estudiante est = new Estudiante();
            est.Id = id;
            _estudiante.DeleteEstudiante(est);
            return View("Index");
        }

        public IActionResult GetAllDataBase(){
            //List<Estudiante> lista = new List<Estudiante>();
            //var lista = 
            ViewBag.list = _estudiante.GetAllEstudiantes();
            //var lista = EstudianteCL.GetAllEstudiantes();
            return View();
            
        }

        public IActionResult Notas(Notas notas)
        {
            NotasBL op = new NotasBL();
            Double Laboratorios = op.SumaLab(notas);
            Double Paraciales = op.SumaPar(notas);
            Double Promedio = op.Prom(notas);
            ViewBag.Nombre = notas.Nombre;
            ViewBag.Lab1 = notas.Lab1;
            ViewBag.Lab2 = notas.Lab2;
            ViewBag.Lab3 = notas.Lab3;
            ViewBag.Par1 = notas.Par1;
            ViewBag.Par2 = notas.Par2;
            ViewBag.Par3 = notas.Par3;
            ViewBag.Prom = notas.Prom;
            return View();
        }
    }
}
 