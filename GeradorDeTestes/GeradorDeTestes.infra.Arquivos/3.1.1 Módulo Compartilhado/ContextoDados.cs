using System.Text.Json;
using System.Text.Json.Serialization;
using GeradorDeTestes.Domain.MóduloTestes;
using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Domain.MóduloQuestões;
using GeradorDeTestes.Domain.MóduloDisciplinas;


namespace GeradorDeTestes.Infra.Arquivos.MóduloCompartilhado
{
    public class ContextoDados
    {
        private string caminho = Directory.GetCurrentDirectory().Split("bin")[0] + "\\Dados\\Data.json";


        public List<Disciplinas> Disciplina { get; set; }
        public List<Teste> Teste { get; set; }
        public List<Materias> Materia { get; set; }
        public List<Questoes> Questoes { get; set; }

        public ContextoDados()
        {
            Disciplina = new List<Disciplinas>();
            Teste = new List<Teste>();
            Materia = new List<Materias>();
            Questoes = new List<Questoes>();

        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null)
                return;

            Disciplina = ctx.Disciplina;
            Teste = ctx.Teste;
            Materia = ctx.Materia;
            Questoes = ctx.Questoes;
        }
    }
}
