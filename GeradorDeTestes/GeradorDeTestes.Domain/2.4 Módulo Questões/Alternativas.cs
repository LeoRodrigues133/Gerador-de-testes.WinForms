namespace GeradorDeTestes.Domain.MóduloQuestões
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

        public void RefatorarModeloAlternativa(int i)
        {
            if (Enunciado.Contains(":"))
                Enunciado = Enunciado.Split(" ")[2];
            Enunciado = $"{(char)(97 + i)} : {Enunciado}";
        }

        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}