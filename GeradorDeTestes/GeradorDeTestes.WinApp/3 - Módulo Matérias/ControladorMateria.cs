using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using GeradorDeTestes.WinApp._4___Módulo_Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._3___Módulo_Matérias
{
    public class ControladorMateria : ControladorBase
    {
        public IRepositorioMateria repositorioMaterias;
        public IRepositorioDisciplina repositorioDisciplina;
        TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioMateria materiasRepositorio, IRepositorioDisciplina disciplinaRepositorio)
        {
            repositorioMaterias = materiasRepositorio;
            repositorioDisciplina = disciplinaRepositorio;
        }


        public override string TipoCadastro { get { return "Matérias"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova Matéria"; } }

        public override string ToolTipEditar { get { return "Editar uma Matéria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma Matéria"; } }

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            CarregarDisciplinas(telaMateria);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Materias novaMateria = telaMateria.Materia;

            repositorioMaterias.Cadastrar(novaMateria);

            CarregarMaterias();
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            CarregarDisciplinas(telaMateria);

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materias Selecionado = repositorioMaterias.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                MessageBox.Show(
                 "Não é possível realizar esta ação sem um registro selecionado.",
                 "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning
                 ); return;
            }

            telaMateria.Materia= Selecionado;

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Materias materiaEditada = telaMateria.Materia;

            repositorioMaterias.Editar(materiaEditada.Id, materiaEditada);

            CarregarMaterias();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materias Selecionado = repositorioMaterias.SelecionarPorId(idSelecionado);
            if (Selecionado == null)
            {
                MessageBox.Show(
                 "Não é possível realizar esta ação sem um registro selecionado.",
                 "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning
                 ); return;
            }
            DialogResult resultado = MessageBox.Show(
               $"Você deseja realmente excluir o registro \"{Selecionado.Id}\"?",
               "Confirmar Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            repositorioMaterias.Excluir(Selecionado.Id);
            CarregarMaterias();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }

        private void CarregarMaterias()
        {
            List<Materias> materias = repositorioMaterias.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }

        public void CarregarDisciplinas(TelaMateriaForm telaMateria)
        {
            List<Disciplinas> disciplinas = repositorioDisciplina.SelecionarTodos();

            telaMateria.MostrarDisciplinas(disciplinas);
        }
    }
}
