using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp._3___Módulo_Matérias
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
                grid.Rows.Add(m.Id.ToString(), m.Nome,m.Disciplina);
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
            };
        }
    }
}
