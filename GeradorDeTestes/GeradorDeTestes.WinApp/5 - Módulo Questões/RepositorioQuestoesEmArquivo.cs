using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
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
