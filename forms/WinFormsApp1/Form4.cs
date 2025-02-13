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
    public partial class Form4 : Form
    {
        ConectaBanco conectaBanco = new ConectaBanco();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 novoForm5 = new Form5(); // Criar uma instância do Form2
            novoForm5.ShowDialog(); // Mostrar o Form3
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            dgLista.DataSource = conectaBanco.listaCidades();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgLista.DataSource = conectaBanco.listaCidadesFromNameSearch(textBox1.Text);
        }
    }
}
