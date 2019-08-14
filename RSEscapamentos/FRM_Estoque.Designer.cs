namespace RSEscapamentos
{
    partial class FRM_Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grelha_estoque = new System.Windows.Forms.DataGridView();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_produto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.check_lista = new System.Windows.Forms.CheckBox();
            this.lista_fornecedor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_valor_venda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_valor_real = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_ganho = new System.Windows.Forms.Label();
            this.label_valor_venda = new System.Windows.Forms.Label();
            this.label_valor_real = new System.Windows.Forms.Label();
            this.label_quantidade = new System.Windows.Forms.Label();
            this.label_produto = new System.Windows.Forms.Label();
            this.label_codigo = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_pesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_estoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grelha_estoque
            // 
            this.grelha_estoque.AllowUserToAddRows = false;
            this.grelha_estoque.AllowUserToDeleteRows = false;
            this.grelha_estoque.AllowUserToResizeColumns = false;
            this.grelha_estoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.grelha_estoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grelha_estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grelha_estoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grelha_estoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grelha_estoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grelha_estoque.ColumnHeadersHeight = 45;
            this.grelha_estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grelha_estoque.Location = new System.Drawing.Point(12, 259);
            this.grelha_estoque.MultiSelect = false;
            this.grelha_estoque.Name = "grelha_estoque";
            this.grelha_estoque.ReadOnly = true;
            this.grelha_estoque.RowHeadersVisible = false;
            this.grelha_estoque.RowHeadersWidth = 43;
            dataGridViewCellStyle9.NullValue = null;
            this.grelha_estoque.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grelha_estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_estoque.Size = new System.Drawing.Size(685, 253);
            this.grelha_estoque.TabIndex = 9;
            this.grelha_estoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_estoque_CellClick);
            this.grelha_estoque.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_estoque_CellEnter);
            this.grelha_estoque.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grelha_estoque_ColumnHeaderMouseClick);
            // 
            // text_codigo
            // 
            this.text_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_codigo.Location = new System.Drawing.Point(147, 27);
            this.text_codigo.MaxLength = 10;
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(93, 22);
            this.text_codigo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código(opcional):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produto/Peça:";
            // 
            // text_produto
            // 
            this.text_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_produto.Location = new System.Drawing.Point(374, 27);
            this.text_produto.MaxLength = 100;
            this.text_produto.Name = "text_produto";
            this.text_produto.Size = new System.Drawing.Size(243, 22);
            this.text_produto.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.check_lista);
            this.groupBox1.Controls.Add(this.lista_fornecedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_valor_venda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_valor_real);
            this.groupBox1.Controls.Add(this.quantidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_codigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_produto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto/Peça";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "Selecionar Fornecedor:";
            // 
            // check_lista
            // 
            this.check_lista.AutoSize = true;
            this.check_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_lista.Location = new System.Drawing.Point(379, 124);
            this.check_lista.Name = "check_lista";
            this.check_lista.Size = new System.Drawing.Size(122, 20);
            this.check_lista.TabIndex = 22;
            this.check_lista.Text = "Não selecionar ";
            this.check_lista.UseVisualStyleBackColor = true;
            this.check_lista.CheckedChanged += new System.EventHandler(this.check_lista_CheckedChanged);
            // 
            // lista_fornecedor
            // 
            this.lista_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_fornecedor.FormattingEnabled = true;
            this.lista_fornecedor.ItemHeight = 15;
            this.lista_fornecedor.Location = new System.Drawing.Point(170, 100);
            this.lista_fornecedor.Name = "lista_fornecedor";
            this.lista_fornecedor.Size = new System.Drawing.Size(180, 64);
            this.lista_fornecedor.TabIndex = 21;
            this.lista_fornecedor.SelectedIndexChanged += new System.EventHandler(this.lista_fornecedor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Preço de venda:";
            // 
            // text_valor_venda
            // 
            this.text_valor_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor_venda.Location = new System.Drawing.Point(519, 63);
            this.text_valor_venda.MaxLength = 10;
            this.text_valor_venda.Name = "text_valor_venda";
            this.text_valor_venda.Size = new System.Drawing.Size(81, 22);
            this.text_valor_venda.TabIndex = 19;
            this.text_valor_venda.Leave += new System.EventHandler(this.text_valor_venda_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Preço real:";
            // 
            // text_valor_real
            // 
            this.text_valor_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor_real.Location = new System.Drawing.Point(269, 63);
            this.text_valor_real.MaxLength = 10;
            this.text_valor_real.Name = "text_valor_real";
            this.text_valor_real.Size = new System.Drawing.Size(81, 22);
            this.text_valor_real.TabIndex = 17;
            this.text_valor_real.Leave += new System.EventHandler(this.text_valor_real_Leave);
            // 
            // quantidade
            // 
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(104, 64);
            this.quantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(55, 22);
            this.quantidade.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantidade: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_ganho);
            this.groupBox2.Controls.Add(this.label_valor_venda);
            this.groupBox2.Controls.Add(this.label_valor_real);
            this.groupBox2.Controls.Add(this.label_quantidade);
            this.groupBox2.Controls.Add(this.label_produto);
            this.groupBox2.Controls.Add(this.label_codigo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 123);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item selecionado";
            // 
            // label_ganho
            // 
            this.label_ganho.AutoSize = true;
            this.label_ganho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ganho.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_ganho.Location = new System.Drawing.Point(19, 95);
            this.label_ganho.Name = "label_ganho";
            this.label_ganho.Size = new System.Drawing.Size(113, 16);
            this.label_ganho.TabIndex = 26;
            this.label_ganho.Text = "Ganho na venda: ";
            // 
            // label_valor_venda
            // 
            this.label_valor_venda.AutoSize = true;
            this.label_valor_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_venda.Location = new System.Drawing.Point(431, 67);
            this.label_valor_venda.Name = "label_valor_venda";
            this.label_valor_venda.Size = new System.Drawing.Size(107, 16);
            this.label_valor_venda.TabIndex = 25;
            this.label_valor_venda.Text = "Preço de venda:";
            // 
            // label_valor_real
            // 
            this.label_valor_real.AutoSize = true;
            this.label_valor_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_real.Location = new System.Drawing.Point(215, 67);
            this.label_valor_real.Name = "label_valor_real";
            this.label_valor_real.Size = new System.Drawing.Size(73, 16);
            this.label_valor_real.TabIndex = 24;
            this.label_valor_real.Text = "Preço real:";
            // 
            // label_quantidade
            // 
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantidade.Location = new System.Drawing.Point(19, 67);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(84, 16);
            this.label_quantidade.TabIndex = 23;
            this.label_quantidade.Text = "Quantidade: ";
            // 
            // label_produto
            // 
            this.label_produto.AutoSize = true;
            this.label_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_produto.Location = new System.Drawing.Point(313, 38);
            this.label_produto.Name = "label_produto";
            this.label_produto.Size = new System.Drawing.Size(94, 16);
            this.label_produto.TabIndex = 22;
            this.label_produto.Text = "Produto/Peça:";
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo.Location = new System.Drawing.Point(19, 39);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(58, 16);
            this.label_codigo.TabIndex = 21;
            this.label_codigo.Text = "Código: ";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(544, 194);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(146, 48);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(219, 194);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(146, 48);
            this.btn_remover.TabIndex = 17;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(381, 194);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(146, 48);
            this.btn_editar.TabIndex = 18;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.Location = new System.Drawing.Point(23, 524);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(277, 16);
            this.label_count.TabIndex = 20;
            this.label_count.Text = "Quantidade de produtos/peças cadastrados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pesquisar:";
            // 
            // text_pesquisa
            // 
            this.text_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pesquisa.Location = new System.Drawing.Point(101, 204);
            this.text_pesquisa.MaxLength = 10;
            this.text_pesquisa.Name = "text_pesquisa";
            this.text_pesquisa.Size = new System.Drawing.Size(104, 22);
            this.text_pesquisa.TabIndex = 21;
            this.text_pesquisa.TextChanged += new System.EventHandler(this.text_pesquisa_TextChanged);
            // 
            // FRM_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 694);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_pesquisa);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grelha_estoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.FRM_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_estoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grelha_estoque;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_produto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_valor_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_valor_real;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_valor_venda;
        private System.Windows.Forms.Label label_valor_real;
        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.Label label_produto;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_ganho;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.ListBox lista_fornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_lista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_pesquisa;
    }
}