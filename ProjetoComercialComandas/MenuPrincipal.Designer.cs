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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBoxAtendente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtendente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(41, 23);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(98, 13);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENU PRINCIPAL";
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Location = new System.Drawing.Point(44, 50);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(58, 13);
            this.lblSaudacao.TabIndex = 1;
            this.lblSaudacao.Text = "Olá, nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAtendente
            // 
            this.pictureBoxAtendente.Image = global::ProjetoComercialComandas.Properties.Resources.atendente;
            this.pictureBoxAtendente.Location = new System.Drawing.Point(230, 108);
            this.pictureBoxAtendente.Name = "pictureBoxAtendente";
            this.pictureBoxAtendente.Size = new System.Drawing.Size(220, 139);
            this.pictureBoxAtendente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAtendente.TabIndex = 7;
            this.pictureBoxAtendente.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxAtendente);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtendente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBoxAtendente;
    }
}