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
        bool Editar(int id, Questoes atualizaQuestao);
        bool Excluir(int id);
        Questoes SelecionarPorId(int id);
        List<Questoes> SelecionarTodos();
    }
}
