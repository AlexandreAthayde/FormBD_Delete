﻿using System;
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

            if (e.Button == MouseButtons.Right)
            {
                Usuarios user = dgv_dados.CurrentRow.DataBoundItem as Usuarios;
                Delete delete = new Delete(user);
                delete.Show();
            }
            else
            {
                Usuarios user = dgv_dados.CurrentRow.DataBoundItem as Usuarios;
                Update update = new Update(user);
                update.Show();
            }
            //Usuarios linha = dgv_dados.CurrentRow.DataBoundItem as Usuarios;
            //this.Close();
            
            //Update update = new Update(linha);
            //update.Show();

            //MessageBox.Show( "Nome: " +linha.Nome + "\n" + "E-mail: " + linha.Email + "\n" +"Usuário: " + linha.Usuario, "Seleção de linha", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void dgv_dados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgv_dados_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        {

        }

        private void dgv_dados_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
