using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoComercialComandas
{
    public partial class MenuPrincipal : Form
    {
        //Objetos Globais:
        Classes.Usuario Usuario = new Classes.Usuario();
        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            //atribuir usuario local no global
            this.Usuario = usuario;
            //mudar a label de aprensentação
            lblSaudacao.Text = "Olá," + usuario.NomeCompleto;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerenciamentoUsuarios_Click(object sender, EventArgs e)
        {
            //instanciar a janela:
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //instanciar janela
            Views.GerenciamentoProdutos janela= new Views.GerenciamentoProdutos();
            janela.Show();
        }
    }
}
