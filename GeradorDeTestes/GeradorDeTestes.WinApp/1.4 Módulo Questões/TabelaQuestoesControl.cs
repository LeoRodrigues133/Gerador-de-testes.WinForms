using GeradorDeTestes.Domain.MóduloQuestões;
using GeradorDeTestes.View.Grid.MóduloCompartilhado;

namespace GeradorDeTestes.View.Grid.MóduloQuestões
{
    public partial class TabelaQuestoesControl : UserControl
    {
        public TabelaQuestoesControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }
        public void AtualizarRegistros(List<Questoes> questoes)
        {
            grid.Rows.Clear();

            foreach (Questoes q in questoes)
                grid.Rows.Add(q.Id, q.Enunciado, q.Materia, q.RespostaValida());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Questão" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Resposta", HeaderText = "Resposta" }
                };
        }
    }
}
