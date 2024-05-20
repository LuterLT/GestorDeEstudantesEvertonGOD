namespace GestorDeEstudantesT7EvertonGOD_VS
{
    partial class FormInserirEstudante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirEstudante));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.buttonInserirFoto = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(100, 57);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(211, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(100, 89);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(211, 20);
            this.textBoxSobrenome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sobrenome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nascimento";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(100, 133);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerNascimento.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gênero";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(136, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 47);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.ForeColor = System.Drawing.Color.White;
            this.radioButtonFeminino.Location = new System.Drawing.Point(123, 19);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.ForeColor = System.Drawing.Color.White;
            this.radioButtonMasculino.Location = new System.Drawing.Point(15, 19);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Endereço";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("News701 BT", 8.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(393, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Foto";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = global::GestorDeEstudantesT7EvertonGOD_VS.Properties.Resources.user;
            this.pictureBoxFoto.Location = new System.Drawing.Point(364, 57);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 19;
            this.pictureBoxFoto.TabStop = false;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(136, 197);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(175, 20);
            this.textBoxTelefone.TabIndex = 20;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(138, 229);
            this.textBoxEndereco.Multiline = true;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(175, 42);
            this.textBoxEndereco.TabIndex = 21;
            // 
            // buttonInserirFoto
            // 
            this.buttonInserirFoto.Location = new System.Drawing.Point(364, 163);
            this.buttonInserirFoto.Name = "buttonInserirFoto";
            this.buttonInserirFoto.Size = new System.Drawing.Size(100, 38);
            this.buttonInserirFoto.TabIndex = 22;
            this.buttonInserirFoto.Text = "Inserir";
            this.buttonInserirFoto.UseVisualStyleBackColor = true;
            this.buttonInserirFoto.Click += new System.EventHandler(this.buttonInserirFoto_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(75, 404);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(178, 65);
            this.buttonAdicionar.TabIndex = 23;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(286, 404);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(142, 65);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(507, 523);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonInserirFoto);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInserirEstudante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Estudante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Button buttonInserirFoto;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}