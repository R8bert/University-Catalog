namespace Aplicatie
{
    partial class DI_Adaugare
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
            textBox_IDD = new TextBox();
            textBox_ND = new TextBox();
            textBox_AD = new TextBox();
            textBox_NC = new TextBox();
            textBox_IDA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_Ad = new Button();
            SuspendLayout();
            // 
            // textBox_IDD
            // 
            textBox_IDD.Location = new Point(12, 32);
            textBox_IDD.Name = "textBox_IDD";
            textBox_IDD.Size = new Size(288, 27);
            textBox_IDD.TabIndex = 0;
            // 
            // textBox_ND
            // 
            textBox_ND.Location = new Point(12, 85);
            textBox_ND.Name = "textBox_ND";
            textBox_ND.Size = new Size(288, 27);
            textBox_ND.TabIndex = 1;
            // 
            // textBox_AD
            // 
            textBox_AD.Location = new Point(12, 138);
            textBox_AD.Name = "textBox_AD";
            textBox_AD.Size = new Size(288, 27);
            textBox_AD.TabIndex = 2;
            // 
            // textBox_NC
            // 
            textBox_NC.Location = new Point(12, 191);
            textBox_NC.Name = "textBox_NC";
            textBox_NC.Size = new Size(288, 27);
            textBox_NC.TabIndex = 3;
            // 
            // textBox_IDA
            // 
            textBox_IDA.Location = new Point(12, 244);
            textBox_IDA.Name = "textBox_IDA";
            textBox_IDA.Size = new Size(288, 27);
            textBox_IDA.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "ID Disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 6;
            label2.Text = "Nume Disciplina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 7;
            label3.Text = "Acronim Disciplina";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 8;
            label4.Text = "Numar Credite";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "ID An";
            // 
            // button_Ad
            // 
            button_Ad.Location = new Point(107, 294);
            button_Ad.Name = "button_Ad";
            button_Ad.Size = new Size(94, 33);
            button_Ad.TabIndex = 10;
            button_Ad.Text = "Adaugare";
            button_Ad.UseVisualStyleBackColor = true;
            button_Ad.Click += button_Ad_Click;
            // 
            // DI_Adaugare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 338);
            Controls.Add(button_Ad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_IDA);
            Controls.Add(textBox_NC);
            Controls.Add(textBox_AD);
            Controls.Add(textBox_ND);
            Controls.Add(textBox_IDD);
            Name = "DI_Adaugare";
            Text = "Adaugare Disciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_IDD;
        private TextBox textBox_ND;
        private TextBox textBox_AD;
        private TextBox textBox_NC;
        private TextBox textBox_IDA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_Ad;
    }
}