using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Infra.Memória.MóduloCompartilhado;


namespace GeradorDeTestes.Infra.Memória.MóduloMatéria
{
    public class RepositorioMateriasEmMemoria : RepositorioBaseEmMemoria<Materias>, IRepositorioMateria
    {
    }
}
