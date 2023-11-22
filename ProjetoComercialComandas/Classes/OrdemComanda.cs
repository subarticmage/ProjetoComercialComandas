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
    public class OrdemComanda
    {
        public int Id { get; set; }

        public int IdFicha { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }
        
        public int IdResp { get; set; }

        public DateTime DataAdic { get; set; }

        public int Situacao { get; set; }

        public bool Novolancamento()
        {
            string comando = "INSERT INTO `ordens_comandas`(`id`, `id_ficha`, `id_produto`, `quantidade`, `id_resp`) " +
                "VALUES (@id, @id_ficha,@id_produto,@quantidade,@id_resp)";
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
            cmd.Parameters.AddWithValue("@id_produtos", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", IdResp);



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
