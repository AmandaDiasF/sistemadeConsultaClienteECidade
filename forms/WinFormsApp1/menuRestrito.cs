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
    public partial class menuRestrito : Form
    {
        public menuRestrito()
        {
            InitializeComponent();
        }

        private void menuRestrito_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 novoFormulario = new Form3(); // Criar uma instância do Form2
            novoFormulario.Show(); // Mostrar o Form3
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 novoFormulario = new Form4(); // Criar uma instância do Form2
            novoFormulario.Show(); // Mostrar o Form3
        }
    }
}

