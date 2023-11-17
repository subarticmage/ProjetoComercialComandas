namespace ProjetoComercialComandas.Views
{
    partial class Produtos
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
            this.lblProdutos = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pictureBoxFigura = new System.Windows.Forms.PictureBox();
            this.gbrApagarProdutos = new System.Windows.Forms.GroupBox();
            this.btnApagarProdutos = new System.Windows.Forms.Button();
            this.lblApagarProdutos = new System.Windows.Forms.Label();
            this.grbCadastrarProdutos = new System.Windows.Forms.GroupBox();
            this.lblNomeProdutoCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.lblCatCad = new System.Windows.Forms.Label();
            this.txbCatCad = new System.Windows.Forms.TextBox();
            this.grbModProduto = new System.Windows.Forms.GroupBox();
            this.txbCatMod = new System.Windows.Forms.TextBox();
            this.lblCatProdutosMod = new System.Windows.Forms.Label();
            this.btnEditarProdutos = new System.Windows.Forms.Button();
            this.txtPrecoMod = new System.Windows.Forms.TextBox();
            this.txbNomeMod = new System.Windows.Forms.TextBox();
            this.lblPrecoMod = new System.Windows.Forms.Label();
            this.lblNomeProdutoMod = new System.Windows.Forms.Label();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigura)).BeginInit();
            this.gbrApagarProdutos.SuspendLayout();
            this.grbCadastrarProdutos.SuspendLayout();
            this.grbModProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(12, 12);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(234, 20);
            this.lblProdutos.TabIndex = 0;
            this.lblProdutos.Text = "Gerenciamento de Produtos";
            this.lblProdutos.Click += new System.EventHandler(this.lblProdutos_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(907, 35);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(314, 471);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // pictureBoxFigura
            // 
            this.pictureBoxFigura.Image = global::ProjetoComercialComandas.Properties.Resources._9264122_conjunto_de_produtos_de_padaria_de_pao_frances_vetor;
            this.pictureBoxFigura.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxFigura.Name = "pictureBoxFigura";
            this.pictureBoxFigura.Size = new System.Drawing.Size(378, 343);
            this.pictureBoxFigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFigura.TabIndex = 2;
            this.pictureBoxFigura.TabStop = false;
            // 
            // gbrApagarProdutos
            // 
            this.gbrApagarProdutos.Controls.Add(this.lblApagarProdutos);
            this.gbrApagarProdutos.Location = new System.Drawing.Point(17, 384);
            this.gbrApagarProdutos.Name = "gbrApagarProdutos";
            this.gbrApagarProdutos.Size = new System.Drawing.Size(374, 73);
            this.gbrApagarProdutos.TabIndex = 3;
            this.gbrApagarProdutos.TabStop = false;
            this.gbrApagarProdutos.Text = "Apagar";
            // 
            // btnApagarProdutos
            // 
            this.btnApagarProdutos.BackColor = System.Drawing.Color.Red;
            this.btnApagarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarProdutos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApagarProdutos.Location = new System.Drawing.Point(12, 470);
            this.btnApagarProdutos.Name = "btnApagarProdutos";
            this.btnApagarProdutos.Size = new System.Drawing.Size(379, 46);
            this.btnApagarProdutos.TabIndex = 4;
            this.btnApagarProdutos.Text = "Apagar";
            this.btnApagarProdutos.UseVisualStyleBackColor = false;
            this.btnApagarProdutos.Click += new System.EventHandler(this.btnApagarProdutos_Click);
            // 
            // lblApagarProdutos
            // 
            this.lblApagarProdutos.AutoSize = true;
            this.lblApagarProdutos.Location = new System.Drawing.Point(7, 30);
            this.lblApagarProdutos.Name = "lblApagarProdutos";
            this.lblApagarProdutos.Size = new System.Drawing.Size(177, 13);
            this.lblApagarProdutos.TabIndex = 0;
            this.lblApagarProdutos.Text = "Selecione o Produto a ser apagado.";
            // 
            // grbCadastrarProdutos
            // 
            this.grbCadastrarProdutos.Controls.Add(this.txbCatCad);
            this.grbCadastrarProdutos.Controls.Add(this.lblCatCad);
            this.grbCadastrarProdutos.Controls.Add(this.btnCadastrarProduto);
            this.grbCadastrarProdutos.Controls.Add(this.txbPrecoCad);
            this.grbCadastrarProdutos.Controls.Add(this.txbNomeCad);
            this.grbCadastrarProdutos.Controls.Add(this.lblPrecoCad);
            this.grbCadastrarProdutos.Controls.Add(this.lblNomeProdutoCad);
            this.grbCadastrarProdutos.Location = new System.Drawing.Point(396, 35);
            this.grbCadastrarProdutos.Name = "grbCadastrarProdutos";
            this.grbCadastrarProdutos.Size = new System.Drawing.Size(504, 240);
            this.grbCadastrarProdutos.TabIndex = 5;
            this.grbCadastrarProdutos.TabStop = false;
            this.grbCadastrarProdutos.Text = "Cadastrar";
            // 
            // lblNomeProdutoCad
            // 
            this.lblNomeProdutoCad.AutoSize = true;
            this.lblNomeProdutoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoCad.Location = new System.Drawing.Point(6, 45);
            this.lblNomeProdutoCad.Name = "lblNomeProdutoCad";
            this.lblNomeProdutoCad.Size = new System.Drawing.Size(132, 16);
            this.lblNomeProdutoCad.TabIndex = 0;
            this.lblNomeProdutoCad.Text = "Nome do Produto:";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.Location = new System.Drawing.Point(6, 85);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(52, 16);
            this.lblPrecoCad.TabIndex = 1;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(150, 45);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(252, 20);
            this.txbNomeCad.TabIndex = 2;
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Location = new System.Drawing.Point(150, 85);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(253, 20);
            this.txbPrecoCad.TabIndex = 3;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(10, 167);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(419, 48);
            this.btnCadastrarProduto.TabIndex = 4;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // lblCatCad
            // 
            this.lblCatCad.AutoSize = true;
            this.lblCatCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatCad.Location = new System.Drawing.Point(7, 123);
            this.lblCatCad.Name = "lblCatCad";
            this.lblCatCad.Size = new System.Drawing.Size(79, 16);
            this.lblCatCad.TabIndex = 5;
            this.lblCatCad.Text = "Categoria:";
            // 
            // txbCatCad
            // 
            this.txbCatCad.Location = new System.Drawing.Point(150, 119);
            this.txbCatCad.Name = "txbCatCad";
            this.txbCatCad.Size = new System.Drawing.Size(253, 20);
            this.txbCatCad.TabIndex = 7;
            // 
            // grbModProduto
            // 
            this.grbModProduto.Controls.Add(this.txbCatMod);
            this.grbModProduto.Controls.Add(this.lblCatProdutosMod);
            this.grbModProduto.Controls.Add(this.btnEditarProdutos);
            this.grbModProduto.Controls.Add(this.txtPrecoMod);
            this.grbModProduto.Controls.Add(this.txbNomeMod);
            this.grbModProduto.Controls.Add(this.lblPrecoMod);
            this.grbModProduto.Controls.Add(this.lblNomeProdutoMod);
            this.grbModProduto.Location = new System.Drawing.Point(396, 281);
            this.grbModProduto.Name = "grbModProduto";
            this.grbModProduto.Size = new System.Drawing.Size(504, 235);
            this.grbModProduto.TabIndex = 9;
            this.grbModProduto.TabStop = false;
            this.grbModProduto.Text = "Modificar";
            // 
            // txbCatMod
            // 
            this.txbCatMod.Location = new System.Drawing.Point(175, 103);
            this.txbCatMod.Name = "txbCatMod";
            this.txbCatMod.Size = new System.Drawing.Size(253, 20);
            this.txbCatMod.TabIndex = 7;
            // 
            // lblCatProdutosMod
            // 
            this.lblCatProdutosMod.AutoSize = true;
            this.lblCatProdutosMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatProdutosMod.Location = new System.Drawing.Point(6, 103);
            this.lblCatProdutosMod.Name = "lblCatProdutosMod";
            this.lblCatProdutosMod.Size = new System.Drawing.Size(79, 16);
            this.lblCatProdutosMod.TabIndex = 5;
            this.lblCatProdutosMod.Text = "Categoria:";
            // 
            // btnEditarProdutos
            // 
            this.btnEditarProdutos.BackColor = System.Drawing.Color.LightCoral;
            this.btnEditarProdutos.Location = new System.Drawing.Point(10, 177);
            this.btnEditarProdutos.Name = "btnEditarProdutos";
            this.btnEditarProdutos.Size = new System.Drawing.Size(419, 48);
            this.btnEditarProdutos.TabIndex = 4;
            this.btnEditarProdutos.Text = "Modificar";
            this.btnEditarProdutos.UseVisualStyleBackColor = false;
            this.btnEditarProdutos.Click += new System.EventHandler(this.btnEditarProdutos_Click);
            // 
            // txtPrecoMod
            // 
            this.txtPrecoMod.Location = new System.Drawing.Point(175, 66);
            this.txtPrecoMod.Name = "txtPrecoMod";
            this.txtPrecoMod.Size = new System.Drawing.Size(253, 20);
            this.txtPrecoMod.TabIndex = 3;
            // 
            // txbNomeMod
            // 
            this.txbNomeMod.Location = new System.Drawing.Point(175, 32);
            this.txbNomeMod.Name = "txbNomeMod";
            this.txbNomeMod.Size = new System.Drawing.Size(254, 20);
            this.txbNomeMod.TabIndex = 2;
            // 
            // lblPrecoMod
            // 
            this.lblPrecoMod.AutoSize = true;
            this.lblPrecoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoMod.Location = new System.Drawing.Point(6, 66);
            this.lblPrecoMod.Name = "lblPrecoMod";
            this.lblPrecoMod.Size = new System.Drawing.Size(52, 16);
            this.lblPrecoMod.TabIndex = 1;
            this.lblPrecoMod.Text = "Preço:";
            // 
            // lblNomeProdutoMod
            // 
            this.lblNomeProdutoMod.AutoSize = true;
            this.lblNomeProdutoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoMod.Location = new System.Drawing.Point(6, 32);
            this.lblNomeProdutoMod.Name = "lblNomeProdutoMod";
            this.lblNomeProdutoMod.Size = new System.Drawing.Size(132, 16);
            this.lblNomeProdutoMod.TabIndex = 0;
            this.lblNomeProdutoMod.Text = "Nome do Produto:";
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Image = global::ProjetoComercialComandas.Properties.Resources.x_sair;
            this.pictureBoxFechar.Location = new System.Drawing.Point(1172, 3);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(49, 29);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 10;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBoxFechar_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 528);
            this.Controls.Add(this.pictureBoxFechar);
            this.Controls.Add(this.grbModProduto);
            this.Controls.Add(this.grbCadastrarProdutos);
            this.Controls.Add(this.btnApagarProdutos);
            this.Controls.Add(this.gbrApagarProdutos);
            this.Controls.Add(this.pictureBoxFigura);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigura)).EndInit();
            this.gbrApagarProdutos.ResumeLayout(false);
            this.gbrApagarProdutos.PerformLayout();
            this.grbCadastrarProdutos.ResumeLayout(false);
            this.grbCadastrarProdutos.PerformLayout();
            this.grbModProduto.ResumeLayout(false);
            this.grbModProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.PictureBox pictureBoxFigura;
        private System.Windows.Forms.GroupBox gbrApagarProdutos;
        private System.Windows.Forms.Button btnApagarProdutos;
        private System.Windows.Forms.Label lblApagarProdutos;
        private System.Windows.Forms.GroupBox grbCadastrarProdutos;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeProdutoCad;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.TextBox txbCatCad;
        private System.Windows.Forms.Label lblCatCad;
        private System.Windows.Forms.GroupBox grbModProduto;
        private System.Windows.Forms.TextBox txbCatMod;
        private System.Windows.Forms.Label lblCatProdutosMod;
        private System.Windows.Forms.Button btnEditarProdutos;
        private System.Windows.Forms.TextBox txtPrecoMod;
        private System.Windows.Forms.TextBox txbNomeMod;
        private System.Windows.Forms.Label lblPrecoMod;
        private System.Windows.Forms.Label lblNomeProdutoMod;
        private System.Windows.Forms.PictureBox pictureBoxFechar;
    }
}