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
    public partial class FrmConsultaAlugueis : Form
    {
        internal NpgsqlConnection conexao = null;

        public FrmConsultaAlugueis(NpgsqlConnection conexao)
        {
            InitializeComponent();
            comboBoxCampo.SelectedIndex = 0;
            comboBoxTipo.SelectedIndex = 0;
            this.conexao = conexao;
            atualizaTela();
        }

        private void atualizaTela()
        {
            if (textBoxDescricao.Text.Length > 0)
            {
                dataGridView1.DataSource = AlugueisDB.getConsultaAlugueis(conexao,comboBoxCampo.SelectedIndex, comboBoxTipo.SelectedIndex, textBoxDescricao.Text);
            }
            else
            {
                dataGridView1.DataSource = AlugueisDB.getConsultaAlugueis(conexao);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIncluiAlugueis form = new FrmIncluiAlugueis(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigoAluguel = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            int i_pagamentos = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int i_pessoas = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int i_imoveis = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            bool excluido = AlugueisDB.setExcluiAlugueis(conexao, codigoAluguel, i_imoveis, i_pagamentos, i_pessoas);
            if (excluido)
            {
                MessageBox.Show("Aluguel excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir aluguel!");
            }
            atualizaTela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigoPagamento = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int codigoImovel = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            int codigoPessoa = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            int codigoAluguel = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            Alugueis alugueis = new Alugueis();
            alugueis.i_pagamentos = codigoPagamento;
            alugueis.i_imoveis = codigoImovel;
            alugueis.i_pessoas = codigoPessoa;
            alugueis.i_alugueis = codigoAluguel;

            bool alterou = AlugueisDB.setAlteraAlugueis(conexao, alugueis);
            if (alterou)
            {
                MessageBox.Show("Aluguel alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar aluguel!");
            }
            atualizaTela();
        }

        private void textBoxDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                atualizaTela();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRelacaoAlugueis form = new FrmRelacaoAlugueis(conexao);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmRelacaoDeImoveisPorPessoa form = new FrmRelacaoDeImoveisPorPessoa(conexao);
            form.Show();
        }
    }
}
