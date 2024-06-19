using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class ControladorQuestoes : ControladorBase
    {
        IRepositorioQuestoes iRepositorio;
        TabelaQuestoesControl tabelaQuestoes;
        public override string TipoCadastro { get { return "Questões"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão"; } }

        public override void Adicionar()
        {
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            DialogResult resultado = telaQuestoes.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Questoes novaQuestao = telaQuestoes.Questao;

            iRepositorio.Cadastrar(novaQuestao);

            CarregarQuestoes();

        }

        private void CarregarQuestoes()
        {
            List<Questoes> questaos = iRepositorio.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questaos);
        }

        public override void Editar()
        {
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            int idSelecionado = tabelaQuestoes.ObterRegistroSelecionado();

            Questoes Selecionado = iRepositorio.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                MessageBox.Show(
                             "Não é possível realizar esta ação sem um registro selecionado.",
                             "Aviso",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning
                     ); return;
            }

            telaQuestoes.Questao = Selecionado;


            DialogResult resultado = telaQuestoes.ShowDialog();

            if (resultado != DialogResult.OK) return;


            Questoes questaoEditada = telaQuestoes.Questao;

            iRepositorio.Editar(idSelecionado, questaoEditada);
            CarregarQuestoes();
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaQuestoes.ObterRegistroSelecionado();

            Questoes Selecionado = iRepositorio.SelecionarPorId(idSelecionado);

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
               MessageBoxIcon.Warning
               );

            iRepositorio.Excluir(idSelecionado);
            CarregarQuestoes();


        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        private void CarregarMaterias()
        {
            List<Questoes>  questoes = iRepositorio.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);
        }
    }
}
