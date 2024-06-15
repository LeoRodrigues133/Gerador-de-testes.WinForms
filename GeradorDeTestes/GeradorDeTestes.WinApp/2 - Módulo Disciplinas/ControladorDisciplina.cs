using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        IRepositorioDisciplina iRepositorio;
        TabelaDisciplinasControl tabelaDisciplinas;

        public ControladorDisciplina(IRepositorioDisciplina repositorio)
        {
            iRepositorio = repositorio;
        }
        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma disciplina"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(iRepositorio.SelecionarTodos());

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Disciplinas novaDisciplina = telaDisciplina.Disciplina;

            iRepositorio.Cadastrar(novaDisciplina);

            CarregarDisciplinas();

        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(iRepositorio.SelecionarTodos());

            int idSelecionado = tabelaDisciplinas.ObterRegistroSelecionado();

            Disciplinas Selecionado = iRepositorio.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                MessageBox.Show(
                 "Não é possível realizar esta ação sem um registro selecionado.",
                 "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning
                 ); return;
            }

            telaDisciplina.Disciplina = Selecionado;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Disciplinas disciplinaEditada = telaDisciplina.Disciplina;

            iRepositorio.Editar(disciplinaEditada.Id, disciplinaEditada);
            CarregarDisciplinas();

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplinas.ObterRegistroSelecionado();

            Disciplinas Selecionado = iRepositorio.SelecionarPorId(idSelecionado);
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

            iRepositorio.Excluir(Selecionado.Id);
            CarregarDisciplinas();

        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplinas == null)
                tabelaDisciplinas = new TabelaDisciplinasControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }
        private void CarregarDisciplinas()
        {
            List<Disciplinas> disciplinas = iRepositorio.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);
        }

   
    }
}
