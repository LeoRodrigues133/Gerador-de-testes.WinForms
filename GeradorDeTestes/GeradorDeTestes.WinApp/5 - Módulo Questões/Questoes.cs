using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._4___Módulo_Testes;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class Questoes : EntidadeBase
    {
        public string Enunciado { get; set; }
        public Materias Materia { get; set; }
        public List<Teste> Testes { get; set; }

        public List<Alternativas> alternativas { get; set; }

        public Questoes() { }

        public Questoes(string enunciado, Materias materia, List<Alternativas> alternativa)
        {
            Enunciado = enunciado;
            Materia = materia;
            alternativas = alternativa;
            Testes = new List<Teste>();

        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questoes atualizar = (Questoes)novoRegistro;

            Enunciado = atualizar.Enunciado;
            Materia = atualizar.Materia;
            alternativas = atualizar.alternativas;
        }
        public Alternativas RespostaValida()
        {
            foreach (Alternativas a in alternativas)
            {
                if (a.Reposta)
                    return a;
            }
            return null;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" deve ser preenchido");


            return erros;
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}