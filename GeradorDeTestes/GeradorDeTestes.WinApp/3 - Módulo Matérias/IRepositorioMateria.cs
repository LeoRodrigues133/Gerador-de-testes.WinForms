using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Matérias
{
    public interface IRepositorioMaterias
    {
        void Cadastrar(Materias novaMateria);
        bool Editar(int id, Materias atualizarMateria);
        bool Excluir(int id);
        Materias SelecionarPorId(int id);
        List<Materias> SelecionarTodos();
    }
}
