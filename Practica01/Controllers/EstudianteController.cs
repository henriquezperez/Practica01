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
 