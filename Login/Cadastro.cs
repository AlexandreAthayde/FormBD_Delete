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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConecxaoBD con = new ConecxaoBD();
            var relsultado = con.Inserir(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            if (relsultado)
            {
                MessageBox.Show("Inserção no banco com sucesso!");
            }
            else
            {
                MessageBox.Show("Inserção Falied");
            }
            this.Close();
        }
    }
}
