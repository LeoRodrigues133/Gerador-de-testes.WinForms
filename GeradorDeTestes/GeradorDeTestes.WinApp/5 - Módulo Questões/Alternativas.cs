using GeradorDeTestes.WinApp._1___Módulo_Compartilado;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class Alternativas
    {
        public string Enunciado { get; set; }

        public bool Reposta {  get; set; }

        public Alternativas(string enunciado)
        {
            Enunciado = enunciado;
            Reposta = false;
        }

        public void RefatorarModeloAlternativa(int count)
        {
            if (Enunciado.Contains(":"))
                Enunciado = Enunciado.Split(" ")[2];
            Enunciado = $"({(char)(65 + count)}) : {Enunciado}";
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}