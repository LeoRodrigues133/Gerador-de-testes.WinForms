using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    public class Teste : EntidadeBase
    {
        public string Titulo {  get; set; }
        public Disciplinas Disciplina;
        //public Materias Materia;
        public string Serie {  get; set; }
        public decimal NumQuestoes {  get; set; }

        public Teste( ) { } //Ctor para Deserializar
        public Teste(string titulo, Disciplinas disciplina,decimal questoes)
        {
            Titulo = titulo;
            Serie = "";
            Disciplina = disciplina;
            NumQuestoes = questoes;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Teste A = (Teste)novoRegistro;

            Titulo = A.Titulo;
            Disciplina = A.Disciplina;
            //Materia = teste.Materia;
            Serie = A.Serie;
            NumQuestoes = A.NumQuestoes;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Titulo.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");


            return erros;
        }
        public bool VerificarRegistros(List<Disciplinas> repositorio, Disciplinas d)
        {

            foreach (Disciplinas D in repositorio)
                if (D.Nome == d.Nome)
                    return false;

            return true;
        }

    }
}
