using GeradorDeTestes.WinApp;
using GeradorDeTestes.Domain.MóduloDisciplinas;

namespace GeradorDeTestes.View.MóduloDisciplinas
{
    public partial class TelaDisciplinaForm : Form
    {
        Disciplinas disciplina;
        List<Disciplinas> rDisciplinas;
        public Disciplinas Disciplina
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDisciplina.Text = value.Nome;
            }

            get => disciplina;
        }

        public TelaDisciplinaForm(List<Disciplinas> disciplinas)
        {
            InitializeComponent();

            this.rDisciplinas = disciplinas;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nomeDisciplina = txtDisciplina.Text;

            disciplina = new Disciplinas(nomeDisciplina);

            if (!disciplina.VerificarRegistros(rDisciplinas, disciplina))
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação, já existe um registro com este nome cadastrado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                     );
                DialogResult = DialogResult.Cancel;
            }

            TelaPrincipalForm.Instancia.AtualizarRodape("Um novo registro de Disciplina foi adicionado.");

        }

        private void txtDisciplina_KeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnGravar.PerformClick();

        }
    }
}
