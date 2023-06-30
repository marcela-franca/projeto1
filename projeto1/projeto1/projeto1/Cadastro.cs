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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnvoltar(object sender, EventArgs e)
        {
            AgendaVirtual telacasdastro = new AgendaVirtual();
            telacasdastro.ShowDialog();
        }

        private void btnsalvar(object sender, EventArgs e)
        {
            MessageBox.Show("Salvo com sucesso");
        }
    }
}
