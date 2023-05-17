namespace Aplicatie
{
    partial class InputDialogBox_CI
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
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(399, 390);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "btnOK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(515, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtNumeCiclu
            // 
            txtNumeCiclu.Location = new Point(399, 159);
            txtNumeCiclu.Name = "txtNumeCiclu";
            txtNumeCiclu.Size = new Size(100, 23);
            txtNumeCiclu.TabIndex = 2;
            txtNumeCiclu.TextChanged += txtNumeCiclu_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(399, 221);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // InputDialogBox_CI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtID);
            Controls.Add(txtNumeCiclu);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Name = "InputDialogBox_CI";
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
    }
}