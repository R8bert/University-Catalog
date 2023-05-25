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
            button_adn = new Button();
            button_gc = new Button();
            dataGridView1 = new DataGridView();
            IDCatalog = new DataGridViewTextBoxColumn();
            IDStudent = new DataGridViewTextBoxColumn();
            IDDisciplina = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_adn
            // 
            button_adn.Location = new Point(115, 445);
            button_adn.Name = "button_adn";
            button_adn.Size = new Size(153, 29);
            button_adn.TabIndex = 2;
            button_adn.Text = "Adauga Nota";
            button_adn.UseVisualStyleBackColor = true;
            button_adn.Click += button_adn_Click;
            // 
            // button_gc
            // 
            button_gc.Location = new Point(370, 445);
            button_gc.Name = "button_gc";
            button_gc.Size = new Size(153, 29);
            button_gc.TabIndex = 3;
            button_gc.Text = "Genereaza Catalog";
            button_gc.UseVisualStyleBackColor = true;
            button_gc.Click += button_gc_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCatalog, IDStudent, IDDisciplina, Nota });
            dataGridView1.Location = new Point(27, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(554, 379);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDCatalog
            // 
            IDCatalog.HeaderText = "ID Catalog";
            IDCatalog.MinimumWidth = 6;
            IDCatalog.Name = "IDCatalog";
            IDCatalog.Width = 125;
            // 
            // IDStudent
            // 
            IDStudent.HeaderText = "ID Student";
            IDStudent.MinimumWidth = 6;
            IDStudent.Name = "IDStudent";
            IDStudent.Width = 125;
            // 
            // IDDisciplina
            // 
            IDDisciplina.HeaderText = "ID Disciplina";
            IDDisciplina.MinimumWidth = 6;
            IDDisciplina.Name = "IDDisciplina";
            IDDisciplina.Width = 125;
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.Width = 125;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 499);
            Controls.Add(dataGridView1);
            Controls.Add(button_gc);
            Controls.Add(button_adn);
            Name = "Note";
            Text = "Note";
            Load += Note_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_adn;
        private Button button_gc;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDCatalog;
        private DataGridViewTextBoxColumn IDStudent;
        private DataGridViewTextBoxColumn IDDisciplina;
        private DataGridViewTextBoxColumn Nota;
        private SaveFileDialog saveFileDialog1;
    }
}