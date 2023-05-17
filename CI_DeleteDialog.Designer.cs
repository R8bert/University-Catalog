namespace Aplicatie
{
    partial class CI_DeleteDialog
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
            label1 = new Label();
            CI_DeleteIDTextBox = new TextBox();
            CI_Delete_Cancel = new Button();
            CI_Delete_Confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 35);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 0;
            label1.Text = "INTRODUCERE ID";
            // 
            // CI_DeleteIDTextBox
            // 
            CI_DeleteIDTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CI_DeleteIDTextBox.Location = new Point(57, 75);
            CI_DeleteIDTextBox.Name = "CI_DeleteIDTextBox";
            CI_DeleteIDTextBox.Size = new Size(200, 43);
            CI_DeleteIDTextBox.TabIndex = 1;
            CI_DeleteIDTextBox.TextChanged += CI_DeleteIDTextBox_TextChanged;
            // 
            // CI_Delete_Cancel
            // 
            CI_Delete_Cancel.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            CI_Delete_Cancel.Location = new Point(182, 149);
            CI_Delete_Cancel.Name = "CI_Delete_Cancel";
            CI_Delete_Cancel.Size = new Size(117, 59);
            CI_Delete_Cancel.TabIndex = 2;
            CI_Delete_Cancel.Text = "ANULEAZA";
            CI_Delete_Cancel.UseVisualStyleBackColor = true;
            CI_Delete_Cancel.Click += button1_Click;
            // 
            // CI_Delete_Confirm
            // 
            CI_Delete_Confirm.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            CI_Delete_Confirm.Location = new Point(29, 149);
            CI_Delete_Confirm.Name = "CI_Delete_Confirm";
            CI_Delete_Confirm.Size = new Size(117, 59);
            CI_Delete_Confirm.TabIndex = 3;
            CI_Delete_Confirm.Text = "CONFIRM";
            CI_Delete_Confirm.UseVisualStyleBackColor = true;
            CI_Delete_Confirm.Click += CI_Delete_Confirm_Click;
            // 
            // CI_DeleteDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 248);
            Controls.Add(CI_Delete_Confirm);
            Controls.Add(CI_Delete_Cancel);
            Controls.Add(CI_DeleteIDTextBox);
            Controls.Add(label1);
            Name = "CI_DeleteDialog";
            Text = "CI_DeleteDialog";
            Load += CI_DeleteDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CI_DeleteIDTextBox;
        private Button CI_Delete_Cancel;
        private Button CI_Delete_Confirm;
    }
}