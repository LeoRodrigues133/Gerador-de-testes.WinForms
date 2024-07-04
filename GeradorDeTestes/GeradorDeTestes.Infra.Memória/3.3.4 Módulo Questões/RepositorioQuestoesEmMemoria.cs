using GeradorDeTestes.Domain.MóduloQuestões;
using GeradorDeTestes.Infra.Memória.MóduloCompartilhado;

namespace GeradorDeTestes.Infra.Memória.MóduloQuestões
{
    public class RepositorioQuestoesEmMemoria : RepositorioBaseEmMemoria<Questoes>, IRepositorioQuestoes
    {
    }
}
