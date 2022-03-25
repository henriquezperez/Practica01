using Practica01.Models;
using Practica01.Services;

namespace Practica01.BusinessLogic
{
    public class OperacionesBL : IOperaciones
    {
        public double Division(Acciones acciones)
        {
            return acciones.Dato1 / acciones.Dato2;
        }

        public double Multiplicacion(Acciones acciones)
        {
            return acciones.Dato1 * acciones.Dato2;
        }

        public double Resta(Acciones acciones)
        {
            return acciones.Dato1 - acciones.Dato2;
        }

        public double Suma(Acciones acciones)
        {
            return acciones.Dato1 + acciones.Dato2;
        }
    }
}
