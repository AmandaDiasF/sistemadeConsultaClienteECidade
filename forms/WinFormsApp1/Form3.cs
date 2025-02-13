using Atividade1Matheus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        ConectaBanco conectaBanco = new ConectaBanco();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgLista.DataSource = conectaBanco.listaCLientes();
        }



        private void btAdd_Click(object sender, EventArgs e)
        {
            formCadCliente novoFormulario = new formCadCliente(); // Criar uma instância do Form2
            novoFormulario.ShowDialog(); // Mostrar o Form3
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgLista.DataSource = conectaBanco.listaClientesFromNameSearch(textBox1.Text);
        }
    }
}
