namespace RSEscapamentos
{
    partial class FRM_Cadastrar_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.text_placa = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_veiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_telefone = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grelha_cliente = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_data = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_count = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radio_veiculo = new System.Windows.Forms.RadioButton();
            this.radio_placa = new System.Windows.Forms.RadioButton();
            this.radio_data = new System.Windows.Forms.RadioButton();
            this.radio_cliente = new System.Windows.Forms.RadioButton();
            this.text_pesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_cliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_placa
            // 
            this.text_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_placa.Location = new System.Drawing.Point(386, 47);
            this.text_placa.Mask = ">LLL-0000";
            this.text_placa.Name = "text_placa";
            this.text_placa.Size = new System.Drawing.Size(93, 22);
            this.text_placa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de entrada:";
            // 
            // text_veiculo
            // 
            this.text_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_veiculo.Location = new System.Drawing.Point(17, 47);
            this.text_veiculo.MaxLength = 30;
            this.text_veiculo.Name = "text_veiculo";
            this.text_veiculo.Size = new System.Drawing.Size(328, 22);
            this.text_veiculo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // text_cliente
            // 
            this.text_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_cliente.Location = new System.Drawing.Point(18, 108);
            this.text_cliente.MaxLength = 40;
            this.text_cliente.Name = "text_cliente";
            this.text_cliente.Size = new System.Drawing.Size(279, 22);
            this.text_cliente.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Celular/Telefone:";
            // 
            // text_telefone
            // 
            this.text_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_telefone.Location = new System.Drawing.Point(546, 108);
            this.text_telefone.Name = "text_telefone";
            this.text_telefone.Size = new System.Drawing.Size(136, 22);
            this.text_telefone.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Tag = "";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Selecione:";
            // 
            // grelha_cliente
            // 
            this.grelha_cliente.AllowUserToAddRows = false;
            this.grelha_cliente.AllowUserToDeleteRows = false;
            this.grelha_cliente.AllowUserToResizeColumns = false;
            this.grelha_cliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            this.grelha_cliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grelha_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grelha_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grelha_cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grelha_cliente.ColumnHeadersHeight = 45;
            this.grelha_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grelha_cliente.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grelha_cliente.Location = new System.Drawing.Point(16, 241);
            this.grelha_cliente.MultiSelect = false;
            this.grelha_cliente.Name = "grelha_cliente";
            this.grelha_cliente.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grelha_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grelha_cliente.RowHeadersVisible = false;
            this.grelha_cliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grelha_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_cliente.Size = new System.Drawing.Size(781, 299);
            this.grelha_cliente.TabIndex = 6;
            this.grelha_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_cliente_CellClick);
            this.grelha_cliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_cliente_CellDoubleClick);
            this.grelha_cliente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_cliente_CellEnter);
            this.grelha_cliente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grelha_cliente_ColumnHeaderMouseClick);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(673, 560);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(124, 49);
            this.btn_cadastrar.TabIndex = 3;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(537, 560);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(124, 49);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.text_data);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.text_telefone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text_veiculo);
            this.groupBox1.Controls.Add(this.text_placa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_cliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente:";
            // 
            // text_data
            // 
            this.text_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_data.Location = new System.Drawing.Point(532, 47);
            this.text_data.Mask = "00/00/0000";
            this.text_data.Name = "text_data";
            this.text_data.Size = new System.Drawing.Size(91, 22);
            this.text_data.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(646, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 22);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Não possui data.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_count.Location = new System.Drawing.Point(16, 570);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(211, 24);
            this.label_count.TabIndex = 5;
            this.label_count.Text = "Número de cadastros: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pesquisar:";
            // 
            // radio_veiculo
            // 
            this.radio_veiculo.AutoSize = true;
            this.radio_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_veiculo.Location = new System.Drawing.Point(241, 195);
            this.radio_veiculo.Name = "radio_veiculo";
            this.radio_veiculo.Size = new System.Drawing.Size(65, 19);
            this.radio_veiculo.TabIndex = 9;
            this.radio_veiculo.Text = "Veículo";
            this.radio_veiculo.UseVisualStyleBackColor = true;
            this.radio_veiculo.CheckedChanged += new System.EventHandler(this.radio_veiculo_CheckedChanged);
            // 
            // radio_placa
            // 
            this.radio_placa.AutoSize = true;
            this.radio_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_placa.Location = new System.Drawing.Point(309, 195);
            this.radio_placa.Name = "radio_placa";
            this.radio_placa.Size = new System.Drawing.Size(56, 19);
            this.radio_placa.TabIndex = 10;
            this.radio_placa.Text = "Placa";
            this.radio_placa.UseVisualStyleBackColor = true;
            this.radio_placa.CheckedChanged += new System.EventHandler(this.radio_placa_CheckedChanged);
            // 
            // radio_data
            // 
            this.radio_data.AutoSize = true;
            this.radio_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_data.Location = new System.Drawing.Point(430, 195);
            this.radio_data.Name = "radio_data";
            this.radio_data.Size = new System.Drawing.Size(51, 19);
            this.radio_data.TabIndex = 11;
            this.radio_data.Text = "Data";
            this.radio_data.UseVisualStyleBackColor = true;
            this.radio_data.CheckedChanged += new System.EventHandler(this.radio_data_CheckedChanged);
            // 
            // radio_cliente
            // 
            this.radio_cliente.AutoSize = true;
            this.radio_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_cliente.Location = new System.Drawing.Point(367, 195);
            this.radio_cliente.Name = "radio_cliente";
            this.radio_cliente.Size = new System.Drawing.Size(63, 19);
            this.radio_cliente.TabIndex = 12;
            this.radio_cliente.Text = "Cliente";
            this.radio_cliente.UseVisualStyleBackColor = true;
            this.radio_cliente.CheckedChanged += new System.EventHandler(this.radio_cliente_CheckedChanged);
            // 
            // text_pesquisa
            // 
            this.text_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pesquisa.Location = new System.Drawing.Point(105, 195);
            this.text_pesquisa.MaxLength = 30;
            this.text_pesquisa.Name = "text_pesquisa";
            this.text_pesquisa.Size = new System.Drawing.Size(122, 22);
            this.text_pesquisa.TabIndex = 13;
            this.text_pesquisa.TextChanged += new System.EventHandler(this.text_pesquisa_TextChanged);
            this.text_pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_pesquisa_KeyPress);
            this.text_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_pesquisa_KeyUp);
            // 
            // FRM_Cadastrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(827, 621);
            this.Controls.Add(this.text_pesquisa);
            this.Controls.Add(this.radio_cliente);
            this.Controls.Add(this.radio_data);
            this.Controls.Add(this.radio_placa);
            this.Controls.Add(this.radio_veiculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.grelha_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Cadastrar_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.FRM_Cadastrar_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_cliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox text_placa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_veiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox text_telefone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox text_data;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.DataGridView grelha_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radio_veiculo;
        private System.Windows.Forms.RadioButton radio_placa;
        private System.Windows.Forms.RadioButton radio_data;
        private System.Windows.Forms.RadioButton radio_cliente;
        private System.Windows.Forms.TextBox text_pesquisa;
    }
}