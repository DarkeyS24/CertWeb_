using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertWeb.Armazenamento.Arquivo;
using CertWeb.Armazenamento.Modelo;

namespace CertWeb
{
    public partial class Painel : UserControl
    {
        public static PainelModel Model { get; set; }
        public Painel()
        {
            InitializeComponent();
            Model = GerenciadorIndicadores.LerIndicadores();
            if (Model == null) {
            Model = new PainelModel();
            Model.QtdErros = 0;
            }
            AtualizarDadosTela();
        }

        public void QuantidadeLinks()
        {
            List<Link> links = GerenciadorLinks.LerLinks();
            if (links != null)
            {
                qtdLbl.Text = links.Count.ToString();
            }
        }

        public void AtualizarDadosTela()
        {
            errosLbl.Text = Model.QtdErros.ToString();
            int tempo = (int)(Model.TempoDecorrido.TotalSeconds);
            if (tempo < 60)
            {
                tempoMedioLbl.Text = Model.TempoDecorrido.ToString("ss") + "s";
            }
            else
            {
                tempoMedioLbl.Text = Model.TempoDecorrido.ToString("mm") + "m";
            }
            ultimaExecuçãoLbl.Text = Model.UltimaExecucao.ToString("HH:mm");
        }
    }
}
