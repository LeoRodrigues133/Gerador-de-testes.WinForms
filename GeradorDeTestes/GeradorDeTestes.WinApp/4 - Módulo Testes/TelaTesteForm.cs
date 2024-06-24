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

            Materias materia = (Materias)cmbBoxMateria.SelectedItem;

            decimal NumQuestoes = numQuestoes.Value;

            teste = new Teste(titulo, disciplina, materia, NumQuestoes);
        }

        public void MostrarDisciplinas(List<Disciplinas> disciplinas)
        {
            foreach (Disciplinas d in disciplinas)
                cmbBoxDisciplina.Items.Add(d);
        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();

            int i = 0;
            foreach (Questoes q in SortearQuestoes())
            {

                q.ModeloQuestao(i);
                i++;
                listQuestoes.Items.Add(q);
                foreach (Alternativas a in q.Alternativas)
                {
                    listQuestoes.Items.Add(a);
                }
            }
        }

        private List<Questoes> SortearQuestoes()
        {
            int qtdQuestoesTeste = Convert.ToInt32(numQuestoes.Value);

            List<Questoes> Selecionadas = new List<Questoes>();


            for (int i = 0; i < qtdQuestoesTeste; i++)
            {
                Random r = new();

                List<Questoes> todasAsQuestoes = new List<Questoes>();

                todasAsQuestoes = repositorioQuestoes.SelecionarTodos();


                var filtradas = todasAsQuestoes.Where(q => q.Materia == cmbBoxMateria.SelectedItem).ToList();

                if (filtradas == null)
                {
                    MessageBox.Show(
                        "Selecione uma matéria para criar o teste!",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                };


                int indexLista = r.Next(filtradas.ToList().Count());

                Questoes questaoSelecionada = filtradas[indexLista];


                Selecionadas.Add(questaoSelecionada);
            }

            return Selecionadas;
        }

        public void MostrarMaterias(List<Materias> materias)
        {
            List<Materias> filtradas = materias.Where(x => x.Disciplina == cmbBoxDisciplina.SelectedItem).ToList();


            foreach (Materias m in filtradas)
                cmbBoxMateria.Items.Add(m);
        }

        public void MostrarQ(List<Questoes> questoes)
        {

            foreach (Questoes q in questoes)
            {
                listQuestoes.Items.Add(q);
            }
        }

        private void cmbBoxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxMateria.Items.Clear();

            cmbBoxMateria.Text = null;

            if (cmbBoxDisciplina.SelectedItem != null)
                cmbBoxMateria.Enabled = true;

            List<Materias> materias = repositorioMateria.SelecionarTodos();
            MostrarMaterias(materias);

        }
    }
}
