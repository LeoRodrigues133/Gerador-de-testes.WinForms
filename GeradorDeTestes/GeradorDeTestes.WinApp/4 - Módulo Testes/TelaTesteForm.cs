using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
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
                //cmbBoxMateria.Text = value.Materia.Nome;
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
            Disciplina disciplina = (Disciplina)cmbBoxDisciplina.SelectedItem;
            //Materias materia = (Materias)cmbBoxMateria.SelectedItem;
            decimal NumQuestoes = numQuestoes.Value;
            teste = new Teste(titulo, disciplina/*,materia*/, NumQuestoes);
        }

        public void MostrarDisciplinas(List<Disciplina> disciplinas)
        {
            foreach (Disciplina d in disciplinas)
                cmbBoxDisciplina.Items.Add(d.Nome);
        }

        //public void mostrarmaterias(list<materia> materias)
        //{
        //    foreach (materia m in materias)
        //        cmbboxmateria.items.add(m.nome);
        //}
    }
}
