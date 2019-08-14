namespace RSEscapamentos
{
    partial class FRM_Fornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.grelha_fornecedores = new System.Windows.Forms.DataGridView();
            this.label_count = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_telefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_descricao = new System.Windows.Forms.TextBox();
            this.text_cep = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_telefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_endereço = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_fornecedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(443, 207);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(145, 48);
            this.btn_remover.TabIndex = 22;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(604, 207);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(145, 48);
            this.btn_cadastrar.TabIndex = 21;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // grelha_fornecedores
            // 
            this.grelha_fornecedores.AllowUserToAddRows = false;
            this.grelha_fornecedores.AllowUserToDeleteRows = false;
            this.grelha_fornecedores.AllowUserToResizeColumns = false;
            this.grelha_fornecedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.grelha_fornecedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grelha_fornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grelha_fornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grelha_fornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grelha_fornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grelha_fornecedores.ColumnHeadersHeight = 45;
            this.grelha_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grelha_fornecedores.Location = new System.Drawing.Point(12, 272);
            this.grelha_fornecedores.MultiSelect = false;
            this.grelha_fornecedores.Name = "grelha_fornecedores";
            this.grelha_fornecedores.ReadOnly = true;
            this.grelha_fornecedores.RowHeadersVisible = false;
            this.grelha_fornecedores.RowHeadersWidth = 43;
            dataGridViewCellStyle3.NullValue = null;
            this.grelha_fornecedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grelha_fornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_fornecedores.Size = new System.Drawing.Size(737, 287);
            this.grelha_fornecedores.TabIndex = 19;
            this.grelha_fornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_fornecedores_CellClick);
            this.grelha_fornecedores.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_fornecedores_CellEnter);
            this.grelha_fornecedores.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grelha_fornecedores_ColumnHeaderMouseClick);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.Location = new System.Drawing.Point(12, 580);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(196, 20);
            this.label_count.TabIndex = 24;
            this.label_count.Text = "Quantidade de cadastros: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_telefone2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_descricao);
            this.groupBox1.Controls.Add(this.text_cep);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_cnpj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_telefone1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_endereço);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 189);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Fornecedor";
            // 
            // text_telefone2
            // 
            this.text_telefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_telefone2.Location = new System.Drawing.Point(592, 71);
            this.text_telefone2.Mask = "(00) 00000-0000";
            this.text_telefone2.Name = "text_telefone2";
            this.text_telefone2.Size = new System.Drawing.Size(121, 22);
            this.text_telefone2.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(511, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Telefone 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Descrição:";
            // 
            // text_descricao
            // 
            this.text_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descricao.Location = new System.Drawing.Point(98, 149);
            this.text_descricao.MaxLength = 90;
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(374, 22);
            this.text_descricao.TabIndex = 32;
            // 
            // text_cep
            // 
            this.text_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cep.Location = new System.Drawing.Point(346, 112);
            this.text_cep.Mask = "99999-999";
            this.text_cep.Name = "text_cep";
            this.text_cep.Size = new System.Drawing.Size(111, 22);
            this.text_cep.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "CEP:";
            // 
            // text_cnpj
            // 
            this.text_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cnpj.Location = new System.Drawing.Point(71, 112);
            this.text_cnpj.Mask = "00.000.000/0000-00";
            this.text_cnpj.Name = "text_cnpj";
            this.text_cnpj.Size = new System.Drawing.Size(125, 22);
            this.text_cnpj.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "CNPJ:";
            // 
            // text_telefone1
            // 
            this.text_telefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_telefone1.Location = new System.Drawing.Point(499, 31);
            this.text_telefone1.Mask = "(00) 00000-0000";
            this.text_telefone1.Name = "text_telefone1";
            this.text_telefone1.Size = new System.Drawing.Size(121, 22);
            this.text_telefone1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefone 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Endereço:";
            // 
            // text_endereço
            // 
            this.text_endereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_endereço.Location = new System.Drawing.Point(98, 74);
            this.text_endereço.MaxLength = 140;
            this.text_endereço.Name = "text_endereço";
            this.text_endereço.Size = new System.Drawing.Size(374, 22);
            this.text_endereço.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome(Empresa):";
            // 
            // text_nome
            // 
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.Location = new System.Drawing.Point(139, 32);
            this.text_nome.MaxLength = 100;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(247, 22);
            this.text_nome.TabIndex = 12;
            // 
            // FRM_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(766, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.grelha_fornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.FRM_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_fornecedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView grelha_fornecedores;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_endereço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox text_telefone1;
        private System.Windows.Forms.MaskedTextBox text_cep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox text_cnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_descricao;
        private System.Windows.Forms.MaskedTextBox text_telefone2;
        private System.Windows.Forms.Label label7;
    }
}