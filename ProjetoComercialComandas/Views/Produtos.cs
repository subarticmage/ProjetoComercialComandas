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
            //verificar se o indice da coluna é valido e se a linha nao é de cabeçalho
            if(e.RowIndex>=0 && e.RowIndex>=0)
        {
            //Obter o ID do produto da celular da primeira coluna(assumindo que seja a coluna 0)
                idSelecionado = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value);

                //Preencher os campos de edição com a s informações da linha selecionada
                txbNomeMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txbPrecoMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
                txbCatMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                //Atualizar o rotulo informativo
                lblApagarProdutos.Text= $"Editando o produto Id{idSelecionado}";
                //Habilitar os controles de edição
                gbrApagarProdutos.Enabled= false;
                grbModProduto.Enabled= false;

        }

        private void btnEditarProdutos_Click(object sender, EventArgs e)
         //verificar se algum produto esta selecionado
            if(idSelecionado>0)
        {
         //instanciar o produto
                Classes.Produto produto = new Classes.Produto();
    produto.Id= idSelecionado

    //preencher as informações do produto a ser editado
    produto.Nome=txbNomeMod.Text;
    produto.Preco=txbPrecoMod.Text;
                produto.idCategoria=txbCatMod.Text;

                //Realizar a atualização no banco de dados
                if(produto.Modificar())
                {
                    MessageBox.Show("Produto atualizado com sucesso!");
                    //Limpar os campos de edição
                    txbNomeMod.Clear();
                    txbPrecoMod.Clear();
                    txbCatMod.Clear();
                    //Atualizar o dgv
                    dgvProdutos.DataSource = produto.ListarTudo();

                }
                else
{
    MessageBox.Show("Falha ao atualizar o produto!");
}


{
    MessageBox.Show("Selecione um produto para editar.");
}               
                

        }
    }
}
