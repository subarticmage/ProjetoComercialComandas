using MySqlConnector;
using ProjetoComercialComandas.Classes.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComercialComandas.Classes
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        //metodos:


        //Logar:
        public DataTable Logar()
        {
            string comando = "SELECT id, nome_completo, email, senha" +
                " FROM usuarios WHERE email = @email AND senha = @senha";

            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            // Substituir os 'coringas' por valores:
            cmd.Parameters.AddWithValue("@email", Email);
            // Obter o hash da senha:
            var hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);

            cmd.Parameters.AddWithValue("@senha", hashsenha);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }

        public DataTable ListarTudo()
        {
            string comando = "SELECT id, nome_completo, email FROM usuarios"; 

            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO Usuarios (nome_completo, email, senha) " +
                "VALUES (@nome_completo, @email, @senha)";
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);
            //obter o hash
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@Senha", hashsenha);

            
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }


        public bool Apagar()
        {
            string comando = "DELETE FROM usuarios WHERE id=@id";
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@Id", Id);
           

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }


        public bool Modificar()
        {
            string comando = "UPDATE Usuarios SET nome_completo=@nome_completo, " + "email=@email,senha=@senha WHERE id=@id";
            //Comando SQL caso a senha esteja vazia:
            if(Senha=="")
            { 
            
            comando= "UPDATE Usuarios SET nome_completo=@nome_completo, " + "email=@email WHERE id=@id";

            }
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("Id", Id);
            cmd.Parameters.AddWithValue("@nome_completo", NomeCompleto);
            cmd.Parameters.AddWithValue("@email", Email);

            //obter o hash
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@Senha", hashsenha);


            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }

    }
}
