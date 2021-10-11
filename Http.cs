using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Http
    {
        public static byte[] Post(string url, NameValueCollection pairs)
        {
            using (WebClient WebClient = new WebClient())
            {
                return WebClient.UploadValues(url, pairs);
            }
        }

        
    }
}
