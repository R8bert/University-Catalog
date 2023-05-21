namespace Aplicatie
{
    partial class Grupe
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            idStudent = new DataGridViewTextBoxColumn();
            nume = new DataGridViewTextBoxColumn();
            prenume = new DataGridViewTextBoxColumn();
            program = new DataGridViewTextBoxColumn();
            ciclu = new DataGridViewTextBoxColumn();
            an = new DataGridViewTextBoxColumn();
            medie = new DataGridViewTextBoxColumn();
            contor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idStudent, nume, prenume, program, ciclu, an, medie, contor });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(744, 387);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(893, 30);
            button1.Name = "button1";
            button1.Size = new Size(136, 66);
            button1.TabIndex = 1;
            button1.Text = "Generare automata a grupelor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(893, 118);
            button2.Name = "button2";
            button2.Size = new Size(136, 66);
            button2.TabIndex = 2;
            button2.Text = "Importare grupe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(893, 204);
            button3.Name = "button3";
            button3.Size = new Size(136, 66);
            button3.TabIndex = 3;
            button3.Text = "Editare grupe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // idStudent
            // 
            idStudent.HeaderText = "ID Student";
            idStudent.Name = "idStudent";
            // 
            // nume
            // 
            nume.HeaderText = "Numele studentului";
            nume.Name = "nume";
            // 
            // prenume
            // 
            prenume.HeaderText = "Prenumele studentului";
            prenume.Name = "prenume";
            // 
            // program
            // 
            program.HeaderText = "Programul de studii";
            program.Name = "program";
            // 
            // ciclu
            // 
            ciclu.HeaderText = "Ciclul de invatamant";
            ciclu.Name = "ciclu";
            // 
            // an
            // 
            an.HeaderText = "Anul de admitere";
            an.Name = "an";
            // 
            // medie
            // 
            medie.HeaderText = "Media de intrare";
            medie.Name = "medie";
            // 
            // contor
            // 
            contor.HeaderText = "Contor";
            contor.Name = "contor";
            // 
            // Grupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Grupe";
            Text = "Grupe";
            Load += Grupe_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nume;
        private DataGridViewTextBoxColumn prenume;
        private DataGridViewTextBoxColumn program;
        private DataGridViewTextBoxColumn ciclu;
        private DataGridViewTextBoxColumn an;
        private DataGridViewTextBoxColumn medie;
        private DataGridViewTextBoxColumn contor;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn idStudent;
    }
}