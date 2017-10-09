using Npgsql;
using SistemasImobiliaria.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasImobiliaria.Controle
{
    class ImoveisDB
    {
        public static DataTable getConsultaImoveis(NpgsqlConnection conexao)
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "select * from imoveis";
                NpgsqlDataAdapter dat = new NpgsqlDataAdapter(cmd);
                dat.Fill(dt);
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL:" + erro.Message);
                Console.WriteLine("Erro de SQL:" + erro.Message);
            }

            return dt;
        }

        public static bool setIncluiImoveis(NpgsqlConnection conexao, Imoveis imoveis)
        {
            bool incluiu = false;
            try
            {
                String sql = "insert into imoveis(i_imoveis,endereco, cidade, estado) values(@i_imoveis,@endereco, @cidade, @estado)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@i_imoveis", NpgsqlTypes.NpgsqlDbType.Integer).Value = imoveis.i_imoveis;
                cmd.Parameters.Add("@endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = imoveis.endereco ;
                cmd.Parameters.Add("@cidade", NpgsqlTypes.NpgsqlDbType.Varchar).Value = imoveis.cidade;
                cmd.Parameters.Add("@estado", NpgsqlTypes.NpgsqlDbType.Varchar).Value = imoveis.estado;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    incluiu = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL:" + erro.Message);
                Console.WriteLine("Erro de SQL:" + erro.Message);
            }
            return incluiu;
        }

        public static bool setExcluiImoveis(NpgsqlConnection conexao, int codigo)
        {
            bool excluiu = false;
            try
            {
                String sql = "delete from imoveis where i_imoveis = @codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1)
                {
                    excluiu = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de sql:" + erro.Message);
                Console.WriteLine("Erro de sql:" + erro.Message);
            }
            return excluiu;
        }

        public static bool setAlteraImoveis(NpgsqlConnection conexao, Imoveis imoveis)
        {
            bool alterou = false;
            try
            {
                String sql = "update imoveis set endereco = @endereco,cidade = @cidade, estado =@estado where i_imoveis = @codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = imoveis.endereco;
                cmd.Parameters.Add("@cidade", NpgsqlTypes.NpgsqlDbType.Varchar).Value = imoveis.cidade;
                cmd.Parameters.Add("@estado", NpgsqlTypes.NpgsqlDbType.Varchar).Value = imoveis.estado;
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = imoveis.i_imoveis;
                int valor = cmd.ExecuteNonQuery() ;
                if (valor == 1)
                {
                    alterou = true;
                }
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de sql:" + erro.Message);
                Console.WriteLine("Erro de sql:" + erro.Message);
            }
            return alterou;
        }
    }
}
