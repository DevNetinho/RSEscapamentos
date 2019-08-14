namespace RSEscapamentos
{
    partial class FRM_Editar
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
            this.label5 = new System.Windows.Forms.Label();
            this.text_valor_venda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_valor_real = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_produto = new System.Windows.Forms.TextBox();
            this.quantidade = new System.Windows.Forms.NumericUpDown();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.check_lista = new System.Windows.Forms.CheckBox();
            this.lista_fornecedor = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Preço de venda:";
            // 
            // text_valor_venda
            // 
            this.text_valor_venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor_venda.Location = new System.Drawing.Point(307, 217);
            this.text_valor_venda.MaxLength = 10;
            this.text_valor_venda.Name = "text_valor_venda";
            this.text_valor_venda.Size = new System.Drawing.Size(81, 22);
            this.text_valor_venda.TabIndex = 27;
            this.text_valor_venda.TextChanged += new System.EventHandler(this.text_valor_venda_TextChanged);
            this.text_valor_venda.Leave += new System.EventHandler(this.text_valor_venda_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Preço real:";
            // 
            // text_valor_real
            // 
            this.text_valor_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor_real.Location = new System.Drawing.Point(87, 219);
            this.text_valor_real.MaxLength = 10;
            this.text_valor_real.Name = "text_valor_real";
            this.text_valor_real.Size = new System.Drawing.Size(81, 22);
            this.text_valor_real.TabIndex = 25;
            this.text_valor_real.TextChanged += new System.EventHandler(this.text_valor_real_TextChanged);
            this.text_valor_real.Leave += new System.EventHandler(this.text_valor_real_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quantidade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Produto/Peça:";
            // 
            // text_produto
            // 
            this.text_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_produto.Location = new System.Drawing.Point(120, 57);
            this.text_produto.MaxLength = 100;
            this.text_produto.Name = "text_produto";
            this.text_produto.Size = new System.Drawing.Size(243, 22);
            this.text_produto.TabIndex = 21;
            // 
            // quantidade
            // 
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(120, 96);
            this.quantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(55, 22);
            this.quantidade.TabIndex = 29;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(193, 260);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(103, 31);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_concluir
            // 
            this.btn_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.Location = new System.Drawing.Point(307, 260);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(103, 31);
            this.btn_concluir.TabIndex = 30;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // text_codigo
            // 
            this.text_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_codigo.Location = new System.Drawing.Point(137, 20);
            this.text_codigo.MaxLength = 10;
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(93, 22);
            this.text_codigo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código(opcional):";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 45);
            this.label6.TabIndex = 36;
            this.label6.Text = "Selecionar Fornecedor:";
            // 
            // check_lista
            // 
            this.check_lista.AutoSize = true;
            this.check_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_lista.Location = new System.Drawing.Point(307, 156);
            this.check_lista.Name = "check_lista";
            this.check_lista.Size = new System.Drawing.Size(122, 20);
            this.check_lista.TabIndex = 35;
            this.check_lista.Text = "Não selecionar ";
            this.check_lista.UseVisualStyleBackColor = true;
            this.check_lista.CheckedChanged += new System.EventHandler(this.check_lista_CheckedChanged);
            // 
            // lista_fornecedor
            // 
            this.lista_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_fornecedor.FormattingEnabled = true;
            this.lista_fornecedor.ItemHeight = 15;
            this.lista_fornecedor.Location = new System.Drawing.Point(110, 134);
            this.lista_fornecedor.Name = "lista_fornecedor";
            this.lista_fornecedor.Size = new System.Drawing.Size(180, 64);
            this.lista_fornecedor.TabIndex = 34;
            this.lista_fornecedor.SelectedIndexChanged += new System.EventHandler(this.lista_fornecedor_SelectedIndexChanged);
            // 
            // FRM_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 308);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.check_lista);
            this.Controls.Add(this.lista_fornecedor);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_valor_venda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_valor_real);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Cadastro";
            this.Load += new System.EventHandler(this.FRM_Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_valor_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_valor_real;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_produto;
        private System.Windows.Forms.NumericUpDown quantidade;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox check_lista;
        private System.Windows.Forms.ListBox lista_fornecedor;
    }
}