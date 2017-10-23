using Npgsql;
using SistemasImobiliaria.Controle;
using SistemasImobiliaria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasImobiliaria
{
    public partial class FrmIncluiAlugueis : Form
    {
        internal NpgsqlConnection conexao = null;

        public FrmIncluiAlugueis(NpgsqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aluguelID = int.Parse(tbAluguel.Text);
            int imovelID = int.Parse(tbImovel.Text);
            int pessoaID = int.Parse(tbPessoa.Text);
            int pagamentoID = int.Parse(tbPagamento.Text);

            Alugueis alugueis = new Alugueis();
            alugueis.i_alugueis = aluguelID;
            alugueis.i_imoveis = imovelID;
            alugueis.i_pagamentos = pagamentoID;
            alugueis.i_pessoas = pessoaID;

            bool incluiu = AlugueisDB.setIncluiAlugueis(conexao, alugueis);
            if (incluiu)
            {
                MessageBox.Show("Aluguel cadastrado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar aluguel!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
