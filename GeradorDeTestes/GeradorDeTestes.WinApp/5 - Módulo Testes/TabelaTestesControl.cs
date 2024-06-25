using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
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
