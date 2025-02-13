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

using MySqlX.XDevAPI;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static Atividade1Matheus.API;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp1.formCadCliente;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class formCadCliente : Form
    {
        ConectaBanco conectaBanco = new ConectaBanco();

        public formCadCliente()
        {
            InitializeComponent();
            desableAll();
            InitializeDados();
        }

        private void desableAll()
        {
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            maskedTextBox1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            maskedTextBox3.Enabled = false;
            maskedTextBox2.Enabled = false;
            button4.Enabled = false;
            textBox6.Enabled = false;
            textBox12.Enabled = false;
            textBox10.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox14.Enabled = false;
            maskedTextBox4.Enabled = false;
            textBox15.Enabled = false;
            button6.Enabled = false;
        }

        private void InitializeDados()
        {
            List<int> listaIdCod = conectaBanco.listaClientesEmLista();

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
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            desableAll();
            comboBox1.Enabled = true;
            button6.Text = "Deletar";
            button6.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desableAll();

            button6.Text = "Salvar";

            textBox2.Enabled = true;
            textBox3.Enabled = true;
            maskedTextBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            maskedTextBox3.Enabled = true;
            maskedTextBox2.Enabled = true;
            button4.Enabled = true;
            textBox6.Enabled = true;
            textBox12.Enabled = true;
            textBox10.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox14.Enabled = true;
            maskedTextBox4.Enabled = true;
            textBox15.Enabled = true;
            button6.Enabled = true;

            comboBox1.Text = "0";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox4.Text = "";
            textBox14.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox3.Text = "";
            textBox15.Text = "";
            maskedTextBox2.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox5.Text = "";
            textBox4.Text = "";
            textBox10.Text = "";
            label17.Text = "";


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public class Endereco
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Unidade { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string Uf { get; set; }
            public string Estado { get; set; }
            public string Regiao { get; set; }
            public string Ibge { get; set; }
            public string Gia { get; set; }
            public string Ddd { get; set; }
            public string Siafi { get; set; }
        }

        private async void maskedTextBox2_MaskInputRejected_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private async void button4_Click_1(object sender, EventArgs e)
        {

            String texto = maskedTextBox2.Text;
            texto = texto.Replace(".", "");
            texto = texto.Replace("-", "");
            using HttpClient client = new();
            if (maskedTextBox2.Text == "")
            {
                var endereco = await client.GetFromJsonAsync<Endereco>("https://viacep.com.br/ws/" + textBox12.Text + "/" + textBox6.Text + "/" + textBox5.Text + "/json/");
                textBox5.Text = endereco.Logradouro;
                textBox4.Text = endereco.Bairro;
                textBox6.Text = endereco.Localidade;
                textBox12.Text = endereco.Uf;
            }
            else
            {
                var endereco = await client.GetFromJsonAsync<Endereco>("https://viacep.com.br/ws/" + texto + "/json/");
                textBox5.Text = endereco.Logradouro;
                textBox4.Text = endereco.Bairro;
                textBox6.Text = endereco.Localidade;
                textBox12.Text = endereco.Uf;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            desableAll();
            comboBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            maskedTextBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            maskedTextBox3.Enabled = true;
            maskedTextBox2.Enabled = true;
            button4.Enabled = true;
            textBox6.Enabled = true;
            textBox12.Enabled = true;
            textBox10.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox14.Enabled = true;
            maskedTextBox4.Enabled = true;
            textBox15.Enabled = true;
            button6.Enabled = true;
            button6.Text = "Alterar";
        }

        private async void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = conectaBanco.listaCLientesPorCod((int)comboBox1.SelectedItem);
            int selectedIndex = 0;

            textBox2.Text = dt.Rows[selectedIndex]["nome"].ToString();
            textBox3.Text = dt.Rows[selectedIndex]["sobrenome"].ToString();
            maskedTextBox4.Text = dt.Rows[selectedIndex]["telefone"].ToString();
            textBox14.Text = dt.Rows[selectedIndex]["email"].ToString();
            maskedTextBox1.Text = dt.Rows[selectedIndex]["cpfCnpj"].ToString();
            maskedTextBox3.Text = dt.Rows[selectedIndex]["dataNascimento"].ToString();
            textBox15.Text = dt.Rows[selectedIndex]["observacoes"].ToString();
            maskedTextBox2.Text = dt.Rows[selectedIndex]["cep"].ToString();
            if (dt.Rows[selectedIndex]["genero"].ToString() == "Feminino")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            else if (dt.Rows[selectedIndex]["genero"].ToString() == "Masculino")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                radioButton3.Checked = false;
            }
            else if (dt.Rows[selectedIndex]["genero"].ToString() == "Outro")
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
            }
            String texto = maskedTextBox2.Text;
            texto = texto.Replace(".", "");
            texto = texto.Replace("-", "");

            using HttpClient client = new();

            var endereco = await client.GetFromJsonAsync<Endereco>("https://viacep.com.br/ws/" + texto + "/json/");
            textBox5.Text = endereco.Logradouro;
            textBox4.Text = endereco.Bairro;
            textBox6.Text = endereco.Localidade;
            textBox12.Text = endereco.Uf;

            textBox10.Text = dt.Rows[selectedIndex]["num"].ToString();

            //label17.Text = "Dados carregados!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Deletar")
            {
                if (conectaBanco.deletaCliente((int)comboBox1.SelectedItem))
                {
                    MessageBox.Show("É uma pena perder um cliente.");
                }
                InitializeDados();
            }
            else if (button6.Text == "Alterar")
            {
                Cliente c = new Cliente();
                c.NomeCliente = textBox2.Text;
                c.SobrenomeCliente = textBox3.Text;
                c.TelefoneCliente = maskedTextBox4.Text;
                c.EmailCliente = textBox14.Text;
                c.SenhaCliente = "NADA";
                c.CpfCnpjCliente = maskedTextBox1.Text;
                c.DataNascimento = maskedTextBox3.Text;
                c.ObservacaoCliente = textBox15.Text;
                c.CepCliente = maskedTextBox2.Text;
                if (radioButton1.Checked)
                {
                    c.GeneroCliente = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    c.GeneroCliente = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    c.GeneroCliente = radioButton3.Text;
                }
                c.LogradouroCliente = textBox5.Text;
                c.BairroCliente = textBox4.Text;
                c.NumCliente = int.Parse(textBox10.Text);
                c.CodCidade = conectaBanco.selectCidadeFromName(textBox6.Text);
                if (conectaBanco.alteraCliente(c, (int)comboBox1.SelectedItem))
                {
                    MessageBox.Show("Cliente alterado com sucesso!");
                }
            }
            else if (button6.Text == "Salvar")
            {
                Cliente c = new Cliente();
                c.NomeCliente = textBox2.Text;
                c.SobrenomeCliente = textBox3.Text;
                c.TelefoneCliente = maskedTextBox4.Text;
                c.EmailCliente = textBox14.Text;
                c.SenhaCliente = "NADA";
                c.CpfCnpjCliente = maskedTextBox1.Text;
                c.DataNascimento = maskedTextBox3.Text;
                c.ObservacaoCliente = textBox15.Text;
                c.CepCliente = maskedTextBox2.Text;
                if (radioButton1.Checked)
                {
                    c.GeneroCliente = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    c.GeneroCliente = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    c.GeneroCliente = radioButton3.Text;
                }
                c.LogradouroCliente = textBox5.Text;
                c.BairroCliente = textBox4.Text;
                c.NumCliente = int.Parse(textBox10.Text);
                c.CodCidade = conectaBanco.selectCidadeFromName(textBox6.Text);
                if (conectaBanco.insereCliente(c))
                {
                    MessageBox.Show("Cliente cadastrado!");
                }
            }
            button6.Text = "Salvar";
            desableAll();
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox4.Text = "";
            textBox14.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox3.Text = "";
            textBox15.Text = "";
            maskedTextBox2.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox5.Text = "";
            textBox4.Text = "";
            textBox10.Text = "";
            label17.Text = "";
        }
    }
}
