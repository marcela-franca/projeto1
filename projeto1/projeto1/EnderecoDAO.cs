using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    internal class EnderecoDAO
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public EnderecoDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Endereco end)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Endereco VALUES (@log, @bairro, @num, @CEP)";

            Cmd.Parameters.AddWithValue("@log", end.Logradouro);
            Cmd.Parameters.AddWithValue("@bairro", end.Bairro);
            Cmd.Parameters.AddWithValue("@num", end.Numero);
            Cmd.Parameters.AddWithValue("@CEP", end.CEP);


            try
            {
                //Insere o cliente
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir endereço no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public int UltimoEndereco()
        {
           
            Con = new Conexao();
            int id = -1;
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @" SELECT max (id_end) as 'max_id_end' FROM Endereco";

           
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                rd.Read();
                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                if(rd.HasRows)
                { // int id, string categoria, string email, string usuario, string senha, string nome, string telefone, string foto, string cpf

                    id = (int)rd["max_id_end"];
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return id;
        }

        public List<Endereco> ListarEndereco()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Endereco";

            List<Endereco> listaDeEnd = new List<Endereco>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                { // int id, string categoria, string email, string usuario, string senha, string nome, string telefone, string foto, string cpf
                    Endereco end = new Endereco((int)rd["id_end"], (string)rd["logradouro"],
                        (string)rd["bairro"], (int)rd["numero"], (string)rd["cep"]);
                    listaDeEnd.Add(end);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeEnd;
        }
        public void Atualizar(Aluno alu)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Aluno SET Nome = @nome, Telefone = @tel,
            Senha = @senha WHERE Id = @id, Endereço = @_id_end";
            Cmd.Parameters.AddWithValue("@id", alu.Id);
            Cmd.Parameters.AddWithValue("@Categoria", alu.Categoria);
            Cmd.Parameters.AddWithValue("@Email", alu.Email);
            Cmd.Parameters.AddWithValue("@Usuario", alu.Usuario);
            Cmd.Parameters.AddWithValue("@Senha", alu.Senha);
            Cmd.Parameters.AddWithValue("@Nome", alu.Nome);
            Cmd.Parameters.AddWithValue("@Telefone", alu.Telefone);
            Cmd.Parameters.AddWithValue("@Foto", alu.Foto);
            Cmd.Parameters.AddWithValue("@CPF", alu.CPF);
            Cmd.Parameters.AddWithValue("@_id_end", alu.Id_end);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Excluir(int aluId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE fROM Colaborador WHERE Id = @id";
            Cmd.Parameters.AddWithValue("@id", aluId);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir aluno no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
    }
}
