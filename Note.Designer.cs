namespace Aplicatie
{
    partial class Note
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
            button_adn = new Button();
            button_gc = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(57, 53);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(700, 344);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button_adn
            // 
            button_adn.Location = new Point(518, 442);
            button_adn.Name = "button_adn";
            button_adn.Size = new Size(153, 29);
            button_adn.TabIndex = 2;
            button_adn.Text = "Adauga Nota";
            button_adn.UseVisualStyleBackColor = true;
            button_adn.Click += button_adn_Click;
            // 
            // button_gc
            // 
            button_gc.Location = new Point(518, 517);
            button_gc.Name = "button_gc";
            button_gc.Size = new Size(153, 29);
            button_gc.TabIndex = 3;
            button_gc.Text = "Genereaza Catalog";
            button_gc.UseVisualStyleBackColor = true;
            button_gc.Click += button_gc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 419);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Id Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 467);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "ID Disciplina";
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_gc);
            Controls.Add(button_adn);
            Controls.Add(listBox1);
            Name = "Note";
            Text = "Note";
            Load += Note_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button_adn;
        private Button button_gc;
        private Label label1;
        private Label label2;
    }
}