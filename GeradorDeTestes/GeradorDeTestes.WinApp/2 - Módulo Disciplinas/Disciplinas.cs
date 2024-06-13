using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplina
{
    public class Disciplinas : EntidadeBase
    {
         public string Disciplina { get; set; } // Nome da Disciplina (Complicado de achar um nome)

        public Disciplinas(string disciplina)
        {
            Disciplina = disciplina;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplinas Atualizar = (Disciplinas)novoRegistro;

            Disciplina = Atualizar.Disciplina;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Disciplina.Trim()))
                erros.Add("O campo \"disciplina\" precisa ser preenchido");

            return erros;
        }
    }
}
