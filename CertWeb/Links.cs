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
    public partial class Links : UserControl
    {
        public Links()
        {
            InitializeComponent();
            CarregarLinks();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            Link link = new Link();
            link.Descricao = descTxt.Text;
            link.Endereco = linkTxt.Text;
            GerenciadorLinks.AdicionarLink(link);

            descTxt.Text = "";
            linkTxt.Text = "";
        }

        private void CarregarLinks()
        {
            List<Link> links = GerenciadorLinks.LerLinks();

            foreach (Link link in links)
            {
                var panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.Controls.Add(new Label() { Text = link.Descricao });
                panel.Controls.Add(new Label() { Text = link.Endereco });
                panel.Controls.Add(new LinkLabel() { Text = "Editar" });
                panel.Controls.Add(new LinkLabel() { Text = "Excluir" });

                flowLinks.Controls.Add(panel);
            }
        }
    }
}
