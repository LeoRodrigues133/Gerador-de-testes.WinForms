using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._5___Módulo_Questões;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
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
