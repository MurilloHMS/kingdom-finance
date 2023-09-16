namespace CKFinance
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnHome = new Button();
            button1 = new Button();
            panel7 = new Panel();
            btnLogout = new Button();
            panel6 = new Panel();
            btnMi = new Button();
            panel5 = new Panel();
            btnLi = new Button();
            panel4 = new Panel();
            btnFin = new Button();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1432, 44);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 0;
            label1.Text = "Comunidade Kingdom";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 644);
            panel2.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderColor = Color.Black;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(47, 129);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(154, 55);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(170, 595);
            button1.Name = "button1";
            button1.Size = new Size(47, 44);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnLogout);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(-1, 592);
            panel7.Name = "panel7";
            panel7.Size = new Size(171, 51);
            panel7.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Black;
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 35);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(-15, -28);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(244, 108);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnMi);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(3, 409);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 78);
            panel6.TabIndex = 3;
            // 
            // btnMi
            // 
            btnMi.BackColor = Color.Black;
            btnMi.BackgroundImage = (Image)resources.GetObject("btnMi.BackgroundImage");
            btnMi.BackgroundImageLayout = ImageLayout.Zoom;
            btnMi.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 35);
            btnMi.FlatAppearance.BorderSize = 0;
            btnMi.ForeColor = Color.FromArgb(35, 35, 35);
            btnMi.Location = new Point(-19, -11);
            btnMi.Margin = new Padding(0);
            btnMi.Name = "btnMi";
            btnMi.RightToLeft = RightToLeft.No;
            btnMi.Size = new Size(244, 111);
            btnMi.TabIndex = 0;
            btnMi.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLi);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(3, 306);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 78);
            panel5.TabIndex = 2;
            // 
            // btnLi
            // 
            btnLi.BackColor = Color.Black;
            btnLi.BackgroundImage = (Image)resources.GetObject("btnLi.BackgroundImage");
            btnLi.BackgroundImageLayout = ImageLayout.Zoom;
            btnLi.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 35);
            btnLi.FlatAppearance.BorderSize = 0;
            btnLi.ForeColor = Color.FromArgb(35, 35, 35);
            btnLi.Location = new Point(-19, -11);
            btnLi.Margin = new Padding(0);
            btnLi.Name = "btnLi";
            btnLi.RightToLeft = RightToLeft.No;
            btnLi.Size = new Size(244, 111);
            btnLi.TabIndex = 0;
            btnLi.UseVisualStyleBackColor = false;
            btnLi.Click += btnLi_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnFin);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(3, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 78);
            panel4.TabIndex = 1;
            // 
            // btnFin
            // 
            btnFin.BackColor = Color.Black;
            btnFin.BackgroundImage = (Image)resources.GetObject("btnFin.BackgroundImage");
            btnFin.BackgroundImageLayout = ImageLayout.Zoom;
            btnFin.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 35);
            btnFin.FlatAppearance.BorderSize = 0;
            btnFin.ForeColor = Color.FromArgb(35, 35, 35);
            btnFin.Location = new Point(-19, -11);
            btnFin.Margin = new Padding(0);
            btnFin.Name = "btnFin";
            btnFin.RightToLeft = RightToLeft.No;
            btnFin.Size = new Size(244, 102);
            btnFin.TabIndex = 0;
            btnFin.UseVisualStyleBackColor = false;
            btnFin.Click += btnFin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(222, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(1210, 644);
            panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1210, 644);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Zoom;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1202, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1202, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1202, 623);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 65);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Financeiro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(1432, 688);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comunidade Kingdom";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnFin;
        private Panel panel3;
        private Panel panel5;
        private Button btnLi;
        private Panel panel4;
        private Panel panel7;
        private Button btnLogout;
        private Panel panel6;
        private Button btnMi;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnHome;
        private Label label2;
    }
}