namespace SistemasImobiliaria
{
    partial class FrmConsultaAlugueis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.i_pagamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_imoveis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_pessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_alugueis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_pagamentos,
            this.i_imoveis,
            this.i_pessoas,
            this.i_alugueis});
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // i_pagamentos
            // 
            this.i_pagamentos.DataPropertyName = "i_pagamentos";
            this.i_pagamentos.HeaderText = "ID de Pagamento";
            this.i_pagamentos.Name = "i_pagamentos";
            // 
            // i_imoveis
            // 
            this.i_imoveis.DataPropertyName = "i_imoveis";
            this.i_imoveis.HeaderText = "ID de Imóvel";
            this.i_imoveis.Name = "i_imoveis";
            // 
            // i_pessoas
            // 
            this.i_pessoas.DataPropertyName = "i_pessoas";
            this.i_pessoas.HeaderText = "ID de Pessoa";
            this.i_pessoas.Name = "i_pessoas";
            // 
            // i_alugueis
            // 
            this.i_alugueis.DataPropertyName = "i_alugueis";
            this.i_alugueis.HeaderText = "ID de Aluguel";
            this.i_alugueis.Name = "i_alugueis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Campos:";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "ID de Pagamento",
            "ID de Imóvel",
            "ID de Pessoa",
            "ID de Aluguel"});
            this.comboBoxCampo.Location = new System.Drawing.Point(11, 25);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(136, 21);
            this.comboBoxCampo.TabIndex = 5;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Contém",
            "Inicia com",
            "Termina com",
            "Igual",
            "Maior ou igual",
            "Menor ou igual"});
            this.comboBoxTipo.Location = new System.Drawing.Point(158, 25);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(137, 21);
            this.comboBoxTipo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(307, 26);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(264, 20);
            this.textBoxDescricao.TabIndex = 9;
            this.textBoxDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescricao_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 423);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 43);
            this.button4.TabIndex = 10;
            this.button4.Text = "Relatório de Aluguéis";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 423);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 43);
            this.button5.TabIndex = 11;
            this.button5.Text = "Relatório de Aluguéis por Pessoas";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmConsultaAlugueis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(583, 480);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultaAlugueis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Alugueis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_pagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_imoveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_pessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_alugueis;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}