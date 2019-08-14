namespace RSEscapamentos
{
    partial class FRM_Forma_Pagamento
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
            this.label_parcelas = new System.Windows.Forms.Label();
            this.text_maquina = new System.Windows.Forms.TextBox();
            this.label_maquina = new System.Windows.Forms.Label();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label_tipo = new System.Windows.Forms.Label();
            this.combo_pagamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.contador_parcelas = new System.Windows.Forms.NumericUpDown();
            this.label_total = new System.Windows.Forms.Label();
            this.label_data_final = new System.Windows.Forms.Label();
            this.text_data = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contador_parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_parcelas
            // 
            this.label_parcelas.AutoSize = true;
            this.label_parcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parcelas.Location = new System.Drawing.Point(13, 112);
            this.label_parcelas.Name = "label_parcelas";
            this.label_parcelas.Size = new System.Drawing.Size(128, 16);
            this.label_parcelas.TabIndex = 25;
            this.label_parcelas.Text = "Valor das parcelas: ";
            // 
            // text_maquina
            // 
            this.text_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_maquina.Location = new System.Drawing.Point(380, 107);
            this.text_maquina.MaxLength = 15;
            this.text_maquina.Name = "text_maquina";
            this.text_maquina.Size = new System.Drawing.Size(120, 22);
            this.text_maquina.TabIndex = 24;
            this.text_maquina.TextChanged += new System.EventHandler(this.text_maquina_TextChanged);
            // 
            // label_maquina
            // 
            this.label_maquina.AutoSize = true;
            this.label_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maquina.Location = new System.Drawing.Point(251, 110);
            this.label_maquina.Name = "label_maquina";
            this.label_maquina.Size = new System.Drawing.Size(123, 16);
            this.label_maquina.TabIndex = 23;
            this.label_maquina.Text = "Máquina de cartão:";
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(56, 66);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 24);
            this.comboBox_tipo.TabIndex = 22;
            this.comboBox_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_SelectedIndexChanged);
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipo.Location = new System.Drawing.Point(15, 69);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(39, 16);
            this.label_tipo.TabIndex = 21;
            this.label_tipo.Text = "Tipo:";
            // 
            // combo_pagamento
            // 
            this.combo_pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_pagamento.FormattingEnabled = true;
            this.combo_pagamento.Location = new System.Drawing.Point(159, 25);
            this.combo_pagamento.Name = "combo_pagamento";
            this.combo_pagamento.Size = new System.Drawing.Size(121, 24);
            this.combo_pagamento.TabIndex = 20;
            this.combo_pagamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Forma de pagamento:";
            // 
            // btn_concluir
            // 
            this.btn_concluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.Location = new System.Drawing.Point(391, 160);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(131, 38);
            this.btn_concluir.TabIndex = 27;
            this.btn_concluir.Text = "Finalizar";
            this.btn_concluir.UseVisualStyleBackColor = true;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(255, 160);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(125, 38);
            this.btn_cancelar.TabIndex = 28;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Parcelas:";
            // 
            // contador_parcelas
            // 
            this.contador_parcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador_parcelas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contador_parcelas.Location = new System.Drawing.Point(282, 66);
            this.contador_parcelas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.contador_parcelas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.contador_parcelas.Name = "contador_parcelas";
            this.contador_parcelas.Size = new System.Drawing.Size(39, 22);
            this.contador_parcelas.TabIndex = 31;
            this.contador_parcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contador_parcelas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.contador_parcelas.ValueChanged += new System.EventHandler(this.contador_parcelas_ValueChanged);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(13, 142);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(74, 16);
            this.label_total.TabIndex = 32;
            this.label_total.Text = "Valor total: ";
            // 
            // label_data_final
            // 
            this.label_data_final.AutoSize = true;
            this.label_data_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_final.Location = new System.Drawing.Point(308, 28);
            this.label_data_final.Name = "label_data_final";
            this.label_data_final.Size = new System.Drawing.Size(72, 16);
            this.label_data_final.TabIndex = 33;
            this.label_data_final.Text = "Data Final:";
            // 
            // text_data
            // 
            this.text_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data.Location = new System.Drawing.Point(386, 25);
            this.text_data.Mask = "00/00/0000";
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(83, 22);
            this.text_data.TabIndex = 34;
            this.text_data.Leave += new System.EventHandler(this.text_data_Leave);
            // 
            // FRM_Forma_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(570, 210);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.label_data_final);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.contador_parcelas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.label_parcelas);
            this.Controls.Add(this.text_maquina);
            this.Controls.Add(this.label_maquina);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.label_tipo);
            this.Controls.Add(this.combo_pagamento);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Forma_Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finalizar";
            this.Load += new System.EventHandler(this.FRM_Finalizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contador_parcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_parcelas;
        private System.Windows.Forms.TextBox text_maquina;
        private System.Windows.Forms.Label label_maquina;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.ComboBox combo_pagamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown contador_parcelas;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_data_final;
        private System.Windows.Forms.MaskedTextBox text_data;
    }
}