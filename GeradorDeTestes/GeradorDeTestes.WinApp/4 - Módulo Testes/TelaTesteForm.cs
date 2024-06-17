using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{

    public partial class TelaTesteForm : Form
    {
        Teste teste;
        public Teste Teste
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
            }
            get => teste;
        }
        public TelaTesteForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            Disciplinas disciplina = (Disciplinas)cmbBoxDisciplina.SelectedItem;
            decimal NumQuestoes = numQuestoes.Value;
            teste = new Teste(titulo, disciplina,NumQuestoes);
        }
    }
}
