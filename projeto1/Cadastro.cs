using projeto1.projeto1;
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
        private int id;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
        private void UpdateListView()
        {
            listaAlu.Items.Clear();
            AlunosDAO Aluno = new AlunosDAO();

            List<Aluno> listaDeAlu = Aluno.ListarAluno();
            if (listaDeAlu.Count > 0)
            {
                foreach (var alu in listaDeAlu)
                {
                    ListViewItem lv = new ListViewItem(alu.Id.ToString());
                    lv.SubItems.Add(alu.Categoria);
                    lv.SubItems.Add(alu.Email);
                    lv.SubItems.Add(alu.Usuario);
                    lv.SubItems.Add(alu.Senha);
                    lv.SubItems.Add(alu.Nome);
                    lv.SubItems.Add(alu.Telefone);
                    lv.SubItems.Add(alu.Foto);
                    lv.SubItems.Add(alu.CPF);
                    lv.SubItems.Add(alu.Id.ToString());

                    listaAlu.Items.Add(lv);
                }
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AlunosDAO AlunoDAO = new AlunosDAO();

            try
            {
                AlunoDAO.Excluir(id);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
            
        }

       //perguntar se esta certo
        private void listaAlu_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listaAlu.FocusedItem.Index;
            id = int.Parse(listaAlu.Items[index].SubItems[0].Text);
            textBoxCat.Text = listaAlu.Items[index].SubItems[1].Text;
            textUsuario.Text = listaAlu.Items[index].SubItems[2].Text;
            textBoxSenha.Text = listaAlu.Items[index].SubItems[3].Text;
            textNome.Text = listaAlu.Items[index].SubItems[4].Text;
            textEndereco.Text = listaAlu.Items[index].SubItems[5].Text;
            textEmail.Text = listaAlu.Items[index].SubItems[6].Text;
            TextBoxTel.Text = listaAlu.Items[index].SubItems[7].Text;
            TextBoxCPF.Text = listaAlu.Items[index].SubItems[8].Text;
            TextBoxCEP.Text = listaAlu.Items[index].SubItems[9].Text;

            btneditar.Text = "EDITAR";
            btnExcluir.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
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
            string cpf = TextBoxCEP.Text;
        
            try
            {
                Endereco endereco = new Endereco(textBoxLogra.Text, textBoxBairro.Text, int.Parse(textBoxNum.Text), TextBoxCEP.Text);
                EnderecoDAO enderecoDAO = new EnderecoDAO();
                enderecoDAO.Inserir(endereco);

                Aluno Alu = new Aluno(categoria, email, usuario, senha, nome, telefone, foto, cpf, enderecoDAO.UltimoEndereco());
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
            TextBoxCEP.Clear();
            textUsuario.Clear();
        }

        private void textBoxSenha_MouseHover(object sender, EventArgs e)
        {
            ttpsenha.SetToolTip(textBoxSenha, "Deve conter: 8 caracteres," +
               " letra maiúscula e número!");
        }
    }
}
