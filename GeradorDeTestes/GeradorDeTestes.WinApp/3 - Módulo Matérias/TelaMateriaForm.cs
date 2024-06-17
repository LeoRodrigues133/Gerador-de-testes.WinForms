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

namespace GeradorDeTestes.WinApp._2___Módulo_Matérias
{
    public partial class TelaMateriaForm : Form
    {
        Materias materia;
        List<Materias> rMaterias;

        public Materias Materia
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtMateria.Text = value.Nome;
            }
            get => materia;
        }
        public TelaMateriaForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeMateria = txtMateria.Text;
            Disciplinas disciplina = (Disciplinas)cmbBoxDiscplina.SelectedItem;
            int serie = 0;

            if (rdb1Serie.Checked)
            {
                serie = 1;
            }

            if (rdb2Serie.Checked)
            {
                serie = 2;
            }


            materia = new Materias(nomeMateria, disciplina, serie);

            if (!materia.VerificarRegistros(rMaterias, materia))
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