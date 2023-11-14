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
    public partial class GerenciamentoUsuarios : Form
    {
        private int idSelecionado;

        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario= new Classes.Usuario();
            //Atribuir a tabela(resultado do select) no dgv:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void GerenciamentoUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void grbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar o usuario:
            Classes.Usuario usuario= new Classes.Usuario();
            usuario.NomeCompleto = txtNomeCompletpCad.Text;
            usuario.Email = txtEmailCad.Text;
            usuario.Senha= txtSenhaCad.Text;

            if(usuario.Cadastrar()==true)
            {
                MessageBox.Show("Usuario cadastrado com sucesso!");
                //Limpar os campos
                txtNomeCompletpCad.Clear();
                txtEmailCad.Clear();
                txtSenhaCad.Clear();
                //atualizar o dgv:
                dgvUsuarios.DataSource= usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuario!");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os grbs:
            grbEdit.Enabled = true;
            btnApagar.Enabled = true;

            //obter a linha clicada:
            int LinhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;
            //Armazenar os dados das linha selecionadas em "linha" (tipo vetor):
            var Linha= dgvUsuarios.Rows[LinhaSelecionada];

            txtNomeCompletoEdit.Text = Linha.Cells[1].Value.ToString();
            txtEmailEdit.Text = Linha.Cells[2].Value.ToString();

            //juntar id e o nome para exibir no apagar;
            lblApagar.Text = Linha.Cells[0].Value.ToString() + ".";
            Linha.Cells[1].Value.ToString();

            //salvar o id do selecionado na variavel global:
            idSelecionado = (int)Linha.Cells[0].Value;
        }

        private void lblApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario= new Classes.Usuario(); 
            usuario.Id= idSelecionado;
            //apagar:
        }
    }
}
