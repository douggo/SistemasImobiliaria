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
    public partial class FrmConsultaImoveis : Form
    {
        internal NpgsqlConnection conexao = null;

        public FrmConsultaImoveis(NpgsqlConnection conexao)
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
                dataGridView1.DataSource = ImoveisDB.getConsultaImoveis(conexao, comboBoxCampo.SelectedIndex, comboBoxTipo.SelectedIndex, textBoxDescricao.Text);
            }
            else
            {
                dataGridView1.DataSource = ImoveisDB.getConsultaImoveis(conexao);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIncluiImoveis form = new FrmIncluiImoveis(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigoImovel = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            bool excluido = ImoveisDB.setExcluiImoveis(conexao, codigoImovel);
            if (excluido)
            {
                MessageBox.Show("Imóvel excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir imóvel!");
            }
            atualizaTela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigoImovel = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            String endereco = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String cidade = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String estado = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            Imoveis imoveis = new Imoveis();
            imoveis.i_imoveis = codigoImovel;
            imoveis.endereco = endereco;
            imoveis.cidade = cidade;
            imoveis.estado = estado;

            bool alterou = ImoveisDB.setAlteraImoveis(conexao, imoveis);
            if (alterou)
            {
                MessageBox.Show("Imóvel alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao alterar imóvel!");
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
    }
}
