namespace CKFinance
{
    partial class Midias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Midias));
            panel1 = new Panel();
            label1 = new Label();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            btnFac = new Button();
            btnWha = new Button();
            btnIns = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 44);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stretch Pro", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 27;
            label1.Text = "MÍDIASS";
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
            button5.Location = new Point(345, 3);
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
            // btnFac
            // 
            btnFac.Cursor = Cursors.Hand;
            btnFac.FlatAppearance.BorderSize = 0;
            btnFac.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFac.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFac.FlatStyle = FlatStyle.Flat;
            btnFac.Font = new Font("Stretch Pro", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnFac.Image = (Image)resources.GetObject("btnFac.Image");
            btnFac.ImageAlign = ContentAlignment.TopCenter;
            btnFac.Location = new Point(12, 50);
            btnFac.Name = "btnFac";
            btnFac.Size = new Size(113, 64);
            btnFac.TabIndex = 3;
            btnFac.Text = "FACEBOOK";
            btnFac.TextAlign = ContentAlignment.BottomCenter;
            btnFac.UseVisualStyleBackColor = true;
            btnFac.Click += btnFac_Click;
            // 
            // btnWha
            // 
            btnWha.Cursor = Cursors.Hand;
            btnWha.FlatAppearance.BorderSize = 0;
            btnWha.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnWha.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnWha.FlatStyle = FlatStyle.Flat;
            btnWha.Font = new Font("Stretch Pro", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnWha.Image = (Image)resources.GetObject("btnWha.Image");
            btnWha.ImageAlign = ContentAlignment.TopCenter;
            btnWha.Location = new Point(131, 50);
            btnWha.Name = "btnWha";
            btnWha.Size = new Size(126, 64);
            btnWha.TabIndex = 4;
            btnWha.Text = "WHATSAPP";
            btnWha.TextAlign = ContentAlignment.BottomCenter;
            btnWha.UseVisualStyleBackColor = true;
            // 
            // btnIns
            // 
            btnIns.Cursor = Cursors.Hand;
            btnIns.FlatAppearance.BorderSize = 0;
            btnIns.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIns.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIns.FlatStyle = FlatStyle.Flat;
            btnIns.Font = new Font("Stretch Pro", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnIns.Image = (Image)resources.GetObject("btnIns.Image");
            btnIns.ImageAlign = ContentAlignment.TopCenter;
            btnIns.Location = new Point(263, 50);
            btnIns.Name = "btnIns";
            btnIns.Size = new Size(113, 64);
            btnIns.TabIndex = 5;
            btnIns.Text = "INSTAGRAM";
            btnIns.TextAlign = ContentAlignment.BottomCenter;
            btnIns.UseVisualStyleBackColor = true;
            // 
            // Midias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 142);
            Controls.Add(btnIns);
            Controls.Add(btnWha);
            Controls.Add(btnFac);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Midias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Midias";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnFac;
        private Button btnWha;
        private Button btnIns;
    }
}