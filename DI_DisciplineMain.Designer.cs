namespace Aplicatie
{
    partial class DI_DisciplineMain
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
            IDD = new DataGridViewTextBoxColumn();
            ND = new DataGridViewTextBoxColumn();
            AD = new DataGridViewTextBoxColumn();
            NC = new DataGridViewTextBoxColumn();
            IDA = new DataGridViewTextBoxColumn();
            buttonAd = new Button();
            buttonS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDD, ND, AD, NC, IDA });
            dataGridView1.Location = new Point(1, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(846, 332);
            dataGridView1.TabIndex = 0;
            // 
            // IDD
            // 
            IDD.HeaderText = "ID Disciplina";
            IDD.MinimumWidth = 6;
            IDD.Name = "IDD";
            IDD.Width = 125;
            // 
            // ND
            // 
            ND.HeaderText = "Nume Disciplina";
            ND.MinimumWidth = 6;
            ND.Name = "ND";
            ND.Width = 400;
            // 
            // AD
            // 
            AD.HeaderText = "Acronim Disciplina";
            AD.MinimumWidth = 6;
            AD.Name = "AD";
            AD.Width = 80;
            // 
            // NC
            // 
            NC.HeaderText = "Numar Credite";
            NC.MinimumWidth = 6;
            NC.Name = "NC";
            NC.Width = 60;
            // 
            // IDA
            // 
            IDA.HeaderText = "ID An";
            IDA.MinimumWidth = 6;
            IDA.Name = "IDA";
            IDA.Width = 125;
            // 
            // buttonAd
            // 
            buttonAd.Location = new Point(221, 387);
            buttonAd.Name = "buttonAd";
            buttonAd.Size = new Size(94, 29);
            buttonAd.TabIndex = 1;
            buttonAd.Text = "Adaugare";
            buttonAd.UseVisualStyleBackColor = true;
            buttonAd.Click += buttonAd_Click;
            // 
            // buttonS
            // 
            buttonS.Location = new Point(556, 387);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(94, 29);
            buttonS.TabIndex = 2;
            buttonS.Text = "Stergere";
            buttonS.UseVisualStyleBackColor = true;
            buttonS.Click += buttonS_Click;
            // 
            // DI_DisciplineMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(buttonS);
            Controls.Add(buttonAd);
            Controls.Add(dataGridView1);
            Name = "DI_DisciplineMain";
            Text = "DI_Discipline";
            Load += Discipline_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDD;
        private DataGridViewTextBoxColumn ND;
        private DataGridViewTextBoxColumn AD;
        private DataGridViewTextBoxColumn NC;
        private DataGridViewTextBoxColumn IDA;
        private Button buttonAd;
        private Button buttonS;
    }
}