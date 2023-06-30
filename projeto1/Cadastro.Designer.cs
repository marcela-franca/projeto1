namespace projeto1
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.TextBoxCEP = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.listaAlu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btneditar = new System.Windows.Forms.Button();
            this.ttpsenha = new System.Windows.Forms.ToolTip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLogra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(37, 30);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(410, 20);
            this.textNome.TabIndex = 0;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(37, 74);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(410, 20);
            this.textEndereco.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSalvar.Location = new System.Drawing.Point(651, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(118, 42);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLimpar.Location = new System.Drawing.Point(651, 340);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 41);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(37, 121);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(410, 20);
            this.textEmail.TabIndex = 4;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(37, 165);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(410, 20);
            this.textUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(527, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(527, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(37, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(530, 121);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(235, 20);
            this.textBoxSenha.TabIndex = 13;
            this.textBoxSenha.MouseHover += new System.EventHandler(this.textBoxSenha_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(527, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Senha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(37, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuário:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(527, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "CEP:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Cornsilk;
            this.btnExcluir.Location = new System.Drawing.Point(651, 293);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 41);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // TextBoxCEP
            // 
            this.TextBoxCEP.Location = new System.Drawing.Point(530, 165);
            this.TextBoxCEP.Mask = "00000-9999";
            this.TextBoxCEP.Name = "TextBoxCEP";
            this.TextBoxCEP.Size = new System.Drawing.Size(235, 20);
            this.TextBoxCEP.TabIndex = 19;
            // 
            // TextBoxCPF
            // 
            this.TextBoxCPF.Location = new System.Drawing.Point(530, 30);
            this.TextBoxCPF.Mask = "000.000.000-00";
            this.TextBoxCPF.Name = "TextBoxCPF";
            this.TextBoxCPF.Size = new System.Drawing.Size(235, 20);
            this.TextBoxCPF.TabIndex = 20;
            // 
            // TextBoxTel
            // 
            this.TextBoxTel.Location = new System.Drawing.Point(530, 74);
            this.TextBoxTel.Mask = "(00) 00000-0000";
            this.TextBoxTel.Name = "TextBoxTel";
            this.TextBoxTel.Size = new System.Drawing.Size(235, 20);
            this.TextBoxTel.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(527, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Categoria:";
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(530, 209);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(151, 20);
            this.textBoxCat.TabIndex = 23;
            // 
            // listaAlu
            // 
            this.listaAlu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listaAlu.HideSelection = false;
            this.listaAlu.Location = new System.Drawing.Point(37, 326);
            this.listaAlu.Name = "listaAlu";
            this.listaAlu.Size = new System.Drawing.Size(604, 103);
            this.listaAlu.TabIndex = 24;
            this.listaAlu.UseCompatibleStateImageBehavior = false;
            this.listaAlu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Endereço";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Usuário";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CPF";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tel";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Senha";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CEP";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Categoria";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btneditar.Location = new System.Drawing.Point(651, 245);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 42);
            this.btneditar.TabIndex = 25;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(37, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Logradouro:";
            // 
            // textBoxLogra
            // 
            this.textBoxLogra.Location = new System.Drawing.Point(37, 209);
            this.textBoxLogra.Name = "textBoxLogra";
            this.textBoxLogra.Size = new System.Drawing.Size(410, 20);
            this.textBoxLogra.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(37, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Bairro:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(37, 253);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(410, 20);
            this.textBoxBairro.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(37, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Número:";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(37, 293);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(153, 20);
            this.textBoxNum.TabIndex = 32;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxLogra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.listaAlu);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxTel);
            this.Controls.Add(this.TextBoxCPF);
            this.Controls.Add(this.TextBoxCEP);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox TextBoxCEP;
        private System.Windows.Forms.MaskedTextBox TextBoxCPF;
        private System.Windows.Forms.MaskedTextBox TextBoxTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.ListView listaAlu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.ToolTip ttpsenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLogra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNum;
    }
}