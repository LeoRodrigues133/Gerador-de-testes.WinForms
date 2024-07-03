using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._2___Módulo_Disciplinas
{
    public class RepositorioDisciplinasSQL : IRepositorioDisciplina
    {

        string ConnectionString;

        public RepositorioDisciplinasSQL()
        {
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorDeTesteBD;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
        }

        public void Cadastrar(Disciplinas novaDisciplina)
        {
            string InsertIntoQuery =
                @"INSERT INTO [TBDisciplinas]
                        (
                                [NOME] = @NOME; 
                        ) SELECT SCOPE_IDENTITY();";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand InsertCommand = new SqlCommand(InsertIntoQuery, DataConnection);

            ConfigureParamenters(novaDisciplina, InsertCommand);

            DataConnection.Open();

            object id = InsertCommand.ExecuteScalar();

            novaDisciplina.Id = Convert.ToInt32(id);

            DataConnection.Close();
        }

        public bool Editar(int id, Disciplinas atualizarDisciplina)
        {
            string SelectQuery =
                 @"UPDATE [TBDisciplinas]   
                        SET
                            [NOME] = @NOME
                        WHERE
                            [ID] = @ID;
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand UpdateCommand = new SqlCommand(SelectQuery, DataConnection);

            atualizarDisciplina.Id = id;

            ConfigureParamenters(atualizarDisciplina, UpdateCommand);

            DataConnection.Open();

            int numeroDeRegistrosAfetador = UpdateCommand.ExecuteNonQuery();

            DataConnection.Close();

            if (numeroDeRegistrosAfetador < 1)
                return false;

            return true;
        }

        public bool Excluir(int id)
        {
            string DeleteQuery =
                @"DELETE FROM [TBDisciplinas]
                        WHERE
                            [ID] = @ID;
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, DataConnection);

            DeleteCommand.Parameters.AddWithValue("ID", id);

            DataConnection.Open();

            int numeroDeRegistrosExcluidos = DeleteCommand.ExecuteNonQuery();

            DataConnection.Close();

            if (numeroDeRegistrosExcluidos < 1)
                return false;

            return true;
        }
        public List<Disciplinas> SelecionarTodos()
        {
            string selectAll =
                @"SELECT *
                        FROM
                            [TBDisciplinas]
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand selectCommand = new SqlCommand(selectAll, DataConnection);

            DataConnection.Open();

            SqlDataReader disciplinaReader = selectCommand.ExecuteReader();

            List<Disciplinas> disciplinas = new List<Disciplinas>();

            while (disciplinaReader.Read())
            {
                Disciplinas d = disciplinaConverter(disciplinaReader);
                disciplinas.Add(d);
            }
            DataConnection.Close();

            return disciplinas;
        }

        public Disciplinas SelecionarPorId(int id)
        {
            string SelectQuery =
                 @"SELECT *
                        FROM
                            [TBDisciplinas]
                        WHERE
                            [ID] = @ID;
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand selectCommand = new SqlCommand(SelectQuery, DataConnection);

            selectCommand.Parameters.AddWithValue("ID", SelectQuery);

            DataConnection.Open();

            SqlDataReader disciplinaReader = selectCommand.ExecuteReader();

            List<Disciplinas> disciplinas = new List<Disciplinas>();

            Disciplinas d = null;

            if (disciplinaReader.Read())
                d = disciplinaConverter(disciplinaReader);

            DataConnection.Close();

            return d;
        }

        Disciplinas disciplinaConverter(SqlDataReader reader)
        {

            Disciplinas d = new Disciplinas()
            {
                Id = Convert.ToInt32(reader["ID"]),
                Nome = Convert.ToString(reader["NOME"])
            };

            return d;
        }

        void ConfigureParamenters(Disciplinas d, SqlCommand command)
        {

            command.Parameters.AddWithValue("ID", d.Id);
            command.Parameters.AddWithValue("NOME", d.Nome);

        }
    }
}
