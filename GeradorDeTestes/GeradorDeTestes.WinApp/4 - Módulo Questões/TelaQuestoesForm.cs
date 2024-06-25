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
        Alternativas alternativa;
        public Questoes Questao
        {
            set
            {
                cmbBoxMateria.SelectedItem = value.Materia;
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
            string resposta = txtAlternativa.Text;

            if (string.IsNullOrEmpty(resposta))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar uma alternativa vazia.");
                return;
            }

            alternativa = new Alternativas(resposta);


            listAlternativas.Items.Add(alternativa);

            EnumerarAlternativa();

            txtAlternativa.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listAlternativas.Items.Remove(listAlternativas.SelectedItem);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {


            Materias materia = (Materias)cmbBoxMateria.SelectedItem;

            string enunciado = txtEnunciado.Text.Trim();

            List<Alternativas> alternativas = listAlternativas.Items.Cast<Alternativas>().ToList();

            foreach (Alternativas a in listAlternativas.CheckedItems)
            {
                a.Resposta = true;
            }

            if (listAlternativas.CheckedItems.Count != 1)
            {
                MessageBox.Show(
                    "Selecione UMA resposta para o enunciado!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    ); return;
            }

            questao = new Questoes(enunciado, materia, alternativas);


        }

        private void EnumerarAlternativa()
        {
            int i = 0;
            foreach (Alternativas a in listAlternativas.Items)
            {
                a.RefatorarModeloAlternativa(i);
                i++;
            }
        }

        public void MostrarMaterias(List<Materias> materias)
        {
            foreach (Materias m in materias)
                cmbBoxMateria.Items.Add(m);
        }

        public void CarregarMaterias(List<Materias> materias)
        {
            cmbBoxMateria.Items.Clear();

            foreach (Materias m in materias)
                cmbBoxMateria.Items.Add(m);
            if (questao != null)
                cmbBoxMateria.SelectedItem = questao.Materia;
        }

    }
}
