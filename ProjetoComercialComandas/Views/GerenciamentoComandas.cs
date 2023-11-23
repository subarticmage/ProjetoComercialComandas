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
    public partial class GerenciamentoComandas : Form
    {
        //global
        Classes.Usuario Usuario;
        public GerenciamentoComandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            this.Text = "Gerenciamento de comandas - " + "Logado como:" + usuario.NomeCompleto.ToUpper();

            Classes.Produto produto = new Classes.Produto();
            gdvGerenciamentoComand.DataSource = produto.ListarTudo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GerenciamentoComandas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gdvGerenciamentoComand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int LinhaSelecionada = gdvGerenciamentoComand.CurrentCell.RowIndex;
            var Linha = gdvGerenciamentoComand.Rows[LinhaSelecionada];

            txbProdutInfos.Text= Linha.Cells[0].Value.ToString();
            txbProdutLanc.Text = Linha.Cells[1].Value.ToString();
        }

        private void LimparTudo()
        {
            //limpar os campos
            txbComanda.Text.Clone();
            txbProdutInfos.Clear();
            txbProdutLanc.Clear();
            txbQuantidadeComand.Clear();

            //resetar os grbs:
            gbrInfos.Enabled = true;
            gbrLancamento.Enabled = false;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(txbQuantidadeComand.Text!="")
            {
                var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                    ordem.IdProduto = int.Parse(txbComanda.Text);
                    ordem.IdProduto = int.Parse(txbProdutLanc.Text);
                    ordem.Quantidade = int.Parse(txbQuantidadeComand.Text);
                    ordem.IdResp = Usuario.Id;
                    //efetuar o cadastro
                    if (ordem.Novolancamento() == true)
                    {
                        MessageBox.Show("Lançamento efetuado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTudo();
                    }
                    else
                    {
                        MessageBox.Show("Falha no Lnaçamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimparTudo();
                    }

                }
            }
            else
            {
                MessageBox.Show("Informe a quantidade!","Erro!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txbComanda.Text != "" && txbProdutInfos.Text != "")
            {
                gbrLancamento.Enabled = true;
                gbrInfos.Enabled = true;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
    }
}
