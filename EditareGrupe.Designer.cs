namespace Aplicatie
{
    partial class EditareGrupe
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
            adaugareStudent = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            stergeStudent = new Button();
            SuspendLayout();
            // 
            // adaugareStudent
            // 
            adaugareStudent.Location = new Point(12, 175);
            adaugareStudent.Name = "adaugareStudent";
            adaugareStudent.Size = new Size(126, 51);
            adaugareStudent.TabIndex = 0;
            adaugareStudent.Text = "Adaugare student";
            adaugareStudent.UseVisualStyleBackColor = true;
            adaugareStudent.Click += adaugareStudent_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 19);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Id-ul studentului";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 91);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Grupa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 3;
            // 
            // stergeStudent
            // 
            stergeStudent.Location = new Point(147, 175);
            stergeStudent.Name = "stergeStudent";
            stergeStudent.Size = new Size(126, 51);
            stergeStudent.TabIndex = 5;
            stergeStudent.Text = "Sterge student";
            stergeStudent.UseVisualStyleBackColor = true;
            stergeStudent.Click += stergeStudent_Click;
            // 
            // EditareGrupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 270);
            Controls.Add(stergeStudent);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(adaugareStudent);
            Name = "EditareGrupe";
            Text = "EditareGrupe";
            Load += EditareGrupe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adaugareStudent;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button stergeStudent;
    }
}