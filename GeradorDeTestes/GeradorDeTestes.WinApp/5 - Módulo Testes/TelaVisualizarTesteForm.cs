using GeradorDeTestes.WinApp._5___Módulo_Questões;
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
    public partial class TelaVisualizarTesteForm : Form
    {
        public TelaVisualizarTesteForm(Teste testeSelecionado)
        {
            InitializeComponent();

            lblTitulo.Text = testeSelecionado.Titulo;

            lblDisciplina.Text = testeSelecionado.Disciplina.ToString();

            if (testeSelecionado.Materia != null)
                lblMateria.Text = testeSelecionado.Materia.ToString();
            else
                lblMateria.Text = "Recuperação";

        }
        public void CarregarQuestoes(Teste testeSelecionado)
        {

            foreach (Questoes questao in testeSelecionado.Questoes)
                listQuestoes.Items.Add(questao);

        }
    }
}
