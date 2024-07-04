namespace GeradorDeTestes.Domain.MóduloCompartilhado
{
    public interface IControladorGeradorPDF
    {
        string ToolTipGerarTestePdf { get; }
        void GerarTeste();
    }
}
