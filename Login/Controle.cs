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
    public partial class Controle : Form
    {

        AdventureWorksModel dataEntities = new AdventureWorksModel();

        public Controle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Controle_Load(object sender, EventArgs e)
        {
            ConecxaoBD conexao = new ConecxaoBD();
            var lista = conexao.BuscarTodos();

            dgv_dados.DataSource = lista;
        }

        private void dgv_dados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var linha = dgv_dados.CurrentRow.DataBoundItem as Usuarios;
            MessageBox.Show( "Nome: " +linha.Nome + "\n" + "E-mail: " + linha.Email + "\n" +"Usuário: " + linha.Usuario, "Seleção de linha", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
