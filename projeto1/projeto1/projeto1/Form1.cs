using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
           
             
            
        }

        private void link_cadastro(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro telainicial = new Cadastro();
            telainicial.ShowDialog();
        }

        private void txtboxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxemail_Leave(object sender, EventArgs e)
        {
            string email = txtboxemail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Email inválido");
                txtboxemail.Focus();
            }
               
          
        }
    }
}
