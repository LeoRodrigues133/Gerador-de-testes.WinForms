using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplinas
{
    public partial class TabelaDisciplinasControl : UserControl
    {
        public TabelaDisciplinasControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Disciplinas> disciplinas)
        {
            grid.Rows.Clear();

            foreach (Disciplinas d in disciplinas)
                grid.Rows.Add(d);
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

    }
}
