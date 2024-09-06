using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Aviator_Hack
{
    public partial class Form1 : Form
    {

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        /*private string connectionString = "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;";*/
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(660, 600);
            this.BackColor = Color.White;
            Form1_Load(this, EventArgs.Empty);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateRoundedForm();

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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("admin");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string username = APUsername.Text;
            string password = APPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("The username or password cannot be blank.");
                return;
            }

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Successful entry!");
                OpenForm2();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid user name or password.");
            }

        }

        private void OpenForm2()
        {
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start https://spribe.co/games/aviator",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
        /*        private bool IsUserAuthenticated(string username, string password)
       {

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
               using (SqlCommand command = new SqlCommand(query, connection))
               {
                   command.Parameters.AddWithValue("@Username", username);
                   command.Parameters.AddWithValue("@Password", password);
                   connection.Open();
                   int count = (int)command.ExecuteScalar();
                   return count > 0;
               }
           }
       }*/
    }
}