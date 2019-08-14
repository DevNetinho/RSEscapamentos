namespace RSEscapamentos
{
    partial class FRM_Detalhes
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
            this.grelha_servicos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label_placa = new System.Windows.Forms.Label();
            this.label_veiculo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_pagamento = new System.Windows.Forms.Label();
            this.label_data_final = new System.Windows.Forms.Label();
            this.label_tipo = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_maquina = new System.Windows.Forms.Label();
            this.label_parcelas = new System.Windows.Forms.Label();
            this.label_valor_parcelas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_servicos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grelha_servicos
            // 
            this.grelha_servicos.AllowUserToAddRows = false;
            this.grelha_servicos.AllowUserToDeleteRows = false;
            this.grelha_servicos.AllowUserToResizeColumns = false;
            this.grelha_servicos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.grelha_servicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grelha_servicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grelha_servicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grelha_servicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grelha_servicos.ColumnHeadersHeight = 45;
            this.grelha_servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grelha_servicos.Location = new System.Drawing.Point(21, 399);
            this.grelha_servicos.MultiSelect = false;
            this.grelha_servicos.Name = "grelha_servicos";
            this.grelha_servicos.ReadOnly = true;
            this.grelha_servicos.RowHeadersVisible = false;
            this.grelha_servicos.RowHeadersWidth = 42;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.grelha_servicos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grelha_servicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_servicos.Size = new System.Drawing.Size(836, 223);
            this.grelha_servicos.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grelha_servicos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 639);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_telefone);
            this.groupBox3.Controls.Add(this.label_data);
            this.groupBox3.Controls.Add(this.label_cliente);
            this.groupBox3.Controls.Add(this.label_placa);
            this.groupBox3.Controls.Add(this.label_veiculo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 125);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Cliente";
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.Location = new System.Drawing.Point(556, 87);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(98, 18);
            this.label_telefone.TabIndex = 8;
            this.label_telefone.Text = "label_telefone";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data.Location = new System.Drawing.Point(690, 36);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(74, 18);
            this.label_data.TabIndex = 9;
            this.label_data.Text = "label_data";
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cliente.Location = new System.Drawing.Point(88, 88);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(88, 18);
            this.label_cliente.TabIndex = 3;
            this.label_cliente.Text = "label_cliente";
            // 
            // label_placa
            // 
            this.label_placa.AutoSize = true;
            this.label_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_placa.Location = new System.Drawing.Point(423, 34);
            this.label_placa.Name = "label_placa";
            this.label_placa.Size = new System.Drawing.Size(81, 18);
            this.label_placa.TabIndex = 5;
            this.label_placa.Text = "label_placa";
            // 
            // label_veiculo
            // 
            this.label_veiculo.AutoSize = true;
            this.label_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_veiculo.Location = new System.Drawing.Point(91, 33);
            this.label_veiculo.Name = "label_veiculo";
            this.label_veiculo.Size = new System.Drawing.Size(92, 18);
            this.label_veiculo.TabIndex = 1;
            this.label_veiculo.Text = "label_veiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Celular/Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Veículo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Serviços realizados:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_pagamento);
            this.groupBox2.Controls.Add(this.label_data_final);
            this.groupBox2.Controls.Add(this.label_tipo);
            this.groupBox2.Controls.Add(this.label_total);
            this.groupBox2.Controls.Add(this.label_maquina);
            this.groupBox2.Controls.Add(this.label_parcelas);
            this.groupBox2.Controls.Add(this.label_valor_parcelas);
            this.groupBox2.Location = new System.Drawing.Point(21, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 183);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de pagamento";
            // 
            // label_pagamento
            // 
            this.label_pagamento.AutoSize = true;
            this.label_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pagamento.Location = new System.Drawing.Point(19, 33);
            this.label_pagamento.Name = "label_pagamento";
            this.label_pagamento.Size = new System.Drawing.Size(166, 20);
            this.label_pagamento.TabIndex = 34;
            this.label_pagamento.Text = "Forma de pagamento:";
            // 
            // label_data_final
            // 
            this.label_data_final.AutoSize = true;
            this.label_data_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_final.Location = new System.Drawing.Point(338, 33);
            this.label_data_final.Name = "label_data_final";
            this.label_data_final.Size = new System.Drawing.Size(86, 20);
            this.label_data_final.TabIndex = 40;
            this.label_data_final.Text = "Data Final:";
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo.Location = new System.Drawing.Point(22, 74);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(43, 20);
            this.label_tipo.TabIndex = 35;
            this.label_tipo.Text = "Tipo:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(20, 147);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(89, 20);
            this.label_total.TabIndex = 39;
            this.label_total.Text = "Valor total: ";
            // 
            // label_maquina
            // 
            this.label_maquina.AutoSize = true;
            this.label_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maquina.Location = new System.Drawing.Point(265, 117);
            this.label_maquina.Name = "label_maquina";
            this.label_maquina.Size = new System.Drawing.Size(145, 20);
            this.label_maquina.TabIndex = 36;
            this.label_maquina.Text = "Máquina de cartão:";
            // 
            // label_parcelas
            // 
            this.label_parcelas.AutoSize = true;
            this.label_parcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parcelas.Location = new System.Drawing.Point(218, 74);
            this.label_parcelas.Name = "label_parcelas";
            this.label_parcelas.Size = new System.Drawing.Size(74, 20);
            this.label_parcelas.TabIndex = 38;
            this.label_parcelas.Text = "Parcelas:";
            // 
            // label_valor_parcelas
            // 
            this.label_valor_parcelas.AutoSize = true;
            this.label_valor_parcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor_parcelas.Location = new System.Drawing.Point(20, 117);
            this.label_valor_parcelas.Name = "label_valor_parcelas";
            this.label_valor_parcelas.Size = new System.Drawing.Size(148, 20);
            this.label_valor_parcelas.TabIndex = 37;
            this.label_valor_parcelas.Text = "Valor das parcelas: ";
            // 
            // FRM_Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(899, 655);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Detalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Informações";
            this.Load += new System.EventHandler(this.FRM_Detalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_servicos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grelha_servicos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_data_final;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_parcelas;
        private System.Windows.Forms.Label label_valor_parcelas;
        private System.Windows.Forms.Label label_maquina;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.Label label_pagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.Label label_placa;
        private System.Windows.Forms.Label label_veiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}