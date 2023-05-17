namespace Aplicatie
{
    partial class CD_AddCD
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
            textBox1 = new TextBox();
            id = new Label();
            Nume = new Label();
            textBox2 = new TextBox();
            Prenume = new Label();
            textBox3 = new TextBox();
            Post = new Label();
            textBox4 = new TextBox();
            Titlu = new Label();
            textBox5 = new TextBox();
            MarcaAngajat = new Label();
            textBox6 = new TextBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(258, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            id.Location = new Point(28, 46);
            id.Name = "id";
            id.Size = new Size(214, 35);
            id.TabIndex = 1;
            id.Text = "ID_CadruDidactic";
            id.Click += label1_Click;
            // 
            // Nume
            // 
            Nume.AutoSize = true;
            Nume.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            Nume.Location = new Point(155, 105);
            Nume.Name = "Nume";
            Nume.Size = new Size(87, 35);
            Nume.TabIndex = 3;
            Nume.Text = "Nume";
            Nume.Click += label1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(258, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 39);
            textBox2.TabIndex = 2;
            // 
            // Prenume
            // 
            Prenume.AutoSize = true;
            Prenume.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            Prenume.Location = new Point(121, 169);
            Prenume.Name = "Prenume";
            Prenume.Size = new Size(121, 35);
            Prenume.TabIndex = 5;
            Prenume.Text = "Prenume";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(258, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 39);
            textBox3.TabIndex = 4;
            // 
            // Post
            // 
            Post.AutoSize = true;
            Post.FlatStyle = FlatStyle.System;
            Post.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            Post.Location = new Point(681, 172);
            Post.Name = "Post";
            Post.RightToLeft = RightToLeft.Yes;
            Post.Size = new Size(65, 35);
            Post.TabIndex = 11;
            Post.Text = "Post";
            Post.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(487, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 39);
            textBox4.TabIndex = 10;
            // 
            // Titlu
            // 
            Titlu.AutoSize = true;
            Titlu.FlatStyle = FlatStyle.System;
            Titlu.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            Titlu.Location = new Point(681, 108);
            Titlu.Name = "Titlu";
            Titlu.RightToLeft = RightToLeft.Yes;
            Titlu.Size = new Size(69, 35);
            Titlu.TabIndex = 9;
            Titlu.Text = "Titlu";
            Titlu.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(487, 104);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(173, 39);
            textBox5.TabIndex = 8;
            // 
            // MarcaAngajat
            // 
            MarcaAngajat.AutoSize = true;
            MarcaAngajat.FlatStyle = FlatStyle.System;
            MarcaAngajat.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            MarcaAngajat.Location = new Point(666, 49);
            MarcaAngajat.Name = "MarcaAngajat";
            MarcaAngajat.RightToLeft = RightToLeft.Yes;
            MarcaAngajat.Size = new Size(178, 35);
            MarcaAngajat.TabIndex = 7;
            MarcaAngajat.Text = "MarcaAngajat";
            MarcaAngajat.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(487, 45);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(173, 39);
            textBox6.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Pink;
            btnCancel.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(473, 265);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 49);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "ANULEAZA";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SpringGreen;
            btnConfirm.Font = new Font("Segoe UI", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(294, 265);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(147, 45);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // CD_AddCD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 352);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(Post);
            Controls.Add(textBox4);
            Controls.Add(Titlu);
            Controls.Add(textBox5);
            Controls.Add(MarcaAngajat);
            Controls.Add(textBox6);
            Controls.Add(Prenume);
            Controls.Add(textBox3);
            Controls.Add(Nume);
            Controls.Add(textBox2);
            Controls.Add(id);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CD_AddCD";
            Text = "CD_AddCD";
            Load += CD_AddCD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label id;
        private Label Nume;
        private TextBox textBox2;
        private Label Prenume;
        private TextBox textBox3;
        private Label Post;
        private TextBox textBox4;
        private Label Titlu;
        private TextBox textBox5;
        private Label MarcaAngajat;
        private TextBox textBox6;
        private Button btnCancel;
        private Button btnConfirm;
    }
}