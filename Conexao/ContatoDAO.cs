using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CadastroDeDados.Conexao
{
    class ContatoDAO
    {
        DBConexao connect;

        public ContatoDAO()
        {
            connect = new DBConexao();
        }

        public bool inserir(Contato contato)
        {
            return connect.Conexao($"INSERT INTO contato (nome, sexo, data, cidade) values ('{contato.nome}', '{contato.sexo}', '{contato.data}', '{contato.cidade}')");
        }

        public int Delete(int id)
        {
            connect.Conexao($"DELETE FROM contato WHERE cod_contato=" + id);
            return 1;
        }

        public DataSet Buscar()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contato");

            return connect.ExecutarVerificarSelect(command);

        }

        public int Update(Contato contato)
        {
           connect.Conexao($"UPDATE contato SET nome='{contato.nome}', sexo='{contato.sexo}', cidade='{contato.cidade}' WHERE cod_contato = {contato.cod_contato}");
           return 1;
        }




    }
}
