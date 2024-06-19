using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
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

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public partial class TelaQuestoesForm : Form
    {
        Questoes questao;
        List<Alternativas> alternativas {  get; set; }
        Alternativas alternativa;
        public Questoes Questao
        {
            set
            {
                txtAlternativa.Text = alternativas.Count().ToString();
                cmbBoxMateria.SelectedItem = value.Materia;
                txtEnunciado.Text = value.Enunciado.ToString();
                CarregarLista(value);

            }
            get => questao;
        }
        public TelaQuestoesForm()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string resposta = txtAlternativa.Text;

            if (string.IsNullOrEmpty(resposta))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar uma alternativa vazia.");
                return;
            }
            alternativa = new Alternativas(resposta);

            listAlternativas.Items.Add(alternativa);

            RefatorarAlternativasDinamicamente();

        }
        private void CarregarLista(Questoes questao)
        {
            int i = 0;
            foreach (Alternativas a in questao.alternativas)
            {
                listAlternativas.Items.Add(a);
                if(a.Reposta)
                    listAlternativas.SetItemChecked(i, true);

                i++;
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        public void MostrarMaterias(List<Materias> materias)
        {
            foreach (Materias m in materias)
                cmbBoxMateria.Items.Add(m);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Materias materia = (Materias)cmbBoxMateria.SelectedItem;
            string enunciado = txtEnunciado.Text.Trim();

            List<Alternativas> alternativas = new List<Alternativas>();

            questao = new Questoes(enunciado, materia, alternativas);
        }

        private void RefatorarAlternativasDinamicamente()
        {
            int i = 0;
            foreach (Alternativas a in listAlternativas.Items)
            {
                a.RefatorarModeloAlternativa(i);
                i++;
            }
        }

    
    }
}
