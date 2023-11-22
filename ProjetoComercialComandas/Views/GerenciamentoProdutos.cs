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
        Classes.Usuario usuario= new Classes.Usuario();
        public GerenciamentoProdutos(Classes.Usuario usuario)

        {
            InitializeComponent();
            this.usuario = usuario;
            this.Text = "Gerenciamento de comandas - " + "Logado como:" + usuario.NomeCompleto.ToUpper();
            //instanciar a classe produto
            Classes.Produto produto1 =new Classes.Produto();
            //Atribuir a tabela(resultado do select) no dgv:
            dgvProdutos.DataSource = produto1.ListarTudo();
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
            //instanciar a CLASSE PRODUTO   
            Classes.Produto produto = new Classes.Produto();
            produto.Nome=txbNomeCad.Text;
           
            produto.idCategoria=cmbCatCad.Text.ToString();
            if(produto.Cadastrar())
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                //limpar dados
                txbNomeCad.Clear();
                txbPrecoCad.Clear();
                cmbCatCad.Text= string.Empty;
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
            if (r == DialogResult.Yes && IdSelecionado>0)
            {
                Classes.Produto produto1 = new Classes.Produto();
                produto.Id= IdSelecionado.ToString();
                //Apagar
                if(produto.Modificar())
                {
                    MessageBox.Show("Produto removido!", "Sucesso!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    dgvProdutos.DataSource = produto.ListarTudo();
                    //limpar os campos de edição
                    cmbNomeMod.Text= string.Empty;
                    txbPrecoMod.Clear();
                    cmbCatMod.Text= string.Empty;
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
            if (e.RowIndex >0)
            {
                //Obter o id do produto da primeira coluna(assumindo que seja a coluna 0)
                IdSelecionado = Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[IdSelecionado].Value);
                //preencher os campos de edição com as informações da linha selecionada
                cmbNomeMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txbPrecoMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
                cmbCatMod.Text = dgvProdutos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString().ToLower();
                //Atualizar o rotulo informativo
                lblApagar.Text = $"Editando o produto Id{IdSelecionado}";
                //Habilitar os controles de edição
                gbrApagar.Enabled = true;
                btnModificiar.Enabled = true;
            }

                
        }

        private void btnModificiar_Click(object sender, EventArgs e)
        {
            //verificar se algum produto esta selecionado
            if (IdSelecionado > 0)
            {
                //instanciar o produto
                Classes.Produto produto = new Classes.Produto();
                produto.Id = IdSelecionado.ToString();

                //preencher as informações do produto a ser modificado
                produto.Nome = cmbNomeMod.Text;
                produto.Preco = double.Parse(txbPrecoMod.Text);
                produto.idCategoria = cmbCatMod.Text;
                //realizar a atualização no banco de dados
                if (produto.Modificar())
                {
                    MessageBox.Show("produto atualizado com sucesso!");
                    //limpar os campos de edição
                    cmbNomeMod.Text= string.Empty;
                    txbPrecoMod.Clear();
                    cmbCatMod.Text= string.Empty;
                    //atualizar o dgv
                    dgvProdutos.DataSource = produto.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Falha aoa atualizar o produto!");
                }

            }
                
        }

        private void GerenciamentoProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
