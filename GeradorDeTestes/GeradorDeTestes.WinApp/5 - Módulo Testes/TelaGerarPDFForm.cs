using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._5___Módulo_Questões;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    public partial class TelaGerarPDFForm : Form
    {
        string conteudoPdf = "";
        string caminho = "";
        public string Caminho { get { return caminho; } }

        public string path = Directory.GetCurrentDirectory().Split("bin")[0] + "\\Dados";

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
                caminho = $"{path}\\{testeSelecionado.Titulo}-{testeSelecionado.Disciplina}-Gabarito.pdf";
            else
                caminho = $"{path}\\{testeSelecionado.Titulo}-{testeSelecionado.Disciplina}.pdf";

            if (!File.Exists(caminho))
            {
                GerarPDF(caminho);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "O arquivo PDF já existe! Deseja substitui-lo?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

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
                if (d.Id == testeSelecionado.Disciplina.Id)
                    conteudoPdf += $"Disciplina: {d}.\n";

            if (testeSelecionado.Materia == null)
                conteudoPdf += $"Recuperação: \n\n";
            else
            {
                foreach (Materias m in materias)
                    if (m.Id == testeSelecionado.Materia.Id)
                        conteudoPdf += $"Matéria: {m}.\n\n";
            }

            conteudoPdf += "\n\n";

            foreach (Questoes questao in testeSelecionado.Questoes)
            {
                if (questoes.Find(q => q.Id == questao.Id) != null)
                {
                    conteudoPdf += $" {questao}\n";

                    if (checkBoxGabarito.Checked == true)
                        conteudoPdf += $"Alternativa correta é {questao.Alternativas.FirstOrDefault(x => x.Resposta)}";
                    else
                        foreach (Alternativas alternativa in questao.Alternativas)
                            conteudoPdf += $"(    ) {alternativa}\n";


                    conteudoPdf += "\n";
                }
            }
        }
    }
}

