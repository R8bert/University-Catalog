namespace Aplicatie
{
    partial class CD_DeleteDialog
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
            CI_Delete_Confirm = new Button();
            CI_Delete_Cancel = new Button();
            CI_DeleteIDTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CI_Delete_Confirm
            // 
            CI_Delete_Confirm.BackColor = Color.SpringGreen;
            CI_Delete_Confirm.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            CI_Delete_Confirm.Location = new Point(11, 139);
            CI_Delete_Confirm.Name = "CI_Delete_Confirm";
            CI_Delete_Confirm.Size = new Size(117, 59);
            CI_Delete_Confirm.TabIndex = 7;
            CI_Delete_Confirm.Text = "CONFIRM";
            CI_Delete_Confirm.UseVisualStyleBackColor = false;
            CI_Delete_Confirm.Click += CI_Delete_Confirm_Click;
            // 
            // CI_Delete_Cancel
            // 
            CI_Delete_Cancel.BackColor = Color.Crimson;
            CI_Delete_Cancel.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            CI_Delete_Cancel.Location = new Point(164, 139);
            CI_Delete_Cancel.Name = "CI_Delete_Cancel";
            CI_Delete_Cancel.Size = new Size(117, 59);
            CI_Delete_Cancel.TabIndex = 6;
            CI_Delete_Cancel.Text = "ANULEAZA";
            CI_Delete_Cancel.UseVisualStyleBackColor = false;
            CI_Delete_Cancel.Click += CI_Delete_Cancel_Click;
            // 
            // CI_DeleteIDTextBox
            // 
            CI_DeleteIDTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CI_DeleteIDTextBox.Location = new Point(39, 65);
            CI_DeleteIDTextBox.Name = "CI_DeleteIDTextBox";
            CI_DeleteIDTextBox.Size = new Size(200, 43);
            CI_DeleteIDTextBox.TabIndex = 5;
            CI_DeleteIDTextBox.TextChanged += CI_DeleteIDTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 4;
            label1.Text = "INTRODUCERE ID";
            // 
            // CD_DeleteDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 231);
            Controls.Add(CI_Delete_Confirm);
            Controls.Add(CI_Delete_Cancel);
            Controls.Add(CI_DeleteIDTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CD_DeleteDialog";
            Text = "CD_DeleteDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CI_Delete_Confirm;
        private Button CI_Delete_Cancel;
        private TextBox CI_DeleteIDTextBox;
        private Label label1;
    }
}