namespace Aplicatie
{
    partial class CD_Main
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
            idCadru = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Prenume = new DataGridViewTextBoxColumn();
            MarcaAngajat = new DataGridViewTextBoxColumn();
            Titlu = new DataGridViewTextBoxColumn();
            Post = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCadru, Nume, Prenume, MarcaAngajat, Titlu, Post });
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 340);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // idCadru
            // 
            idCadru.HeaderText = "idCadru";
            idCadru.Name = "idCadru";
            idCadru.ReadOnly = true;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.Name = "Nume";
            Nume.ReadOnly = true;
            // 
            // Prenume
            // 
            Prenume.HeaderText = "Prenume";
            Prenume.Name = "Prenume";
            Prenume.ReadOnly = true;
            // 
            // MarcaAngajat
            // 
            MarcaAngajat.HeaderText = "MarcaAngajat";
            MarcaAngajat.Name = "MarcaAngajat";
            MarcaAngajat.ReadOnly = true;
            // 
            // Titlu
            // 
            Titlu.HeaderText = "Titlu";
            Titlu.Name = "Titlu";
            Titlu.ReadOnly = true;
            // 
            // Post
            // 
            Post.HeaderText = "Post";
            Post.Name = "Post";
            Post.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SpringGreen;
            btnAdd.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(107, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 49);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADAUGA";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnOK_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Pink;
            btnDelete.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(401, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 49);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "STERGE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // CD_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CD_Main";
            Text = "CD_Main";
            Load += CD_Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCadru;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn Prenume;
        private DataGridViewTextBoxColumn MarcaAngajat;
        private DataGridViewTextBoxColumn Titlu;
        private DataGridViewTextBoxColumn Post;
        private Button btnAdd;
        private Button btnDelete;
    }
}