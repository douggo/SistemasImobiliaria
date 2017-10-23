using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.modelo
{
    public class Conexao
    {
        public static NpgsqlConnection getConexao()
        {
            NpgsqlConnection conexao = null;
            try
            {
                //conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=unidavi;Database=sistema_gestao_imobiliaria;");
                conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=imobiliaria;");
                conexao.Open();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de conexão:" + erro.Message);
                Console.WriteLine("Erro de conexão:" + erro.Message);
            }
            return conexao;
        }

        public static void setFecharConexao(NpgsqlConnection conexao)
        {
            if (conexao != null)
            {
                try
                {
                    conexao.Close();
                }
                catch (NpgsqlException erro)
                {
                    MessageBox.Show("Erro fechar conexão:" + erro.Message);
                    Console.WriteLine("Erro fechar conexão:" + erro.Message);
                }
            }
        }
    }
}
