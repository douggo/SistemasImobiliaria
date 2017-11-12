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
    class AlugueisDB
    {

        public static DataTable getConsultaAlugueis(NpgsqlConnection conexao)
        {
            DataTable dt = new DataTable();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "select * from alugueis";
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

        public static DataTable getConsultaAlugueis(NpgsqlConnection conexao, int campo, int tipo, String descricao)
        {
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM alugueis";
                String nomeCampoOrdenacao = "i_pagamentos";
                switch (campo)
                {
                    case 0:
                        sql += " where cast (i_pagamentos as varchar(20)) ";
                        nomeCampoOrdenacao = "i_pagamentos";
                        break;
                    case 1:
                        sql += " where cast (i_imoveis as varchar(20)) ";
                        nomeCampoOrdenacao = "i_imoveis";
                        break;
                    case 2:
                        sql += " where cast (i_pessoas as varchar(20)) ";
                        nomeCampoOrdenacao = "i_pessoas";
                        break;
                    default:
                        sql += " where cast (i_alugueis as varchar(20)) ";
                        nomeCampoOrdenacao = "i_alugueis";
                        break;
                }
                switch (tipo)
                {
                    case 0:
                        sql += " like '%" + descricao + "%'";
                        break;
                    case 1:
                        sql += " like '" + descricao + "%'";
                        break;
                    case 2:
                        sql += " like '%" + descricao + "'";
                        break;
                    case 3:
                        sql += " = '" + descricao + "'";
                        break;
                    case 4:
                        sql += " >= '" + descricao + "'";
                        break;
                    default:
                        sql += " <= '" + descricao + "'";
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

        public static bool setIncluiAlugueis(NpgsqlConnection conexao, Alugueis alugueis)
        {
            bool incluiu = false;
            try
            {
                String sql = "insert into alugueis(i_alugueis,i_imoveis, i_pessoas, i_pagamentos) values(@i_alugueis,@i_imoveis, @i_pessoas, @i_pagamentos)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@i_alugueis", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_alugueis;
                cmd.Parameters.Add("@i_imoveis", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_imoveis;
                cmd.Parameters.Add("@i_pessoas", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_pessoas;
                cmd.Parameters.Add("@i_pagamentos", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_pagamentos;

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

        public static bool setExcluiAlugueis(NpgsqlConnection conexao, int codigo, int i_imoveis, int i_pagamentos, int i_pessoas)
        {
            bool excluiu = false;
            try
            {
                String sql = "delete from alugueis where i_alugueis = @codigo and i_pagamentos = @pagamentos and i_imoveis = @imoveis and i_pessoas = @pessoas";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = codigo;
                cmd.Parameters.Add("@pagamentos", NpgsqlTypes.NpgsqlDbType.Integer).Value = i_pagamentos;
                cmd.Parameters.Add("@imoveis", NpgsqlTypes.NpgsqlDbType.Integer).Value = i_imoveis;
                cmd.Parameters.Add("@pessoas", NpgsqlTypes.NpgsqlDbType.Integer).Value = i_pessoas;
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

        public static bool setAlteraAlugueis(NpgsqlConnection conexao, Alugueis alugueis)
        {
            bool alterou = false;
            try
            {
                String sql = "update alugueis set i_pagamentos = @i_pagamentos,i_imoveis = @i_imoveis, i_pessoas = @i_pessoas where i_alugueis = @codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@i_pagamentos", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_pagamentos;
                cmd.Parameters.Add("@i_imoveis", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_imoveis;
                cmd.Parameters.Add("@codigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_alugueis;
                cmd.Parameters.Add("@i_pessoas", NpgsqlTypes.NpgsqlDbType.Integer).Value = alugueis.i_pessoas;

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

