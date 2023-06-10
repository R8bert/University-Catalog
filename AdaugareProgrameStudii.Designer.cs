namespace Aplicatie
{
    partial class AdaugareProgrameStudii
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
            NumarProgram = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NumeProgram = new TextBox();
            label3 = new Label();
            Cicluri = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // NumarProgram
            // 
            NumarProgram.Location = new Point(27, 67);
            NumarProgram.Name = "NumarProgram";
            NumarProgram.Size = new Size(171, 23);
            NumarProgram.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 1;
            label1.Text = "Numarul Programului";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 112);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 3;
            label2.Text = "Numele Programului";
            // 
            // NumeProgram
            // 
            NumeProgram.Location = new Point(27, 149);
            NumeProgram.Name = "NumeProgram";
            NumeProgram.Size = new Size(171, 23);
            NumeProgram.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 194);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Ciclul";
            // 
            // Cicluri
            // 
            Cicluri.FormattingEnabled = true;
            Cicluri.Location = new Point(46, 231);
            Cicluri.Name = "Cicluri";
            Cicluri.Size = new Size(127, 23);
            Cicluri.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(73, 276);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Adaugare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdaugareProgrameStudii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 330);
            Controls.Add(button1);
            Controls.Add(Cicluri);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NumeProgram);
            Controls.Add(label1);
            Controls.Add(NumarProgram);
            Name = "AdaugareProgrameStudii";
            Text = "AdaugareProgrameStudii";
            Load += AdaugareProgrameStudii_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumarProgram;
        private Label label1;
        private Label label2;
        private TextBox NumeProgram;
        private Label label3;
        private ComboBox Cicluri;
        private Button button1;
    }
}