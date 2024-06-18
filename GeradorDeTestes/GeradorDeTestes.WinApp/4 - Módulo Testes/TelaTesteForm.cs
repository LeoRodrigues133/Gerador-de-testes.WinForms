using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{

    public partial class TelaTesteForm : Form
    {
        IRepositorioDisciplina repositorioDisciplina;
        TelaTesteForm telaTeste;
        ControladorTestes controlador = new();
        Teste teste;
        public Teste Teste
        {

            set
            {
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbBoxDisciplina.Text = value.Disciplina.Nome;
                cmbBoxMateria.Text = value.Materia.Nome;
                numQuestoes.Value = value.NumQuestoes;
            }
            get => teste;
        }
        public TelaTesteForm(IRepositorioDisciplina d, IRepositorioMateria m)
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            Disciplinas disciplina = (Disciplinas)cmbBoxDisciplina.SelectedItem;
            Materias materia = (Materias)cmbBoxMateria.SelectedItem;
            decimal NumQuestoes = numQuestoes.Value;
            teste = new Teste(titulo, disciplina, materia, NumQuestoes);
        }

        public void MostrarDisciplinas(List<Disciplinas> disciplinas)
        {
            foreach (Disciplinas d in disciplinas)
                cmbBoxDisciplina.Items.Add(d.Nome);
        }

        private void btnSortearQuestoes_Click(object sender, EventArgs e)
        {
            listQuestoes.Items.Clear();

            for (int i = 0; i < numQuestoes.Value; i++)
                listQuestoes.Items.Add(questao());

        }

        public void MostrarMaterias(List<Materias> materias)
        {
            foreach (Materias m in materias)
                cmbBoxMateria.Items.Add(m.Nome);
        }

        public List<string> questao()
        {

            Random r = new Random();
            string[] teste2 = { "a", "a4", "a3", "a2", "b" };
            int teste4 = r.Next(teste2.Length);
            string teste3 = teste2[teste4].ToString();

            List<string> teste = new List<string>();

            teste.Add(teste3);

            return teste;
        }
    }
}
