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

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = textBoxCat.Text;
            string email = textEmail.Text;
            string usuario = textUsuario.Text;
            string senha = textBoxSenha.Text;
            string nome = textNome.Text;
            string telefone = TextBoxTel.Text;
            string foto = "/";
            string cpf = TextBoxCPF.Text;
           

        

            try
            {
                Endereco endereco = new Endereco(textBoxLogra.Text, textBoxBairro.Text, int.Parse(textBoxNum.Text), textBoxCep.Text);
                EnderecoDAO enderecoDAO = new EnderecoDAO();
                enderecoDAO.Inserir(endereco);

                Aluno Alu = new Aluno(categoria, email, usuario, senha, nome, telefone, foto, cpf,enderecoDAO.UltimoEndereco());
                AlunosDAO alunosDAO = new AlunosDAO();
                alunosDAO.Inserir(Alu);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            textNome.Clear();
            TextBoxTel.Clear();
            textBoxSenha.Clear();
            textEmail.Clear();
            textBoxCat.Clear();
            TextBoxCPF.Clear();
            textUsuario.Clear();
        }
    }
}
