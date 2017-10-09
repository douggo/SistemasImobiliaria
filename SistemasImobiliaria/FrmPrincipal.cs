using ConFin.modelo;
using Npgsql;
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

    public partial class FrmPrincipal : Form
    {
        public NpgsqlConnection conexao = null;

        public FrmPrincipal()
        {
            InitializeComponent();
            conexao = Conexao.getConexao();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao.setFecharConexao(conexao);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmConsultaPessoas form = new FrmConsultaPessoas(conexao);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConsultaImoveis form = new FrmConsultaImoveis(conexao);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmConsultaPagamentos form = new FrmConsultaPagamentos(conexao);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultaAlugueis form = new FrmConsultaAlugueis(conexao);
            form.Show();
        }
    }
}
