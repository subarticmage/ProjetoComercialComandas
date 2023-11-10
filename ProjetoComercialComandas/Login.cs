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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instanciar um usuario:
            Classes.Usuario usuario= new Classes.Usuario();
            usuario.Email= txtEmail.Text;
            usuario.Senha= txtSenha.Text;
            //obter o resultado do select no banco:
            var resultado = usuario.Logar();
            if(resultado.Rows.Count==1)
            {
                //senha correta:prosseguir...
                usuario.NomeCompleto = resultado.Rows[0]["Nome_Completo"].ToString();
                usuario.Id =(int) resultado.Rows[0]["Id"];
                MessageBox.Show(usuario.NomeCompleto);
                //Proximo Passo: Abrir a janela menu:
                MenuPrincipal janela= new MenuPrincipal();
                //esconder a janela atual:
                Hide();
                    //mostrar o menu:
                janela.ShowDialog();
                //mostrar o login quando o menu fechar:
                Show();


            }
            else
            {
                //senha incorreta:
                MessageBox.Show("Email ou senha incorretos.",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
