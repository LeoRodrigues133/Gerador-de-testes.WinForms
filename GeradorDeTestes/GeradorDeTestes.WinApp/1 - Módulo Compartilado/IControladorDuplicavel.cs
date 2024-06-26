using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._1___Módulo_Compartilado
{
    public interface IControladorDuplicavel
    {
        string ToolTipDuplicar { get; }
        
        void Duplicar();
    }
}
