namespace Aplicatie
{
    partial class ProgrameStudii
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
            listBox1 = new ListBox();
            adaugare = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(524, 289);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // adaugare
            // 
            adaugare.Location = new Point(641, 108);
            adaugare.Name = "adaugare";
            adaugare.Size = new Size(109, 43);
            adaugare.TabIndex = 1;
            adaugare.Text = "Adaugare Programe";
            adaugare.UseVisualStyleBackColor = true;
            adaugare.Click += adaugare_Click;
            // 
            // button2
            // 
            button2.Location = new Point(641, 238);
            button2.Name = "button2";
            button2.Size = new Size(109, 43);
            button2.TabIndex = 2;
            button2.Text = "Stergere Programe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProgrameStudii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(adaugare);
            Controls.Add(listBox1);
            Name = "ProgrameStudii";
            Text = "ProgrameStudii";
            Load += ProgrameStudii_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button adaugare;
        private Button button2;
    }
}