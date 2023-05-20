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
            adaugare = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            id_program = new DataGridViewTextBoxColumn();
            nume_program = new DataGridViewTextBoxColumn();
            id_ciclu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // adaugare
            // 
            adaugare.Location = new Point(411, 120);
            adaugare.Name = "adaugare";
            adaugare.Size = new Size(109, 43);
            adaugare.TabIndex = 1;
            adaugare.Text = "Adaugare Programe";
            adaugare.UseVisualStyleBackColor = true;
            adaugare.Click += adaugare_Click;
            // 
            // button2
            // 
            button2.Location = new Point(411, 195);
            button2.Name = "button2";
            button2.Size = new Size(109, 43);
            button2.TabIndex = 2;
            button2.Text = "Stergere Programe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_program, nume_program, id_ciclu });
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(342, 322);
            dataGridView1.TabIndex = 3;
            // 
            // id_program
            // 
            id_program.HeaderText = "Numar Program";
            id_program.Name = "id_program";
            // 
            // nume_program
            // 
            nume_program.HeaderText = "Numele Programului";
            nume_program.Name = "nume_program";
            // 
            // id_ciclu
            // 
            id_ciclu.HeaderText = "Ciclul";
            id_ciclu.Name = "id_ciclu";
            // 
            // ProgrameStudii
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 375);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(adaugare);
            Name = "ProgrameStudii";
            Text = "ProgrameStudii";
            Load += ProgrameStudii_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button adaugare;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_program;
        private DataGridViewTextBoxColumn nume_program;
        private DataGridViewTextBoxColumn id_ciclu;
    }
}