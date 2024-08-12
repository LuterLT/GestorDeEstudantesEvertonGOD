using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEstudantesT7EvertonGOD_VS
{
    internal class Estudante
    {
        MeuBanquinhoDeDados meuBancoDeDados = new MeuBanquinhoDeDados();

        public bool inserirEstudante(string nome, string sobrenome, DateTime nascimento, string telefone, string genero, string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nome,@sobrenome,@nascimento,@genero,@telefone,@endereco,@foto)", meuBancoDeDados.getConexao);

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto.ToArray();

            meuBancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }

        }

        //Retorna a tabela dos estudantes que estão no banco de dados

        public DataTable getEstudantes(MySqlCommand comando)
        {
            comando.Connection = meuBancoDeDados.getConexao;

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabelaDeDados = new DataTable();
            adaptador.Fill(tabelaDeDados);

            return tabelaDeDados;
        }

        public bool atualizarEstudante(int id, string nome, string sobrenome, DateTime nascimento, string telefone, string genero, string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes` SET `nome`=@nome,`sobrenome`=@sobrenome,`nascimento`=@nascimento,`genero`=@genero,`telefone`=@telefone,`endereco`=@endereco,`foto`=@foto WHERE `id`=@id", meuBancoDeDados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sobrenome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nascimento", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@genero", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@endereco", MySqlDbType.Text).Value = endereco;
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto.ToArray();

            meuBancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }

        }

        //crair o método de apagar o estudante com base no ID
        public bool apagarEstudante(int id)
        {
            meuBancoDeDados.abrirConexao();
            MySqlCommand comando = new MySqlCommand("DELETE FROM `estudantes` WHERE `id`=@id");

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            meuBancoDeDados.abrirConexao();
            if (comando.ExecuteNonQuery() == 1)
            {
                meuBancoDeDados.fecharConexao();
                return true;
            }
            else
            {
                meuBancoDeDados.fecharConexao();
                return false;
            }
        }

        //função que faz a contagem de alunos
        public string fazerContagem(string pesquisa)
        {
            MySqlCommand comando = new MySqlCommand(pesquisa, meuBancoDeDados.getConexao);

            meuBancoDeDados.abrirConexao();
            //a pesquisa
            string contagem = comando.ExecuteScalar().ToString();
            meuBancoDeDados.fecharConexao();
            
            return contagem;
        }

        //pega o total de estudantes
        public string totalDeEstudantes()
        {
            return fazerContagem("SELECT COUNT(*) FROM `estudantes`");
        }
        public string totalDeEstudantesMeninas()
        {
            return fazerContagem("SELECT COUNT(*) FROM `estudantes` WHERE `genero`= 'Feminino'");
        }
        public string totalDeEstudantesMeninos()
        {
            return fazerContagem("SELECT COUNT(*) FROM `estudantes` WHERE `genero`= 'Masculino'");
        }
    }
}
