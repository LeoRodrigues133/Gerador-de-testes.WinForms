using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._5___Módulo_Questões;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
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
using System.Xml.Linq;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    public partial class TelaGerarPDFForm : Form
    {
        private string caminho = "";
        public string Caminho { get { return caminho; } }
        public string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        private string conteudoPdf = "";
        public Teste testeSelecionado;
        public List<Materias> materias;
        public List<Disciplinas> disciplinas;
        public List<Questoes> questoes;
        
        public TelaGerarPDFForm(Teste testeSelecionado, List<Disciplinas> disciplinas, List<Materias> materias, List<Questoes> questoes)
        {
            InitializeComponent();
            this.testeSelecionado = testeSelecionado;
            this.materias = materias;
            this.disciplinas = disciplinas;
            this.questoes = questoes;
        }

        private void GerarPDF(string caminho)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header().Text(testeSelecionado.Titulo).SemiBold().FontSize(30).AlignCenter().FontFamily(Fonts.SegoeUI);

                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x => { x.Item().Text(conteudoPdf).FontSize(11); });
                });
            }).GeneratePdf(caminho);
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
            ConfigurarPDF();

            caminho = "";

            if (checkBoxGabarito.Checked)
                caminho = $"{path}\\ProvaComGabarito.pdf";
            else
                caminho = $"{path}\\Prova.pdf";

            if (!File.Exists(caminho))
            {
                GerarPDF(caminho);
                return;
            }

            DialogResult resposta = MessageBox.Show("O arquivo PDF já existe! Deseja substitui-lo?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
            {
                DialogResult = DialogResult.None;
                return;
            }

            GerarPDF(caminho);
        }

        private void ConfigurarPDF()
        {
            foreach (Disciplinas d in disciplinas)
            {
                if (d.Id == testeSelecionado.Disciplina.Id)
                    conteudoPdf += $"Disciplina: {d}.\n";
            }

            foreach (Materias m in materias)
            {
                if (m.Id == testeSelecionado.Materia.Id)
                    conteudoPdf += $"Matéria: {m}.\n\n";
            }

            int numeroQuestao = 1;
            conteudoPdf += "\n\n";

            foreach (Questoes questao in testeSelecionado.questoes)
            {
                if (questoes.Find(q => q.Id == questao.Id) != null)
                {
                    conteudoPdf += $"{numeroQuestao}) {questao}\n";
                    numeroQuestao++;

                    foreach (Alternativas alternativa in questao.Alternativas)
                    {
                        if (checkBoxGabarito.Checked && alternativa.Resposta)
                            conteudoPdf += $"(X) {alternativa}\n";
                        else
                            conteudoPdf += $"( ) {alternativa}\n";
                    }

                    conteudoPdf += "\n";
                }
            }
        }
    }
}

