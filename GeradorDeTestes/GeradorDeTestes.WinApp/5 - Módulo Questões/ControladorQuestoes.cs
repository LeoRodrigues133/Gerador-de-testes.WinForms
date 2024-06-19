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

namespace GeradorDeTestes.WinApp._5___Módulo_Questões
{
    public class ControladorQuestoes : ControladorBase
    {
        IRepositorioQuestoes repositorioQuestoes;
        TabelaQuestoesControl tabelaQuestoes;
        private IRepositorioTestes repositorioTestes;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioMateria repositorioMaterias;

        public override string TipoCadastro { get { return "Questões"; } }

        public override string ToolTipAdicionar { get { return "Adicionar uma nova questão"; } }

        public override string ToolTipEditar { get { return "Editar uma questão existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma questão"; } }



        public ControladorQuestoes(IRepositorioTestes testeRepositorio, IRepositorioDisciplina disciplinaRepositorio, IRepositorioMateria materiaRepositorio,IRepositorioQuestoes questoesRepositorio)
        {
            repositorioTestes = testeRepositorio;
            repositorioDisciplina = disciplinaRepositorio;
            repositorioMaterias = materiaRepositorio;
            repositorioQuestoes = questoesRepositorio;
            
            AtualizarRodape();
        }

        public override void Adicionar()
        {
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            CarregarMaterias(telaQuestoes);
            
            DialogResult resultado = telaQuestoes.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Questoes novaQuestao = telaQuestoes.Questao;

            repositorioQuestoes.Cadastrar(novaQuestao);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaQuestao.Enunciado}\" foi criado com sucesso!");


        }

        private void CarregarQuestoes()
        {
            List<Questoes> questaos = repositorioQuestoes.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questaos);
        }

        public override void Editar()
        {
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            CarregarMaterias(telaQuestoes);


            int idSelecionado = tabelaQuestoes.ObterRegistroSelecionado();

            Questoes Selecionado = repositorioQuestoes.SelecionarPorId(idSelecionado);

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

            repositorioQuestoes.Editar(idSelecionado, questaoEditada);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{questaoEditada.Enunciado}\" foi editado com sucesso!");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaQuestoes.ObterRegistroSelecionado();

            Questoes Selecionado = repositorioQuestoes.SelecionarPorId(idSelecionado);

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

            repositorioQuestoes.Excluir(idSelecionado);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{Selecionado.Enunciado}\" foi excluído com sucesso!");

        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            List<Questoes> questoes = repositorioQuestoes.SelecionarTodos();

            CarregarQuestoes();

            return tabelaQuestoes;
        }
        private void AtualizarRodape()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {repositorioQuestoes.SelecionarTodos().Count} registro(s)...");
        }
        void CarregarMaterias(TelaQuestoesForm telaQuestoes)
        {
            List<Materias> materias = repositorioMaterias.SelecionarTodos();

            telaQuestoes.MostrarMaterias(materias);
        }
    }
}
