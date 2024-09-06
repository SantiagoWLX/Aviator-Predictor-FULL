using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviator_Hack
{
    public partial class FrmContactus : Form
    {
        public FrmContactus()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = $"/c start https://spribe.co/welcome",
                    UseShellExecute = false,
                    CreateNoWindow = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
}
