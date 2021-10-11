using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Management;
using System.Management.Instrumentation;
using System.Net.Http;



namespace Form1

{
    public partial class Form1 : Form
    {
        public HomePage homePage;
        public Form1()
        {
            InitializeComponent();
            //SidePanel.Height = button3.Height;
            //
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();


                    sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", "**--------------------------------------**\n > **Otvorenie aplikácie** \n \n " + "**IP:** " + localIP + "\n **PC Name:** " + Environment.MachineName + "\n **User:** " + Environment.UserName + "\n \n**--------------------------------------**", "RVRP APP | LOG ");

            homePage1.BringToFront();

        }
            }
        }

        private static readonly HttpClient client = new HttpClient();

        public static void sendWebHook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    Username
                },
                {
                    "content",
                    msg
                }
            });

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void version_Click(object sender, EventArgs e)
        {

        }

        [DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool ShowWindow([In] IntPtr hWnd, [In] int nCmdShow);

        public static class library

        {
            public static void say(string message, int delay)
            {
                Console.Write(message);
                System.Threading.Thread.Sleep(delay);


            }
        }

        public String SwapClipboardHtmlText(String replacementHtmlText)
        {
            String returnHtmlText = null;
            if (Clipboard.ContainsText(TextDataFormat.Html))
            {
                returnHtmlText = Clipboard.GetText(TextDataFormat.Html);
                Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
            }
            return returnHtmlText;
        }
        [STAThread]
        [System.Obsolete("GetHostByName is obsoleted for this type, please use GetHostEntry instead. https://go.microsoft.com/fwlink/?linkid=14202")]

        private void button11_Click(object sender, EventArgs e)
        { // MAIL
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://protonmail.com/login";
            Process.Start(prs);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Momentálne je táto funkcia nedostupná !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button9_Click(object sender, EventArgs e)
        { // VEDENI DIS
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://discord.gg/tUT8CkPdy2";
            Process.Start(prs);
        }

        private void button18_Click(object sender, EventArgs e)
        { // MAIN DIS
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://discord.gg/avfwS2U3RU";
            Process.Start(prs);

        }

        private void button19_Click(object sender, EventArgs e)
        { // ZAP
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://zap-hosting.com/";
            Process.Start(prs);

        }

        private void button16_Click(object sender, EventArgs e)
        { // WINSCP
          //var prs = new ProcessStartInfo("chrome.exe");
          //prs.Arguments = "https://zap-hosting.com/";
          //Process.Start(prs);
          MessageBox.Show("Momentálne je táto funkcia nedostupná !", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button17_Click(object sender, EventArgs e)
        { // txAdmin
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "http://95.156.227.203:40120/auth";
            Process.Start(prs);

        }

        private void button8_Click(object sender, EventArgs e)
        { // Patreon
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = "https://patreon.com/";
            Process.Start(prs);

        }

        private void button12_Click(object sender, EventArgs e)
        { // Settings button
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Otvorenie menu **Setting** \n \n ", "RVRP APP | LOG ");

            //SidePanel.Height = button12.Height;
            //SidePanel.Top = button12.Top;
            //serversPanelPage.BringToFront();
            MessageBox.Show("Táto funkcia je momentálne nedostupná !", "FekyDEV APP", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void SidePanel_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            SidePanel.Height = button15.Height;
            SidePanel.Top = button15.Top;
            aminpanel1.BringToFront();
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Otvorenie menu **Admin Panel** \n \n ", "RVRP APP | LOG ");

        }

        private void button14_Click(object sender, EventArgs e)
        { // Accounts button
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Otvorenie menu **Accounts** \n \n ", "RVRP APP | LOG ");

            SidePanel.Height = button14.Height;
            SidePanel.Top = button14.Top;
            accounts1.BringToFront();
        }

        private void homePage1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Táto aplikácia bola vytvorená pre administráciu a spravovanie servera ReverseRP. \n \n Update 1.1.1 \n- Úprava Discord WebHookov / Správ \n- Pridané audit logy \n- Ďalšie menšie veci... \n \n Čoskoro viac !", "About APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ID: A123\nName: Unknown\nLevel: Admin", "About user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void accounts1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { // MENU BUTTON

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Otvorenie menu **Home** \n \n ", "RVRP APP | LOG ");

            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            homePage1.BringToFront();

        }
    }
    }
   

