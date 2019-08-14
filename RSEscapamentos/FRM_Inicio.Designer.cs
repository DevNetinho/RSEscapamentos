namespace RSEscapamentos
{
    partial class FRM_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Inicio));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_fechamento = new System.Windows.Forms.Button();
            this.text_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grelha_pesquisa = new System.Windows.Forms.DataGridView();
            this.radio_clientes = new System.Windows.Forms.RadioButton();
            this.radio_estoque = new System.Windows.Forms.RadioButton();
            this.radio_fornecedores = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label_mensagem = new System.Windows.Forms.Label();
            this.btn_alterar_senha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(978, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(81, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 94);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pagamentos Pendentes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(81, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 88);
            this.button3.TabIndex = 4;
            this.button3.Text = "Estoque";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(81, 411);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 95);
            this.button4.TabIndex = 5;
            this.button4.Text = "Fornecedores";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_fechamento
            // 
            this.btn_fechamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_fechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechamento.Location = new System.Drawing.Point(81, 503);
            this.btn_fechamento.Name = "btn_fechamento";
            this.btn_fechamento.Size = new System.Drawing.Size(238, 93);
            this.btn_fechamento.TabIndex = 6;
            this.btn_fechamento.Text = "Calcular Fechamento";
            this.btn_fechamento.UseVisualStyleBackColor = false;
            this.btn_fechamento.Click += new System.EventHandler(this.btn_fechamento_Click);
            // 
            // text_pesquisa
            // 
            this.text_pesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pesquisa.Location = new System.Drawing.Point(566, 147);
            this.text_pesquisa.Name = "text_pesquisa";
            this.text_pesquisa.Size = new System.Drawing.Size(317, 29);
            this.text_pesquisa.TabIndex = 7;
            this.text_pesquisa.TextChanged += new System.EventHandler(this.text_pesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisa geral:";
            // 
            // grelha_pesquisa
            // 
            this.grelha_pesquisa.AllowUserToAddRows = false;
            this.grelha_pesquisa.AllowUserToDeleteRows = false;
            this.grelha_pesquisa.AllowUserToResizeColumns = false;
            this.grelha_pesquisa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.grelha_pesquisa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grelha_pesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grelha_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grelha_pesquisa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grelha_pesquisa.ColumnHeadersHeight = 45;
            this.grelha_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grelha_pesquisa.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grelha_pesquisa.Location = new System.Drawing.Point(425, 200);
            this.grelha_pesquisa.MultiSelect = false;
            this.grelha_pesquisa.Name = "grelha_pesquisa";
            this.grelha_pesquisa.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grelha_pesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grelha_pesquisa.RowHeadersVisible = false;
            this.grelha_pesquisa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grelha_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_pesquisa.Size = new System.Drawing.Size(719, 357);
            this.grelha_pesquisa.TabIndex = 9;
            // 
            // radio_clientes
            // 
            this.radio_clientes.AutoSize = true;
            this.radio_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_clientes.Location = new System.Drawing.Point(904, 132);
            this.radio_clientes.Name = "radio_clientes";
            this.radio_clientes.Size = new System.Drawing.Size(79, 22);
            this.radio_clientes.TabIndex = 10;
            this.radio_clientes.TabStop = true;
            this.radio_clientes.Text = "Clientes";
            this.radio_clientes.UseVisualStyleBackColor = true;
            this.radio_clientes.CheckedChanged += new System.EventHandler(this.radio_clientes_CheckedChanged);
            // 
            // radio_estoque
            // 
            this.radio_estoque.AutoSize = true;
            this.radio_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_estoque.Location = new System.Drawing.Point(1012, 132);
            this.radio_estoque.Name = "radio_estoque";
            this.radio_estoque.Size = new System.Drawing.Size(81, 22);
            this.radio_estoque.TabIndex = 12;
            this.radio_estoque.TabStop = true;
            this.radio_estoque.Text = "Estoque";
            this.radio_estoque.UseVisualStyleBackColor = true;
            this.radio_estoque.CheckedChanged += new System.EventHandler(this.radio_estoque_CheckedChanged);
            // 
            // radio_fornecedores
            // 
            this.radio_fornecedores.AutoSize = true;
            this.radio_fornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_fornecedores.Location = new System.Drawing.Point(904, 154);
            this.radio_fornecedores.Name = "radio_fornecedores";
            this.radio_fornecedores.Size = new System.Drawing.Size(119, 22);
            this.radio_fornecedores.TabIndex = 13;
            this.radio_fornecedores.TabStop = true;
            this.radio_fornecedores.Text = "Fornecedores";
            this.radio_fornecedores.UseVisualStyleBackColor = true;
            this.radio_fornecedores.CheckedChanged += new System.EventHandler(this.radio_fornecedores_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Desenvolvido por Ricardo Júnior ";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cadastrar.Location = new System.Drawing.Point(81, 171);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(238, 79);
            this.btn_cadastrar.TabIndex = 1;
            this.btn_cadastrar.Text = "Cadastrar Clientes";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // label_mensagem
            // 
            this.label_mensagem.AutoSize = true;
            this.label_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensagem.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_mensagem.Location = new System.Drawing.Point(444, 24);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(223, 37);
            this.label_mensagem.TabIndex = 15;
            this.label_mensagem.Text = "Bem Vindo(a) ";
            // 
            // btn_alterar_senha
            // 
            this.btn_alterar_senha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_alterar_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_senha.Location = new System.Drawing.Point(999, 24);
            this.btn_alterar_senha.Name = "btn_alterar_senha";
            this.btn_alterar_senha.Size = new System.Drawing.Size(133, 49);
            this.btn_alterar_senha.TabIndex = 16;
            this.btn_alterar_senha.Text = "Alterar senha";
            this.btn_alterar_senha.UseVisualStyleBackColor = false;
            this.btn_alterar_senha.Click += new System.EventHandler(this.btn_alterar_senha_Click);
            // 
            // FRM_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1174, 695);
            this.Controls.Add(this.btn_alterar_senha);
            this.Controls.Add(this.label_mensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio_fornecedores);
            this.Controls.Add(this.radio_estoque);
            this.Controls.Add(this.radio_clientes);
            this.Controls.Add(this.grelha_pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_pesquisa);
            this.Controls.Add(this.btn_fechamento);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cadastro RS Escapamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Inicio_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_pesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_fechamento;
        private System.Windows.Forms.TextBox text_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grelha_pesquisa;
        private System.Windows.Forms.RadioButton radio_clientes;
        private System.Windows.Forms.RadioButton radio_estoque;
        private System.Windows.Forms.RadioButton radio_fornecedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_mensagem;
        private System.Windows.Forms.Button btn_alterar_senha;
    }
}