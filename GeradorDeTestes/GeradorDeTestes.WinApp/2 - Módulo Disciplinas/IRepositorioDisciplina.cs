using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplinas
{
    internal interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplinas novaDisciplina);
        bool Editar(int id,Disciplinas atualizarDisciplina);
        bool Excluir(int id);
        Disciplinas SelecionarPorId(int id);
        List<Disciplinas> SelecionarTodos();
    }
}
