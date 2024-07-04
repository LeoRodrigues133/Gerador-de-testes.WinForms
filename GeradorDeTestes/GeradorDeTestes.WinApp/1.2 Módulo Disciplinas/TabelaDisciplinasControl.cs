using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.View.Grid.MóduloCompartilhado;

namespace GeradorDeTestes.View.Grid.MóduloDisciplinas
{
    public partial class TabelaDisciplinasControl : UserControl
    {
        public TabelaDisciplinasControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();

        }
        public void AtualizarRegistros(List<Disciplinas> disciplinas)
        {
            grid.Rows.Clear();

            foreach (Disciplinas d in disciplinas)
                grid.Rows.Add(d.Id.ToString(), d.Nome);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Disciplina" }
                };
        }
    }
}
