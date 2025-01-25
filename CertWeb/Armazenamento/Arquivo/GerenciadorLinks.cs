using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertWeb.Armazenamento.Modelo;
using Newtonsoft.Json;

namespace CertWeb.Armazenamento.Arquivo
{
    public class GerenciadorLinks
    {
        private static string NomeArquivo = "links.txt";
        private static List<Link> ListaLinks = new List<Link>();
        public static void AdicionarLink(Link link)
        {
            ListaLinks.Add(link);
        }

        public static void RemoverLink(Link link)
        {
            ListaLinks.Remove(link);
        }
        public static List<Link> LerLinks()
        {
            if (ListaLinks == null || !ListaLinks.Any())
            {
                string conteudoArquivo = new GerenciadorArquivos().Ler(NomeArquivo);

                if (string.IsNullOrEmpty(conteudoArquivo))
                {
                    return new List<Link>();
                }

                ListaLinks = JsonConvert.DeserializeObject<List<Link>>(conteudoArquivo);
                return ListaLinks;
                
            }
            else
            {
                return ListaLinks;
            }
        }
        public static void SalvarLinks()
        {
            string jsonLink = JsonConvert.SerializeObject(ListaLinks);
            new GerenciadorArquivos().Escrever(NomeArquivo, jsonLink);
        }
    }
}
