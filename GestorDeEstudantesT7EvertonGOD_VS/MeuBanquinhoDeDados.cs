using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    internal class MeuBanquinhoDeDados
    {
        //Criar a Conexão com o Banco de DAdos.
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t7");

        //Criar um acessor
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }

        //função pra abrir a conexão com o banco de dados
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            { 
                conexao.Open();
            }
        }

        //função para fechar a conexão com o banco de dados
        public void fecharConexao()
        { 
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
