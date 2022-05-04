namespace GestaoTarefas.WinApp
{
    partial class TelaPrincipal
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
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTarefa
            // 
            this.btnTarefa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTarefa.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTarefa.Location = new System.Drawing.Point(38, 139);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(177, 68);
            this.btnTarefa.TabIndex = 0;
            this.btnTarefa.Text = "Tarefas";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click_1);
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContatos.Location = new System.Drawing.Point(247, 139);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(187, 68);
            this.btnContatos.TabIndex = 1;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompromissos.Location = new System.Drawing.Point(464, 139);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(190, 68);
            this.btnCompromissos.TabIndex = 2;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.btnTarefa);
            this.panel1.Controls.Add(this.btnCompromissos);
            this.panel1.Controls.Add(this.btnContatos);
            this.panel1.Location = new System.Drawing.Point(-26, -37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 358);
            this.panel1.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 284);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Panel panel1;
    }
}