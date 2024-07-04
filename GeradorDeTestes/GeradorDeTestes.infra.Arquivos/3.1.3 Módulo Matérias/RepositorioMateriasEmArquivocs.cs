using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Infra.Arquivos.MóduloCompartilhado;

namespace GeradorDeTestes.Infra.Arquivos.MóduloMatérias
{
    public class RepositorioMateriasEmArquivo : RepositorioBaseEmArquivo<Materias>, IRepositorioMateria
    {

        public RepositorioMateriasEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Materias> ObterRegistros()
        {
            return contexto.Materia;
        }
    }
}
