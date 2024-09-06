using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviator_Hack
{
    public partial class FrmAviator : Form
    {

        private Random random = new Random();
        public FrmAviator()
        {
            InitializeComponent();
        }
        private Color currentColor = Color.Red;
        private Color targetColor;

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private int ApproachColor(int current, int target)
        {
            if (current == target)
                return current;
            else if (current < target)
                return Math.Min(current + 1, target);
            else
                return Math.Max(current - 1, target);
        }

        private void gameseed_TextChanged(object sender, EventArgs e)
        {

        }

        private void randomMultiplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(gameseed.Text))
            {
                MessageBox.Show("This section cannot be left blank.");
            }
            else
            {
                MessageBox.Show("Done");
            }

        }

        private void FrmAviator_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (currentColor.R == targetColor.R && currentColor.G == targetColor.G && currentColor.B == targetColor.B)
            {
                targetColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }

            currentColor = Color.FromArgb(
                ApproachColor(currentColor.R, targetColor.R),
                ApproachColor(currentColor.G, targetColor.G),
                ApproachColor(currentColor.B, targetColor.B));

            label5.ForeColor = currentColor;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double upperLimit = 10;
            double multiplier = random.NextDouble() * (upperLimit - 1) + 1;
            double decimalPart = random.Next(0, 100) / 100.0;

            double result = Math.Round(multiplier + decimalPart, 2);

            randomMultiplierLabel.Text = $"{result}x";
        }
    }
}
