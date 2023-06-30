namespace projeto1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Aulas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefinirSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(23, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // Aulas
            // 
            this.Aulas.FormattingEnabled = true;
            this.Aulas.Location = new System.Drawing.Point(271, 32);
            this.Aulas.Name = "Aulas";
            this.Aulas.Size = new System.Drawing.Size(227, 160);
            this.Aulas.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 455);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-58, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(359, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::projeto1.Properties.Resources.OIP__1_;
            this.pictureBox2.Location = new System.Drawing.Point(59, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(229, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redefinirSenhaToolStripMenuItem,
            this.editarFotoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(124, 32);
            this.menuToolStripMenuItem.Text = "Editar Perfil";
            // 
            // redefinirSenhaToolStripMenuItem
            // 
            this.redefinirSenhaToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.redefinirSenhaToolStripMenuItem.Name = "redefinirSenhaToolStripMenuItem";
            this.redefinirSenhaToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.redefinirSenhaToolStripMenuItem.Text = "Redefinir senha";
            this.redefinirSenhaToolStripMenuItem.Click += new System.EventHandler(this.redefinirSenhaToolStripMenuItem_Click);
            // 
            // editarFotoToolStripMenuItem
            // 
            this.editarFotoToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.editarFotoToolStripMenuItem.Name = "editarFotoToolStripMenuItem";
            this.editarFotoToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.editarFotoToolStripMenuItem.Text = "Editar foto";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.LemonChiffon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.Aulas);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Location = new System.Drawing.Point(256, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 225);
            this.panel2.TabIndex = 4;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackColor = System.Drawing.Color.Orange;
            this.buttonCadastro.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastro.Location = new System.Drawing.Point(672, 368);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(100, 59);
            this.buttonCadastro.TabIndex = 6;
            this.buttonCadastro.Text = "Cadastro";
            this.buttonCadastro.UseVisualStyleBackColor = false;
            this.buttonCadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox Aulas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redefinirSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFotoToolStripMenuItem;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}