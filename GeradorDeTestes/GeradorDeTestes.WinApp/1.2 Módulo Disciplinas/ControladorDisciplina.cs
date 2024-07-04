using GeradorDeTestes.WinApp;
using GeradorDeTestes.View.MóduloDisciplinas;
using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.View.Grid.MóduloDisciplinas;
using GeradorDeTestes.View.Control.MóduloCompartilhado;


namespace GeradorDeTestes.View.Control.MóduloDisciplinas
{
    public class ControladorDisciplina : ControladorBase
    {
        IRepositorioDisciplina repositorioDisciplina;
        TabelaDisciplinasControl tabelaDisciplinas;

        public ControladorDisciplina(IRepositorioDisciplina repositorio)
        {
            repositorioDisciplina = repositorio;
        }
        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Disciplinas novaDisciplina = telaDisciplina.Disciplina;

            List<Disciplinas> disciplinas = repositorioDisciplina.SelecionarTodos();

            foreach (var disciplina in disciplinas)
            {
                if (disciplina.Nome.ToLower() == novaDisciplina.Nome.ToLower())
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma disciplina com este nome");
                    return;
                }
            }

            repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDisciplinas();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

            int idSelecionado = tabelaDisciplinas.ObterRegistroSelecionado();

            Disciplinas Selecionado = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                TelaPrincipalForm
                     .Instancia
                     .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }

            telaDisciplina.Disciplina = Selecionado;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Disciplinas disciplinaEditada = telaDisciplina.Disciplina;

            repositorioDisciplina.Editar(disciplinaEditada.Id, disciplinaEditada);
            CarregarDisciplinas();

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplinas.ObterRegistroSelecionado();

            Disciplinas disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);
            if (disciplinaSelecionada == null)
            {
                TelaPrincipalForm
                  .Instancia
                  .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado");
                return;
            }

            DialogResult resultado = MessageBox.Show(
               $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Id}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
                return;

            bool conseguiuExcluir = repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            if (!conseguiuExcluir)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível excluir a disciplina pois há matérias relacionadas.");
                return;
            }

            CarregarDisciplinas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{disciplinaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplinas == null)
                tabelaDisciplinas = new TabelaDisciplinasControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }
        private void CarregarDisciplinas()
        {
            List<Disciplinas> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);
        }
    }
}
