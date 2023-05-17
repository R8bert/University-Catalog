namespace Aplicatie
{
    partial class CI_InputDialogBox
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
            btnOK = new Button();
            btnCancel = new Button();
            txtNumeCiclu = new TextBox();
            txtID = new TextBox();
            nume_CI = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.SpringGreen;
            btnOK.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.Location = new Point(90, 289);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(147, 45);
            btnOK.TabIndex = 0;
            btnOK.Text = "CONFIRM";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Pink;
            btnCancel.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(90, 340);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 49);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "ANULEAZA";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtNumeCiclu
            // 
            txtNumeCiclu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumeCiclu.Location = new Point(72, 97);
            txtNumeCiclu.Name = "txtNumeCiclu";
            txtNumeCiclu.Size = new Size(181, 43);
            txtNumeCiclu.TabIndex = 2;
            txtNumeCiclu.TextChanged += txtNumeCiclu_TextChanged;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtID.Location = new Point(72, 206);
            txtID.Name = "txtID";
            txtID.Size = new Size(181, 43);
            txtID.TabIndex = 3;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // nume_CI
            // 
            nume_CI.AutoSize = true;
            nume_CI.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nume_CI.ImageAlign = ContentAlignment.TopCenter;
            nume_CI.Location = new Point(72, 57);
            nume_CI.Name = "nume_CI";
            nume_CI.Size = new Size(181, 37);
            nume_CI.TabIndex = 4;
            nume_CI.Text = "NUME CICLU";
            nume_CI.TextAlign = ContentAlignment.TopCenter;
            nume_CI.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(90, 166);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 5;
            label1.Text = "ID CICLU";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CI_InputDialogBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 450);
            Controls.Add(label1);
            Controls.Add(nume_CI);
            Controls.Add(txtID);
            Controls.Add(txtNumeCiclu);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CI_InputDialogBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InputDialogBox";
            Load += InputDialogBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtNumeCiclu;
        private TextBox txtID;
        private Label nume_CI;
        private Label label1;
    }
}