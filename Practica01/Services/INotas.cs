using Practica01.Models;

namespace Practica01.Services
{
    public interface INotas
    {
        String NombreCompleto(Notas action);
        Double SumaLab(Notas nt);
        Double SumaPar(Notas nt);
        Double PorcLab(Notas nt);
        Double PorcPar(Notas nt);
        Double TotalLab(Notas nt);
        Double TotalParc(Notas nt);
        Double Prom(Notas nt);
    }
}
