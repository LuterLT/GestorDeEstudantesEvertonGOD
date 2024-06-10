using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    public partial class FormListarEstudante : Form
    {
        public FormListarEstudante()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListarEstudante_Load(object sender, EventArgs e)
        {
            //Preenche o dataGridView com as informações dos estudantes.

            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
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

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            //atualiza a lista de estudantes
            
        }

        private void dataGridViewListaDeAlunos_DoubleClick(object sender, EventArgs e)
        {
            //exibir as informações do estudante ao clicar nele
        }
    }
}
