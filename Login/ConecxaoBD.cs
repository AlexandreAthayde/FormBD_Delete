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
            var caminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexandre Athayde\OneDrive - Centro Paula Souza - FATEC\Fatec - Garça\4º - Termo\Prof.Fabio\N2\Login\UsersDB.mdf;Integrated Security=True;Connect Timeout=30";
            conecxao = new SqlConnection(caminho);
            conecxao.Open();

            if (conecxao.State == ConnectionState.Open)
            {
                
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Conecxão no Banco Fracassada!");
            }
            conecxao.Close();
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
        
    }
}
