using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1
{
    internal class AlunosDAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public AlunosDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Aluno alu)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Aluno VALUES (@categoria, @email, @usuario, @senha, @nome, @telefone, @foto, @cpf, @_id_end)";

            Cmd.Parameters.AddWithValue("@categoria", alu.Categoria);
            Cmd.Parameters.AddWithValue("@email", alu.Email);
            Cmd.Parameters.AddWithValue("@usuario", alu.Usuario);
            Cmd.Parameters.AddWithValue("@senha", alu.Senha);
            Cmd.Parameters.AddWithValue("@nome", alu.Nome);
            Cmd.Parameters.AddWithValue("@telefone", alu.Telefone);
            Cmd.Parameters.AddWithValue("@foto", alu.Foto);
            Cmd.Parameters.AddWithValue("@cpf", alu.CPF);
            Cmd.Parameters.AddWithValue("@_id_end", alu.Id_end);

            try
            {
                //Insere o cliente
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir aluno no banco.\n"
                    + err.Message);
            }
            finally
            {
                Con.CloseConnection(); 
            }
        }
        
        public List<Aluno> ListarAluno()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Aluno";

            List<Aluno> listaDeAlu = new List<Aluno>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                { // int id, string categoria, string email, string usuario, string senha, string nome, string telefone, string foto, string cpf
                    Aluno alu = new Aluno((int)rd["Id"], (string)rd["Categoria"],
                        (string)rd["Email"], (string)rd["Usuario"], (string)rd["Senha"], (string)rd["Nome"], (string)rd["Telefone"], (string)rd["Foto"], (string)rd["CPF"], (int)rd["_id_end"]);
                    listaDeAlu.Add(alu);
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

            return listaDeAlu;
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
