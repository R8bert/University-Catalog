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
            Id_Grupa = new DataGridViewTextBoxColumn();
            Nume_Grupa = new DataGridViewTextBoxColumn();
            idStudent = new DataGridViewTextBoxColumn();
            Id_An = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_Grupa, Nume_Grupa, idStudent, Id_An });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 387);
            dataGridView1.TabIndex = 0;
            // 
            // Id_Grupa
            // 
            Id_Grupa.HeaderText = "ID Grupa";
            Id_Grupa.Name = "Id_Grupa";
            // 
            // Nume_Grupa
            // 
            Nume_Grupa.HeaderText = "Nume Grupa";
            Nume_Grupa.Name = "Nume_Grupa";
            Nume_Grupa.ReadOnly = true;
            // 
            // idStudent
            // 
            idStudent.HeaderText = "ID Student";
            idStudent.Name = "idStudent";
            // 
            // Id_An
            // 
            Id_An.HeaderText = "ID An";
            Id_An.Name = "Id_An";
            // 
            // button1
            // 
            button1.Location = new Point(490, 26);
            button1.Name = "button1";
            button1.Size = new Size(136, 66);
            button1.TabIndex = 1;
            button1.Text = "Generare automata a grupelor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(490, 114);
            button2.Name = "button2";
            button2.Size = new Size(136, 66);
            button2.TabIndex = 2;
            button2.Text = "Importare grupe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(490, 200);
            button3.Name = "button3";
            button3.Size = new Size(136, 66);
            button3.TabIndex = 3;
            button3.Text = "Editare grupe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(490, 287);
            button4.Name = "button4";
            button4.Size = new Size(136, 66);
            button4.TabIndex = 4;
            button4.Text = "Adaugare grupe";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Grupe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 425);
            Controls.Add(button4);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Id_Grupa;
        private DataGridViewTextBoxColumn Nume_Grupa;
        private DataGridViewTextBoxColumn idStudent;
        private DataGridViewTextBoxColumn Id_An;
        private Button button4;
    }
}