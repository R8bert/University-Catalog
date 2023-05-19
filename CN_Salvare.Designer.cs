namespace Aplicatie
{
    partial class CN_Salvare
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
            textBox_ID = new TextBox();
            button_S = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Catalog";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(12, 32);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(125, 27);
            textBox_ID.TabIndex = 1;
            // 
            // button_S
            // 
            button_S.Location = new Point(180, 32);
            button_S.Name = "button_S";
            button_S.Size = new Size(94, 29);
            button_S.TabIndex = 2;
            button_S.Text = "Salvare";
            button_S.UseVisualStyleBackColor = true;
            button_S.Click += button_S_Click;
            // 
            // CN_Salvare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 72);
            Controls.Add(button_S);
            Controls.Add(textBox_ID);
            Controls.Add(label1);
            Name = "CN_Salvare";
            Text = "Salvare catalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_ID;
        private Button button_S;
    }
}