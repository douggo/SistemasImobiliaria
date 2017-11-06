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
    public partial class FrmRelAlugueisPorImovel : Form
    {
        internal NpgsqlConnection conexao = null;
        public FrmRelAlugueisPorImovel(NpgsqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void FrmRelAlugueisPorImovel_Load(object sender, EventArgs e)
        {
            AlugueisBindingSource.DataSource = AlugueisDB.getConsultaAlugueis(conexao);
            this.reportViewer1.RefreshReport();
        }
    }
}
