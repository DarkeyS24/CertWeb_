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

namespace CertWeb
{
    public partial class Tarefas : UserControl
    {
        public Tarefas()
        {
            InitializeComponent();
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

        private void executarBtn_Click(object sender, EventArgs e)
        {
            List<Link> links = GerenciadorLinks.LerLinks();
            foreach (var link in links) 
            {
                GerenciadorDeAcesso.AcesssarLink(link.Endereco);
            }

            MessageBox.Show("Sucesso");
        }
    }
}
