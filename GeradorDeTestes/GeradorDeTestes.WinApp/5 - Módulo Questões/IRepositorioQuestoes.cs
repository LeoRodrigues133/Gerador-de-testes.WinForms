using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public interface IRepositorioQuestoes
    {
        void Cadastrar(Questoes novaQuestao);
        bool Editar(int id, Disciplinas atualizarDisciplina);
        bool Excluir(int id);
        Disciplinas SelecionarPorId(int id);
        List<Disciplinas> SelecionarTodos();
    }
}
