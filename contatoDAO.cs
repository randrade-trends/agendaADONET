using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaADONET.NovaPasta
{
    public class contatoDAO
    {
    public DataSet GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType() = CommandType.Text;
            comando.CommandText = "SELECT * FROM CONTATOS";
            DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "contatos");
            return ds;
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            datatable.Load(reader);
            return datatable;

        }

        public void Excluir(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CONTATOS WHERE ID = ?id";
            comando.Parameters.Add(new SqlParameter("?id", id));
            comando.ExecuteNonQuery();
        }
        public void Inserir(Contato contato)
        {
            DbConnection conexao = DAOUtils.getConexao();
            DbCommand comando = DAOUtils.GetComando();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CONATOS (NOME, EMAIL, TELEFONE) VALUES (@nome, @email, @telefone)";
            comando.Parameters.Add(SqlParameter("@nome", contato.Nome));
            comando.Parameters.Add(SqlParameter("@email", contato.Email);
            comando.Parameters.Add(SqlParameter("@telefone", contato.Telefone));
            comando.ExecuteNonQuery();
        }
        public void Atualizar(Contato contato)
        {
            DbConnection conexao = DAOUtils.getConexao();
            DbCommand comando = DAOUtils.GetComando();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CONTATOS SET NOME = @nome, EMAIL = @email, TELEFONE = @telefone WHERE ID = @id";
            comando.Parameters.Add(SqlParameter("@nome", contato.Nome));
            comando.Parameters.Add(SqlParameter("@email", contato.Email);
            comando.Parameters.Add(SqlParameter("@telefone", contato.Telefone));
            comando.Parameters.Add(SqlParameter("@id", contato.id));
            comando.ExecuteNonQuery();
        }

    }
}
