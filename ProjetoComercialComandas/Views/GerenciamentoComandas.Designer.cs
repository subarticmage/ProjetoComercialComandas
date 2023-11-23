namespace ProjetoComercialComandas.Views
{
    partial class GerenciamentoComandas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdvGerenciamentoComand = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbrInfos = new System.Windows.Forms.GroupBox();
            this.txbProdutInfos = new System.Windows.Forms.TextBox();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblProdutoComanda = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.gbrLancamento = new System.Windows.Forms.GroupBox();
            this.txbProdutLanc = new System.Windows.Forms.TextBox();
            this.txbQuantidadeComand = new System.Windows.Forms.TextBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblprodutolanca = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblComandasTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvGerenciamentoComand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbrInfos.SuspendLayout();
            this.gbrLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdvGerenciamentoComand
            // 
            this.gdvGerenciamentoComand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvGerenciamentoComand.Location = new System.Drawing.Point(294, 58);
            this.gdvGerenciamentoComand.Name = "gdvGerenciamentoComand";
            this.gdvGerenciamentoComand.Size = new System.Drawing.Size(288, 410);
            this.gdvGerenciamentoComand.TabIndex = 0;
            this.gdvGerenciamentoComand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvGerenciamentoComand_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoComercialComandas.Properties.Resources.x_sair;
            this.pictureBox1.Location = new System.Drawing.Point(530, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbrInfos
            // 
            this.gbrInfos.Controls.Add(this.txbProdutInfos);
            this.gbrInfos.Controls.Add(this.txbComanda);
            this.gbrInfos.Controls.Add(this.btnContinuar);
            this.gbrInfos.Controls.Add(this.lblProdutoComanda);
            this.gbrInfos.Controls.Add(this.lblComanda);
            this.gbrInfos.Location = new System.Drawing.Point(12, 58);
            this.gbrInfos.Name = "gbrInfos";
            this.gbrInfos.Size = new System.Drawing.Size(276, 187);
            this.gbrInfos.TabIndex = 2;
            this.gbrInfos.TabStop = false;
            this.gbrInfos.Text = "Informações";
            // 
            // txbProdutInfos
            // 
            this.txbProdutInfos.Location = new System.Drawing.Point(81, 102);
            this.txbProdutInfos.Name = "txbProdutInfos";
            this.txbProdutInfos.Size = new System.Drawing.Size(186, 20);
            this.txbProdutInfos.TabIndex = 9;
            // 
            // txbComanda
            // 
            this.txbComanda.Location = new System.Drawing.Point(81, 46);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(186, 20);
            this.txbComanda.TabIndex = 6;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(9, 136);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(261, 45);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblProdutoComanda
            // 
            this.lblProdutoComanda.AutoSize = true;
            this.lblProdutoComanda.Location = new System.Drawing.Point(6, 102);
            this.lblProdutoComanda.Name = "lblProdutoComanda";
            this.lblProdutoComanda.Size = new System.Drawing.Size(47, 13);
            this.lblProdutoComanda.TabIndex = 1;
            this.lblProdutoComanda.Text = "Produto:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Location = new System.Drawing.Point(6, 46);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(55, 13);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // gbrLancamento
            // 
            this.gbrLancamento.Controls.Add(this.btnCancelar);
            this.gbrLancamento.Controls.Add(this.txbProdutLanc);
            this.gbrLancamento.Controls.Add(this.txbQuantidadeComand);
            this.gbrLancamento.Controls.Add(this.btnLancar);
            this.gbrLancamento.Controls.Add(this.lblprodutolanca);
            this.gbrLancamento.Controls.Add(this.lblQuantidade);
            this.gbrLancamento.Enabled = false;
            this.gbrLancamento.Location = new System.Drawing.Point(12, 251);
            this.gbrLancamento.Name = "gbrLancamento";
            this.gbrLancamento.Size = new System.Drawing.Size(276, 217);
            this.gbrLancamento.TabIndex = 3;
            this.gbrLancamento.TabStop = false;
            this.gbrLancamento.Text = "Lançamento";
            // 
            // txbProdutLanc
            // 
            this.txbProdutLanc.Location = new System.Drawing.Point(81, 43);
            this.txbProdutLanc.Name = "txbProdutLanc";
            this.txbProdutLanc.ReadOnly = true;
            this.txbProdutLanc.Size = new System.Drawing.Size(186, 20);
            this.txbProdutLanc.TabIndex = 8;
            // 
            // txbQuantidadeComand
            // 
            this.txbQuantidadeComand.Location = new System.Drawing.Point(81, 89);
            this.txbQuantidadeComand.Name = "txbQuantidadeComand";
            this.txbQuantidadeComand.Size = new System.Drawing.Size(186, 20);
            this.txbQuantidadeComand.TabIndex = 7;
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(6, 115);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(261, 45);
            this.btnLancar.TabIndex = 3;
            this.btnLancar.Text = "LANÇAR";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblprodutolanca
            // 
            this.lblprodutolanca.AutoSize = true;
            this.lblprodutolanca.Location = new System.Drawing.Point(6, 43);
            this.lblprodutolanca.Name = "lblprodutolanca";
            this.lblprodutolanca.Size = new System.Drawing.Size(47, 13);
            this.lblprodutolanca.TabIndex = 2;
            this.lblprodutolanca.Text = "Produto:";
            this.lblprodutolanca.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(6, 96);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblComandasTitulo
            // 
            this.lblComandasTitulo.AutoSize = true;
            this.lblComandasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandasTitulo.Location = new System.Drawing.Point(196, 12);
            this.lblComandasTitulo.Name = "lblComandasTitulo";
            this.lblComandasTitulo.Size = new System.Drawing.Size(94, 20);
            this.lblComandasTitulo.TabIndex = 4;
            this.lblComandasTitulo.Text = "Comandas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 166);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(261, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GerenciamentoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 480);
            this.Controls.Add(this.lblComandasTitulo);
            this.Controls.Add(this.gbrLancamento);
            this.Controls.Add(this.gbrInfos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gdvGerenciamentoComand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciamentoComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoComandas";
            this.Load += new System.EventHandler(this.GerenciamentoComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvGerenciamentoComand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbrInfos.ResumeLayout(false);
            this.gbrInfos.PerformLayout();
            this.gbrLancamento.ResumeLayout(false);
            this.gbrLancamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvGerenciamentoComand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbrInfos;
        private System.Windows.Forms.Label lblprodutolanca;
        private System.Windows.Forms.Label lblProdutoComanda;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox gbrLancamento;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblComandasTitulo;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.TextBox txbQuantidadeComand;
        private System.Windows.Forms.TextBox txbProdutInfos;
        private System.Windows.Forms.TextBox txbProdutLanc;
        private System.Windows.Forms.Button btnCancelar;
    }
}