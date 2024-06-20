using GeradorDeTestes.WinApp._1___Módulo_Compartilado;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class Alternativas
    {
        public string Enunciado { get; set; }

        public bool Resposta { get; set; }

        public Alternativas(string enunciado)
        {
            Enunciado = enunciado;
            Resposta = false;
        }

        public void RefatorarModeloAlternativa(int count)
        {
            if (Enunciado.Contains(":"))
                Enunciado = $"{(char)(97 + count)} : {Enunciado}";
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}