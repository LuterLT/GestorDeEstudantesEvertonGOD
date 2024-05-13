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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //cria um objeto da classe "MeuBanquinhoDeDados"
            MeuBanquinhoDeDados meuBancoDeDados = new MeuBanquinhoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable();
            MySqlCommand comandoSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario`=@usuario AND `senha`=@senha", meuBancoDeDados.getConexao);

            comandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = textBoxNome.Text;
            comandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text;

            meuAdaptadorSql.SelectCommand = comandoSql;

            meuAdaptadorSql.Fill(tabelaDeDados);

            if (tabelaDeDados.Rows.Count > 0)
            {
                MessageBox.Show("SIM");
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
