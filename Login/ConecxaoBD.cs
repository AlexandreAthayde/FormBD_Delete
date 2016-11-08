using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ConecxaoBD
    {
        public SqlConnection conecxao { get; set; }

        public ConecxaoBD()
        {
            var caminho = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =C:\Users\Alexandre Athayde\OneDrive - Centro Paula Souza - FATEC\Fatec-Garça\4º - Termo\Prof. Fabio\N2\Login\UsersDB.mdf; Integrated Security = True; Connect Timeout = 30";
            conecxao = new SqlConnection(caminho);
            conecxao.Open();

            if (conecxao.State == ConnectionState.Open)
            {
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Conecxão no Banco Fracassada!");
            }
            
        }
        public bool Inserir(String nome, String email, String usuario, String senha)
        {
            var sql = "Insert into usuarios (Nome, Email, Usuario, Senha) values (@nome, @email, @usuario, @senha)";
            var comando = new SqlCommand(sql, conecxao);

            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);

            var retorno = comando.ExecuteNonQuery();

            if (retorno > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        bool buscar;
        public bool Select(String nome, string senha)
        {
            string consulta = "SELECT Usuario, Senha from usuarios";
            SqlCommand cmd = new SqlCommand(consulta, conecxao);
            SqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                 var n = rdr["Usuario"].ToString();
                 var s = rdr["Senha"].ToString();
                if (nome == n && senha == s)
                {
                    buscar = true;
                    break;
                }
                else
                {
                    buscar = false;
                }
            }return buscar;
        }

        
        public List<Usuarios> BuscarTodos()
        {
            string consulta = "SELECT * from usuarios";
            SqlCommand cmd = new SqlCommand(consulta, conecxao);
            SqlDataReader rdr = cmd.ExecuteReader();

            Usuarios users = null;
            List<Usuarios> listuser = new List<Usuarios>();

            while (rdr.Read())
            {
                users = new Usuarios();
                users.Id = Convert.ToInt32(rdr["Id"]);
                users.Nome = rdr["Nome"].ToString();
                users.Email = rdr["Email"].ToString();
                users.Usuario = rdr["Usuario"].ToString();
                users.Senha = rdr["Senha"].ToString();
                listuser.Add(users);
            }
            return listuser;
        }

        public bool Update(String nome, String email, String usuario, String senha, int id)
        {
            var sql = " UPDATE usuarios SET " +
                " Nome = @nome, " +
                " Email = @email, " +
                " Usuario = @usuario, " +
                " Senha = @senha " +
                " WHERE Id = @id ";

            var comando = new SqlCommand(sql, conecxao);

            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@id", id);

            var retorno = comando.ExecuteNonQuery();

            if (retorno > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
