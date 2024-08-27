using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    public partial class FormGerenciarEstudantes : Form
    {
        public FormGerenciarEstudantes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Estudante estudante = new Estudante();

        private void FormGerenciarEstudantes_Load(object sender, EventArgs e)
        {
            //preencher a tabela com os alunos do banco de dados.
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

        }

        //Método que preenche a tabela com os alunos do banco de dados.
        public void preencheTabela(MySqlCommand comando)
        {
            dataGridViewListaDeAlunos.ReadOnly = true;

            //Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            //Determina uma altura padrão para as linhas da tabelas
            dataGridViewListaDeAlunos.RowTemplate.Height = 80;
            //Determina a origem da tabela
            dataGridViewListaDeAlunos.DataSource = estudante.getEstudantes(comando);
            //Determinar qual será a coluna com as imagens
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //Impede o usuário de incluir linhas
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;

            //Mostra o total de alunos
            labelTotalAlunos.Text = "Total de Alunos: " + dataGridViewListaDeAlunos.Rows.Count;
        }

        private void dataGridViewListaDeAlunos_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[1].Value.ToString();
            textBoxSobrenome.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerNascimento.Value = (DateTime)dataGridViewListaDeAlunos.CurrentRow.Cells[3].Value;

            if (dataGridViewListaDeAlunos.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                radioButtonFeminino.Checked = true;
            }
            else
            {
                radioButtonMasculino.Checked = true;
            }

            textBoxTelefone.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[5].Value.ToString();
            textBoxEndereco.Text = dataGridViewListaDeAlunos.CurrentRow.Cells[6].Value.ToString();

            byte[] imagem;
            imagem = (byte[])dataGridViewListaDeAlunos.CurrentRow.Cells[7].Value;
            MemoryStream fotoDoAluno = new MemoryStream(imagem);
            pictureBoxFoto.Image = Image.FromStream(fotoDoAluno);
        }

        private void buttonRedefinir_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            textBoxEndereco.Text = "";
            textBoxTelefone.Text = "";
            radioButtonFeminino.Checked = true;
            dateTimePickerNascimento.Value = DateTime.Now;
            pictureBoxFoto.Image = null;
        }

        private void buttonInserirFoto_Click(object sender, EventArgs e)
        {
            //abre janela para pesquisar a imagem no computador.
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|*.jpg;*.png;*.jpeg;*.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonBaixarFoto_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarArquivo = new SaveFileDialog();
            //define o nome do arquivo que será salvo
            salvarArquivo.FileName = "Estudante_" + textBoxID.Text;

            //Verificar se tem imagem na caixa de imagem
            if (pictureBoxFoto.Image == null)
            {
                MessageBox.Show("Não tem foto para baixar");
            }
            else if (salvarArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image.Save(salvarArquivo.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonBuscarDado_Click(object sender, EventArgs e)
        {
            string pesquisa = "SELECT * FROM `estudantes` WHERE CONCAT(`nome`,`sobrenome`,`endereco`) LIKE'%" + textBoxBuscarDado.Text + "%'";
            MySqlCommand comando = new MySqlCommand(pesquisa);
            preencheTabela(comando);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                // Esta linha só existe em "buttonSalvar_Click(...)"
                int id = Convert.ToInt32(textBoxID.Text);

                string nome = textBoxNome.Text;
                string sobrenome = textBoxSobrenome.Text;
                DateTime nascimento = dateTimePickerNascimento.Value;
                string telefone = textBoxTelefone.Text;
                string endereco = textBoxEndereco.Text;
                string genero = "Feminino";

                if (radioButtonMasculino.Checked == true)
                {
                    genero = "Masculino";
                }

                MemoryStream foto = new MemoryStream();

                // Verificar se o aluno tem entre 10 e 100 anos.
                int anoDeNascimento = dateTimePickerNascimento.Value.Year;
                int anoAtual = DateTime.Now.Year;

                if ((anoAtual - anoDeNascimento) < 10 || (anoAtual - anoDeNascimento) > 100)
                {
                    MessageBox.Show("O aluno precisa ter entre 10 e 100 anos.",
                        "Ano de nascimento inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else if (Verificar())
                {
                    pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);

                    if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento, telefone,
                        genero, endereco, foto))
                    {
                        MessageBox.Show("Dados salvos!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //preencher a tabela com os alunos do banco de dados.
                        preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível salvar!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("Existem campos não preenchidos!", "Campos não preenchidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

            try
            {
                //referencia a ID do aluno
                int idDoAluno = Convert.ToInt32(textBoxID.Text);
                //Mostrar uma caixa de dialogo perguntando se o usuario
                //tem certeza de que quer apagar o aluno
                if (MessageBox.Show("Tem certeza que deseja apagar o aluno?", "Apagar Estudante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (estudante.apagarEstudante(idDoAluno))
                    {
                        MessageBox.Show("Aluno apagado!", "Apagar Estudante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpa as coisas de texto
                        textBoxNome.Text = "";
                        textBoxSobrenome.Text = "";
                        textBoxTelefone.Text = "";
                        dateTimePickerNascimento.Text = "";
                        textBoxEndereco.Text = "";
                        pictureBoxFoto.Text = "";

                        //preencher a tabela com os alunos do banco de dados.
                        preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));

                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") || (textBoxSobrenome.Text.Trim() == "") || (textBoxTelefone.Text.Trim() == "") || (textBoxEndereco.Text.Trim() == "") || (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void dataGridViewListaDeAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
