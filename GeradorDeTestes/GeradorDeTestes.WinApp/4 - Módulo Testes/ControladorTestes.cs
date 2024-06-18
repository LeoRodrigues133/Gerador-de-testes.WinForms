using GeradorDeTestes.WinApp._1___Módulo_Compartilado;
using GeradorDeTestes.WinApp._2___Módulo_Disciplina;
using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using GeradorDeTestes.WinApp._3___Módulo_Matérias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._4___Módulo_Testes
{
    public class ControladorTestes : ControladorBase
    {

        private IRepositorioTestes repositorioTeste;
        private TabelaTesteControl tabelaTeste;
        public IRepositorioDisciplina repositorioDisciplina;
        //private IRepositorioQuestao repositorioQuestao;
        private IRepositorioMateria repositorioMateria;

        public ControladorTestes() { } // Ctor para deserialização;
        public ControladorTestes(IRepositorioTestes testeRepositorio, IRepositorioDisciplina disciplinaRepositorio, IRepositorioMateria materiaRepositorio)
        {
            repositorioTeste = testeRepositorio;
            repositorioDisciplina = disciplinaRepositorio;
            repositorioMateria = materiaRepositorio;
        }
        public override string TipoCadastro { get { return "Testes"; } }
        public override string ToolTipAdicionar { get { return "Cadastrar um novo teste"; } }
        public override string ToolTipEditar { get { return "Editar um teste existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um teste existente"; } }

        public override void Adicionar()
        {

            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina, repositorioMateria);

            CarregarDisciplinas(telaTeste);
            CarregarMaterias(telaTeste);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorioTeste.Cadastrar(novoTeste);

            CarregarTestes();

        }

        public override void Editar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(repositorioDisciplina, repositorioMateria);

            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste Selecionado = repositorioTeste.SelecionarPorId(idSelecionado);

            if (Selecionado == null)
            {
                MessageBox.Show(
                 "Não é possível realizar esta ação sem um registro selecionado.",
                 "Aviso",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning
                 ); return;
            }
            telaTeste.Teste = Selecionado;

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Teste testeEditado = telaTeste.Teste;

            repositorioTeste.Editar(testeEditado.Id, testeEditado);

            CarregarTestes();

        }
        public override void Excluir()
        {
            int idSelecionado = tabelaTeste.ObterRegistroSelecionado();

            Teste Selecionado = repositorioTeste.SelecionarPorId(idSelecionado);

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

            repositorioTeste.Excluir(Selecionado.Id);

            CarregarTestes();

        }

        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTeste;
        }
        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(testes);
        }
        void CarregarDisciplinas(TelaTesteForm telaTeste)
        {
            List<Disciplinas> disciplinas = repositorioDisciplina.SelecionarTodos();

            telaTeste.MostrarDisciplinas(disciplinas);
        }

        void CarregarMaterias(TelaTesteForm telaTeste)
        {
            List<Materias> materias = repositorioMateria.SelecionarTodos();

            telaTeste.MostrarMaterias(materias);
        }
    }
}
