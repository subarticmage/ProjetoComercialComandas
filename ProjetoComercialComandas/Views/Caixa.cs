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
    public partial class Caixa : Form
    {
        Classes.Usuario Usuario;
        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.Usuario=usuario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbPagamento.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txbNComanda.Text !="")
            {
                Classes.OrdemComanda ordem=new Classes.OrdemComanda();  
                ordem.IdFicha=int.Parse(txbNComanda.Text);
                var r = ordem.BuscarFicha();
                dgvTotalComand.DataSource = r;
                //Atualizar o valor total
                lblTotalComanda.Text = "R$" + r.Compute("SUM(Total_Item)", "True").ToString();

                
            }
            else
            {
                MessageBox.Show("digite o numero da ficha!","Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTotalComanda_Click(object sender, EventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r= MessageBox.Show("Tem certeza que deseja encerrar?","Atenção!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha= int.Parse(txbNComanda.Text);
                if(ordem.EncerrarFicha()==true)
                {
                    MessageBox.Show("Ficha encerrada!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar
                    txbNComanda.Clear();
                    dgvTotalComand.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a ficha!","Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
