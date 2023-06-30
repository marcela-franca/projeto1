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
          Form2 agenda = new Form2();
          agenda.ShowDialog();
            
        }

    }// refereciar o id do banco aluno para o login select * from AlunosDAO

}
