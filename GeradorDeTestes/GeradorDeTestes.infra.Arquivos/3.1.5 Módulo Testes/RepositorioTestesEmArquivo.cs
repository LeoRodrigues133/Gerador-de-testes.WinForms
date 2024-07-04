using GeradorDeTestes.Infra.Arquivos.MóduloCompartilhado;
using GeradorDeTestes.Domain.MóduloTestes;


namespace GeradorDeTestes.Infra.Arquivos.MóduloTestes
{ 
    public class RepositorioTestesEmArquivo : RepositorioBaseEmArquivo<Teste>, IRepositorioTestes
    {
        public RepositorioTestesEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }


        protected override List<Teste> ObterRegistros()
        {
            return contexto.Teste;
        }
    }
}
