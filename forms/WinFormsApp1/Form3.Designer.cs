namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            groupBox1 = new GroupBox();
            button4 = new Button();
            btEditar = new Button();
            btAdd = new Button();
            dgLista = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLista).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(btEditar);
            groupBox1.Controls.Add(btAdd);
            groupBox1.ForeColor = Color.SlateGray;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(132, 94);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            groupBox1.Enter += groupBox1_Enter;
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
            // btAdd
            // 
            btAdd.BackColor = Color.Transparent;
            btAdd.Cursor = Cursors.Hand;
            btAdd.FlatAppearance.BorderSize = 0;
            btAdd.Image = Properties.Resources.icons8_add_48;
            btAdd.Location = new Point(18, 28);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(48, 48);
            btAdd.TabIndex = 2;
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // dgLista
            // 
            dgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLista.Location = new Point(34, 140);
            dgLista.Name = "dgLista";
            dgLista.RowHeadersWidth = 51;
            dgLista.Size = new Size(1193, 477);
            dgLista.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 66);
            label1.Name = "label1";
            label1.Size = new Size(180, 22);
            label1.TabIndex = 8;
            label1.Text = "Pesquisa por nome";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 29);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradiente;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgLista);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 11F);
            ForeColor = Color.SteelBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btAdd;
        private Button button4;
        private Button btEditar;
        private DataGridView dgLista;
        private Label label1;
        private TextBox textBox1;
    }
}