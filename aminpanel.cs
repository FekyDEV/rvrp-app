using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Net.NetworkInformation;
using TSendKeys = System.Windows.Forms.SendKeys;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;
using System.Net.Sockets;

namespace Form1
{
    public partial class aminpanel : UserControl
    {
        public aminpanel()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            string host = @"95.156.227.203";
            Task.Run(() =>
            {
                PingReply reply = pingSender.Send(host);
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Address: {0}", reply.Address.ToString());
                    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
                    MessageBox.Show("Server je ONLINE !", "FekyDEV STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Console.WriteLine("Address: {0}", reply.Status);
                    MessageBox.Show("Server je OFFLINE !", "FekyDEV STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect("95.156.227.203", 30120);
                MessageBox.Show("Server je ONLINE !", "FekyDEV STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Server je OFFLINE !", "FekyDEV STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();

            try
            {
                tcpClient.Connect("95.156.227.203", 40120);
                MessageBox.Show("Server je ONLINE !", "FekyDEV STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Server je OFFLINE !", "FekyDEV STATUS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { // DOWNLOAD
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://the.earth.li/~sgtatham/putty/latest/w64/putty-64bit-0.76-installer.msi";
            Process.Start(prs);

        }

        private void button6_Click(object sender, EventArgs e)
        { // FTP OPEN
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button10_Click(object sender, EventArgs e)
        { // START MIDDLE
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button9_Click(object sender, EventArgs e)
        { // STOP MIDDLE
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button12_Click(object sender, EventArgs e)
        { // START RIGHT
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button11_Click(object sender, EventArgs e)
        { // STOP RIGHT
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button8_Click(object sender, EventArgs e)
        {// START LEFT
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button7_Click(object sender, EventArgs e)
        { // STOP LEFT
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        { // CONSOLE OPEN
            //MessageBox.Show("Táto funkcia je momentálne nedostupná !", "RVRP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var prs = new ProcessStartInfo("putty.exe");
            prs.Arguments = "95.156.227.203";
            Process.Start(prs);

            Thread.Sleep(900);
            TSendKeys.SendWait("root");
            TSendKeys.SendWait("{ENTER}");
            Clipboard.SetText("o!@&mb@Am@4%");

            DialogResult dialogResult = MessageBox.Show("V konzoli stlač pravé tlačítko na myši a čakaj !", "RVRP", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Thread.Sleep(4200);
                TSendKeys.SendWait("{ENTER}");
                //
                Thread.Sleep(3200);
            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }
    }
}
