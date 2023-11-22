using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoComercialComandas.Classes
{
    public class Produto
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string idCategoria { get; set; }

        public int idRespCadastro { get; set; }





        public bool Cadastrar()
        {
            string comando = "INSERT INTO `produtos`(`id`, `nome`, `preco`, `id_categoria`, `id_respcadastro`) " +
                "VALUES (@id,@nome,@preco,@id_categoria,@id_respcadastro)";
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", idCategoria); 
            cmd.Parameters.AddWithValue("@id_respcadastro", idRespCadastro);



            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return true;
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
                return true;
            }


        }

        public bool Modificar()
        {
            string comando = "UPDATE Usuarios SET nome_completo=@nome_completo, " + "email=@email,senha=@senha WHERE id=@id";
            //Comando SQL caso a senha esteja vazia:
           
            {

                comando = "UPDATE Usuarios SET nome_completo=@nome_completo, " + "email=@email WHERE id=@id";

            }
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("Id", Id);
            
         




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

    


        public DataTable ListarTudo()
        {
            string comando = "SELECT `id`, `nome`, `preco`, `id_categoria`, `id_respcadastro` FROM `produtos` ";

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





    }   
}
