namespace Aplicatie
{
    partial class CI_Main
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
            listBox1 = new ListBox();
            btnSterge = new Button();
            btnAdauga = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 319);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(139, 383);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(120, 42);
            btnSterge.TabIndex = 1;
            btnSterge.Text = "STERGE";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(139, 337);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(120, 42);
            btnAdauga.TabIndex = 2;
            btnAdauga.Text = "ADAUGA";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // CicluriInvatamant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(btnAdauga);
            Controls.Add(btnSterge);
            Controls.Add(listBox1);
            Name = "CicluriInvatamant";
            Text = "Form2";
            Load += CicluriInvatamant_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnSterge;
        private Button btnAdauga;
    }
}