using GeradorDeTestes.Domain.MóduloTestes;
using GeradorDeTestes.Domain.MóduloQuestões;

namespace GeradorDeTestes.View.MóduloTestes
{
    public partial class TelaVisualizarTesteForm : Form
    {
        public TelaVisualizarTesteForm(Teste testeSelecionado)
        {
            InitializeComponent();

            lblTitulo.Text = testeSelecionado.Titulo;

            lblDisciplina.Text = testeSelecionado.Disciplina.ToString();

            if (testeSelecionado.Materia != null)
                lblMateria.Text = testeSelecionado.Materia.ToString();
            else
                lblMateria.Text = "Recuperação";

        }
        public void CarregarQuestoes(Teste testeSelecionado)
        {

            foreach (Questoes questao in testeSelecionado.Questoes)
                listQuestoes.Items.Add(questao);

        }
    }
}
