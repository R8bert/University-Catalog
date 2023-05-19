﻿namespace Aplicatie
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btn_CadreDidactice = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button5 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            buttonS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1625, 157);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(btn_CadreDidactice);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1669, 133);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btn_CadreDidactice
            // 
            btn_CadreDidactice.BackColor = Color.FromArgb(255, 128, 128);
            btn_CadreDidactice.FlatAppearance.BorderSize = 0;
            btn_CadreDidactice.FlatStyle = FlatStyle.Flat;
            btn_CadreDidactice.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadreDidactice.Location = new Point(232, 17);
            btn_CadreDidactice.Margin = new Padding(3, 4, 3, 4);
            btn_CadreDidactice.Name = "btn_CadreDidactice";
            btn_CadreDidactice.Size = new Size(208, 96);
            btn_CadreDidactice.TabIndex = 4;
            btn_CadreDidactice.Text = "Cadre Didactice";
            btn_CadreDidactice.UseVisualStyleBackColor = false;
            btn_CadreDidactice.Click += btn_CadreDidactice_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(447, 17);
            button2.Name = "button2";
            button2.Size = new Size(208, 96);
            button2.TabIndex = 1;
            button2.Text = "Programe de studii";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(662, 20);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(208, 91);
            button3.TabIndex = 3;
            button3.Text = "Note";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(17, 20);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(208, 91);
            button1.TabIndex = 0;
            button1.Text = "Cicluri de învățământ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.AliceBlue;
            button5.Location = new Point(1517, 932);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(166, 107);
            button5.TabIndex = 4;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // buttonS
            // 
            buttonS.BackColor = Color.FromArgb(255, 128, 128);
            buttonS.FlatAppearance.BorderSize = 0;
            buttonS.FlatStyle = FlatStyle.Flat;
            buttonS.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonS.Location = new Point(258, 284);
            buttonS.Margin = new Padding(3, 4, 3, 4);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(208, 91);
            buttonS.TabIndex = 5;
            buttonS.Text = "Studenti";
            buttonS.UseVisualStyleBackColor = false;
            buttonS.Click += buttonS_Click;
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1696, 1055);
            Controls.Add(buttonS);
            Controls.Add(pictureBox2);
            Controls.Add(button5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FirstPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "--";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn_CadreDidactice;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.CodeDom.CodeTypeReference chart1;
        private Button buttonS;
    }
}