using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplinas
{
    internal class RepositorioDisciplinaEmArquivo : RepositorioBaseEmArquivo<Disciplinas>, IRepositorioDisciplina
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
