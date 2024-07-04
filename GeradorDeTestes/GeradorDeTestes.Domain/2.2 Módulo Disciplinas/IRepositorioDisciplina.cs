namespace GeradorDeTestes.Domain.MóduloDisciplinas
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplinas novaDisciplina);
        bool Editar(int id,Disciplinas atualizarDisciplina);
        bool Excluir(int id);
        Disciplinas SelecionarPorId(int id);
        List<Disciplinas> SelecionarTodos();
    }
}
