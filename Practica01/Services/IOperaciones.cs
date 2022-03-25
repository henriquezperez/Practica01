using Practica01.Models;

namespace Practica01.Services
{
    public interface IOperaciones
    {
        Double Suma(Acciones acciones);
        Double Resta(Acciones acciones);
        Double Multiplicacion(Acciones acciones);
        Double Division(Acciones acciones);
    }
}
