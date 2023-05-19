namespace Aplicatie
{
    partial class ST_StudentiMain
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
            IDStudent = new DataGridViewTextBoxColumn();
            NRMatricol = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Prenume = new DataGridViewTextBoxColumn();
            InT = new DataGridViewTextBoxColumn();
            CNP = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            IDC = new DataGridViewTextBoxColumn();
            Media = new DataGridViewTextBoxColumn();
            button_Ad = new Button();
            button_S = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDStudent, NRMatricol, Nume, Prenume, InT, CNP, Data, IDC, Media });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1188, 397);
            dataGridView1.TabIndex = 0;
            // 
            // IDStudent
            // 
            IDStudent.HeaderText = "ID Student";
            IDStudent.MinimumWidth = 6;
            IDStudent.Name = "IDStudent";
            IDStudent.Width = 125;
            // 
            // NRMatricol
            // 
            NRMatricol.HeaderText = "Nr Matricol";
            NRMatricol.MinimumWidth = 6;
            NRMatricol.Name = "NRMatricol";
            NRMatricol.Width = 125;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 6;
            Nume.Name = "Nume";
            Nume.Width = 125;
            // 
            // Prenume
            // 
            Prenume.HeaderText = "Prenume";
            Prenume.MinimumWidth = 6;
            Prenume.Name = "Prenume";
            Prenume.Width = 125;
            // 
            // InT
            // 
            InT.HeaderText = "Initiala Tata";
            InT.MinimumWidth = 6;
            InT.Name = "InT";
            InT.Width = 125;
            // 
            // CNP
            // 
            CNP.HeaderText = "CNP";
            CNP.MinimumWidth = 6;
            CNP.Name = "CNP";
            CNP.Width = 125;
            // 
            // Data
            // 
            Data.HeaderText = "Data Inscriere";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.Width = 125;
            // 
            // IDC
            // 
            IDC.HeaderText = "ID Ciclu";
            IDC.MinimumWidth = 6;
            IDC.Name = "IDC";
            IDC.Width = 125;
            // 
            // Media
            // 
            Media.HeaderText = "Media Inscriere";
            Media.MinimumWidth = 6;
            Media.Name = "Media";
            Media.Width = 125;
            // 
            // button_Ad
            // 
            button_Ad.Location = new Point(396, 452);
            button_Ad.Name = "button_Ad";
            button_Ad.Size = new Size(94, 29);
            button_Ad.TabIndex = 1;
            button_Ad.Text = "Adaugare";
            button_Ad.UseVisualStyleBackColor = true;
            button_Ad.Click += button_Ad_Click;
            // 
            // button_S
            // 
            button_S.Location = new Point(762, 452);
            button_S.Name = "button_S";
            button_S.Size = new Size(94, 29);
            button_S.TabIndex = 2;
            button_S.Text = "Stergere";
            button_S.UseVisualStyleBackColor = true;
            button_S.Click += button_S_Click;
            // 
            // ST_StudentiMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 511);
            Controls.Add(button_S);
            Controls.Add(button_Ad);
            Controls.Add(dataGridView1);
            Name = "ST_StudentiMain";
            Text = "Studenti";
            Load += Studenti_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDStudent;
        private DataGridViewTextBoxColumn NRMatricol;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn Prenume;
        private DataGridViewTextBoxColumn InT;
        private DataGridViewTextBoxColumn CNP;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn IDC;
        private DataGridViewTextBoxColumn Media;
        private Button button_Ad;
        private Button button_S;
    }
}