using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class accounts : UserControl
    {
        public accounts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // HOSTING
            Clipboard.SetText("SMRDIS");

        }

        private void button2_Click(object sender, EventArgs e)
        { //txAdmin
            Clipboard.SetText("SMRDIS");
        }

        private void button4_Click(object sender, EventArgs e)
        { // DB
            Clipboard.SetText("SMRDIS");
        }

        private void button3_Click(object sender, EventArgs e)
        { // SFTP
            Clipboard.SetText("SMRDIS");
        }

        private void button8_Click(object sender, EventArgs e)
        { // MAIL
            Clipboard.SetText("SMRDIS");
        }

        private void button7_Click(object sender, EventArgs e)
        { // INSTA
            Clipboard.SetText("SMRDIS");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { // LOOK (ZAP)
            MessageBox.Show("Momentálne je táto funkcia nedostupná !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
