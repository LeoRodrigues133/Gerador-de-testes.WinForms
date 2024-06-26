using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._5___Módulo_Questões;


namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{

    public partial class TelaTesteForm : Form
    {
        IRepositorioQuestoes repositorioQuestoes;
        IRepositorioTestes repositorioTestes;
        IRepositorioMateria repositorioMateria;
        IRepositorioDisciplina repositorioDisciplina;
        Materias materia = null;
        public List<Questoes> questoes;
        TelaTesteForm telaTeste;
        ControladorTestes controlador;
        TabelaQuestoesControl tabelaQuestoes;
        Teste teste;
        public Teste Teste
        {

            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbBoxDisciplina.SelectedItem = value.Disciplina;
                cmbBoxMateria.SelectedItem = value.Materia;
                numQuestoes.Value = value.NumQuestoes;
            }
            get => teste;
        }
        public TelaTesteForm(IRepositorioDisciplina d, IRepositorioMateria m, IRepositorioQuestoes q)
        {
            InitializeComponent();
            repositorioDisciplina = d;
            repositorioMateria = m;
            repositorioQuestoes = q;

            cmbBoxMateria.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string titulo = txtTitulo.Text.Trim();

            Disciplinas disciplina = (Disciplinas)cmbBoxDisciplina.SelectedItem;

            materia = (Materias)cmbBoxMateria.SelectedItem;

            decimal NumQuestoes = numQuestoes.Value;

            teste = new Teste(titulo, disciplina, materia, NumQuestoes);

            List<Questoes> q = listQuestoes.Items.Cast<Questoes>().ToList();

            teste.Questoes = q;

        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();
            int i = 1;

            if (cmbBoxDisciplina.SelectedItem == null)
                MessageBox.Show(
                    "Você deve selecionar uma disciplina",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            else
                foreach (Questoes q in SortearQuestoes())
                {

                    q.ModeloQuestao(i);
                    i++;

                    listQuestoes.Items.Add(q);
                }
        }

        private void cmbBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxMateria.Items.Clear();

            cmbBoxMateria.Text = string.Empty;

            if (cmbBoxDisciplina.SelectedItem != null)
                cmbBoxMateria.Enabled = true;

            List<Materias> materias = repositorioMateria.SelecionarTodos();
            MostrarMaterias(materias);

        }

        private void chkRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecuperacao.Checked)
            {
                cmbBoxMateria.Enabled = false;
                cmbBoxMateria.Text = string.Empty;
            }
            else
            {
                cmbBoxMateria.Enabled = true;
                cmbBoxMateria.Text = string.Empty;
            }
        }

        private List<Questoes> SortearQuestoes()
        {
            int qtdQuestoesTeste = Convert.ToInt32(numQuestoes.Value);

            List<Questoes> Selecionadas = new List<Questoes>();

            if (qtdQuestoesTeste > SelecionarLista().Count)
            {
                MessageBox.Show(
                    "A quantidade de questões registradas é insuficiente para criar um teste.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (qtdQuestoesTeste >= SelecionarLista().Count())
                if (chkRecuperacao.Checked)
                    foreach (Questoes q in SelecionarLista())
                        Selecionadas.Add(q);

                else
                    foreach (Questoes q in SelecionarLista().Where(x => x.Materia == cmbBoxMateria.SelectedItem))
                        Selecionadas.Add(q);

            else

                SelecionarAleatoriamente(qtdQuestoesTeste, Selecionadas);

            return Selecionadas;
        }

        private void SelecionarAleatoriamente(int qtdQuestoesTeste, List<Questoes> Selecionadas)
        {

            while (qtdQuestoesTeste > Selecionadas.Count())
            {
                int indexList = 0;
                Questoes questaoSelecionada = null;
                Random r = new();

                indexList = r.Next(SelecionarLista().Count());

                questaoSelecionada = SelecionarLista()[indexList];

                if (questaoSelecionada != Selecionadas.FirstOrDefault(x => x.Enunciado == questaoSelecionada.Enunciado))
                    Selecionadas.Add(questaoSelecionada);

            }
        }

        private List<Questoes> SelecionarLista()
        {
            List<Questoes> todasAsQuestoes = new List<Questoes>();

            todasAsQuestoes = repositorioQuestoes.SelecionarTodos();

            List<Questoes> filtradas = todasAsQuestoes.Where(q => q.Materia == cmbBoxMateria.SelectedItem).ToList();

            if (chkRecuperacao.Checked == true)
                return todasAsQuestoes;
            else
                return filtradas;

        }

        public void MostrarDisciplinas(List<Disciplinas> disciplinas)
        {
            foreach (Disciplinas d in disciplinas)
                cmbBoxDisciplina.Items.Add(d);
        }

        public void MostrarMaterias(List<Materias> materias)
        {

            List<Materias> filtradas = materias.Where(x => x.Disciplina == cmbBoxDisciplina.SelectedItem).ToList();

            foreach (Materias m in filtradas)
                cmbBoxMateria.Items.Add(m);

        }
    }
}

