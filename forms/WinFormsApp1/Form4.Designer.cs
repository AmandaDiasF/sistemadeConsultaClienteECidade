namespace WinFormsApp1
{
    partial class Form4
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
            dgLista = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button4 = new Button();
            btEditar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(43, 142);
            dgLista.Name = "dgLista";
            dgLista.RowHeadersWidth = 51;
            dgLista.Size = new Size(594, 477);
            dgLista.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(btEditar);
            groupBox1.ForeColor = Color.SlateGray;
            groupBox1.Location = new Point(12, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(132, 94);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.icons8_add_48;
            button1.Location = new Point(18, 30);
            button1.Name = "button1";
            button1.Size = new Size(48, 46);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.Image = Properties.Resources.icons8_add_48;
            button4.Location = new Point(180, 28);
            button4.Name = "button4";
            button4.Size = new Size(0, 0);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Transparent;
            btEditar.Cursor = Cursors.Hand;
            btEditar.Enabled = false;
            btEditar.FlatAppearance.BorderSize = 0;
            btEditar.Image = Properties.Resources.icons8_edit_48;
            btEditar.Location = new Point(72, 28);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(48, 48);
            btEditar.TabIndex = 2;
            btEditar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 61);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 6;
            label1.Text = "Pesquisa por nome";
            label1.Click += label1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(692, 649);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(dgLista);
            Name = "Form4";
            Text = "Cidade";
            Load += Form4_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgLista;
        private GroupBox groupBox1;
        private Button button4;
        private Button btEditar;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}