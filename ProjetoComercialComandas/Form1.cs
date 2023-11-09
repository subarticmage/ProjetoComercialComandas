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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //instanciar a janela de login

            Login janela= new Login();
            //mostrar janela:
            janela.ShowDialog();
            //fechar tudo ao fechar login
            Application.Exit();
        }
    }
}
