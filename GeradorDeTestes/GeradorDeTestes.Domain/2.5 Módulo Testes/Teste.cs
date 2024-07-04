using GeradorDeTestes.Domain.MóduloMatérias;
using GeradorDeTestes.Domain.MóduloQuestões;
using GeradorDeTestes.Domain.MóduloDisciplinas;
using GeradorDeTestes.Domain.MóduloCompartilhado;

namespace GeradorDeTestes.Domain.MóduloTestes
{
    public class Teste : EntidadeBase
    {
        public string Titulo { get; set; }
        public Disciplinas Disciplina { get; set; }
        public Materias Materia { get; set; }
        public string Serie { get; set; }
        public decimal NumQuestoes { get; set; }

        public List<Questoes> Questoes { get; set; }

        public Teste() { } //Ctor para Deserializar
        public Teste(string titulo, Disciplinas disciplina, Materias materia, decimal numQuestoes, List<Questoes> q)
        {
            Titulo = titulo;
            Serie = "";
            Disciplina = disciplina;
            Materia = materia;
            NumQuestoes = numQuestoes;
            Questoes = q;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste A = (Teste)novoRegistro;

            Titulo = A.Titulo;
            Disciplina = A.Disciplina;
            Materia = A.Materia;
            Serie = A.Serie;
            NumQuestoes = A.NumQuestoes;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");


            return erros;
        }
        public bool VerificarRegistros(List<Disciplinas> repositorio, Disciplinas d)
        {

            foreach (Disciplinas D in repositorio)
                if (D.Nome == d.Nome)
                    return false;

            return true;
        }
    }
}
