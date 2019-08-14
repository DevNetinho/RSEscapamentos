namespace RSEscapamentos
{
    partial class FRM_Alterar_Senha
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
            this.text_nova_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_confirmar_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.check_visualizar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // text_nova_senha
            // 
            this.text_nova_senha.Location = new System.Drawing.Point(79, 49);
            this.text_nova_senha.MaxLength = 30;
            this.text_nova_senha.Name = "text_nova_senha";
            this.text_nova_senha.Size = new System.Drawing.Size(145, 20);
            this.text_nova_senha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova senha:";
            // 
            // text_confirmar_senha
            // 
            this.text_confirmar_senha.Location = new System.Drawing.Point(79, 130);
            this.text_confirmar_senha.MaxLength = 30;
            this.text_confirmar_senha.Name = "text_confirmar_senha";
            this.text_confirmar_senha.Size = new System.Drawing.Size(145, 20);
            this.text_confirmar_senha.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmar senha:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(111, 188);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(82, 34);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(206, 188);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(88, 34);
            this.btn_confirmar.TabIndex = 8;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // check_visualizar
            // 
            this.check_visualizar.AutoSize = true;
            this.check_visualizar.Location = new System.Drawing.Point(79, 75);
            this.check_visualizar.Name = "check_visualizar";
            this.check_visualizar.Size = new System.Drawing.Size(102, 17);
            this.check_visualizar.TabIndex = 10;
            this.check_visualizar.Text = "Visualizar senha";
            this.check_visualizar.UseVisualStyleBackColor = true;
            this.check_visualizar.CheckedChanged += new System.EventHandler(this.check_visualizar_CheckedChanged);
            // 
            // FRM_Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 234);
            this.ControlBox = false;
            this.Controls.Add(this.check_visualizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.text_confirmar_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_nova_senha);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_Alterar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.FRM_Alterar_Senha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nova_senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_confirmar_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.CheckBox check_visualizar;
    }
}