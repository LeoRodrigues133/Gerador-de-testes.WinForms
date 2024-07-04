using GeradorDeTestes.Domain.MóduloTestes;
using GeradorDeTestes.Infra.Memória.MóduloCompartilhado;

namespace GeradorDeTestes.Infra.Memória.MóduloTestes
{
    public class RepositorioTestesEmMemoria : RepositorioBaseEmMemoria<Teste>, IRepositorioTestes
    {
    }
}

