using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace CadastroDeDados.Conexao
{
    class DBConexao
    {
        private string stringConexao = "Data Source=DESKTOP-JKHNGF8\\SQLEXPRESS;Initial Catalog=cadastro;Integrated Security=True;";
        SqlConnection connection;

        public SqlConnection EstabelecerConexao()
        {
            this.connection = new SqlConnection(this.stringConexao);
            return this.connection;
        }



        public bool Conexao(string scriptBD)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = scriptBD;
                command.Connection = this.EstabelecerConexao();
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet ExecutarVerificarSelect(SqlCommand sqlCommand)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand();
                command = sqlCommand;
                command.Connection = EstabelecerConexao();
                sqlDataAdapter.SelectCommand = command;
                connection.Open();
                sqlDataAdapter.Fill(dataSet);
                connection.Close();
                return dataSet;
            }
            catch
            {
                return dataSet;
            }

        }
    }
}
