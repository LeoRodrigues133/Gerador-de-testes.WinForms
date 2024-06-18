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
        Disciplina disciplina;
        List<Disciplina> rDisciplinas;
        public Disciplina Disciplina
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtDisciplina.Text = value.Nome;
            }

            get => disciplina;
        }

        public TelaDisciplinaForm(List<Disciplina> disciplinas)
        {
            InitializeComponent();

            this.rDisciplinas = disciplinas;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nomeDisciplina = txtDisciplina.Text;

            disciplina = new Disciplina(nomeDisciplina);

            if (!disciplina.VerificarRegistros(rDisciplinas, disciplina))
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação, já existe um registro com este nome cadastrado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                     );
                DialogResult = DialogResult.Cancel;
            }


        }
    }
}
