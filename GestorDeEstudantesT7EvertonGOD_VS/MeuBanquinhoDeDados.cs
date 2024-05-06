using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    internal class MeuBanquinhoDeDados
    {
        //Criar a Conexão com o Banco de DAdos.
        MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t7");
    }
}
