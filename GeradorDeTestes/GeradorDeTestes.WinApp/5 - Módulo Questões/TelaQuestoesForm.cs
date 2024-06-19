using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public partial class TelaQuestoesForm : Form
    {
        Questoes questao;
        List<Alternativas> alternativas;
        Materia materia;
        public Questoes Questao
        {
            set
            {
                txtAlternativa.Text = alternativas.Count().ToString();
                cmbBoxMateria.Text = materia.Nome;
                txtEnunciado.Text = value.Enunciado.ToString();
            }
            get => questao;
        }
        public TelaQuestoesForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
