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
    public partial class FormGerenciarEstudantes: Form
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
            else
            {
                salvarArquivo.ShowDialog();
                pictureBoxFoto.Image.Save(salvarArquivo.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void buttonBuscarDado_Click(object sender, EventArgs e)
        {
            string pesquisa = "SELECT * FROM `estudantes` WHERE CONCAT(`nome`,`sobrenome`,`endereco`) LIKE'%"+textBoxBuscarDado.Text+"%'";
            MySqlCommand comando = new MySqlCommand(pesquisa);
            preencheTabela(comando);
        }
    }
}
