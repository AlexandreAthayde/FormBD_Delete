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
    public partial class Update : Form
    {
        public Usuarios Usuario { get; set; }

        public Update()
        {
            InitializeComponent();
        }

        public Update(Usuarios user)
        {

            InitializeComponent();
            Usuario = user;
        }


        private void Update_Load(object sender, EventArgs e)
        {
            textBox1.Text = Usuario.Nome;
            textBox2.Text = Usuario.Email;
            textBox3.Text = Usuario.Usuario;
            textBox4.Text = Usuario.Senha;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConecxaoBD conexao = new ConecxaoBD();
            var retorno = conexao.Update(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Usuario.Id);

            if (retorno)
            {
                MessageBox.Show("Usuário alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Controle controle = new Controle();
                controle.Show();
            }
            
        }
    }
}
