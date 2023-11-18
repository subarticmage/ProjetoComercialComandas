namespace ProjetoComercialComandas.Views
{
    partial class GerenciamentoProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pictureBoxPaes = new System.Windows.Forms.PictureBox();
            this.pictureBoxFecharProdutos = new System.Windows.Forms.PictureBox();
            this.gbrCadastrarProduto = new System.Windows.Forms.GroupBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPreço = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbCatCad = new System.Windows.Forms.ComboBox();
            this.gbrModificar = new System.Windows.Forms.GroupBox();
            this.cmbCatMod = new System.Windows.Forms.ComboBox();
            this.btnModificiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbrApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.txbPrecoMod = new System.Windows.Forms.TextBox();
            this.cmbNomeMod = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharProdutos)).BeginInit();
            this.gbrCadastrarProduto.SuspendLayout();
            this.gbrModificar.SuspendLayout();
            this.gbrApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(548, 43);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(240, 395);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // pictureBoxPaes
            // 
            this.pictureBoxPaes.Image = global::ProjetoComercialComandas.Properties.Resources._9264122_conjunto_de_produtos_de_padaria_de_pao_frances_vetor1;
            this.pictureBoxPaes.Location = new System.Drawing.Point(3, 43);
            this.pictureBoxPaes.Name = "pictureBoxPaes";
            this.pictureBoxPaes.Size = new System.Drawing.Size(219, 231);
            this.pictureBoxPaes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPaes.TabIndex = 2;
            this.pictureBoxPaes.TabStop = false;
            // 
            // pictureBoxFecharProdutos
            // 
            this.pictureBoxFecharProdutos.Image = global::ProjetoComercialComandas.Properties.Resources.x_sair;
            this.pictureBoxFecharProdutos.Location = new System.Drawing.Point(739, 7);
            this.pictureBoxFecharProdutos.Name = "pictureBoxFecharProdutos";
            this.pictureBoxFecharProdutos.Size = new System.Drawing.Size(49, 30);
            this.pictureBoxFecharProdutos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFecharProdutos.TabIndex = 1;
            this.pictureBoxFecharProdutos.TabStop = false;
            this.pictureBoxFecharProdutos.Click += new System.EventHandler(this.pictureBoxFecharProdutos_Click);
            // 
            // gbrCadastrarProduto
            // 
            this.gbrCadastrarProduto.Controls.Add(this.txbPrecoCad);
            this.gbrCadastrarProduto.Controls.Add(this.txbNomeCad);
            this.gbrCadastrarProduto.Controls.Add(this.cmbCatCad);
            this.gbrCadastrarProduto.Controls.Add(this.btnCadastrar);
            this.gbrCadastrarProduto.Controls.Add(this.lblCategoria);
            this.gbrCadastrarProduto.Controls.Add(this.lblPreço);
            this.gbrCadastrarProduto.Controls.Add(this.lblNomeProduto);
            this.gbrCadastrarProduto.Location = new System.Drawing.Point(229, 43);
            this.gbrCadastrarProduto.Name = "gbrCadastrarProduto";
            this.gbrCadastrarProduto.Size = new System.Drawing.Size(313, 204);
            this.gbrCadastrarProduto.TabIndex = 3;
            this.gbrCadastrarProduto.TabStop = false;
            this.gbrCadastrarProduto.Text = "Cadastrar";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(3, 16);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(78, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Produto:";
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Location = new System.Drawing.Point(6, 62);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(38, 13);
            this.lblPreço.TabIndex = 1;
            this.lblPreço.Text = "Preço:";
            this.lblPreço.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 111);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(0, 146);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(313, 52);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbCatCad
            // 
            this.cmbCatCad.FormattingEnabled = true;
            this.cmbCatCad.Location = new System.Drawing.Point(88, 111);
            this.cmbCatCad.Name = "cmbCatCad";
            this.cmbCatCad.Size = new System.Drawing.Size(219, 21);
            this.cmbCatCad.TabIndex = 6;
            // 
            // gbrModificar
            // 
            this.gbrModificar.Controls.Add(this.cmbNomeMod);
            this.gbrModificar.Controls.Add(this.txbPrecoMod);
            this.gbrModificar.Controls.Add(this.cmbCatMod);
            this.gbrModificar.Controls.Add(this.btnModificiar);
            this.gbrModificar.Controls.Add(this.label1);
            this.gbrModificar.Controls.Add(this.label2);
            this.gbrModificar.Controls.Add(this.label3);
            this.gbrModificar.Location = new System.Drawing.Point(229, 247);
            this.gbrModificar.Name = "gbrModificar";
            this.gbrModificar.Size = new System.Drawing.Size(313, 204);
            this.gbrModificar.TabIndex = 7;
            this.gbrModificar.TabStop = false;
            this.gbrModificar.Text = "Modificar";
            // 
            // cmbCatMod
            // 
            this.cmbCatMod.FormattingEnabled = true;
            this.cmbCatMod.Location = new System.Drawing.Point(88, 111);
            this.cmbCatMod.Name = "cmbCatMod";
            this.cmbCatMod.Size = new System.Drawing.Size(219, 21);
            this.cmbCatMod.TabIndex = 6;
            // 
            // btnModificiar
            // 
            this.btnModificiar.Location = new System.Drawing.Point(0, 146);
            this.btnModificiar.Name = "btnModificiar";
            this.btnModificiar.Size = new System.Drawing.Size(313, 52);
            this.btnModificiar.TabIndex = 3;
            this.btnModificiar.Text = "Modificar";
            this.btnModificiar.UseVisualStyleBackColor = true;
            this.btnModificiar.Click += new System.EventHandler(this.btnModificiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Produto:";
            // 
            // gbrApagar
            // 
            this.gbrApagar.Controls.Add(this.btnApagar);
            this.gbrApagar.Controls.Add(this.lblApagar);
            this.gbrApagar.Location = new System.Drawing.Point(3, 280);
            this.gbrApagar.Name = "gbrApagar";
            this.gbrApagar.Size = new System.Drawing.Size(219, 165);
            this.gbrApagar.TabIndex = 8;
            this.gbrApagar.TabStop = false;
            this.gbrApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(6, 29);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(165, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o produto para apagar:";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(9, 113);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(204, 52);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(314, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 13);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(88, 20);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(219, 20);
            this.txbNomeCad.TabIndex = 7;
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Location = new System.Drawing.Point(88, 59);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(219, 20);
            this.txbPrecoCad.TabIndex = 8;
            // 
            // txbPrecoMod
            // 
            this.txbPrecoMod.Location = new System.Drawing.Point(88, 62);
            this.txbPrecoMod.Name = "txbPrecoMod";
            this.txbPrecoMod.Size = new System.Drawing.Size(219, 20);
            this.txbPrecoMod.TabIndex = 10;
            // 
            // cmbNomeMod
            // 
            this.cmbNomeMod.FormattingEnabled = true;
            this.cmbNomeMod.Location = new System.Drawing.Point(87, 19);
            this.cmbNomeMod.Name = "cmbNomeMod";
            this.cmbNomeMod.Size = new System.Drawing.Size(219, 21);
            this.cmbNomeMod.TabIndex = 9;
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbrApagar);
            this.Controls.Add(this.gbrModificar);
            this.Controls.Add(this.gbrCadastrarProduto);
            this.Controls.Add(this.pictureBoxPaes);
            this.Controls.Add(this.pictureBoxFecharProdutos);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciamentoProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFecharProdutos)).EndInit();
            this.gbrCadastrarProduto.ResumeLayout(false);
            this.gbrCadastrarProduto.PerformLayout();
            this.gbrModificar.ResumeLayout(false);
            this.gbrModificar.PerformLayout();
            this.gbrApagar.ResumeLayout(false);
            this.gbrApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox pictureBoxFecharProdutos;
        private System.Windows.Forms.PictureBox pictureBoxPaes;
        private System.Windows.Forms.GroupBox gbrCadastrarProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.ComboBox cmbCatCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gbrModificar;
        private System.Windows.Forms.ComboBox cmbCatMod;
        private System.Windows.Forms.Button btnModificiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbrApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.TextBox txbPrecoMod;
        private System.Windows.Forms.ComboBox cmbNomeMod;
    }
}