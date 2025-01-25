using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertWeb.Armazenamento.Arquivo;
using CertWeb.Armazenamento.Modelo;

namespace CertWeb
{
    public partial class Links : UserControl
    {
        private Link LinkEdit { get; set; }
        public Links()
        {
            InitializeComponent();
            CarregarLinks();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if(LinkEdit == null)
            {
                Link link = new Link();
                link.Descricao = descTxt.Text;
                link.Endereco = linkTxt.Text;
                GerenciadorLinks.AdicionarLink(link);
            }
            else
            {
                LinkEdit.Descricao = descTxt.Text;
                LinkEdit.Endereco = linkTxt.Text;
            }

            CarregarLinks();
            descTxt.Text = "Descrição";
            linkTxt.Text = "Link";
        }

        private void CarregarLinks()
        {
            flowLinks.Controls.Clear();

            List<Link> links = GerenciadorLinks.LerLinks();

            foreach (Link link in links)
            {
                var panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.Size = new Size((flowLinks.Width - 8), 20);

                var desc = new Label() { Text = link.Descricao, Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Width = 300, ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))) };
                var end = new Label() { Text = link.Endereco, Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Width = 430, ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134))))) };
                var editar = new LinkLabel() { Text = "Editar", Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) };
                var excluir = new LinkLabel() { Text = "Excluir", Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) };

                panel.Controls.Add(desc);
                panel.Controls.Add(end);
                panel.Controls.Add(editar);
                panel.Controls.Add(excluir);

                flowLinks.Controls.Add(panel);

                editar.Click += delegate
                {
                    EditarAction(link);
                };

                excluir.Click += delegate
                {
                    ExcluirAction(link);
                };
            }
        }

        private void EditarAction(Link link)
        {
            LinkEdit = link;

            descTxt.Text = link.Descricao;
            linkTxt.Text = link.Endereco;


        }

        private void ExcluirAction(Link link)
        {
            GerenciadorLinks.RemoverLink(link);
            CarregarLinks();
        }

        private void descTxt_Enter(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == "Descrição")
            {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
        }

        private void descTxt_Leave(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == "")
            {
                campo.Text = "Descrição";
                campo.ForeColor = Color.FromArgb(68,68,68);
            }
        }

        private void linkTxt_Enter(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == "Link")
            {
                campo.Text = "";
                campo.ForeColor = Color.Black;
            }
        }

        private void linkTxt_Leave(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == "")
            {
                campo.Text = "Link";
                campo.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}
