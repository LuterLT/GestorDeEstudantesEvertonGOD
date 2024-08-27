using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    public partial class FormImprimirAlunos : Form
    {
        public FormImprimirAlunos()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormImprimirAlunos_Load(object sender, EventArgs e)
        {

            //Preenche o dataGridView com as informações dos estudantes.
            preencheTabela(new MySqlCommand("SELECT * FROM `estudantes`"));
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");


            //Desativar Filtro por data
            if (radioButtonNao.Checked == true)
            {
                dateTimePickerInicial.Enabled = false;
                dateTimePickerFinal.Enabled = false;
            }

        }

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
        }

        private void dataGridViewListaDeAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Enabled = false;
            dateTimePickerFinal.Enabled = false;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerInicial.Enabled = true;
            dateTimePickerFinal.Enabled = true;
        }

        private void buttonFiltrarDados_Click(object sender, EventArgs e)
        {
            //filtra os dados que serão exibidos na tela
            MySqlCommand comando;
            string busca;

            //verificar se o usuário quer usar um intervalo de datas
            if (radioButtonSim.Checked == true)
            {
                //pega as datas que o usuário selecionou
                string dataInicial = dateTimePickerInicial.Value.ToString("yyyy/MM/dd");
                //formato dia/mês/ano ex. 27/08/2024
                string dataFinal = dateTimePickerFinal.Value.ToString("yyyy/MM/dd");
                if (radioButtonMasculino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' AND genero = 'Masculino'";
                }
                else if (radioButtonFemino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '" + dataInicial + "' AND '" + dataFinal + "' AND genero = 'Feminino'";
                }
                else
                {
                    busca = "SELECT * FROM `estudantes` WHERE `nascimento` BETWEEN '" + dataInicial + "' AND '" + dataFinal + "'";
                }

                comando = new MySqlCommand(busca);
                preencheTabela(comando);

            }
            else
            {
                if (radioButtonMasculino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE genero = 'Masculino'";
                }
                else if (radioButtonFemino.Checked)
                {
                    busca = "SELECT * FROM `estudantes` WHERE genero = 'Feminino'";
                }
                else
                {
                    busca = "SELECT * FROM `estudantes`";
                }
            }
        }
    }
}
