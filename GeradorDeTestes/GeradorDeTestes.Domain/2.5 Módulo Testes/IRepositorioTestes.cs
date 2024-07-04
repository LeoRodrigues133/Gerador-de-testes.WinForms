namespace GeradorDeTestes.Domain.MóduloTestes
{
    public interface IRepositorioTestes
    {
        void Cadastrar(Teste novoTeste);
        bool Editar(int id, Teste atualizarTeste);
        bool Excluir(int id);
        Teste SelecionarPorId(int id);
        List<Teste> SelecionarTodos();
    }
}
