namespace Aplicatie
{
    partial class GenerareGrupe
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(52, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Genereaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 2;
            label1.Text = "Numarul de grupe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 95);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "Ultimul an de inscriere";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 4;
            // 
            // GenerareGrupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(186, 213);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "GenerareGrupe";
            Text = "GenerareGrupe";
            Load += GenerareGrupe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}