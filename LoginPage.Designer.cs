namespace Aplicatie
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            label1 = new Label();
            enteredUsername = new TextBox();
            label2 = new Label();
            enteredPassword = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 144);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "UTILIZATOR";
            label1.Click += label1_Click;
            // 
            // enteredUsername
            // 
            enteredUsername.Location = new Point(309, 194);
            enteredUsername.Name = "enteredUsername";
            enteredUsername.Size = new Size(180, 23);
            enteredUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(348, 231);
            label2.Name = "label2";
            label2.Size = new Size(114, 37);
            label2.TabIndex = 2;
            label2.Text = "PAROLA";
            // 
            // enteredPassword
            // 
            enteredPassword.Location = new Point(309, 271);
            enteredPassword.Name = "enteredPassword";
            enteredPassword.PasswordChar = '*';
            enteredPassword.Size = new Size(180, 23);
            enteredPassword.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(322, 348);
            button1.Name = "button1";
            button1.Size = new Size(158, 68);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(346, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(enteredPassword);
            Controls.Add(label2);
            Controls.Add(enteredUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox enteredUsername;
        private Label label2;
        private TextBox enteredPassword;
        private Button button1;
        private PictureBox pictureBox1;
    }
}