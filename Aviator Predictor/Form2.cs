using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using System.Runtime.InteropService;*/
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;
using System.Windows.Forms.Design;

namespace Aviator_Hack
{
    public partial class Form2 : Form
    {
        /*        if (Form1 != null)
                {
                    Form1.Show();
                }

                Form2 Form2 = new Form2();
                Form2.Form1 = this; // İkinci formun sahibini mevcut form olarak ayarlayın
                Form2.FormClosed += Form2_FormClosed; // Form kapatıldığında bu olayı işleyin
                this.Hide();
                Form2.Show();*/


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private Random random = new Random();
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public Form2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 26));
            PnlNav.Height = BtnAviator.Height;
            PnlNav.Top = BtnAviator.Top;
            PnlNav.Left = BtnAviator.Left;
            BtnAviator.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "AviatorPredictor";
            this.PnlFrmLoader.Controls.Clear();
            FrmAviator frmAviator_Vrb = new FrmAviator() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAviator_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmAviator_Vrb);
            frmAviator_Vrb.Show();
        }

        private void ADMIN_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAviator.Height;
            PnlNav.Top = BtnAviator.Top;
            PnlNav.Left = BtnAviator.Left;
            BtnAviator.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "AVIATOR PREDICTOR";
            this.PnlFrmLoader.Controls.Clear();
            FrmAviator frmAviator_Vrb = new FrmAviator() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAviator_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmAviator_Vrb);
            frmAviator_Vrb.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnContactus_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnContactus.Height;
            PnlNav.Top = btnContactus.Top;
            PnlNav.Left = btnContactus.Left;
            btnContactus.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "CONTACT US";
            this.PnlFrmLoader.Controls.Clear();
            FrmContactus frmAviator_Vrb = new FrmContactus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAviator_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFrmLoader.Controls.Add(frmAviator_Vrb);
            frmAviator_Vrb.Show();
        }

        private void BtnAviator_Leave(object sender, EventArgs e)
        {
            BtnAviator.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactus_Leave(object sender, EventArgs e)
        {
            btnContactus.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void randomMultiplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateRoundedForm();
            /*            timer1.Start();
                        timer1.Enabled = true;*/

        }
        private void CreateRoundedForm()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90);
            path.AddArc(new Rectangle(this.Width - 2 * radius, 0, radius * 2, radius * 2), 270, 90);
            path.AddArc(new Rectangle(this.Width - 2 * radius, this.Height - 2 * radius, radius * 2, radius * 2), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - 2 * radius, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void timerSeedUpdate_Tick(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
