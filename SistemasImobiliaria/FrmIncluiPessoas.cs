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
    public partial class FrmIncluiPessoas : Form
    {
        internal NpgsqlConnection conexao = null;

        public FrmIncluiPessoas(NpgsqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pessoaID = int.Parse(tbPessoa.Text);
            String nome = tbNome.Text;
            String cpf = tbCPF.Text;
            String genero = tbGenero.Text;
            String endereco = tbEndereco.Text;

            Pessoas pessoas = new Pessoas();
            pessoas.i_pessoas = pessoaID;
            pessoas.nome = nome;
            pessoas.cpf = cpf;
            pessoas.genero = genero;
            pessoas.endereco = endereco;

            bool incluiu = PessoasDB.setIncluiPessoas(conexao, pessoas);
            if (incluiu)
            {
                MessageBox.Show("Pessoa cadastrada com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar pessoa!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
