using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
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

        public double  Preco { get; set; }

        public string idCategoria { get; set;}

        public int idRespCadastro { get; set; }

        public bool Cadastrar()
        {
            string comando= "INSERT INTO Produtos(nome_produto, preco,categoria) "+"VALUES(@nome_produto,@preco, @categoria");
            DataBase.Produto produto= new DataBase.Produto();
            MySqlConnection con = Produto.();
        }
        public bool Modificar()
        {

        }

        public DataTable ListarTudo()
        {

        }





        }
}
