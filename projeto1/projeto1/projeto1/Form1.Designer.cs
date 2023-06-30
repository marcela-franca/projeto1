namespace projeto1
{
    partial class AgendaVirtual
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelemail = new System.Windows.Forms.Label();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.txtboxsenha = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.linkredsenha = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.Navy;
            this.labelemail.Location = new System.Drawing.Point(615, 190);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(96, 34);
            this.labelemail.TabIndex = 1;
            this.labelemail.Text = "E-mail";
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(621, 237);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(371, 20);
            this.txtboxemail.TabIndex = 2;
            this.txtboxemail.TextChanged += new System.EventHandler(this.txtboxemail_TextChanged);
            this.txtboxemail.Leave += new System.EventHandler(this.txtboxemail_Leave);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.ForeColor = System.Drawing.Color.Navy;
            this.Senha.Location = new System.Drawing.Point(624, 320);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(77, 31);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha";
            // 
            // txtboxsenha
            // 
            this.txtboxsenha.Location = new System.Drawing.Point(621, 354);
            this.txtboxsenha.Name = "txtboxsenha";
            this.txtboxsenha.PasswordChar = '*';
            this.txtboxsenha.Size = new System.Drawing.Size(367, 20);
            this.txtboxsenha.TabIndex = 4;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Navy;
            this.buttonlogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonlogin.Location = new System.Drawing.Point(621, 436);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(117, 33);
            this.buttonlogin.TabIndex = 5;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // linkredsenha
            // 
            this.linkredsenha.AutoSize = true;
            this.linkredsenha.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkredsenha.LinkColor = System.Drawing.Color.Navy;
            this.linkredsenha.Location = new System.Drawing.Point(849, 397);
            this.linkredsenha.Name = "linkredsenha";
            this.linkredsenha.Size = new System.Drawing.Size(139, 23);
            this.linkredsenha.TabIndex = 6;
            this.linkredsenha.TabStop = true;
            this.linkredsenha.Text = "Redefinir senha";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(849, 436);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cadastro";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cadastro);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(629, 392);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Salvar login";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto1.Properties.Resources.kisspng_traffic_police_police_officer_clip_art_vector_command_traffic_police_5a7e814e2c4047_7146599115182400781813_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(103, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 542);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AgendaVirtual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1283, 636);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkredsenha);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.txtboxsenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Name = "AgendaVirtual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Virtual";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txtboxsenha;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.LinkLabel linkredsenha;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

