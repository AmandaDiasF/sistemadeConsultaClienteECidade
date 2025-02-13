namespace WinFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();/* encerra janela */
        }

        private void button2_Click(object sender, EventArgs e)
        {   //verificação de senha e apresentação do erro caso tenha
            try
            {
                if (txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("admin"))
                {
                    //ir para o sistema restrito
                    var menu = new menuRestrito();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Usuário ou Senha incorretos",
                        "Desculpe.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Desculpe.",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.LightYellow;
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;

            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ou números",
                    "Ops",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.SelectionStart = 0;
                txtUsuario.SelectionLength = txtUsuario.Text.Length;

                txtUsuario.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
