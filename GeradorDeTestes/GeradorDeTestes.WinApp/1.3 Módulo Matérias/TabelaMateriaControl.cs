using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.View.Grid.MóduloCompartilhado;

namespace GeradorDeTestes.View.Grid.MóduloMatérias
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
            grid.Columns.AddRange(CriarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        internal void AtualizarRegistros(List<Materias> materias)
        {
            grid.Rows.Clear();

            foreach (Materias m in materias)
            {
                grid.Rows.Add(m.Id.ToString(), m.Nome, m.Disciplina, $"{m.Serie}ª Série");
            }
        }

        internal int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        private DataGridViewColumn[] CriarColunas()
        {
            return new DataGridViewColumn[]                 {
                new DataGridViewTextBoxColumn{DataPropertyName =  "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Titulo", HeaderText = "Titulo" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Disciplina", HeaderText = "Disciplina" },
                new DataGridViewTextBoxColumn{DataPropertyName =  "Serie", HeaderText = "Série" },
            };
        }
    }
}
