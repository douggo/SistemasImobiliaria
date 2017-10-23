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

namespace SistemasImobiliaria.Relatorios
{
    public partial class FrmRelacaoPessoas : Form

   {
        internal NpgsqlConnection conexao = null;
        public FrmRelacaoPessoas(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelacaoPessoas_Load(object sender, EventArgs e)
        {
            PessoasBindingSource.DataSource = PessoasDB.getConsultaPessoas(conexao);
            this.reportViewer1.RefreshReport();
        }
    }
}
