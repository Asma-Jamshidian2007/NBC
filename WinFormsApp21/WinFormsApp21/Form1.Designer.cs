namespace WinFormsApp21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(44, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 45);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(210, 151);
            button1.Name = "button1";
            button1.Size = new Size(159, 44);
            button1.TabIndex = 2;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.GhostWhite;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binary-2", "Decimal-10", "Hex-16" });
            comboBox2.Location = new Point(49, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 28);
            comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 156);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 5;
            label1.Text = "from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 207);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 6;
            label2.Text = "to:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Location = new Point(268, 201);
            button2.Name = "button2";
            button2.Size = new Size(101, 46);
            button2.TabIndex = 7;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(44, 100);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 45);
            textBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary-2", "Decimal-10", "Hex-16" });
            comboBox1.Location = new Point(49, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 28);
            comboBox1.TabIndex = 9;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(218, 213);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "All";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(405, 259);
            Controls.Add(checkBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Base Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private CheckBox checkBox2;
    }
}
