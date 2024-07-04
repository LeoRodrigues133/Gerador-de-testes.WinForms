using GeradorDeTestes.View.MóduloTestes;
using GeradorDeTestes.Domain.MóduloTestes;
using GeradorDeTestes.View.Grid.MóduloCompartilhado;

namespace GeradorDeTestes.View.Grid.MóduloTestes
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl(TelaTesteForm t)
        {
            InitializeComponent();
            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        internal void AtualizarRegistros(List<Teste> testes)
        {
            grid.Rows.Clear();

            foreach (Teste t in testes)
                if (t.Materia == null) 
                    grid.Rows.Add(t.Id.ToString(), t.Titulo, t.Disciplina, "Recuperação", t.NumQuestoes); 
                else
                    grid.Rows.Add(t.Id.ToString(), t.Titulo, t.Disciplina, t.Materia, t.NumQuestoes);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn{DataPropertyName =  "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Titulo", HeaderText = "Titulo" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Disciplina", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Materia", HeaderText = "Matéria" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Questoes", HeaderText = "Qtd. Questões" },
            };
        }

    }
}
