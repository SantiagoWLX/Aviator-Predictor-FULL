namespace Aviator_Hack
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            PnlNav = new Panel();
            btnContactus = new Button();
            button1 = new Button();
            BtnAviator = new Button();
            panel2 = new Panel();
            Aviator = new Label();
            ADMIN = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            button4 = new Button();
            panel5 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            PnlFrmLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(btnContactus);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnAviator);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.Red;
            PnlNav.Location = new Point(-4, 158);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(10, 30);
            PnlNav.TabIndex = 3;
            // 
            // btnContactus
            // 
            btnContactus.BackColor = Color.Transparent;
            btnContactus.FlatAppearance.BorderSize = 0;
            btnContactus.FlatStyle = FlatStyle.Flat;
            btnContactus.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactus.ForeColor = Color.Red;
            btnContactus.Image = (Image)resources.GetObject("btnContactus.Image");
            btnContactus.ImageAlign = ContentAlignment.MiddleLeft;
            btnContactus.Location = new Point(0, 485);
            btnContactus.Name = "btnContactus";
            btnContactus.Size = new Size(186, 43);
            btnContactus.TabIndex = 4;
            btnContactus.Text = "CONTACT US";
            btnContactus.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnContactus.UseVisualStyleBackColor = false;
            btnContactus.Click += btnContactus_Click;
            btnContactus.Leave += btnContactus_Leave;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 534);
            button1.Name = "button1";
            button1.Size = new Size(186, 43);
            button1.TabIndex = 3;
            button1.Text = "NEW GAMES COMING SOON";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnAviator
            // 
            BtnAviator.BackColor = Color.Transparent;
            BtnAviator.Dock = DockStyle.Top;
            BtnAviator.FlatAppearance.BorderSize = 0;
            BtnAviator.FlatStyle = FlatStyle.Flat;
            BtnAviator.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAviator.ForeColor = Color.Red;
            BtnAviator.Image = (Image)resources.GetObject("BtnAviator.Image");
            BtnAviator.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAviator.Location = new Point(0, 152);
            BtnAviator.Name = "BtnAviator";
            BtnAviator.Size = new Size(186, 43);
            BtnAviator.TabIndex = 2;
            BtnAviator.Text = "Aviator";
            BtnAviator.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnAviator.UseVisualStyleBackColor = false;
            BtnAviator.Click += button1_Click;
            BtnAviator.Leave += BtnAviator_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(Aviator);
            panel2.Controls.Add(ADMIN);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 152);
            panel2.TabIndex = 1;
            // 
            // Aviator
            // 
            Aviator.AutoSize = true;
            Aviator.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            Aviator.ForeColor = Color.FromArgb(158, 161, 178);
            Aviator.Location = new Point(46, 126);
            Aviator.Name = "Aviator";
            Aviator.Size = new Size(92, 12);
            Aviator.TabIndex = 2;
            Aviator.Text = "Aviator Predictor";
            // 
            // ADMIN
            // 
            ADMIN.AutoSize = true;
            ADMIN.BackColor = Color.Transparent;
            ADMIN.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ADMIN.ForeColor = Color.FromArgb(0, 126, 249);
            ADMIN.Location = new Point(52, 92);
            ADMIN.Name = "ADMIN";
            ADMIN.Size = new Size(75, 24);
            ADMIN.TabIndex = 1;
            ADMIN.Text = "ADMIN";
            ADMIN.Click += ADMIN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(192, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "AVIATOR PREDICTOR";
            lblTitle.Click += label1_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(731, 3);
            button4.Name = "button4";
            button4.Size = new Size(25, 25);
            button4.TabIndex = 10;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(46, 51, 71);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(192, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(759, 31);
            panel5.TabIndex = 13;
            panel5.Paint += panel5_Paint;
            panel5.MouseDown += panel5_MouseDown;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PnlFrmLoader
            // 
            PnlFrmLoader.Dock = DockStyle.Bottom;
            PnlFrmLoader.Location = new Point(186, 55);
            PnlFrmLoader.Name = "PnlFrmLoader";
            PnlFrmLoader.Size = new Size(765, 522);
            PnlFrmLoader.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 71);
            ClientSize = new Size(951, 577);
            Controls.Add(PnlFrmLoader);
            Controls.Add(lblTitle);
            Controls.Add(panel5);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aviator Predictor";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label ADMIN;
        private Label Aviator;
        private Button BtnAviator;
        private Button button1;
        private Button btnContactus;
        private Panel PnlNav;
        private Label lblTitle;
        private Button button4;
        private Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private Panel PnlFrmLoader;
    }
}