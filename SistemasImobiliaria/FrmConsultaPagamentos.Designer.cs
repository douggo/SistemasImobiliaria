namespace SistemasImobiliaria
{
    partial class FrmConsultaPagamentos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.i_pagamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_pagamentos,
            this.parcelas,
            this.valor,
            this.tipo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(308, 32);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(264, 20);
            this.textBoxDescricao.TabIndex = 21;
            this.textBoxDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescricao_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descrição:";
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
            this.comboBoxTipo.Location = new System.Drawing.Point(159, 31);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(137, 21);
            this.comboBoxTipo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo:";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "ID do Pagamento",
            "Parcelas",
            "Valor",
            "Tipo"});
            this.comboBoxCampo.Location = new System.Drawing.Point(12, 31);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(136, 21);
            this.comboBoxCampo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Campos:";
            // 
            // i_pagamentos
            // 
            this.i_pagamentos.DataPropertyName = "i_pagamentos";
            this.i_pagamentos.HeaderText = "ID do Pagamento";
            this.i_pagamentos.Name = "i_pagamentos";
            // 
            // parcelas
            // 
            this.parcelas.DataPropertyName = "parcelas";
            this.parcelas.HeaderText = "Parcelas";
            this.parcelas.Name = "parcelas";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // FrmConsultaPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(583, 423);
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
            this.Name = "FrmConsultaPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pagamentos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmConsultaPagamentos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_pagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}