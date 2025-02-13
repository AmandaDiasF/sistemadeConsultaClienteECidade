namespace WinFormsApp1
{
    partial class menuRestrito
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
            button1 = new Button();
            BemV = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(227, 181);
            button1.Name = "button1";
            button1.Size = new Size(250, 41);
            button1.TabIndex = 0;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BemV
            // 
            BemV.AutoSize = true;
            BemV.BackColor = Color.Transparent;
            BemV.FlatStyle = FlatStyle.Flat;
            BemV.Font = new Font("Segoe UI", 20F);
            BemV.ForeColor = Color.SteelBlue;
            BemV.Location = new Point(227, 66);
            BemV.Name = "BemV";
            BemV.Size = new Size(253, 46);
            BemV.TabIndex = 1;
            BemV.Text = "Seja Bem Vindo";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(227, 356);
            button2.Name = "button2";
            button2.Size = new Size(250, 41);
            button2.TabIndex = 0;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.SteelBlue;
            button3.Location = new Point(227, 267);
            button3.Name = "button3";
            button3.Size = new Size(250, 41);
            button3.TabIndex = 0;
            button3.Text = "Cidade";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // menuRestrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gradiente;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 540);
            Controls.Add(BemV);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = Color.SteelBlue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "menuRestrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menuRestrito";
            Load += menuRestrito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label BemV;
        private Button button2;
        private Button button3;
    }
}