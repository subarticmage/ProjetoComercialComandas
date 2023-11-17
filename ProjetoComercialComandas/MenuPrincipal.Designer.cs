namespace ProjetoComercialComandas
{
    partial class MenuPrincipal
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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnGerenciamentoUsuarios = new System.Windows.Forms.Button();
            this.pictureBoxAtendente = new System.Windows.Forms.PictureBox();
            this.pictureBoxFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(41, 23);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(158, 20);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENU PRINCIPAL";
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.Location = new System.Drawing.Point(44, 50);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(95, 20);
            this.lblSaudacao.TabIndex = 1;
            this.lblSaudacao.Text = "Olá, nome:";
            // 
            // btnComandas
            // 
            this.btnComandas.Location = new System.Drawing.Point(362, 71);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(250, 43);
            this.btnComandas.TabIndex = 2;
            this.btnComandas.Text = "COMANDAS";
            this.btnComandas.UseVisualStyleBackColor = true;
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Location = new System.Drawing.Point(362, 120);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(250, 43);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(362, 169);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(250, 43);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "PRODUTOS";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnGerenciamentoUsuarios
            // 
            this.btnGerenciamentoUsuarios.Location = new System.Drawing.Point(362, 218);
            this.btnGerenciamentoUsuarios.Name = "btnGerenciamentoUsuarios";
            this.btnGerenciamentoUsuarios.Size = new System.Drawing.Size(250, 43);
            this.btnGerenciamentoUsuarios.TabIndex = 5;
            this.btnGerenciamentoUsuarios.Text = "GERENCIAMENTO USUARIOS";
            this.btnGerenciamentoUsuarios.UseVisualStyleBackColor = true;
            this.btnGerenciamentoUsuarios.Click += new System.EventHandler(this.btnGerenciamentoUsuarios_Click);
            // 
            // pictureBoxAtendente
            // 
            this.pictureBoxAtendente.Image = global::ProjetoComercialComandas.Properties.Resources.atendente;
            this.pictureBoxAtendente.Location = new System.Drawing.Point(44, 71);
            this.pictureBoxAtendente.Name = "pictureBoxAtendente";
            this.pictureBoxAtendente.Size = new System.Drawing.Size(275, 190);
            this.pictureBoxAtendente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAtendente.TabIndex = 7;
            this.pictureBoxAtendente.TabStop = false;
            // 
            // pictureBoxFechar
            // 
            this.pictureBoxFechar.Image = global::ProjetoComercialComandas.Properties.Resources.x_sair;
            this.pictureBoxFechar.Location = new System.Drawing.Point(576, 12);
            this.pictureBoxFechar.Name = "pictureBoxFechar";
            this.pictureBoxFechar.Size = new System.Drawing.Size(67, 41);
            this.pictureBoxFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFechar.TabIndex = 8;
            this.pictureBoxFechar.TabStop = false;
            this.pictureBoxFechar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 280);
            this.Controls.Add(this.pictureBoxFechar);
            this.Controls.Add(this.pictureBoxAtendente);
            this.Controls.Add(this.btnGerenciamentoUsuarios);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnComandas);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.lblMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnGerenciamentoUsuarios;
        private System.Windows.Forms.PictureBox pictureBoxAtendente;
        private System.Windows.Forms.PictureBox pictureBoxFechar;
    }
}