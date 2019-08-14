namespace RSEscapamentos
{
    partial class FRM_Pendentes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grelha_pendentes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_data1 = new System.Windows.Forms.MaskedTextBox();
            this.text_data2 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.text_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_veiculo = new System.Windows.Forms.TextBox();
            this.text_placa = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.btn_pago = new System.Windows.Forms.Button();
            this.text_valor = new System.Windows.Forms.TextBox();
            this.label_nao_pagos = new System.Windows.Forms.Label();
            this.label_pagos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radio_pagos = new System.Windows.Forms.RadioButton();
            this.radio_nao_pagos = new System.Windows.Forms.RadioButton();
            this.radio_pendentes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_pendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // grelha_pendentes
            // 
            this.grelha_pendentes.AllowUserToAddRows = false;
            this.grelha_pendentes.AllowUserToDeleteRows = false;
            this.grelha_pendentes.AllowUserToResizeColumns = false;
            this.grelha_pendentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.grelha_pendentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grelha_pendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grelha_pendentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grelha_pendentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grelha_pendentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grelha_pendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grelha_pendentes.ColumnHeadersHeight = 45;
            this.grelha_pendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grelha_pendentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.grelha_pendentes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grelha_pendentes.Location = new System.Drawing.Point(12, 295);
            this.grelha_pendentes.MultiSelect = false;
            this.grelha_pendentes.Name = "grelha_pendentes";
            this.grelha_pendentes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grelha_pendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grelha_pendentes.RowHeadersVisible = false;
            this.grelha_pendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_pendentes.Size = new System.Drawing.Size(755, 251);
            this.grelha_pendentes.TabIndex = 14;
            this.grelha_pendentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_pendentes_CellClick);
            this.grelha_pendentes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grelha_pendentes_ColumnHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Vencimento:";
            // 
            // text_data1
            // 
            this.text_data1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data1.Location = new System.Drawing.Point(134, 153);
            this.text_data1.Mask = "00/00/0000";
            this.text_data1.Name = "text_data1";
            this.text_data1.Size = new System.Drawing.Size(82, 24);
            this.text_data1.TabIndex = 23;
            this.text_data1.Leave += new System.EventHandler(this.text_data1_Leave);
            // 
            // text_data2
            // 
            this.text_data2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data2.Location = new System.Drawing.Point(335, 153);
            this.text_data2.Mask = "00/00/0000";
            this.text_data2.Name = "text_data2";
            this.text_data2.Size = new System.Drawing.Size(84, 24);
            this.text_data2.TabIndex = 24;
            this.text_data2.ValidatingType = typeof(System.DateTime);
            this.text_data2.Leave += new System.EventHandler(this.text_data2_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Valor Pendente:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(611, 194);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(150, 42);
            this.btn_cadastrar.TabIndex = 27;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // text_desc
            // 
            this.text_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_desc.Location = new System.Drawing.Point(18, 111);
            this.text_desc.MaxLength = 50;
            this.text_desc.Name = "text_desc";
            this.text_desc.Size = new System.Drawing.Size(496, 22);
            this.text_desc.TabIndex = 29;
            this.text_desc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descrição:";
            // 
            // text_cliente
            // 
            this.text_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cliente.Location = new System.Drawing.Point(18, 48);
            this.text_cliente.MaxLength = 30;
            this.text_cliente.Name = "text_cliente";
            this.text_cliente.Size = new System.Drawing.Size(306, 22);
            this.text_cliente.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Veículo:";
            // 
            // text_veiculo
            // 
            this.text_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_veiculo.Location = new System.Drawing.Point(353, 48);
            this.text_veiculo.MaxLength = 20;
            this.text_veiculo.Name = "text_veiculo";
            this.text_veiculo.Size = new System.Drawing.Size(227, 22);
            this.text_veiculo.TabIndex = 33;
            // 
            // text_placa
            // 
            this.text_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_placa.Location = new System.Drawing.Point(612, 48);
            this.text_placa.Mask = ">???-9999";
            this.text_placa.Name = "text_placa";
            this.text_placa.Size = new System.Drawing.Size(93, 22);
            this.text_placa.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Celular/Telefone:";
            // 
            // text_telefone
            // 
            this.text_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_telefone.Location = new System.Drawing.Point(580, 111);
            this.text_telefone.Mask = "(99) 99999-9999";
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(150, 22);
            this.text_telefone.TabIndex = 37;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(409, 194);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(150, 42);
            this.btn_remover.TabIndex = 38;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Location = new System.Drawing.Point(222, 194);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(146, 42);
            this.btn_visualizar.TabIndex = 39;
            this.btn_visualizar.Text = "Vizualizar";
            this.btn_visualizar.UseVisualStyleBackColor = true;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.Location = new System.Drawing.Point(19, 559);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(287, 20);
            this.label_count.TabIndex = 40;
            this.label_count.Text = "Número de Cadastros em pendentes: 0";
            // 
            // btn_pago
            // 
            this.btn_pago.Location = new System.Drawing.Point(34, 194);
            this.btn_pago.Name = "btn_pago";
            this.btn_pago.Size = new System.Drawing.Size(146, 42);
            this.btn_pago.TabIndex = 41;
            this.btn_pago.Text = "Marcar como pago";
            this.btn_pago.UseVisualStyleBackColor = true;
            this.btn_pago.Click += new System.EventHandler(this.btn_pago_Click);
            // 
            // text_valor
            // 
            this.text_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor.Location = new System.Drawing.Point(565, 153);
            this.text_valor.MaxLength = 8;
            this.text_valor.Name = "text_valor";
            this.text_valor.Size = new System.Drawing.Size(95, 24);
            this.text_valor.TabIndex = 26;
            this.text_valor.Leave += new System.EventHandler(this.text_preco_Leave);
            // 
            // label_nao_pagos
            // 
            this.label_nao_pagos.AutoSize = true;
            this.label_nao_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nao_pagos.ForeColor = System.Drawing.Color.Red;
            this.label_nao_pagos.Location = new System.Drawing.Point(377, 559);
            this.label_nao_pagos.Name = "label_nao_pagos";
            this.label_nao_pagos.Size = new System.Drawing.Size(257, 20);
            this.label_nao_pagos.TabIndex = 42;
            this.label_nao_pagos.Text = "Número de cadastros não pagos: 0";
            // 
            // label_pagos
            // 
            this.label_pagos.AutoSize = true;
            this.label_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pagos.ForeColor = System.Drawing.Color.Green;
            this.label_pagos.Location = new System.Drawing.Point(19, 590);
            this.label_pagos.Name = "label_pagos";
            this.label_pagos.Size = new System.Drawing.Size(226, 20);
            this.label_pagos.TabIndex = 43;
            this.label_pagos.Text = "Número de cadastros pagos: 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "Exibir resultados por: ";
            // 
            // radio_pagos
            // 
            this.radio_pagos.AutoSize = true;
            this.radio_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_pagos.ForeColor = System.Drawing.Color.Green;
            this.radio_pagos.Location = new System.Drawing.Point(172, 254);
            this.radio_pagos.Name = "radio_pagos";
            this.radio_pagos.Size = new System.Drawing.Size(66, 20);
            this.radio_pagos.TabIndex = 45;
            this.radio_pagos.TabStop = true;
            this.radio_pagos.Text = "Pagos";
            this.radio_pagos.UseVisualStyleBackColor = true;
            this.radio_pagos.CheckedChanged += new System.EventHandler(this.radio_pagos_CheckedChanged);
            // 
            // radio_nao_pagos
            // 
            this.radio_nao_pagos.AutoSize = true;
            this.radio_nao_pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nao_pagos.ForeColor = System.Drawing.Color.Red;
            this.radio_nao_pagos.Location = new System.Drawing.Point(255, 254);
            this.radio_nao_pagos.Name = "radio_nao_pagos";
            this.radio_nao_pagos.Size = new System.Drawing.Size(94, 20);
            this.radio_nao_pagos.TabIndex = 46;
            this.radio_nao_pagos.TabStop = true;
            this.radio_nao_pagos.Text = "Não pagos";
            this.radio_nao_pagos.UseVisualStyleBackColor = true;
            this.radio_nao_pagos.CheckedChanged += new System.EventHandler(this.radio_nao_pagos_CheckedChanged);
            // 
            // radio_pendentes
            // 
            this.radio_pendentes.AutoSize = true;
            this.radio_pendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_pendentes.Location = new System.Drawing.Point(353, 256);
            this.radio_pendentes.Name = "radio_pendentes";
            this.radio_pendentes.Size = new System.Drawing.Size(91, 20);
            this.radio_pendentes.TabIndex = 47;
            this.radio_pendentes.TabStop = true;
            this.radio_pendentes.Text = "Pendentes";
            this.radio_pendentes.UseVisualStyleBackColor = true;
            this.radio_pendentes.CheckedChanged += new System.EventHandler(this.radio_pendentes_CheckedChanged);
            // 
            // FRM_Pendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(776, 623);
            this.Controls.Add(this.radio_pendentes);
            this.Controls.Add(this.radio_nao_pagos);
            this.Controls.Add(this.radio_pagos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_pagos);
            this.Controls.Add(this.label_nao_pagos);
            this.Controls.Add(this.btn_pago);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.text_telefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_veiculo);
            this.Controls.Add(this.text_placa);
            this.Controls.Add(this.text_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.text_valor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_data2);
            this.Controls.Add(this.text_data1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grelha_pendentes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Pendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "Pagamentos Pendentes";
            this.Load += new System.EventHandler(this.FRM_Pendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_pendentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox text_data1;
        private System.Windows.Forms.MaskedTextBox text_data2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox text_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_veiculo;
        private System.Windows.Forms.MaskedTextBox text_placa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox text_telefone;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button btn_pago;
        public System.Windows.Forms.DataGridView grelha_pendentes;
        private System.Windows.Forms.TextBox text_valor;
        private System.Windows.Forms.Label label_nao_pagos;
        private System.Windows.Forms.Label label_pagos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radio_pagos;
        private System.Windows.Forms.RadioButton radio_nao_pagos;
        private System.Windows.Forms.RadioButton radio_pendentes;
    }
}