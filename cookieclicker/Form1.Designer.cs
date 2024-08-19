namespace cookieclicker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            updateLoop = new System.Windows.Forms.Timer(components);
            richTextBox2 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(407, 371);
            button1.MaximumSize = new Size(257, 190);
            button1.MinimumSize = new Size(257, 190);
            button1.Name = "button1";
            button1.Size = new Size(257, 190);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 20F);
            richTextBox1.Location = new Point(0, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(621, 54);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(924, 12);
            button2.Name = "button2";
            button2.Size = new Size(155, 102);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // updateLoop
            // 
            updateLoop.Enabled = true;
            updateLoop.Interval = 1;
            updateLoop.Tick += updateLoop_Tick;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(924, 120);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(155, 29);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(832, 32);
            button3.Name = "button3";
            button3.Size = new Size(75, 62);
            button3.TabIndex = 5;
            button3.Text = "MAX BUY";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(967, 487);
            button4.Name = "button4";
            button4.Size = new Size(112, 74);
            button4.TabIndex = 6;
            button4.Text = "Save and Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 623);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(1107, 662);
            MinimumSize = new Size(1107, 662);
            Name = "Form1";
            Text = "Cookie Clicker OS";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private System.Windows.Forms.Timer updateLoop;
        private RichTextBox richTextBox2;
        private Button button3;
        private Button button4;
    }
}
