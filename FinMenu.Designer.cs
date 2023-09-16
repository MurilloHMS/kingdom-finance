namespace CKFinance
{
    partial class FinMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinMenu));
            panel1 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            txtOk = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbCulEve = new ComboBox();
            rdEnt = new RadioButton();
            rdSai = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            lblEve = new RadioButton();
            radioButton2 = new RadioButton();
            panel2 = new Panel();
            panel3 = new Panel();
            lblDes = new Label();
            textBox1 = new TextBox();
            txtVlr = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 44);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(280, 9);
            button5.Name = "button5";
            button5.Size = new Size(53, 32);
            button5.TabIndex = 26;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            label1.Location = new Point(52, 72);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // button1
            // 
            button1.Location = new Point(28, 269);
            button1.Name = "button1";
            button1.Size = new Size(72, 25);
            button1.TabIndex = 3;
            button1.Text = "INSERIR";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtOk
            // 
            txtOk.Location = new Point(23, 90);
            txtOk.Name = "txtOk";
            txtOk.Size = new Size(77, 23);
            txtOk.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 174);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "VALOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 174);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "CULTO/EVENTO";
            // 
            // cbCulEve
            // 
            cbCulEve.FormattingEnabled = true;
            cbCulEve.Items.AddRange(new object[] { "", "QUARTA", "DOMINGO", "EVENTO" });
            cbCulEve.Location = new Point(23, 192);
            cbCulEve.Name = "cbCulEve";
            cbCulEve.Size = new Size(121, 23);
            cbCulEve.TabIndex = 8;
            // 
            // rdEnt
            // 
            rdEnt.AutoSize = true;
            rdEnt.Location = new Point(3, 3);
            rdEnt.Name = "rdEnt";
            rdEnt.Size = new Size(77, 19);
            rdEnt.TabIndex = 9;
            rdEnt.TabStop = true;
            rdEnt.Text = "ENTRADA";
            rdEnt.UseVisualStyleBackColor = true;
            // 
            // rdSai
            // 
            rdSai.AutoSize = true;
            rdSai.Location = new Point(86, 2);
            rdSai.Name = "rdSai";
            rdSai.Size = new Size(58, 19);
            rdSai.TabIndex = 10;
            rdSai.TabStop = true;
            rdSai.Text = "SAIDA";
            rdSai.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(106, 269);
            button2.Name = "button2";
            button2.Size = new Size(72, 25);
            button2.TabIndex = 11;
            button2.Text = "LIMPAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(184, 269);
            button3.Name = "button3";
            button3.Size = new Size(82, 25);
            button3.TabIndex = 12;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblEve
            // 
            lblEve.AutoSize = true;
            lblEve.Location = new Point(71, 2);
            lblEve.Name = "lblEve";
            lblEve.Size = new Size(67, 19);
            lblEve.TabIndex = 14;
            lblEve.TabStop = true;
            lblEve.Text = "EVENTO";
            lblEve.UseVisualStyleBackColor = true;
            lblEve.CheckedChanged += lblEve_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "CULTO";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(rdEnt);
            panel2.Controls.Add(rdSai);
            panel2.Location = new Point(23, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 26);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(lblEve);
            panel3.Location = new Point(173, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 26);
            panel3.TabIndex = 16;
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Location = new Point(27, 218);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(70, 15);
            lblDes.TabIndex = 17;
            lblDes.Text = "DESCRIÇÃO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 23);
            textBox1.TabIndex = 18;
            // 
            // txtVlr
            // 
            txtVlr.Location = new Point(184, 192);
            txtVlr.Name = "txtVlr";
            txtVlr.Size = new Size(121, 23);
            txtVlr.TabIndex = 19;
            // 
            // FinMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 306);
            Controls.Add(txtVlr);
            Controls.Add(textBox1);
            Controls.Add(lblDes);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(cbCulEve);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOk);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FinMenu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private TextBox txtOk;
        private Label label2;
        private Label label3;
        private ComboBox cbCulEve;
        private RadioButton rdEnt;
        private RadioButton rdSai;
        private Button button2;
        private Button button3;
        private RadioButton lblEve;
        private RadioButton radioButton2;
        private Panel panel2;
        private Panel panel3;
        private Label lblDes;
        private TextBox textBox1;
        private TextBox txtVlr;
    }
}