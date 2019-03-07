using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer
{
    public class VeiculoRepositorio : RepositorioBase
    {
        public void Inserir(Veiculo veiculo)
        {
            using (var conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("pVeiculo_INS", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddRange(Mapear(veiculo).ToArray());

                    comando.ExecuteNonQuery();
                }

                //conexao.Close();
                //conexao.Dispose();
            }
        }

        private List<SqlParameter> Mapear(Veiculo veiculo)
        {
            var parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@placa", veiculo.Placa));
            parametros.Add(new SqlParameter("@modelo", veiculo.Modelo.Nome));
            parametros.Add(new SqlParameter("@cor", veiculo.Cor.Nome));
            parametros.Add(new SqlParameter("@ano", veiculo.Ano));
            parametros.Add(new SqlParameter("@codigoCliente", 1));

            return parametros;
        }
    }
}
