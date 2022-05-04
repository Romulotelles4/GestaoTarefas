namespace GestaoTarefas.WinApp
{
    partial class CadastroCompromissos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textAssunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textHorarioInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textHorariotermino = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assunto:";
            // 
            // textAssunto
            // 
            this.textAssunto.Location = new System.Drawing.Point(71, 6);
            this.textAssunto.Name = "textAssunto";
            this.textAssunto.Size = new System.Drawing.Size(130, 23);
            this.textAssunto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local:";
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(71, 64);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(130, 23);
            this.textData.TabIndex = 3;
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(71, 35);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(130, 23);
            this.textLocal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // textHorarioInicio
            // 
            this.textHorarioInicio.Location = new System.Drawing.Point(116, 93);
            this.textHorarioInicio.Name = "textHorarioInicio";
            this.textHorarioInicio.Size = new System.Drawing.Size(59, 23);
            this.textHorarioInicio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horário de início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Horário de término:";
            // 
            // textHorariotermino
            // 
            this.textHorariotermino.Location = new System.Drawing.Point(315, 93);
            this.textHorariotermino.Name = "textHorariotermino";
            this.textHorariotermino.Size = new System.Drawing.Size(59, 23);
            this.textHorariotermino.TabIndex = 9;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(251, 174);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 43);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(332, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 43);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 229);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.textHorariotermino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textHorarioInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAssunto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCompromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAssunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHorarioInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHorariotermino;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
    }
}