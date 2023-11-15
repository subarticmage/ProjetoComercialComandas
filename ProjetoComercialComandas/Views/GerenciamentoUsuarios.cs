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
         int idSelecionado=0;

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
           
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = idSelecionado;
            //apagar:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //Apagar
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuario removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    dgvUsuarios.DataSource = usuario.ListarTudo();
                    //Limpas os campos de edição:
                    txtEmailEdit.Clear();
                    txtNomeCompletoEdit.Clear();
                    txtSenhaEdit.Clear();
                    lblApagar.Text = "selecione um usuario para apagar.";
                    //desabilitar os gbrs:
                    gbrApagar.Enabled = false;
                    grbEdit.Enabled = false;


                }
                else
                {
                    MessageBox.Show("Falha ao remover usuario!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Obter os dos txts:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id=idSelecionado;
            usuario.NomeCompleto = txtNomeCompletoEdit.Text;
            usuario.Email = txtEmailEdit.Text;
            usuario.Senha = txtSenhaEdit.Text;

            //Editar:


            if (usuario.Modificar() == true)
            {
                MessageBox.Show("Usuario Editado com sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Atualizar dgv
                dgvUsuarios.DataSource=usuario.ListarTudo();
                //Limpar os campos edição:
                txtEmailEdit.Clear();
                txtNomeCompletoEdit.Clear();
                txtSenhaEdit.Clear();
                lblApagar.Text = "Selecione um usuario para apagar.";
                //Desabilitar os grbs:
                grbEdit.Enabled=false;
                btnEdit.Enabled = false;

            }
            else
            {
                MessageBox.Show("Falha ao Editar usuario!","Falha!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
