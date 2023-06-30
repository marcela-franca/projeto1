using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    internal class Endereco
    {
        private int _id;
        private string _logradouro;
        private string _bairro;
        private int _numero;
        private string _CEP;
       



        public Endereco(string log, string bairro, int num, string CEP)
        {
            Logradouro = log;
            Bairro = bairro;
            Numero = num;
            this.CEP = CEP;

        }

        public Endereco( int id, string log, string bairro, int num, string CEP) : this(log, bairro, num, CEP)
        {
            Id = id;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Logradouro
        {
            get { return _logradouro; }
            set
            {

                if (string.IsNullOrEmpty(value) || value.Length < 3)
                    throw new Exception("O nome precisa ter ao menos 3 caracteres.");
                _logradouro = value;
            }
        }
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
            }
        }
        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }
       
    }
}
