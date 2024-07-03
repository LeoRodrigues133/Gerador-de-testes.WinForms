using GeradorDeTestes.WinApp._2___Módulo_Disciplinas;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp._3___Módulo_Matérias
{
    public class RepositorioMateriasSQL : IRepositorioMateria
    {

        string ConnectionString;

        public RepositorioMateriasSQL()
        {
            ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorDeTesteBD;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
        }

        public void Cadastrar(Materias novaMateria)
        {
            string InsertIntoQuery =
                           @"INSERT INTO [TBDisciplinas]
                        (
                                [NOME],
                                [DISCIPLINA],
                                [SERIE]
                        )
                            VALUES
                        (
                                @NOME,
                                @DISCIPLINA,
                                @SERIE,
                        )       SELECT SCOPE_IDENTITY();";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand InsertCommand = new SqlCommand(InsertIntoQuery, DataConnection);

            ConfigureParamenters(novaMateria, InsertCommand);

            DataConnection.Open();

            object id = InsertCommand.ExecuteScalar();

            novaMateria.Id = Convert.ToInt32(id);

            DataConnection.Close();

        }

        public bool Editar(int id, Materias atualizarMateria)
        {
            string UpdateQuery =
                                 @"UPDATE [TBDisciplinas]   
                        SET
                            [NOME] = @NOME,
                            [DISCIPLINA] = @DISCIPLINA,
                            [SERIE] = @SERIE
                        WHERE
                            [ID] = @ID;
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand UpdateCommand = new SqlCommand(UpdateQuery, DataConnection);

            atualizarMateria.Id = id;

            ConfigureParamenters(atualizarMateria, UpdateCommand);

            DataConnection.Open();

            int findResponse = UpdateCommand.ExecuteNonQuery();

            DataConnection.Close(); 
            if (findResponse < 1)
                return false;

            return true;

        }

        public bool Excluir(int id)
        {
            string DeleteQuery =
                                @"DELETE FROM [TBMaterias]
                        WHERE
                            [ID] = @ID;
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand DeleteCommand = new SqlCommand(DeleteQuery, DataConnection);

            DataConnection.Open();

            int findResponse = DeleteCommand.ExecuteNonQuery();

            DataConnection.Close();

            if(findResponse < 1)
                return false;

            return true;
        }

        public Materias SelecionarPorId(int id)
        {
            string selectAll =
                 @"SELECT *
                        FROM
                            [TBMaterias]
                        WHERE
                            [ID] = @ID
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand selectCommand = new SqlCommand(selectAll, DataConnection);

            DataConnection.Open();

            SqlDataReader Reader = selectCommand.ExecuteReader();

            List<Materias> materias = new List<Materias>();

            Materias m = null;

            if (Reader.Read())
                m = materiaConverter(Reader);

            DataConnection.Close();

            return m;
        }

        public List<Materias> SelecionarTodos()
        {
            string selectAll =
                 @"SELECT *
                        FROM
                            [TBMaterias]
                    ";

            SqlConnection DataConnection = new SqlConnection(ConnectionString);

            SqlCommand selectCommand = new SqlCommand(selectAll, DataConnection);

            DataConnection.Open();

            SqlDataReader Reader = selectCommand.ExecuteReader();

            List<Materias> materias = new List<Materias>();

            while (Reader.Read())
            {
                Materias m = materiaConverter(Reader);
                materias.Add(m);
            }
            DataConnection.Close();

            return materias;
        }

        Materias materiaConverter(SqlDataReader reader)
        {

            Materias m = new Materias()
            {
                Id = Convert.ToInt32(reader["ID"]),
                Nome = Convert.ToString(reader["NOME"]),
                Disciplina = (Disciplinas)reader["DISCIPLINAS"],
                Serie = Convert.ToInt32(reader["SERIE"])
            };

            return m;
        }

        void ConfigureParamenters(Materias m, SqlCommand command)
        {

            command.Parameters.AddWithValue("ID", m.Id);
            command.Parameters.AddWithValue("NOME", m.Nome);
            command.Parameters.AddWithValue("DISCPLINA", m.Disciplina);
            command.Parameters.AddWithValue("SERIE", m.Serie);

        }
    }
}

