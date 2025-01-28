using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CertWeb.Armazenamento.Modelo;
using Newtonsoft.Json;

namespace CertWeb.Armazenamento.Arquivo
{
    internal class GerenciadorIndicadores
    {
        private static string NomeArquivo = "indicadores.txt";

        public static PainelModel LerIndicadores()
        {
            string conteudoArquivo = new GerenciadorArquivos().Ler(NomeArquivo);

            if (string.IsNullOrEmpty(conteudoArquivo))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<PainelModel>(conteudoArquivo);
        }
            
        public static void SalvarIndicadores(PainelModel painel)
        {
            string jsonLink = JsonConvert.SerializeObject(painel);
            new GerenciadorArquivos().Escrever(NomeArquivo, jsonLink);
        }
    }
}
