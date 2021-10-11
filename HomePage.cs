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
using System.IO;
using System.Collections.Specialized;
using System.Net.Http;

namespace Form1
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
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


        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { // SEND OWN MESSAGE (OZNÁMENÍ)
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
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Odoslanie správy do **Oznámení** \n \n ", "RVRP APP | LOG ");

            sendWebHook("https://discord.com/api/webhooks/892107551255195699/gIKEGOGDC18z7QTTjYkiMqDxD4lRJFMxVqyAU3huM9_dyXVwzmRhcelgeaR_0btXc8k5", textBox1.Text, "RVRP | OZNÁMENIE");
        }

        private void button10_Click(object sender, EventArgs e)
        { // SERVER ON
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
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Odoslanie správy **Server ON** \n \n ", "RVRP APP | LOG ");

            sendWebHook("https://discord.com/api/webhooks/892107551255195699/gIKEGOGDC18z7QTTjYkiMqDxD4lRJFMxVqyAU3huM9_dyXVwzmRhcelgeaR_0btXc8k5", " <:plus:857598731808407563> **Server UP!** \n > *Můžete se pojit !*  <:hauko:889095548081172491> \n \n **IP:** fivem.rvrp.tk \n \n @everyon", "RVRP | OZNÁMENIE");

        }

        private void button9_Click(object sender, EventArgs e)
        { // Server OFF
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
            sendWebHook("https://discord.com/api/webhooks/893152199025254500/rl-3Oq2riE7E_VD4rdBzZNKb2_62kR4QcGoQwSGkR1Gh3J-pvhT6s3QIEj3V7mUg2ETJ", " > Odoslanie správy **Server OFF** \n \n ", "RVRP APP | LOG ");

            sendWebHook("https://discord.com/api/webhooks/892107551255195699/gIKEGOGDC18z7QTTjYkiMqDxD4lRJFMxVqyAU3huM9_dyXVwzmRhcelgeaR_0btXc8k5", "<:minus:857598732160729118>** Server OFF!** \n > *Vyčkejte !*  <:hauko:889095548081172491> \n \n @her", "RVRP | OZNÁMENIE");

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
