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
    public partial class Form5 : Form
    {
        ConectaBanco conectaBanco = new ConectaBanco();

        int codEstado = 0;
        public Form5()
        {
            InitializeComponent();
            desableAll();
            InitializeDados();
        }

        private void desableAll()
        {
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox2.Enabled = false;
            comboBox1.SelectedIndex = 0;
            textBox2.Text = "";
            comboBox2.SelectedIndex = 0;
            button6.Enabled = false;
        }

        private void InitializeDados()
        {
            List<int> listaIdCod = conectaBanco.listaCidadesEmLista();

            // Verifica se a lista não é nula
            if (listaIdCod != null)
            {
                // Limpa o ComboBox antes de adicionar novos itens
                comboBox1.Items.Clear();

                // Adiciona cada idCod ao ComboBox
                foreach (int idCod in listaIdCod)
                {
                    comboBox1.Items.Add(idCod);
                }
            }

            List<String> listaIdCodEstados = conectaBanco.listaEstadoEmLista();

            // Verifica se a lista não é nula
            if (listaIdCodEstados != null)
            {
                // Limpa o ComboBox antes de adicionar novos itens
                comboBox2.Items.Clear();

                // Adiciona cada idCod ao ComboBox
                foreach (String idCod in listaIdCodEstados)
                {
                    comboBox2.Items.Add(idCod);
                }
            }
            comboBox1.Text = "Codigo";
            comboBox2.Text = "Estados";
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Deletar")
            {
                if (conectaBanco.deletaCidade((int)comboBox1.SelectedItem))
                {
                    MessageBox.Show("Que pena perder uma cidade no Brasil.  :(");
                }
            }
            else if (button6.Text == "Salvar")
            {
                Cidade c = new Cidade();
                c.Cid = textBox2.Text;
                //MessageBox.Show("CALL `Yproc_insertCidades`('"+textBox2.Text+"',"+conectaBanco.selectEstadoFromUf(comboBox2.Text)+")");
                c.UF = codEstado;
                if (conectaBanco.insereCidades(c))
                {
                    MessageBox.Show("Cidade cadastrada!");
                }
            }
            else if (button6.Text == "Alterar")
            {
                Cidade c = new Cidade();
                c.Cid = textBox2.Text;
                //MessageBox.Show("Cod do estado: "+ conectaBanco.selectEstadoFromUf(comboBox2.Text));
                c.UF = codEstado;
                if (conectaBanco.alteraCidade(c, (int)comboBox1.SelectedItem))
                {
                    MessageBox.Show("Cidade alterada!");
                }
            }
            desableAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desableAll();
            comboBox1.Enabled = true;
            button6.Enabled = true;
            button6.Text = "Deletar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desableAll();
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            button6.Enabled = true;
            button6.Text = "Salvar";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            desableAll();
            textBox2.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Enabled = true;
            button6.Enabled = true;
            button6.Text = "Alterar";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    if (comboBox1.SelectedItem == "0" || comboBox1.SelectedItem == "1,2")
                    {
                        return;
                    }
                    DataTable dt = new DataTable();
                    int x = (int)comboBox1.SelectedItem;
                    dt = conectaBanco.listaCidadePorCod(x);
                    int selectedIndex = 0;

                    if (dt.Rows.Count > 0)
                    {
                        textBox2.Text = dt.Rows[selectedIndex]["nome"].ToString();
                        comboBox2.SelectedIndex = (int)dt.Rows[selectedIndex]["codEstado"] -1;
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            codEstado = conectaBanco.selectEstadoFromUf(comboBox2.Text);
        }
    }
}
