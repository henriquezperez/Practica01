using Practica01.Data;
using Practica01.Models;
using Practica01.Services;

namespace Practica01.Repository
{
    public class EstudianteCL : IEstudiante
    {
        private ApplicationDBContext app; //Conexión a la DB

        public EstudianteCL(ApplicationDBContext app)
        {
            this.app = app;
        }

        public void AddEstudiante(Estudiante est)
        {
            app.estudiante.Add(est);
            app.SaveChanges();
            //throw new NotImplementedException();
        }

        public void DeleteEstudiante(Estudiante est)
        {
            app.estudiante.Remove(est);
            app.SaveChanges();
            //throw new NotImplementedException();
        }

        public List<Estudiante> GetAllEstudiantes()
        {
            //return new List<Estudiante>();
            //throw new NotImplementedException();
            return app.estudiante.ToList();
        }

        public void UpdateEstudiante(Estudiante est)
        {
            //throw new NotImplementedException();
        }
    }
}
