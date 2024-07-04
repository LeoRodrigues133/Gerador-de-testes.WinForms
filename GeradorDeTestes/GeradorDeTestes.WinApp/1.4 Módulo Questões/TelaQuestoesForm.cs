using System.Data;
using GeradorDeTestes.WinApp;
using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Domain.MóduloQuestões;

namespace GeradorDeTestes.View.MóduloQuestões
{
    public partial class TelaQuestoesForm : Form
    {
        Questoes questao;
        Alternativas alternativa;
        public Questoes Questao
        {
            set
            {
                cmbBoxMateria.SelectedItem = value.Materia;
                txtEnunciado.Text = value.Enunciado.ToString();

            }
            get => questao;
        }

        public TelaQuestoesForm()
        {
            InitializeComponent();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string resposta = txtAlternativa.Text;

            if (string.IsNullOrEmpty(resposta))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar uma alternativa vazia.");
                return;
            }

            alternativa = new Alternativas(resposta);


            listAlternativas.Items.Add(alternativa);

            EnumerarAlternativa();

            txtAlternativa.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listAlternativas.Items.Remove(listAlternativas.SelectedItem);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {


            Materias materia = (Materias)cmbBoxMateria.SelectedItem;

            string enunciado = txtEnunciado.Text.Trim();

            List<Alternativas> alternativas = listAlternativas.Items.Cast<Alternativas>().ToList();

            foreach (Alternativas a in listAlternativas.CheckedItems)
            {
                a.Resposta = true;
            }

            if (listAlternativas.CheckedItems.Count != 1)
            {
                MessageBox.Show(
                    "Selecione UMA resposta para o enunciado!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    ); return;
            }

            questao = new Questoes(enunciado, materia, alternativas);


        }

        private void EnumerarAlternativa()
        {
            int i = 0;
            foreach (Alternativas a in listAlternativas.Items)
            {
                a.RefatorarModeloAlternativa(i);
                i++;
            }
        }

        public void MostrarMaterias(List<Materias> materias)
        {
            foreach (Materias m in materias)
                cmbBoxMateria.Items.Add(m);
        }

        internal void MostrarAlternativas(List<Alternativas> alternativas)
        {
            foreach (Alternativas a in alternativas)
                listAlternativas.Items.Add(a);
        }

        private void txtAlternativa_PressKey(object sender, KeyEventArgs e)
        {
            if (txtAlternativa.Focused && e.KeyCode == Keys.Enter)
            {
                btnAdicionar.PerformClick();
            }

        }
    }
}
