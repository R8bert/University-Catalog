namespace Aplicatie
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
            label_U = new Label();
            button5 = new Button();
            buttonD = new Button();
            buttonS = new Button();
            btn_anistudiu = new Button();
            btn_grupe = new Button();
            btn_CadreDidactice = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 420);
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
            panel1.Controls.Add(label_U);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonD);
            panel1.Controls.Add(buttonS);
            panel1.Controls.Add(btn_anistudiu);
            panel1.Controls.Add(btn_grupe);
            panel1.Controls.Add(btn_CadreDidactice);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 496);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label_U
            // 
            label_U.AutoSize = true;
            label_U.Location = new Point(86, 450);
            label_U.Name = "label_U";
            label_U.Size = new Size(98, 20);
            label_U.TabIndex = 9;
            label_U.Text = "Logged in as "+Global.utilizator;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.AliceBlue;
            button5.Location = new Point(869, 380);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(166, 107);
            button5.TabIndex = 4;
            button5.Text = "LOG OUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // buttonD
            // 
            buttonD.BackColor = Color.FromArgb(255, 128, 128);
            buttonD.FlatAppearance.BorderSize = 0;
            buttonD.FlatStyle = FlatStyle.Flat;
            buttonD.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonD.Location = new Point(728, 141);
            buttonD.Margin = new Padding(3, 4, 3, 4);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(201, 107);
            buttonD.TabIndex = 7;
            buttonD.Text = "Discipline";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += buttonD_Click;
            // 
            // buttonS
            // 
            buttonS.BackColor = Color.FromArgb(255, 128, 128);
            buttonS.FlatAppearance.BorderSize = 0;
            buttonS.FlatStyle = FlatStyle.Flat;
            buttonS.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            buttonS.Location = new Point(520, 143);
            buttonS.Margin = new Padding(3, 4, 3, 4);
            buttonS.Name = "buttonS";
            buttonS.Size = new Size(201, 105);
            buttonS.TabIndex = 5;
            buttonS.Text = "Studenti";
            buttonS.UseVisualStyleBackColor = false;
            buttonS.Click += buttonS_Click;
            // 
            // btn_anistudiu
            // 
            btn_anistudiu.BackColor = Color.FromArgb(255, 128, 128);
            btn_anistudiu.FlatAppearance.BorderSize = 0;
            btn_anistudiu.FlatStyle = FlatStyle.Flat;
            btn_anistudiu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_anistudiu.Location = new Point(312, 141);
            btn_anistudiu.Margin = new Padding(3, 4, 3, 4);
            btn_anistudiu.Name = "btn_anistudiu";
            btn_anistudiu.Size = new Size(201, 107);
            btn_anistudiu.TabIndex = 6;
            btn_anistudiu.Text = "Ani de Studiu";
            btn_anistudiu.UseVisualStyleBackColor = false;
            btn_anistudiu.Click += btn_anistudiu_Click;
            // 
            // btn_grupe
            // 
            btn_grupe.BackColor = Color.FromArgb(255, 128, 128);
            btn_grupe.FlatAppearance.BorderSize = 0;
            btn_grupe.FlatStyle = FlatStyle.Flat;
            btn_grupe.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_grupe.Location = new Point(104, 141);
            btn_grupe.Margin = new Padding(3, 4, 3, 4);
            btn_grupe.Name = "btn_grupe";
            btn_grupe.Size = new Size(201, 107);
            btn_grupe.TabIndex = 5;
            btn_grupe.Text = "Grupe";
            btn_grupe.UseVisualStyleBackColor = false;
            btn_grupe.Click += btn_grupe_Click;
            // 
            // btn_CadreDidactice
            // 
            btn_CadreDidactice.BackColor = Color.FromArgb(255, 128, 128);
            btn_CadreDidactice.FlatAppearance.BorderSize = 0;
            btn_CadreDidactice.FlatStyle = FlatStyle.Flat;
            btn_CadreDidactice.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_CadreDidactice.Location = new Point(312, 16);
            btn_CadreDidactice.Margin = new Padding(3, 4, 3, 4);
            btn_CadreDidactice.Name = "btn_CadreDidactice";
            btn_CadreDidactice.Size = new Size(201, 105);
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
            button2.Location = new Point(520, 15);
            button2.Name = "button2";
            button2.Size = new Size(201, 107);
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
            button3.Location = new Point(728, 15);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(201, 107);
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
            button1.Location = new Point(104, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(201, 105);
            button1.TabIndex = 0;
            button1.Text = "Cicluri de învățământ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1078, 520);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FirstPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "--";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button btn_grupe;
        private Button btn_anistudiu;
        private Button buttonD;
        private Label label_U;
    }
}