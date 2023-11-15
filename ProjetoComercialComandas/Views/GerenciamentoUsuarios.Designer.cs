namespace ProjetoComercialComandas.Views
{
    partial class GerenciamentoUsuarios
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
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.txtSenhaCad = new System.Windows.Forms.TextBox();
            this.txtEmailCad = new System.Windows.Forms.TextBox();
            this.txtNomeCompletpCad = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.txtSenhaEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtNomeCompletoEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblSenhaEdit = new System.Windows.Forms.Label();
            this.lblEmailEdit = new System.Windows.Forms.Label();
            this.lblNomeCompletoEdit = new System.Windows.Forms.Label();
            this.gbrApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblGerenciamentodeUsuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbEdit.SuspendLayout();
            this.gbrApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txtSenhaCad);
            this.grbCadastro.Controls.Add(this.txtEmailCad);
            this.grbCadastro.Controls.Add(this.txtNomeCompletpCad);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenha);
            this.grbCadastro.Controls.Add(this.lblEmail);
            this.grbCadastro.Controls.Add(this.lblNomeCompleto);
            this.grbCadastro.Location = new System.Drawing.Point(243, 277);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(246, 156);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            this.grbCadastro.Enter += new System.EventHandler(this.grbCadastro_Enter);
            // 
            // txtSenhaCad
            // 
            this.txtSenhaCad.Location = new System.Drawing.Point(99, 65);
            this.txtSenhaCad.Name = "txtSenhaCad";
            this.txtSenhaCad.Size = new System.Drawing.Size(141, 20);
            this.txtSenhaCad.TabIndex = 6;
            // 
            // txtEmailCad
            // 
            this.txtEmailCad.Location = new System.Drawing.Point(98, 39);
            this.txtEmailCad.Name = "txtEmailCad";
            this.txtEmailCad.Size = new System.Drawing.Size(141, 20);
            this.txtEmailCad.TabIndex = 5;
            // 
            // txtNomeCompletpCad
            // 
            this.txtNomeCompletpCad.Location = new System.Drawing.Point(98, 13);
            this.txtNomeCompletpCad.Name = "txtNomeCompletpCad";
            this.txtNomeCompletpCad.Size = new System.Drawing.Size(141, 20);
            this.txtNomeCompletpCad.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(10, 91);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(230, 59);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(7, 68);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(6, 16);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 34);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(729, 237);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.txtSenhaEdit);
            this.grbEdit.Controls.Add(this.txtEmailEdit);
            this.grbEdit.Controls.Add(this.txtNomeCompletoEdit);
            this.grbEdit.Controls.Add(this.btnEdit);
            this.grbEdit.Controls.Add(this.lblSenhaEdit);
            this.grbEdit.Controls.Add(this.lblEmailEdit);
            this.grbEdit.Controls.Add(this.lblNomeCompletoEdit);
            this.grbEdit.Enabled = false;
            this.grbEdit.Location = new System.Drawing.Point(496, 277);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(246, 156);
            this.grbEdit.TabIndex = 7;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Editar";
            // 
            // txtSenhaEdit
            // 
            this.txtSenhaEdit.Location = new System.Drawing.Point(99, 65);
            this.txtSenhaEdit.Name = "txtSenhaEdit";
            this.txtSenhaEdit.Size = new System.Drawing.Size(141, 20);
            this.txtSenhaEdit.TabIndex = 6;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(98, 39);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(141, 20);
            this.txtEmailEdit.TabIndex = 5;
            // 
            // txtNomeCompletoEdit
            // 
            this.txtNomeCompletoEdit.Location = new System.Drawing.Point(98, 13);
            this.txtNomeCompletoEdit.Name = "txtNomeCompletoEdit";
            this.txtNomeCompletoEdit.Size = new System.Drawing.Size(141, 20);
            this.txtNomeCompletoEdit.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.IndianRed;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(10, 91);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(230, 59);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSenhaEdit
            // 
            this.lblSenhaEdit.AutoSize = true;
            this.lblSenhaEdit.Location = new System.Drawing.Point(7, 68);
            this.lblSenhaEdit.Name = "lblSenhaEdit";
            this.lblSenhaEdit.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaEdit.TabIndex = 2;
            this.lblSenhaEdit.Text = "Senha";
            // 
            // lblEmailEdit
            // 
            this.lblEmailEdit.AutoSize = true;
            this.lblEmailEdit.Location = new System.Drawing.Point(7, 42);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdit.TabIndex = 1;
            this.lblEmailEdit.Text = "Email:";
            // 
            // lblNomeCompletoEdit
            // 
            this.lblNomeCompletoEdit.AutoSize = true;
            this.lblNomeCompletoEdit.Location = new System.Drawing.Point(6, 16);
            this.lblNomeCompletoEdit.Name = "lblNomeCompletoEdit";
            this.lblNomeCompletoEdit.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompletoEdit.TabIndex = 0;
            this.lblNomeCompletoEdit.Text = "Nome Completo:";
            // 
            // gbrApagar
            // 
            this.gbrApagar.Controls.Add(this.lblApagar);
            this.gbrApagar.Location = new System.Drawing.Point(244, 433);
            this.gbrApagar.Name = "gbrApagar";
            this.gbrApagar.Size = new System.Drawing.Size(498, 79);
            this.gbrApagar.TabIndex = 8;
            this.gbrApagar.TabStop = false;
            this.gbrApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(7, 36);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(163, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuario para apagar:";
            this.lblApagar.Click += new System.EventHandler(this.lblApagar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Enabled = false;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnApagar.Location = new System.Drawing.Point(593, 439);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(149, 74);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblGerenciamentodeUsuarios
            // 
            this.lblGerenciamentodeUsuarios.AutoSize = true;
            this.lblGerenciamentodeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciamentodeUsuarios.Location = new System.Drawing.Point(212, 7);
            this.lblGerenciamentodeUsuarios.Name = "lblGerenciamentodeUsuarios";
            this.lblGerenciamentodeUsuarios.Size = new System.Drawing.Size(270, 24);
            this.lblGerenciamentodeUsuarios.TabIndex = 10;
            this.lblGerenciamentodeUsuarios.Text = "Gerenciamento de Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoComercialComandas.Properties.Resources.usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(12, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoComercialComandas.Properties.Resources.x_sair;
            this.pictureBox2.Location = new System.Drawing.Point(703, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 532);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGerenciamentodeUsuarios);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.gbrApagar);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grbCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciamentoUsuarios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GerenciamentoUsuarios_Load);
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.gbrApagar.ResumeLayout(false);
            this.gbrApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txtSenhaCad;
        private System.Windows.Forms.TextBox txtEmailCad;
        private System.Windows.Forms.TextBox txtNomeCompletpCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.TextBox txtSenhaEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtNomeCompletoEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblSenhaEdit;
        private System.Windows.Forms.Label lblEmailEdit;
        private System.Windows.Forms.Label lblNomeCompletoEdit;
        private System.Windows.Forms.GroupBox gbrApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblGerenciamentodeUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}