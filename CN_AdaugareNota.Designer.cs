namespace Aplicatie
{
    partial class CN_AdaugareNota
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_IDS = new TextBox();
            textBox_IDD = new TextBox();
            textBox_N = new TextBox();
            button_Ad = new Button();
            label4 = new Label();
            textBox_IDC = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 118);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "ID Disciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 171);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Nota";
            // 
            // textBox_IDS
            // 
            textBox_IDS.Location = new Point(75, 88);
            textBox_IDS.Name = "textBox_IDS";
            textBox_IDS.Size = new Size(125, 27);
            textBox_IDS.TabIndex = 3;
            // 
            // textBox_IDD
            // 
            textBox_IDD.Location = new Point(75, 141);
            textBox_IDD.Name = "textBox_IDD";
            textBox_IDD.Size = new Size(125, 27);
            textBox_IDD.TabIndex = 4;
            // 
            // textBox_N
            // 
            textBox_N.Location = new Point(75, 194);
            textBox_N.Name = "textBox_N";
            textBox_N.Size = new Size(125, 27);
            textBox_N.TabIndex = 5;
            // 
            // button_Ad
            // 
            button_Ad.Location = new Point(86, 238);
            button_Ad.Name = "button_Ad";
            button_Ad.Size = new Size(94, 29);
            button_Ad.TabIndex = 6;
            button_Ad.Text = "Adaugare";
            button_Ad.UseVisualStyleBackColor = true;
            button_Ad.Click += button_Ad_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 12);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 7;
            label4.Text = "ID Catalog";
            // 
            // textBox_IDC
            // 
            textBox_IDC.Location = new Point(75, 35);
            textBox_IDC.Name = "textBox_IDC";
            textBox_IDC.Size = new Size(125, 27);
            textBox_IDC.TabIndex = 8;
            // 
            // CN_AdaugareNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 279);
            Controls.Add(textBox_IDC);
            Controls.Add(label4);
            Controls.Add(button_Ad);
            Controls.Add(textBox_N);
            Controls.Add(textBox_IDD);
            Controls.Add(textBox_IDS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CN_AdaugareNota";
            Text = "Adaugare nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_IDS;
        private TextBox textBox_IDD;
        private TextBox textBox_N;
        private Button button_Ad;
        private Label label4;
        private TextBox textBox_IDC;
    }
}