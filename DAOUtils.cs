sing System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaADONET.NovaPasta
{
    public internal class DAOUtils
    {
    public static DbConnection getConexao()
        {
            DbConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS; Database=TreinaWebCSharpIntermediario; User Id=sa; Password=myPassword");
            conexao.Open();
            return conexao;

        }
        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }
        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader()
        }
    }
}
