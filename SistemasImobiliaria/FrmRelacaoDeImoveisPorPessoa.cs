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
    public partial class FrmRelacaoDeImoveisPorPessoa : Form
    {
        internal NpgsqlConnection conexao = null;
        public FrmRelacaoDeImoveisPorPessoa(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelacaoDeImoveisPorPessoa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            AlugueisBindingSource.DataSource = AlugueisDB.getConsultaAlugueis(conexao);
        }
    }
}
