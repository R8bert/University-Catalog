namespace Aplicatie
{
    partial class ST_StergereStudent
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
            textBox_IDS = new TextBox();
            label1 = new Label();
            button_St = new Button();
            SuspendLayout();
            // 
            // textBox_IDS
            // 
            textBox_IDS.Location = new Point(77, 32);
            textBox_IDS.Name = "textBox_IDS";
            textBox_IDS.Size = new Size(125, 27);
            textBox_IDS.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "  ID Student";
            // 
            // button_St
            // 
            button_St.BackColor = Color.Red;
            button_St.ForeColor = SystemColors.Control;
            button_St.Location = new Point(91, 65);
            button_St.Name = "button_St";
            button_St.Size = new Size(94, 29);
            button_St.TabIndex = 2;
            button_St.Text = "Stergere";
            button_St.UseVisualStyleBackColor = false;
            button_St.Click += button_St_Click;
            // 
            // ST_StergereStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 103);
            Controls.Add(button_St);
            Controls.Add(label1);
            Controls.Add(textBox_IDS);
            Name = "ST_StergereStudent";
            Text = "Stergere Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_IDS;
        private Label label1;
        private Button button_St;
    }
}