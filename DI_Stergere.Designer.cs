namespace Aplicatie
{
    partial class DI_Stergere
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
            textBox_IDD = new TextBox();
            label1 = new Label();
            button_S = new Button();
            SuspendLayout();
            // 
            // textBox_IDD
            // 
            textBox_IDD.Location = new Point(12, 32);
            textBox_IDD.Name = "textBox_IDD";
            textBox_IDD.Size = new Size(233, 27);
            textBox_IDD.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "ID Disciplina";
            // 
            // button_S
            // 
            button_S.BackColor = Color.Red;
            button_S.ForeColor = Color.White;
            button_S.Location = new Point(81, 68);
            button_S.Name = "button_S";
            button_S.Size = new Size(94, 29);
            button_S.TabIndex = 2;
            button_S.Text = "Stergere";
            button_S.UseVisualStyleBackColor = false;
            button_S.Click += button_S_Click;
            // 
            // DI_Stergere
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 109);
            Controls.Add(button_S);
            Controls.Add(label1);
            Controls.Add(textBox_IDD);
            Name = "DI_Stergere";
            Text = "Stergere Disciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_IDD;
        private Label label1;
        private Button button_S;
    }
}