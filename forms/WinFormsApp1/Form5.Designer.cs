namespace WinFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            button6 = new Button();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1,2" });
            comboBox1.Location = new Point(17, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 28);
            comboBox1.TabIndex = 14;
            comboBox1.TabStop = false;
            comboBox1.Text = "0";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.SteelBlue;
            textBox2.Location = new Point(178, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 27);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1,2" });
            comboBox2.Location = new Point(460, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(136, 28);
            comboBox2.TabIndex = 15;
            comboBox2.TabStop = false;
            comboBox2.Text = "Estado";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.ForeColor = Color.SteelBlue;
            button6.Location = new Point(495, 96);
            button6.Name = "button6";
            button6.Size = new Size(115, 45);
            button6.TabIndex = 29;
            button6.Text = "Salvar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.gradiente;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.SteelBlue;
            button5.Location = new Point(11, 103);
            button5.Name = "button5";
            button5.Size = new Size(114, 29);
            button5.TabIndex = 28;
            button5.Text = "Atualizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(162, 189, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 192, 252);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SteelBlue;
            button2.Image = Properties.Resources.fechar;
            button2.Location = new Point(270, 103);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
            button2.TabIndex = 27;
            button2.Text = "Excluir";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(162, 189, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 192, 252);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SteelBlue;
            button1.Image = Properties.Resources.icons8_plus_math_16;
            button1.Location = new Point(144, 103);
            button1.Name = "button1";
            button1.Size = new Size(104, 30);
            button1.TabIndex = 26;
            button1.Text = "Novo";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 170);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Button button6;
        private Button button5;
        private Button button2;
        private Button button1;
    }
}