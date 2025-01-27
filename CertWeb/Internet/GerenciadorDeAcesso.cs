using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace CertWeb.Internet
{
    internal class GerenciadorDeAcesso
    {
        public static string AcesssarLink(string Link) 
        {
            WebClient client = new WebClient();
            return client.DownloadString(Link);
        }
    }
}
