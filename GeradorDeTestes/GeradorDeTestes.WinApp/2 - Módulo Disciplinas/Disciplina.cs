using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; } // Nome da Disciplina (Complicado de achar um nome)

        public Disciplina() { } //Ctor para Deserializar

        public Disciplina(string disciplina)
        {
            Nome = disciplina;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina Atualizar = (Disciplina)novoRegistro;

            Nome = Atualizar.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"disciplina\" precisa ser preenchido");

            return erros;
        }
        public bool VerificarRegistros(List<Disciplina> repositorio, Disciplina d)
        {

            foreach (Disciplina D in repositorio)
                if (D.Nome == d.Nome)
                    return false;

            return true;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
