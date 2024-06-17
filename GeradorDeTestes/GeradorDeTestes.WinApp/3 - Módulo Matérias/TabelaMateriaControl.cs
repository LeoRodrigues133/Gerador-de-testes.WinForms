using GeradorDeTestes.WinApp._2___Módulo_Matérias;
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
        }

        internal void AtualizarRegistros(List<Materias> materias)
        {
            grid.Rows.Clear();

            foreach (Materias m in materias) { grid.Rows.Add(m.Id.ToString()); }
        }

        internal int ObterRegistroSelecionado()
        {
            throw new NotImplementedException();
        }
    }
}
