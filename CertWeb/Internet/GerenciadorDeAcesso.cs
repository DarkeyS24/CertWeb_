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
            try
            {
                WebClient client = new WebClient();
                return client.DownloadString(Link);
            }
            catch (Exception ex)
            {
                Painel.Model.QtdErros++;
                return null;
            }
           
        }
    }
}
