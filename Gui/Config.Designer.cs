namespace CKFinance
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            panel1 = new Panel();
            label1 = new Label();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            btnCTable = new Button();
            button1 = new Button();
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
            panel1.Size = new Size(800, 44);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stretch Pro", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 26);
            label1.TabIndex = 27;
            label1.Text = "CONFIGURAÇÕESS";
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
            button5.Location = new Point(735, 3);
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
            // btnCTable
            // 
            btnCTable.Font = new Font("Stretch Pro", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            btnCTable.Location = new Point(48, 85);
            btnCTable.Name = "btnCTable";
            btnCTable.Size = new Size(231, 41);
            btnCTable.TabIndex = 4;
            btnCTable.Text = "CRIAR TABELAS SQL";
            btnCTable.UseVisualStyleBackColor = true;
            btnCTable.Click += btnCTable_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Stretch Pro", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(470, 85);
            button1.Name = "button1";
            button1.Size = new Size(231, 41);
            button1.TabIndex = 5;
            button1.Text = "DELETAR TABELAS SQL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnCTable);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Config";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Config";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button5;
        private PictureBox pictureBox1;
        private Button btnCTable;
        private Button button1;
    }
}