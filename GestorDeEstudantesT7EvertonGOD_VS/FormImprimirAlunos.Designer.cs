namespace GestorDeEstudantesT7EvertonGOD_VS
{
    partial class FormImprimirAlunos
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
            this.dataGridViewListaDeAlunos = new System.Windows.Forms.DataGridView();
            this.buttonBaixarDocumento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrarDados = new System.Windows.Forms.Button();
            this.groupBoxIntervaloDatas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonFemino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxIntervaloDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListaDeAlunos
            // 
            this.dataGridViewListaDeAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaDeAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeAlunos.Location = new System.Drawing.Point(27, 119);
            this.dataGridViewListaDeAlunos.Name = "dataGridViewListaDeAlunos";
            this.dataGridViewListaDeAlunos.ShowEditingIcon = false;
            this.dataGridViewListaDeAlunos.Size = new System.Drawing.Size(810, 283);
            this.dataGridViewListaDeAlunos.TabIndex = 1;
            this.dataGridViewListaDeAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListaDeAlunos_CellContentClick);
            // 
            // buttonBaixarDocumento
            // 
            this.buttonBaixarDocumento.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBaixarDocumento.Location = new System.Drawing.Point(294, 408);
            this.buttonBaixarDocumento.Name = "buttonBaixarDocumento";
            this.buttonBaixarDocumento.Size = new System.Drawing.Size(301, 40);
            this.buttonBaixarDocumento.TabIndex = 2;
            this.buttonBaixarDocumento.Text = "Baixar Documento";
            this.buttonBaixarDocumento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFiltrarDados);
            this.groupBox1.Controls.Add(this.groupBoxIntervaloDatas);
            this.groupBox1.Controls.Add(this.radioButtonTodos);
            this.groupBox1.Controls.Add(this.radioButtonFemino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonFiltrarDados
            // 
            this.buttonFiltrarDados.BackColor = System.Drawing.Color.Indigo;
            this.buttonFiltrarDados.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrarDados.Location = new System.Drawing.Point(657, 26);
            this.buttonFiltrarDados.Name = "buttonFiltrarDados";
            this.buttonFiltrarDados.Size = new System.Drawing.Size(137, 57);
            this.buttonFiltrarDados.TabIndex = 4;
            this.buttonFiltrarDados.Text = "Filtrar Dados";
            this.buttonFiltrarDados.UseVisualStyleBackColor = false;
            this.buttonFiltrarDados.Click += new System.EventHandler(this.buttonFiltrarDados_Click);
            // 
            // groupBoxIntervaloDatas
            // 
            this.groupBoxIntervaloDatas.Controls.Add(this.label3);
            this.groupBoxIntervaloDatas.Controls.Add(this.dateTimePickerFinal);
            this.groupBoxIntervaloDatas.Controls.Add(this.dateTimePickerInicial);
            this.groupBoxIntervaloDatas.Controls.Add(this.label2);
            this.groupBoxIntervaloDatas.Controls.Add(this.radioButtonNao);
            this.groupBoxIntervaloDatas.Controls.Add(this.radioButtonSim);
            this.groupBoxIntervaloDatas.Controls.Add(this.label1);
            this.groupBoxIntervaloDatas.Location = new System.Drawing.Point(314, 13);
            this.groupBoxIntervaloDatas.Name = "groupBoxIntervaloDatas";
            this.groupBoxIntervaloDatas.Size = new System.Drawing.Size(325, 81);
            this.groupBoxIntervaloDatas.TabIndex = 3;
            this.groupBoxIntervaloDatas.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "e";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(228, 51);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerFinal.TabIndex = 7;
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CustomFormat = "";
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(103, 51);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerInicial.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nascidos entre:";
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Checked = true;
            this.radioButtonNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNao.Location = new System.Drawing.Point(231, 14);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(48, 19);
            this.radioButtonNao.TabIndex = 4;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "Não";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            this.radioButtonNao.CheckedChanged += new System.EventHandler(this.radioButtonNao_CheckedChanged);
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSim.Location = new System.Drawing.Point(172, 14);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(47, 19);
            this.radioButtonSim.TabIndex = 3;
            this.radioButtonSim.Text = "Sim";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usar intervalo de datas:";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTodos.Location = new System.Drawing.Point(23, 50);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(64, 19);
            this.radioButtonTodos.TabIndex = 2;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemino
            // 
            this.radioButtonFemino.AutoSize = true;
            this.radioButtonFemino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemino.Location = new System.Drawing.Point(101, 50);
            this.radioButtonFemino.Name = "radioButtonFemino";
            this.radioButtonFemino.Size = new System.Drawing.Size(85, 19);
            this.radioButtonFemino.TabIndex = 1;
            this.radioButtonFemino.TabStop = true;
            this.radioButtonFemino.Text = "Feminino";
            this.radioButtonFemino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(192, 50);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(91, 19);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // FormImprimirAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBaixarDocumento);
            this.Controls.Add(this.dataGridViewListaDeAlunos);
            this.Name = "FormImprimirAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA-Imprimir";
            this.Load += new System.EventHandler(this.FormImprimirAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIntervaloDatas.ResumeLayout(false);
            this.groupBoxIntervaloDatas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaDeAlunos;
        private System.Windows.Forms.Button buttonBaixarDocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxIntervaloDatas;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonFemino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFiltrarDados;
    }
}