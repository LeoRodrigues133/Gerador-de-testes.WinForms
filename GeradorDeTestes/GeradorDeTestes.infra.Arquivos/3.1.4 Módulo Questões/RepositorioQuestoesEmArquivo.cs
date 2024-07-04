using GeradorDeTestes.Domain.MóduloQuestões;
using GeradorDeTestes.Infra.Arquivos.MóduloCompartilhado;

namespace GeradorDeTestes.Infra.Arquivos.MóduloQuestões
{
    public class RepositorioQuestoesEmArquivo : RepositorioBaseEmArquivo<Questoes>, IRepositorioQuestoes
    {
        public RepositorioQuestoesEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Questoes> ObterRegistros()
        {
            return contexto.Questoes;
        }
    }
}
