using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertWeb.Armazenamento.Modelo
{
    public class PainelModel
    {
        public TimeSpan TempoDecorrido {  get; set; }
        public DateTime UltimaExecucao { get; set; }
        public int QtdErros {  get; set; }
    }
}
