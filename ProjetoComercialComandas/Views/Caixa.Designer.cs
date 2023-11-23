namespace ProjetoComercialComandas.Views
{
    partial class Caixa
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
            this.lblNComanda = new System.Windows.Forms.Label();
            this.txbNComanda = new System.Windows.Forms.TextBox();
            this.dgvTotalComand = new System.Windows.Forms.DataGridView();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.lblTotalComanda = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCaixa = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalComand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNComanda
            // 
            this.lblNComanda.AutoSize = true;
            this.lblNComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNComanda.Location = new System.Drawing.Point(114, 31);
            this.lblNComanda.Name = "lblNComanda";
            this.lblNComanda.Size = new System.Drawing.Size(215, 24);
            this.lblNComanda.TabIndex = 0;
            this.lblNComanda.Text = "Número da Comanda:";
            // 
            // txbNComanda
            // 
            this.txbNComanda.Location = new System.Drawing.Point(330, 36);
            this.txbNComanda.Name = "txbNComanda";
            this.txbNComanda.Size = new System.Drawing.Size(82, 20);
            this.txbNComanda.TabIndex = 1;
            // 
            // dgvTotalComand
            // 
            this.dgvTotalComand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalComand.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTotalComand.Location = new System.Drawing.Point(8, 82);
            this.dgvTotalComand.Name = "dgvTotalComand";
            this.dgvTotalComand.Size = new System.Drawing.Size(586, 308);
            this.dgvTotalComand.TabIndex = 3;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.BackColor = System.Drawing.Color.Salmon;
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Location = new System.Drawing.Point(386, 504);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(207, 52);
            this.btnEncerrar.TabIndex = 4;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(386, 481);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(170, 17);
            this.chbPagamento.TabIndex = 5;
            this.chbPagamento.Text = "PAGAMENTO RECEBIDO";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // lblTotalComanda
            // 
            this.lblTotalComanda.AutoSize = true;
            this.lblTotalComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComanda.Location = new System.Drawing.Point(415, 429);
            this.lblTotalComanda.Name = "lblTotalComanda";
            this.lblTotalComanda.Size = new System.Drawing.Size(94, 25);
            this.lblTotalComanda.TabIndex = 6;
            this.lblTotalComanda.Text = "R$ 0,00";
            this.lblTotalComanda.Click += new System.EventHandler(this.lblTotalComanda_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoComercialComandas.Properties.Resources.caixa_4;
            this.pictureBox2.Location = new System.Drawing.Point(8, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoComercialComandas.Properties.Resources.x_sair;
            this.pictureBox1.Location = new System.Drawing.Point(559, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxCaixa
            // 
            this.pictureBoxCaixa.Image = global::ProjetoComercialComandas.Properties.Resources.caixa_2;
            this.pictureBoxCaixa.Location = new System.Drawing.Point(7, 454);
            this.pictureBoxCaixa.Name = "pictureBoxCaixa";
            this.pictureBoxCaixa.Size = new System.Drawing.Size(373, 102);
            this.pictureBoxCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCaixa.TabIndex = 7;
            this.pictureBoxCaixa.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ProjetoComercialComandas.Properties.Resources.lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(418, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(176, 47);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(607, 562);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxCaixa);
            this.Controls.Add(this.lblTotalComanda);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.dgvTotalComand);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbNComanda);
            this.Controls.Add(this.lblNComanda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalComand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNComanda;
        private System.Windows.Forms.TextBox txbNComanda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvTotalComand;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.Label lblTotalComanda;
        private System.Windows.Forms.PictureBox pictureBoxCaixa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}