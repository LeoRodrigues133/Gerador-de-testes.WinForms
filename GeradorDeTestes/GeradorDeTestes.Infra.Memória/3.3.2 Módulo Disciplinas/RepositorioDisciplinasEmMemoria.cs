using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.Infra.Memória.MóduloCompartilhado;


namespace GeradorDeTestes.Infra.Memória.MóduloDisciplinas
{
    public class RepositorioDisciplinasEmMemoria : RepositorioBaseEmMemoria<Disciplinas>, IRepositorioDisciplina
    {
    }
}
