using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._4___Módulo_Testes;
using GeradorDeTestes.WinApp._5___Módulo_Questões;

namespace GeradorDeTestes.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioTestes repositorioTestes;
        IRepositorioMateria repositorioMaterias;
        IRepositorioQuestoes repositorioQuestoes;
        ContextoDados contexto;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            contexto = new ContextoDados(true);

            lblTipoCadastro.Text = string.Empty;
            Instancia = this;
            repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contexto);
            repositorioMaterias = new RepositorioMateriasEmArquivo(contexto);
            repositorioTestes = new RepositorioTestesEmArquivo(contexto);
            repositorioQuestoes = new RepositorioQuestoesEmArquivo(contexto);

        }

        public void AtualizarRodape(string texto)
        {
            statusLabelPrincipal.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            //btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagem = controladorSelecionado.ObterListagem();
            listagem.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagem);
        }

        private void disciplinasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void testesMenuItem_Click(object sender, EventArgs e)
        {

            controlador = new ControladorTestes(repositorioTestes, repositorioDisciplina, repositorioMaterias);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMaterias, repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }
        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestoes(repositorioTestes, repositorioDisciplina, repositorioMaterias, repositorioQuestoes);

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

    }
}
