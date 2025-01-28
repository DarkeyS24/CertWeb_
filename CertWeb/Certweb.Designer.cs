namespace CertWeb
{
    partial class Certweb
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certweb));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnIndicador = new System.Windows.Forms.Panel();
            this.sobreBtn = new System.Windows.Forms.Button();
            this.linksBtn = new System.Windows.Forms.Button();
            this.tarefasBtn = new System.Windows.Forms.Button();
            this.painelBtn = new System.Windows.Forms.Button();
            this.pnDragDrop = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.Button();
            this.CertWebSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executarBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pnLinks = new CertWeb.Links();
            this.TelaInicial = new CertWeb.Painel();
            this.pnTarefas = new CertWeb.Tarefas();
            this.pnSobre = new CertWeb.Sobre();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.MenuSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnIndicador);
            this.panel1.Controls.Add(this.sobreBtn);
            this.panel1.Controls.Add(this.linksBtn);
            this.panel1.Controls.Add(this.tarefasBtn);
            this.panel1.Controls.Add(this.painelBtn);
            this.panel1.Name = "panel1";
            // 
            // pnIndicador
            // 
            resources.ApplyResources(this.pnIndicador, "pnIndicador");
            this.pnIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            this.pnIndicador.Name = "pnIndicador";
            // 
            // sobreBtn
            // 
            resources.ApplyResources(this.sobreBtn, "sobreBtn");
            this.sobreBtn.BackColor = System.Drawing.Color.Black;
            this.sobreBtn.FlatAppearance.BorderSize = 0;
            this.sobreBtn.ForeColor = System.Drawing.Color.White;
            this.sobreBtn.Name = "sobreBtn";
            this.sobreBtn.UseVisualStyleBackColor = false;
            this.sobreBtn.Click += new System.EventHandler(this.sobreBtn_Click);
            // 
            // linksBtn
            // 
            resources.ApplyResources(this.linksBtn, "linksBtn");
            this.linksBtn.BackColor = System.Drawing.Color.Black;
            this.linksBtn.FlatAppearance.BorderSize = 0;
            this.linksBtn.ForeColor = System.Drawing.Color.White;
            this.linksBtn.Name = "linksBtn";
            this.linksBtn.UseVisualStyleBackColor = false;
            this.linksBtn.Click += new System.EventHandler(this.linksBtn_Click);
            // 
            // tarefasBtn
            // 
            resources.ApplyResources(this.tarefasBtn, "tarefasBtn");
            this.tarefasBtn.BackColor = System.Drawing.Color.Black;
            this.tarefasBtn.FlatAppearance.BorderSize = 0;
            this.tarefasBtn.ForeColor = System.Drawing.Color.White;
            this.tarefasBtn.Name = "tarefasBtn";
            this.tarefasBtn.UseVisualStyleBackColor = false;
            this.tarefasBtn.Click += new System.EventHandler(this.tarefasBtn_Click);
            // 
            // painelBtn
            // 
            resources.ApplyResources(this.painelBtn, "painelBtn");
            this.painelBtn.BackColor = System.Drawing.Color.Black;
            this.painelBtn.FlatAppearance.BorderSize = 0;
            this.painelBtn.ForeColor = System.Drawing.Color.White;
            this.painelBtn.Name = "painelBtn";
            this.painelBtn.UseVisualStyleBackColor = false;
            this.painelBtn.Click += new System.EventHandler(this.painelBtn_Click);
            // 
            // pnDragDrop
            // 
            resources.ApplyResources(this.pnDragDrop, "pnDragDrop");
            this.pnDragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            this.pnDragDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDragDrop.Name = "pnDragDrop";
            this.pnDragDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseDown);
            this.pnDragDrop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseMove);
            this.pnDragDrop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnDragDrop_MouseUp);
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // fechar
            // 
            resources.ApplyResources(this.fechar, "fechar");
            this.fechar.BackColor = System.Drawing.Color.White;
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.Name = "fechar";
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.FecharAction);
            // 
            // CertWebSystemTray
            // 
            resources.ApplyResources(this.CertWebSystemTray, "CertWebSystemTray");
            this.CertWebSystemTray.ContextMenuStrip = this.MenuSystemTray;
            // 
            // MenuSystemTray
            // 
            resources.ApplyResources(this.MenuSystemTray, "MenuSystemTray");
            this.MenuSystemTray.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarBtn,
            this.fecharBtn});
            this.MenuSystemTray.Name = "contextMenuStrip1";
            // 
            // executarBtn
            // 
            resources.ApplyResources(this.executarBtn, "executarBtn");
            this.executarBtn.Name = "executarBtn";
            this.executarBtn.Click += new System.EventHandler(this.executarBtn_Click);
            // 
            // fecharBtn
            // 
            resources.ApplyResources(this.fecharBtn, "fecharBtn");
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Click += new System.EventHandler(this.fecharBtn_Click);
            // 
            // pnLinks
            // 
            resources.ApplyResources(this.pnLinks, "pnLinks");
            this.pnLinks.BackColor = System.Drawing.Color.White;
            this.pnLinks.Name = "pnLinks";
            // 
            // TelaInicial
            // 
            resources.ApplyResources(this.TelaInicial, "TelaInicial");
            this.TelaInicial.BackColor = System.Drawing.Color.White;
            this.TelaInicial.Name = "TelaInicial";
            // 
            // pnTarefas
            // 
            resources.ApplyResources(this.pnTarefas, "pnTarefas");
            this.pnTarefas.BackColor = System.Drawing.Color.White;
            this.pnTarefas.Name = "pnTarefas";
            // 
            // pnSobre
            // 
            resources.ApplyResources(this.pnSobre, "pnSobre");
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Name = "pnSobre";
            // 
            // Certweb
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.pnDragDrop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnLinks);
            this.Controls.Add(this.TelaInicial);
            this.Controls.Add(this.pnTarefas);
            this.Controls.Add(this.pnSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Certweb";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.MenuSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnDragDrop;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button painelBtn;
        private System.Windows.Forms.Button linksBtn;
        private System.Windows.Forms.Button tarefasBtn;
        private System.Windows.Forms.Button sobreBtn;
        private System.Windows.Forms.Button fechar;
        private Painel TelaInicial;
        private Links pnLinks;
        private Tarefas pnTarefas;
        private Sobre pnSobre;
        private System.Windows.Forms.Panel pnIndicador;
        public System.Windows.Forms.NotifyIcon CertWebSystemTray;
        private System.Windows.Forms.ContextMenuStrip MenuSystemTray;
        private System.Windows.Forms.ToolStripMenuItem executarBtn;
        private System.Windows.Forms.ToolStripMenuItem fecharBtn;
    }
}

