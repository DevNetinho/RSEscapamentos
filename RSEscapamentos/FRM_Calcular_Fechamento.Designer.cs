namespace RSEscapamentos
{
    partial class FRM_Calcular_Fechamento
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
            this.text_data_final = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_data_inicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check_debito = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_maquina = new System.Windows.Forms.TextBox();
            this.check_avista = new System.Windows.Forms.CheckBox();
            this.check_credito = new System.Windows.Forms.CheckBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_data_final = new System.Windows.Forms.Label();
            this.label_data_inicial = new System.Windows.Forms.Label();
            this.label_forma_pagamento = new System.Windows.Forms.Label();
            this.label_maquina_cartao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_data_final
            // 
            this.text_data_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_final.Location = new System.Drawing.Point(312, 44);
            this.text_data_final.Mask = "00/00/0000";
            this.text_data_final.Name = "text_data_final";
            this.text_data_final.Size = new System.Drawing.Size(83, 24);
            this.text_data_final.TabIndex = 36;
            this.text_data_final.Leave += new System.EventHandler(this.text_data_final_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data Final:";
            // 
            // text_data_inicio
            // 
            this.text_data_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data_inicio.Location = new System.Drawing.Point(105, 45);
            this.text_data_inicio.Mask = "00/00/0000";
            this.text_data_inicio.Name = "text_data_inicio";
            this.text_data_inicio.Size = new System.Drawing.Size(83, 24);
            this.text_data_inicio.TabIndex = 38;
            this.text_data_inicio.Leave += new System.EventHandler(this.text_data_inicio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Data Inicial:";
            // 
            // check_debito
            // 
            this.check_debito.AutoSize = true;
            this.check_debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_debito.Location = new System.Drawing.Point(19, 40);
            this.check_debito.Name = "check_debito";
            this.check_debito.Size = new System.Drawing.Size(75, 24);
            this.check_debito.TabIndex = 39;
            this.check_debito.Text = "Débito";
            this.check_debito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text_data_inicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_data_final);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 96);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo de data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.text_maquina);
            this.groupBox2.Controls.Add(this.check_avista);
            this.groupBox2.Controls.Add(this.check_credito);
            this.groupBox2.Controls.Add(this.check_debito);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 138);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Máquina de cartão:";
            // 
            // text_maquina
            // 
            this.text_maquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_maquina.Location = new System.Drawing.Point(166, 85);
            this.text_maquina.MaxLength = 15;
            this.text_maquina.Name = "text_maquina";
            this.text_maquina.Size = new System.Drawing.Size(131, 26);
            this.text_maquina.TabIndex = 43;
            this.text_maquina.TextChanged += new System.EventHandler(this.text_maquina_TextChanged);
            // 
            // check_avista
            // 
            this.check_avista.AutoSize = true;
            this.check_avista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_avista.Location = new System.Drawing.Point(278, 40);
            this.check_avista.Name = "check_avista";
            this.check_avista.Size = new System.Drawing.Size(75, 24);
            this.check_avista.TabIndex = 44;
            this.check_avista.Text = "Á vista";
            this.check_avista.UseVisualStyleBackColor = true;
            // 
            // check_credito
            // 
            this.check_credito.AutoSize = true;
            this.check_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_credito.Location = new System.Drawing.Point(143, 40);
            this.check_credito.Name = "check_credito";
            this.check_credito.Size = new System.Drawing.Size(79, 24);
            this.check_credito.TabIndex = 43;
            this.check_credito.Text = "Crédito";
            this.check_credito.UseVisualStyleBackColor = true;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(95, 275);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(139, 42);
            this.btn_calcular.TabIndex = 47;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(11, 148);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(200, 20);
            this.label_total.TabIndex = 49;
            this.label_total.Text = "Valor total do fechamento: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_data_final);
            this.groupBox3.Controls.Add(this.label_data_inicial);
            this.groupBox3.Controls.Add(this.label_forma_pagamento);
            this.groupBox3.Controls.Add(this.label_maquina_cartao);
            this.groupBox3.Controls.Add(this.label_total);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 210);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // label_data_final
            // 
            this.label_data_final.AutoSize = true;
            this.label_data_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_final.Location = new System.Drawing.Point(193, 36);
            this.label_data_final.Name = "label_data_final";
            this.label_data_final.Size = new System.Drawing.Size(86, 20);
            this.label_data_final.TabIndex = 54;
            this.label_data_final.Text = "Data Final:";
            // 
            // label_data_inicial
            // 
            this.label_data_inicial.AutoSize = true;
            this.label_data_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_inicial.Location = new System.Drawing.Point(10, 36);
            this.label_data_inicial.Name = "label_data_inicial";
            this.label_data_inicial.Size = new System.Drawing.Size(92, 20);
            this.label_data_inicial.TabIndex = 53;
            this.label_data_inicial.Text = "Data Inicial:";
            // 
            // label_forma_pagamento
            // 
            this.label_forma_pagamento.AutoSize = true;
            this.label_forma_pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forma_pagamento.Location = new System.Drawing.Point(11, 73);
            this.label_forma_pagamento.Name = "label_forma_pagamento";
            this.label_forma_pagamento.Size = new System.Drawing.Size(166, 20);
            this.label_forma_pagamento.TabIndex = 52;
            this.label_forma_pagamento.Text = "Forma de pagamento:";
            // 
            // label_maquina_cartao
            // 
            this.label_maquina_cartao.AutoSize = true;
            this.label_maquina_cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maquina_cartao.Location = new System.Drawing.Point(10, 108);
            this.label_maquina_cartao.Name = "label_maquina_cartao";
            this.label_maquina_cartao.Size = new System.Drawing.Size(145, 20);
            this.label_maquina_cartao.TabIndex = 51;
            this.label_maquina_cartao.Text = "Máquina de cartão:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 50;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Calcular_Fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(447, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Calcular_Fechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcular Fechamento";
            this.Load += new System.EventHandler(this.FRM_Calcular_Fechamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox text_data_final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox text_data_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_debito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_avista;
        private System.Windows.Forms.CheckBox check_credito;
        private System.Windows.Forms.TextBox text_maquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_data_final;
        private System.Windows.Forms.Label label_data_inicial;
        private System.Windows.Forms.Label label_forma_pagamento;
        private System.Windows.Forms.Label label_maquina_cartao;
        private System.Windows.Forms.Button button1;
    }
}