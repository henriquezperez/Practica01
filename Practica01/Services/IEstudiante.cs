using Practica01.Models;

namespace Practica01.Services
{
    public interface IEstudiante
    {
        public void AddEstudiante(Estudiante est);
        public void UpdateEstudiante(Estudiante est);
        public void DeleteEstudiante(Estudiante est);
        public List<Estudiante> GetAllEstudiantes();

    }
}
