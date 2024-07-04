using GeradorDeTestes.Domain.MóduloCompartilhado;
using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Domain.MóduloQuestões;

namespace GeradorDeTestes.Domain.MóduloMatérias
{
    public interface IRepositorioMateria
    {
        void Cadastrar(Materias novaMateria);
        bool Editar(int id, Materias atualizarMateria);
        bool Excluir(int id);
        Materias SelecionarPorId(int id);
        List<Materias> SelecionarTodos();
    }
}
