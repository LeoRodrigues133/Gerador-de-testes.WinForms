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
    public partial class TelaDisciplinaForm : Form
    {
        string DisciplinaNome { get; set; }
        Disciplinas disciplina;
        public Disciplinas Disciplina
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDisciplina.Text = value.Disciplina;
            }

            get => disciplina;
        }

        public TelaDisciplinaForm()
        {
            InitializeComponent();
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string Disciplina = txtDisciplina.Text;

            disciplina = new Disciplinas(Disciplina);
        }
    }
}
