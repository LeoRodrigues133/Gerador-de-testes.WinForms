using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.Infra.Arquivos.MóduloCompartilhado;

namespace GeradorDeTestes.Infra.Arquivos.MóduloDisciplinas
{ 
    public class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplinas>, IRepositorioDisciplina
    {

        public RepositorioDisciplinaEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Disciplinas> ObterRegistros()
        {
            return contexto.Disciplina;
        }
    }
}
