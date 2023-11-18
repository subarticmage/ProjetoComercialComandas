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
    public partial class GerenciamentoProdutos : Form

    {
        int IdSelecionado = 0;
        //Global
        Classes.Produto Produto= new Classes.Produto();
        public GerenciamentoProdutos(Classes.Produto produto)

        {
            InitializeComponent();
            Classes.Usuario usuario=new Classes.Usuario();
            //Atribuir a tabela(resultado do select) no dgv:
            dgvProdutos.DataSource = usuario;
        }

        public GerenciamentoProdutos()
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFecharProdutos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar o usuario
            Classes.Produto produto = new Classes.Produto();
            produto.Nome=txbNomeCad.Text;
           
            produto.idCategoria=cmbCatCad.Text.ToString();
            if(produto.Cadastrar()==true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                //limpar dados
                txbNomeCad.Clear();
                txbPrecoCad.Clear();
                cmbCatCad.Items.Clear();
                //atualizar o dgv
                dgvProdutos.DataSource=produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastar produto!");
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto=new Classes.Produto();
            produto.idCategoria = cmbCatCad.Text.ToString();
            //apagar
            var r = MessageBox.Show("Tem certeza que deseja remover?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //Apagar
                if(produto.Modificar()==true)
                {
                    MessageBox.Show("Produto removido!", "Sucesso!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    dgvProdutos.DataSource = produto.ListarTudo();
                    //limpar os campos de edição
                    cmbNomeMod.Items.Clear();
                    txbPrecoMod.Clear();
                    cmbCatMod.Items.Clear();
                    lblApagar.Text = "Selecione um usuario para apagar.";
                    //desabilitar os gbrs
                    gbrApagar.Enabled = false;
                    gbrModificar.Enabled = false;
                    
                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto!","Falha",MessageBoxButtons.OK,MessageBoxIcon.Error);   
                }
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar se o indice da coluna é valido e se a linha nao é de cabeçalho
            if (e.RowIndex >= && e.RowIndex >= 0)
            {
                //Obter o id do produto da primeira coluna(assumindo que seja a coluna 0)
                IdSelecionado = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value);
                //preencher os campos de edição com as informações da linha selecionada
                cmbNomeMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txbPrecoMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
                cmbCatMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString().ToLower();
                //Atualizar o rotulo informativo
                lblApagar.Text = $"Editando o produto Id{IdSelecionado}";
                //Habilitar os controles de edição
                gbrApagar.Enabled = false;
                btnModificiar.Enabled = false;
            }

                
        }

        private void btnModificiar_Click(object sender, EventArgs e)
        {
            //verificar se algum produto esta selecionado
            if (IdSelecionado > 0)
            {
                //instanciar o produto
                Classes.Produto produto = new Classes.Produto();
                produto.idRespCadastro = IdSelecionado;

                //preencher as informações do produto a ser modificado
                produto.Nome = cmbNomeMod.Text;
                produto.Preco = txbPrecoMod.Text;
                produto.idCategoria = cmbCatMod.Text;
                //realizar a atualização no banco de dados
                if (produto.Modificar())
                {
                    MessageBox.Show("produto atualizado com sucesso!");
                    //limpar os campos de edição
                    cmbNomeMod.Items.Clear();
                    txbPrecoMod.Clear();
                    cmbCatMod.Items.Clear();
                    //atualizar o dgv
                    dgvProdutos.DataSource = produto.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Falha aoa atualizar o produto!");
                }

            }
                
        } 
    }
}
