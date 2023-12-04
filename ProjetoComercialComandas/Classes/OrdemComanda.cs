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
    public class OrdemComanda
    {
        public int Id { get; set; }

        public int IdFicha { get; set; }

        public int IdProduto { get; set; }

        public int Quantidade { get; set; }

        public int IdResp { get; set; }

        public DateTime DataAdic { get; set; }

        public int Situacao { get; set; }


        public bool EncerrarFicha()
        {
            string comando = "UPDATE ordens_comandas SET situacao= 0 " + "WHERE id_ficha = @id_ficha AND situacao=1";
           
            {

                comando = "UPDATE Usuarios SET nome_completo=@nome_completo, " + "email=@email WHERE id=@id";

            }
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
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
    

        public DataTable BuscarFicha()
        {
        string comando = "SELECT *" + "FROM views_fichas WHERE ficha=@ficha";
                
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
        // Substituir os 'coringas' por valores:
        cmd.Parameters.AddWithValue("@ficha", idficha);
            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }


        public bool Novolancamento()
        {
            string comando = "INSERT INTO `ordens_comandas`(`id`, `id_ficha`, `id_produto`, `quantidade`, `id_resp`) " +
                "VALUES (@id, @id_ficha,@id_produto,@quantidade,@id_resp)";
            DataBase.ConexaoBanco conexaoBD = new DataBase.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_ficha", idficha);
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
