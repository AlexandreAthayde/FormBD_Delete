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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Cadastro cad = new Cadastro();
            cad.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConecxaoBD con = new ConecxaoBD();
            var login = con.Select(textBox1.Text, textBox2.Text);

            if (login)
            {
                MessageBox.Show("Usuário logado");
            }
            else
            {
                MessageBox.Show("Login Falied");
            }
        }
    }
}
