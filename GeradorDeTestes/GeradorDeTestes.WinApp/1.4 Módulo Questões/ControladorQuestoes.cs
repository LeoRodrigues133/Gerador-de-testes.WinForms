using GeradorDeTestes.WinApp;
using GeradorDeTestes.View.MóduloQuestões;
using GeradorDeTestes.Domain.MóduloTestes;
using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Domain.MóduloQuestões;
using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.View.Grid.MóduloQuestões;
using GeradorDeTestes.View.Control.MóduloCompartilhado;

namespace GeradorDeTestes.View.Control.MóduloQuestões
{
    public class ControladorQuestoes : ControladorBase
    {
        IRepositorioQuestoes repositorioQuestoes;
        TabelaQuestoesControl tabelaQuestoes;
        private IRepositorioTestes repositorioTestes;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMaterias;

        public override string TipoCadastro { get { return "Questões"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão"; } }

        public ControladorQuestoes(IRepositorioTestes testeRepositorio, IRepositorioDisciplina disciplinaRepositorio, IRepositorioMateria materiaRepositorio, IRepositorioQuestoes questoesRepositorio)
        {
            repositorioTestes = testeRepositorio;
            repositorioDisciplina = disciplinaRepositorio;
            repositorioMaterias = materiaRepositorio;
            repositorioQuestoes = questoesRepositorio;
        }

        public override void Adicionar()
        {
            TelaQuestoesForm telaQuestao = new TelaQuestoesForm();

            List<Materias> materiasCadastradas = repositorioMaterias.SelecionarTodos();

            CarregarMaterias(telaQuestao);

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questoes novaQuestao = telaQuestao.Questao;

            List<Questoes> questoes = repositorioQuestoes.SelecionarTodos();

            foreach (var questao in questoes)
            {
                if (questao.Enunciado.ToLower() == novaQuestao.Enunciado.ToLower())
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma questão com este nome.");
                    return;
                }
            }

            repositorioQuestoes.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaQuestao.Enunciado}\" foi criado com sucesso!");

        }

        public override void Editar()
        {
            int idSelecionado = tabelaQuestoes.ObterRegistroSelecionado();

            Questoes questaoSelecionada = repositorioQuestoes.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            TelaQuestoesForm telaQuestao = new TelaQuestoesForm();
            telaQuestao.Questao = questaoSelecionada;

            List<Materias> materiasCadastradas = repositorioMaterias.SelecionarTodos();

            CarregarMaterias(telaQuestao);

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questoes questaoEditada = telaQuestao.Questao;

            List<Questoes> questoes = repositorioQuestoes.SelecionarTodos();

            foreach (var questao in questoes)
            {
                if (questao.Enunciado.ToLower() == questaoEditada.Enunciado.ToLower() && questao.Id != questaoSelecionada.Id)
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma questão com este nome.");
                    return;
                }
            }

            repositorioQuestoes.Editar(questaoSelecionada.Id, questaoEditada);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questaoEditada.Enunciado}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaQuestoes.ObterRegistroSelecionado();

            Questoes questaoSelecionada = repositorioQuestoes.SelecionarPorId(idSelecionado);

            if (questaoSelecionada == null)
            {
                TelaPrincipalForm
                   .Instancia
                   .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
               $"Você deseja realmente excluir o registro \"{questaoSelecionada.Id}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
               );

            if (resultado != DialogResult.Yes)
                return;

            bool conseguiuEcluir = repositorioQuestoes.Excluir(questaoSelecionada.Id);

            if (!conseguiuEcluir)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape("Não é possível excluir a questao pois há testes relacionados.");
                return;
            }

            repositorioQuestoes.Excluir(idSelecionado);

            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{questaoSelecionada.Enunciado}\" foi excluído com sucesso!");
        }
        private void CarregarQuestoes()
        {
            List<Questoes> questoes = repositorioQuestoes.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }
        //private void AtualizarRodape()
        //{
        //    TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {repositorioQuestoes.SelecionarTodos().Count} registro(s)...");
        //}
        void CarregarMaterias(TelaQuestoesForm telaQuestoes)
        {
            List<Materias> materias = repositorioMaterias.SelecionarTodos();

            telaQuestoes.MostrarMaterias(materias);
        }
        private void CarregarAlternativas(Questoes Selecionado, TelaQuestoesForm telaQuestoes)
        {
            List<Alternativas> alternativas = Selecionado.Alternativas;

            telaQuestoes.MostrarAlternativas(alternativas);

        }


    }
}
