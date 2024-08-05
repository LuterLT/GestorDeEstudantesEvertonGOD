namespace GestorDeEstudantesT7EvertonGOD_VS
{
    partial class FormEstatisticas
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
            this.panelTotalEstudantes = new System.Windows.Forms.Panel();
            this.labelTotalEstudantes = new System.Windows.Forms.Label();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotalEstudantes.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalEstudantes
            // 
            this.panelTotalEstudantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.panelTotalEstudantes.Controls.Add(this.labelTotalEstudantes);
            this.panelTotalEstudantes.Location = new System.Drawing.Point(106, 45);
            this.panelTotalEstudantes.Name = "panelTotalEstudantes";
            this.panelTotalEstudantes.Size = new System.Drawing.Size(602, 175);
            this.panelTotalEstudantes.TabIndex = 0;
            this.panelTotalEstudantes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTotalEstudantes_Paint);
            this.panelTotalEstudantes.MouseEnter += new System.EventHandler(this.panelTotalEstudantes_MouseEnter);
            this.panelTotalEstudantes.MouseLeave += new System.EventHandler(this.panelTotalEstudantes_MouseLeave);
            // 
            // labelTotalEstudantes
            // 
            this.labelTotalEstudantes.AutoSize = true;
            this.labelTotalEstudantes.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEstudantes.ForeColor = System.Drawing.Color.White;
            this.labelTotalEstudantes.Location = new System.Drawing.Point(165, 83);
            this.labelTotalEstudantes.Name = "labelTotalEstudantes";
            this.labelTotalEstudantes.Size = new System.Drawing.Size(266, 25);
            this.labelTotalEstudantes.TabIndex = 2;
            this.labelTotalEstudantes.Text = "Total de Estudantes: 999";
            this.labelTotalEstudantes.Click += new System.EventHandler(this.labelTotalEstudantes_Click);
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(418, 226);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(290, 184);
            this.panelMeninas.TabIndex = 1;
            this.panelMeninas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMeninas_Paint);
            this.panelMeninas.MouseEnter += new System.EventHandler(this.panelMeninas_MouseEnter);
            this.panelMeninas.MouseLeave += new System.EventHandler(this.panelMeninas_MouseLeave);
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.ForeColor = System.Drawing.Color.White;
            this.labelMeninas.Location = new System.Drawing.Point(71, 76);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(153, 25);
            this.labelMeninas.TabIndex = 2;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.Click += new System.EventHandler(this.labelMeninas_Click);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(108, 226);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(290, 184);
            this.panelMeninos.TabIndex = 2;
            this.panelMeninos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMeninos_Paint);
            this.panelMeninos.MouseEnter += new System.EventHandler(this.panelMeninos_MouseEnter);
            this.panelMeninos.MouseLeave += new System.EventHandler(this.panelMeninos_MouseLeave);
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.ForeColor = System.Drawing.Color.White;
            this.labelMeninos.Location = new System.Drawing.Point(61, 76);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(153, 25);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.Click += new System.EventHandler(this.labelMeninos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelTotalEstudantes);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelTotalEstudantes.ResumeLayout(false);
            this.panelTotalEstudantes.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalEstudantes;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelTotalEstudantes;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Label label1;
    }
}