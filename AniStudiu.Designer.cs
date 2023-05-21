namespace Aplicatie
{
    partial class AniStudiu
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
            idan = new DataGridViewTextBoxColumn();
            numean = new DataGridViewTextBoxColumn();
            idprogram = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idan, numean, idprogram });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(344, 426);
            dataGridView1.TabIndex = 0;
            // 
            // idan
            // 
            idan.HeaderText = "Id An";
            idan.Name = "idan";
            // 
            // numean
            // 
            numean.HeaderText = "Nume An";
            numean.Name = "numean";
            // 
            // idprogram
            // 
            idprogram.HeaderText = "Id Program";
            idprogram.Name = "idprogram";
            // 
            // button1
            // 
            button1.Location = new Point(403, 150);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 1;
            button1.Text = "Adauga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(403, 244);
            button2.Name = "button2";
            button2.Size = new Size(107, 49);
            button2.TabIndex = 2;
            button2.Text = "Sterge";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AniStudiu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "AniStudiu";
            Text = "AniStudiu";
            Load += AniStudiu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idan;
        private DataGridViewTextBoxColumn numean;
        private DataGridViewTextBoxColumn idprogram;
        private Button button1;
        private Button button2;
    }
}