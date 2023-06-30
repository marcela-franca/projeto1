using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    internal class Aluno
    {
        private int _id;
        private string _categoria;
        private string _email;
        private string _usuario;
        private string _senha;
        private string _nome;
        private string _telefone;
        private string _foto;
        private string _cpf;
        private int _id_end;
       

        public Aluno( string categoria, string email, string usuario, string senha, string nome, string telefone, string foto, string cpf, int id_end)
        {
            Nome = nome;
            Telefone = telefone;
            Senha = senha;
            Usuario = usuario;
            Email = email;
            Categoria = categoria;
            Foto = foto;
            CPF = cpf;
            Id_end = id_end;
           
        }

        public Aluno( int id, string categoria, string email, string usuario, string senha, string nome, string telefone, string foto, string cpf, int id_end) : this(nome, telefone, senha, usuario, email, categoria, foto,cpf, id_end)
        {
            Id = id;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Id_end
        {
            get { return _id_end; }
            set { _id_end = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {

                if (string.IsNullOrEmpty(value) || value.Length < 3)
                    throw new Exception("O nome precisa ter ao menos 3 caracteres.");
                _nome = value;
            }
        }
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }
}
