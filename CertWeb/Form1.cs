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

namespace CertWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            GerenciadorLinks.LerLinks();
            InitializeComponent();
            PainelVisivel(pnInicial);
        }

        private void FecharAction(object sender, EventArgs e)
        {
            GerenciadorLinks.SalvarLinks();
            Application.Exit();
        }

        private void painelBtn_Click(object sender, EventArgs e)
        {
            MoverIndicador((Button)sender);
            PainelVisivel(pnInicial);
        }

        private void tarefasBtn_Click(object sender, EventArgs e)
        {
            MoverIndicador((Button)sender);
            PainelVisivel(pnTarefas);
        }

        private void linksBtn_Click(object sender, EventArgs e)
        {
            MoverIndicador((Button)sender);
            PainelVisivel(pnLinks);
        }

        private void sobreBtn_Click(object sender, EventArgs e)
        {
            MoverIndicador((Button)sender);
            PainelVisivel(pnSobre);
        }
        
        private void MoverIndicador(Button itemMenu)
        {
            pnIndicador.Location = new Point(pnIndicador.Location.X, itemMenu.Location.Y);
        }

        private void PainelVisivel(UserControl pn)
        {
            pnInicial.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;
            pn.Visible = true;  
        }

        private bool pressBtn = false;
        private Point formPoint;
        private Point cursorPoint;
        private void pnDragDrop_MouseDown(object sender, MouseEventArgs e)
        {
            pressBtn = true;
            formPoint = this.Location;
            cursorPoint = Cursor.Position;
        }

        private void pnDragDrop_MouseUp(object sender, MouseEventArgs e)
        {
            pressBtn = false;
        }

        private void pnDragDrop_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressBtn == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(cursorPoint));
                this.Location = Point.Add(formPoint, new Size(dif));
            }
        }
    }
}
