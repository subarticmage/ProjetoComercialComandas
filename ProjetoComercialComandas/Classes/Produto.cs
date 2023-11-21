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
            MySqlConnection con = null;
            try
            {
                string comando = "INSERT INTO Produtos(nome_produto, preco, categoria)" +
                    " VALUES (@nome_produto, @preco, @categoria)";

                con = DataBase.GetConnection();  // Certifique-se de ajustar este método conforme a sua implementação
                {
                    con.Open();
                    (MySqlCommand cmd = new MySqlCommand(comando, con);
                    {
                        cmd.Parameters.AddWithValue("@nome_produto", Nome);
                        cmd.Parameters.AddWithValue("@preco", Preco);
                        cmd.Parameters.AddWithValue("@categoria", IdCategoria);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        return linhasAfetadas > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                // Lide com a exceção apropriadamente (pode imprimir no console ou logar, por exemplo)
                Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
                return false;
            }
        }

        public bool Modificar()
        {
            MySqlConnection con = null;
            try
            {
                // Implemente a lógica de modificação aqui
                return false;  // Substitua pelo código real
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao modificar produto: {ex.Message}");
                return false;
            }
            finally
            {
                if (con != null) con.Close();
            }

        }


        public DataTable ListarTudo()
        {
            MySqlConnection con = null;
            try
            {
                string comando = "SELECT * FROM Produtos";

                (MySqlConnection con = DataBase.GetConnection();
                {
                    con.Open();
                    (MySqlDataAdapter adapter = new MySqlDataAdapter(comando, con);
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao listar produtos: {ex.Message}");
                return null;
            }
            finally
            {  if (con != null) con.Close();}
        }





    }   
}
