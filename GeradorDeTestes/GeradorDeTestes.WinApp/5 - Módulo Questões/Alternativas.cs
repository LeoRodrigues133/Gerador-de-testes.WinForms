using GeradorDeTestes.WinApp._1___Módulo_Compartilado;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class Alternativas : EntidadeBase
    {
        public string Resposta { get; set; }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Alternativas atualizar = (Alternativas)novoRegistro;

            Resposta = atualizar.Resposta;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Resposta.Trim()))
                erros.Add("O campo \"reposta\" deve ser preenchido");

            return erros;
        }
    }
}