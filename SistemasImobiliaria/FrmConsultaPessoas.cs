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
    public partial class FrmConsultaPessoas : Form
    {
        internal NpgsqlConnection conexao = null;

        public FrmConsultaPessoas(NpgsqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
            atualizaTela();
        }

        private void atualizaTela()
        {
            dataGridView1.DataSource = PessoasDB.getConsultaPessoas(conexao);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIncluiPessoas form = new FrmIncluiPessoas(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigoPessoa = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            bool excluido = PessoasDB.setExcluiPessoas(conexao, codigoPessoa);
            if (excluido)
            {
                MessageBox.Show("Pessoa excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir pessoa!");
            }
            atualizaTela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigoPessoa = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            String genero = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String cpf = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String endereco = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String nome = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Pessoas pessoas = new Pessoas();
            pessoas.i_pessoas = codigoPessoa;
            pessoas.genero = genero;
            pessoas.cpf = cpf;
            pessoas.endereco = endereco;
            pessoas.nome = nome;

            bool alterou = PessoasDB.setAlteraPessoas(conexao, pessoas);
            if (alterou)
            {
                MessageBox.Show("Pessoa alterada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar pessoa!");
            }
            atualizaTela();
        }
    }
}
