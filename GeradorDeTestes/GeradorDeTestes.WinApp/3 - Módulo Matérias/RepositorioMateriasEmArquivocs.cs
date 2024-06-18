using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._3___Módulo_Matérias
{
    internal class RepositorioMateriasEmArquivo : RepositorioBaseEmArquivo<Materias>, IRepositorioMateria
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
