using Npgsql;
using SistemasImobiliaria.Controle;
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
    public partial class FrmIncluiPagamentos : Form
    {
        internal NpgsqlConnection conexao = null;

        public FrmIncluiPagamentos(NpgsqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pagamentoID = int.Parse(tbPagamento.Text);
            String tipo = tbTipo.Text;
            int parcelas = int.Parse(tbParcelas.Text);
            double valor = double.Parse(tbValor.Text);

            Pagamentos pagamentos = new Pagamentos();
            pagamentos.i_pagamentos = pagamentoID;
            pagamentos.tipo = tipo;
            pagamentos.parcelas = parcelas;
            pagamentos.valor = valor;

            bool incluiu = PagamentosDB.setIncluiPagamentos(conexao, pagamentos);
            if (incluiu)
            {
                MessageBox.Show("Pagamento cadastrado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar pagamento!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
