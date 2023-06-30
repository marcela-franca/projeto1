using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto1
{
    public partial class AgendaVirtual : Form
    {
        public AgendaVirtual()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (txtboxemail.Text.Trim() == "" || txtboxsenha.Text.Trim() == "")
            {
                MessageBox.Show("Email ou Senha inválido");
                return;
            }
            if (!txtboxemail.Text.Contains("@") || !txtboxemail.Text.Contains("."))
            {
                MessageBox.Show("Email ou Senha inválido");
                return;
            }
            Form2 agenda = new Form2();
          agenda.ShowDialog();
            
        }
        
        private void txtboxsenha_MouseHover(object sender, EventArgs e)
        {
            ttpSenha.SetToolTip(txtboxsenha, "Deve conter: 8 caracteres," +
             " letra maiúscula e número!");
        }
    }
}
