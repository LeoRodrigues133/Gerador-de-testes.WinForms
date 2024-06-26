using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;

namespace GeradorDeTestes.WinApp._3___Módulo_Matérias
{
    public class ControladorMateria : ControladorBase
    {
        public IRepositorioMateria repositorioMaterias;
        public IRepositorioDisciplina repositorioDisciplina;
        
        TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioMateria materiasRepositorio, IRepositorioDisciplina disciplinaRepositorio)
        {
            repositorioMaterias = materiasRepositorio;
            repositorioDisciplina = disciplinaRepositorio;
        }

        public override string TipoCadastro { get { return "Matérias"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova Matéria"; } }

        public override string ToolTipEditar { get { return "Editar uma Matéria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma Matéria"; } }

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioMaterias.SelecionarTodos());

            CarregarDisciplinas(telaMateria);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Materias novaMateria = telaMateria.Materia;

            repositorioMaterias.Cadastrar(novaMateria);

            CarregarMateria();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {


            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materias materiaSelecionada = repositorioMaterias.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                TelaPrincipalForm
                   .Instancia
                   .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }
            telaMateria.Materia = materiaSelecionada;

            List<Disciplinas> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materias materiaEditada = telaMateria.Materia;

            List<Materias> materias = repositorioMaterias.SelecionarTodos();

           VerificarNome(materiaEditada, materias);

            repositorioMaterias.Editar(materiaSelecionada.Id, materiaEditada);

            CarregarMateria();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaEditada.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materias materiaSelecionada = repositorioMaterias.SelecionarPorId(idSelecionado);
            if (materiaSelecionada == null)
            {
                TelaPrincipalForm
                     .Instancia
                     .AtualizarRodape($"Não é possível realizar esta ação sem um registro selecionado.");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               $"Você deseja realmente excluir o registro \"{materiaSelecionada.Id}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) 
                return;

            bool conseguiuExcluir = repositorioMaterias.Excluir(materiaSelecionada.Id);

            if (!conseguiuExcluir)
            {
                TelaPrincipalForm
                    .Instancia
                    .AtualizarRodape($"Não é possível excluir a matéria pois há questões relacionadas.");
                return;
            }

            repositorioMaterias.Excluir(materiaSelecionada.Id);
            CarregarMateria();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }

        private void CarregarMateria()
        {
            List<Materias> materias = repositorioMaterias.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }

        public void CarregarDisciplinas(TelaMateriaForm telaMateria)
        {
            List<Disciplinas> disciplinas = repositorioDisciplina.SelecionarTodos();

            telaMateria.MostrarDisciplinas(disciplinas);
        }

        private static void VerificarNome(Materias materiaRecebida, List<Materias> materias)
        {
            foreach (var materia in materias)
            {
                if (materia.Nome.ToLower() == materiaRecebida.Nome.ToLower())
                {
                    TelaPrincipalForm
                        .Instancia
                        .AtualizarRodape($"Já existe uma materia com este nome.");
                    return;
                }
            }
        }
    }
}