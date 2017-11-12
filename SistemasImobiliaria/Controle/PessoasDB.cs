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
    class PessoasDB
    {
        public static DataTable getConsultaPessoas(NpgsqlConnection conexao)
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "select * from pessoas";
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

        public static DataTable getConsultaPessoas(NpgsqlConnection conexao, int campo, int tipo, String descricao)
        {
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM pessoas";
                String nomeCampoOrdenacao = "i_pessoas";
                switch (campo)
                {
                    case 0:
                        sql += " where cast (i_pessoas as varchar(20)) ";
                        nomeCampoOrdenacao = "i_pessoas";
                        break;
                    case 1:
                        sql += " where nome ";
                        nomeCampoOrdenacao = "nome";
                        break;
                    case 2:
                        sql += " where genero ";
                        nomeCampoOrdenacao = "genero";
                        break;
                    case 3:
                        sql += " where cpf ";
                        nomeCampoOrdenacao = "cpf";
                        break;
                    default:
                        sql += " where endereco ";
                        nomeCampoOrdenacao = "endereco";
                        break;
                }
                switch (tipo)
                {
                    case 0:
                        sql += "like '%" + descricao + "%'";
                        break;
                    case 1:
                        sql += "like '" + descricao + "%'";
                        break;
                    case 2:
                        sql += "like '%" + descricao + "%'";
                        break;
                    case 3:
                        sql += "= '" + descricao + "'";
                        break;
                    case 4:
                        sql += ">= '" + descricao + "'";
                        break;
                    default:
                        sql += "<= '" + descricao + "'";
                        break;
                }
                sql += " order by " + nomeCampoOrdenacao;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
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

        public static bool setIncluiPessoas(NpgsqlConnection conexao, Pessoas pessoas)
        {
            bool incluiu = false;
            try
            {
                String sql = "insert into pessoas(i_pessoas,genero, cpf, endereco, nome) values(@i_pessoas,@genero, @cpf, @endereco, @nome)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@i_pessoas", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoas.i_pessoas;
                cmd.Parameters.Add("@genero", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.genero;
                cmd.Parameters.Add("@cpf", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.cpf;
                cmd.Parameters.Add("@endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.endereco;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.nome;
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

        public static bool setExcluiPessoas(NpgsqlConnection conexao, int codigo)
        {
            bool excluiu = false;
            try
            {
                String sql = "delete from pessoas where i_pessoas = @codigo";
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

        public static bool setAlteraPessoas(NpgsqlConnection conexao, Pessoas pessoas)
        {
            bool alterou = false;
            try
            {
                String sql = "update pessoas set genero = @genero,endereco = @endereco, nome = @nome where i_pessoas = @codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@genero", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.genero;
                cmd.Parameters.Add("@endereco", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.endereco;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = pessoas.nome;
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = pessoas.i_pessoas;
                int valor = cmd.ExecuteNonQuery();
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





