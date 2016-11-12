using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Delete : Form
    {
        public Usuarios UsuarioDeletado { get; set; }

        public Delete()
        {
            InitializeComponent();
        }

        public Delete(Usuarios user)
        {
            InitializeComponent();
            UsuarioDeletado = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja deletar o usuário " + UsuarioDeletado.Nome + " ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                ConecxaoBD conexao = new ConecxaoBD();
                var resposta = conexao.Delete(UsuarioDeletado);

                if (resposta)
                {
                    MessageBox.Show("Usuário deletado com sucesso", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            Controle controle = new Controle();
            controle.Show();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            textBox1.Text = UsuarioDeletado.Nome;
            textBox2.Text = UsuarioDeletado.Email;
            textBox3.Text = UsuarioDeletado.Usuario;
            textBox4.Text = UsuarioDeletado.Senha;
        }
    }
}
