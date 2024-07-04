namespace GeradorDeTestes.Domain.MóduloQuestões
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
