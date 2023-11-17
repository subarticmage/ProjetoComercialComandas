using ProjetoComercialComandas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComercialComandas.Views
{
    public partial class Produtos : Form
    {
        int idSelecionado = 0;
        //global:
        Classes.Usuario usuario= new Classes.Usuario();
       
        public Produtos(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }




        private void lblProdutos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            //instanciar o usuario
            Classes.Produto produto = new Classes.Produto();
            produto.Nome=txbNomeCad.Text;
            produto.idCategoria=txbCatCad.Text;
            produto.Preco= txbPrecoCad.Text;
            

            if(produto.Cadastrar()==true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                //limpar os campos
                txbNomeCad.Clear();
                txbPrecoCad.Clear();
                txbCatCad.Clear();
                //Atualizar o DGV:
                dgvProdutos.DataSource = produto.ListarTudo();

            }
            else
            {
                MessageBox.Show("Falha ao cadastrar produto!");
            }
                    
        }

        private void btnApagarProdutos_Click(object sender, EventArgs e)
        {
            Classes. Produto produto = new Classes.Produto();
            produto.idCategoria = idSelecionado;
            //apagar:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r== DialogResult.Yes)
            {
                //apagar
                if(usuario.Apagar()==true)
                {
                    MessageBox.Show("Produto removido!","Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    dgvProdutos.DataSource= produto.ListarTudo();
                    //limpar os campos de edição:
                    txbNomeMod.Clear();
                    txtPrecoMod.Clear();
                    txbCatMod.Clear();
                    lblApagarProdutos.Text = "Selecione um usuario para apagar.";
                    //desabilitar os gbrs:
                    gbrApagarProdutos.Enabled = false;
                    grbModProduto.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto!","Falha!",MessageBoxButtons.OK,MessageBoxIcon.Error);                 
                }
            }

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarProdutos_Click(object sender, EventArgs e)
        {

        }
    }
}
