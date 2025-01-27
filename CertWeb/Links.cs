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
        private Tarefas _tarefa;
        private Painel _painel;
        public Links(Tarefas tarefa, Painel painel)
        {
            InitializeComponent();
            _tarefa = tarefa;
            _painel = painel;
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
            descTxt.Text = Texto.txtDesc ;
            linkTxt.Text = Texto.txtLink;
        }

        private void CarregarLinks()
        {
            flowLinks.Controls.Clear();
            _tarefa.CarregarLinks(); 
            _painel.QuantidadeLinks();

            List<Link> links = GerenciadorLinks.LerLinks();
            if (links != null)
            {
                foreach (Link link in links)
                {
                    var panel = new FlowLayoutPanel();
                    panel.FlowDirection = FlowDirection.LeftToRight;
                    panel.Size = new Size((flowLinks.Width - 8), 20);

                    var desc = new Label() { Text = link.Descricao, Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Width = 200, ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))) };
                    var end = new Label() { Text = link.Endereco, Font = new Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), Width = 280, ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134))))) };
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
            if (campo.Text == Texto.txtDesc)
            {
                campo.Text = string.Empty;
                campo.ForeColor = Color.Black;
            }
        }

        private void descTxt_Leave(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == string.Empty)
            {
                campo.Text = Texto.txtDesc;
                campo.ForeColor = Color.FromArgb(68,68,68);
            }
        }

        private void linkTxt_Enter(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == Texto.txtLink)
            {
                campo.Text = string.Empty;
                campo.ForeColor = Color.Black;
            }
        }

        private void linkTxt_Leave(object sender, EventArgs e)
        {
            var campo = (TextBox)sender;
            if (campo.Text == string.Empty)
            {
                campo.Text = Texto.txtLink;
                campo.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}
