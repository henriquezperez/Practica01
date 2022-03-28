using Practica01.Models;
using Practica01.Services;

namespace Practica01.BusinessLogic
{
    public class NotasBL : INotas
    {
        public string NombreCompleto(Notas nt)
        {
            return nt.Nombre;
        }

        public double PorcLab(Notas nt)
        {
            return nt.TotalLab * 0.40;
        }

        public double PorcPar(Notas nt)
        {
            return nt.TotalParc * 0.60;
        }

        public double Prom(Notas nt)
        {
            return nt.Prom = (nt.TotalLab *0.40) + (nt.TotalParc * 0.60);
        }

        public double SumaLab(Notas nt)
        {
            return nt.TotalLab = (nt.Lab1 + nt.Lab2 + nt.Lab3)/3;
        }

        public double SumaPar(Notas nt)
        {
            return nt.TotalParc = (nt.Par1 + nt.Par2 + nt.Par3)/3;
        }

        public double TotalLab(Notas nt)
        {
            throw new NotImplementedException();
        }

        public double TotalParc(Notas nt)
        {
            throw new NotImplementedException();
        }
    }
}
