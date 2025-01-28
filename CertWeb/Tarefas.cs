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
using CertWeb.Internet;
using System.Diagnostics;
using System.Threading;

namespace CertWeb
{
    public partial class Tarefas : UserControl
    {
        private Painel _painel;
        private Certweb _form1;

        public Tarefas()
        {
            InitializeComponent();
        }
        public void SetTarefas(Certweb form, Painel painel)
        {
            _form1 = form;
            _painel = painel;
            CarregarLinks();
        }

        public void CarregarLinks()
        {
            flowLinks.Controls.Clear();

            List<Link> links = GerenciadorLinks.LerLinks();
            if (links != null)
            {
                foreach (Link link in links)
                {
                    var panel = new FlowLayoutPanel();
                    panel.FlowDirection = FlowDirection.LeftToRight;
                    panel.Size = new Size((flowLinks.Width - 8), 20);

                    var desc = new Label() { Text = link.Descricao, Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Width = 200, ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))) };
                    var end = new Label() { Text = link.Endereco, Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Width = 240, ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134))))) };
                   
                    panel.Controls.Add(desc);
                    panel.Controls.Add(end);

                    flowLinks.Controls.Add(panel);
                }
            }
        }

        public void executarBtn_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread(Executar);
            th.IsBackground = true;
            th.Start(_form1);
        }

        private void Executar(Object _form1)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<Link> links = GerenciadorLinks.LerLinks();

            double totalLinks = links.Count;
            double linkProcessamentoAtual = 0;
            Painel.Model.QtdErros = 0;
            foreach (var link in links)
            {
                GerenciadorDeAcesso.AcesssarLink(link.Endereco);
                linkProcessamentoAtual++;
                double porcentagem = linkProcessamentoAtual / totalLinks * 100;

                if (this.InvokeRequired)
                {
                    Invoke(new Action(() => 
                    {
                        progress.Value = (int)(porcentagem);
                    }));
                }
            }
            sw.Stop();
            Painel.Model.TempoDecorrido = sw.Elapsed;
            Painel.Model.UltimaExecucao = DateTime.Now;


            if (_painel.InvokeRequired) {
                Invoke(new Action(() =>
                {
                    _painel.AtualizarDadosTela();
                }));
            }

            ((Certweb)_form1).CertWebSystemTray.ShowBalloonTip(1000, "CertWeb", Texto.txtTarefaCompletada, ToolTipIcon.Info);
            //MessageBox.Show("Sucesso");
        }
    }
}
