using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._4___Módulo_Testes;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class Questoes : EntidadeBase
    {
        public string Enunciado { get; set; }
        public Materias Materia { get; set; }
        public List<Alternativas> Alternativas { get; set; } = new List<Alternativas>();

        public Questoes() { }

        public Questoes(string enunciado, Materias materia, List<Alternativas> alternativas)
        {
            Enunciado = enunciado;
            Materia = materia;
            Alternativas = alternativas;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questoes atualizar = (Questoes)novoRegistro;

            Enunciado = atualizar.Enunciado;
            Materia = atualizar.Materia;
            Alternativas = atualizar.Alternativas;
        }
        public Alternativas RespostaValida()
        {
            foreach (Alternativas a in Alternativas)
            {
                if (a.Resposta == true)
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
        
        public void ModeloQuestao(int i)
        {
            if (Enunciado.Contains(" )"))
                Enunciado = Enunciado.Split(") ")[1];
            Enunciado = $"{(i)} ) {Enunciado}";
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}