using GeradorDeTestes.WinApp._1___Módulo_Compartilado;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class Questoes : EntidadeBase
    {
        public string Enunciado { get; set; }
        Materia Materia { get; set; }

        List<Alternativas> Alternativa;
        public Questoes() { }
        public Questoes(string enunciado, Materia materia, List<Alternativas> alternativa)
        {
            Enunciado = enunciado;
            Materia = materia;
            Alternativa = alternativa;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questoes atualizar = (Questoes)novoRegistro;

            Enunciado = atualizar.Enunciado;
            Materia = atualizar.Materia;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"enunciado\" deve ser preenchido");


            return erros;
        }
    }
}