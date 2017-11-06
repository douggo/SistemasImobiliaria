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
    public partial class FrmRelacaoAlugueis : Form
    {
        internal NpgsqlConnection conexao = null;
        public FrmRelacaoAlugueis(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelacaoAlugueis_Load(object sender, EventArgs e)
        {
            AlugueisBindingSource.DataSource = AlugueisDB.getConsultaAlugueis(conexao);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
