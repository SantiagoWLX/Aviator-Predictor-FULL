namespace Aviator_Hack
{
    partial class FrmAviator
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
            panel4 = new Panel();
            label5 = new Label();
            randomMultiplierLabel = new Label();
            gameseedpublic = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            gameseed = new TextBox();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(randomMultiplierLabel);
            panel4.Location = new Point(227, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(158, 161, 178);
            label5.Location = new Point(64, 14);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 12;
            label5.Text = "Next Round";
            label5.Click += label5_Click;
            // 
            // randomMultiplierLabel
            // 
            randomMultiplierLabel.AutoSize = true;
            randomMultiplierLabel.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            randomMultiplierLabel.ForeColor = Color.White;
            randomMultiplierLabel.Location = new Point(59, 29);
            randomMultiplierLabel.Name = "randomMultiplierLabel";
            randomMultiplierLabel.Size = new Size(87, 37);
            randomMultiplierLabel.TabIndex = 11;
            randomMultiplierLabel.Text = "1,00x";
            randomMultiplierLabel.Click += randomMultiplierLabel_Click;
            // 
            // gameseedpublic
            // 
            gameseedpublic.Location = new Point(225, 114);
            gameseedpublic.Name = "gameseedpublic";
            gameseedpublic.PasswordChar = '*';
            gameseedpublic.ReadOnly = true;
            gameseedpublic.Size = new Size(211, 23);
            gameseedpublic.TabIndex = 19;
            gameseedpublic.Text = "Yr2#^J2*9h%nK4fT!aD^$8L6pV7G@sZbE&Q3uXwY5N+cR4qF8gU*mP$W";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 42, 64);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(518, 480);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 30);
            panel3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(236, 25);
            label4.TabIndex = 0;
            label4.Text = "Accuracy Rate       %95.78";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(276, 261);
            button3.Name = "button3";
            button3.Size = new Size(109, 39);
            button3.TabIndex = 17;
            button3.Text = "START";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(443, 213);
            button2.Name = "button2";
            button2.Size = new Size(50, 23);
            button2.TabIndex = 16;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // gameseed
            // 
            gameseed.Location = new Point(225, 214);
            gameseed.Name = "gameseed";
            gameseed.Size = new Size(211, 23);
            gameseed.TabIndex = 15;
            gameseed.TextChanged += gameseed_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(239, 169);
            label3.Name = "label3";
            label3.Size = new Size(188, 24);
            label3.TabIndex = 14;
            label3.Text = "LAST GAME SEED";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(264, 77);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 13;
            label2.Text = "GAME SEED";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmAviator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(765, 522);
            Controls.Add(panel4);
            Controls.Add(gameseedpublic);
            Controls.Add(panel3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(gameseed);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAviator";
            Text = "FrmAviator";
            Load += FrmAviator_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label label5;
        private Label randomMultiplierLabel;
        private TextBox gameseedpublic;
        private Panel panel3;
        private Label label4;
        private Button button3;
        private Button button2;
        private TextBox gameseed;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}