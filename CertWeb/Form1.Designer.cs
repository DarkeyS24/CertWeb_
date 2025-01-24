namespace CertWeb
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sobreBtn = new System.Windows.Forms.Button();
            this.linksBtn = new System.Windows.Forms.Button();
            this.tarefasBtn = new System.Windows.Forms.Button();
            this.painelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.Button();
            this.pnIndicador = new System.Windows.Forms.Panel();
            this.pnLinks = new CertWeb.Links();
            this.pnInicial = new CertWeb.Painel();
            this.pnTarefas = new CertWeb.Tarefas();
            this.pnSobre = new CertWeb.Sobre();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnIndicador);
            this.panel1.Controls.Add(this.sobreBtn);
            this.panel1.Controls.Add(this.linksBtn);
            this.panel1.Controls.Add(this.tarefasBtn);
            this.panel1.Controls.Add(this.painelBtn);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 685);
            this.panel1.TabIndex = 1;
            // 
            // sobreBtn
            // 
            this.sobreBtn.BackColor = System.Drawing.Color.Black;
            this.sobreBtn.FlatAppearance.BorderSize = 0;
            this.sobreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sobreBtn.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreBtn.ForeColor = System.Drawing.Color.White;
            this.sobreBtn.Image = ((System.Drawing.Image)(resources.GetObject("sobreBtn.Image")));
            this.sobreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sobreBtn.Location = new System.Drawing.Point(3, 558);
            this.sobreBtn.Name = "sobreBtn";
            this.sobreBtn.Size = new System.Drawing.Size(305, 100);
            this.sobreBtn.TabIndex = 13;
            this.sobreBtn.Text = "Sobre nós";
            this.sobreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sobreBtn.UseVisualStyleBackColor = false;
            this.sobreBtn.Click += new System.EventHandler(this.sobreBtn_Click);
            // 
            // linksBtn
            // 
            this.linksBtn.BackColor = System.Drawing.Color.Black;
            this.linksBtn.FlatAppearance.BorderSize = 0;
            this.linksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linksBtn.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksBtn.ForeColor = System.Drawing.Color.White;
            this.linksBtn.Image = ((System.Drawing.Image)(resources.GetObject("linksBtn.Image")));
            this.linksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linksBtn.Location = new System.Drawing.Point(3, 391);
            this.linksBtn.Name = "linksBtn";
            this.linksBtn.Size = new System.Drawing.Size(302, 100);
            this.linksBtn.TabIndex = 12;
            this.linksBtn.Text = "Links";
            this.linksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linksBtn.UseVisualStyleBackColor = false;
            this.linksBtn.Click += new System.EventHandler(this.linksBtn_Click);
            // 
            // tarefasBtn
            // 
            this.tarefasBtn.BackColor = System.Drawing.Color.Black;
            this.tarefasBtn.FlatAppearance.BorderSize = 0;
            this.tarefasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tarefasBtn.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarefasBtn.ForeColor = System.Drawing.Color.White;
            this.tarefasBtn.Image = ((System.Drawing.Image)(resources.GetObject("tarefasBtn.Image")));
            this.tarefasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tarefasBtn.Location = new System.Drawing.Point(3, 201);
            this.tarefasBtn.Name = "tarefasBtn";
            this.tarefasBtn.Size = new System.Drawing.Size(302, 100);
            this.tarefasBtn.TabIndex = 11;
            this.tarefasBtn.Text = "Tarefas";
            this.tarefasBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarefasBtn.UseVisualStyleBackColor = false;
            this.tarefasBtn.Click += new System.EventHandler(this.tarefasBtn_Click);
            // 
            // painelBtn
            // 
            this.painelBtn.BackColor = System.Drawing.Color.Black;
            this.painelBtn.FlatAppearance.BorderSize = 0;
            this.painelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.painelBtn.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelBtn.ForeColor = System.Drawing.Color.White;
            this.painelBtn.Image = ((System.Drawing.Image)(resources.GetObject("painelBtn.Image")));
            this.painelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.painelBtn.Location = new System.Drawing.Point(3, 25);
            this.painelBtn.Name = "painelBtn";
            this.painelBtn.Size = new System.Drawing.Size(302, 100);
            this.painelBtn.TabIndex = 4;
            this.painelBtn.Text = "Painel";
            this.painelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.painelBtn.UseVisualStyleBackColor = false;
            this.painelBtn.Click += new System.EventHandler(this.painelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 19);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(309, -5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(204, 205);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // fechar
            // 
            this.fechar.BackColor = System.Drawing.Color.White;
            this.fechar.FlatAppearance.BorderSize = 0;
            this.fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechar.Location = new System.Drawing.Point(1260, 25);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(35, 38);
            this.fechar.TabIndex = 4;
            this.fechar.Text = "X";
            this.fechar.UseVisualStyleBackColor = false;
            this.fechar.Click += new System.EventHandler(this.FecharAction);
            // 
            // pnIndicador
            // 
            this.pnIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            this.pnIndicador.Location = new System.Drawing.Point(11, 25);
            this.pnIndicador.Name = "pnIndicador";
            this.pnIndicador.Size = new System.Drawing.Size(10, 100);
            this.pnIndicador.TabIndex = 9;
            // 
            // pnLinks
            // 
            this.pnLinks.BackColor = System.Drawing.Color.White;
            this.pnLinks.Location = new System.Drawing.Point(309, 182);
            this.pnLinks.Name = "pnLinks";
            this.pnLinks.Size = new System.Drawing.Size(992, 512);
            this.pnLinks.TabIndex = 6;
            // 
            // pnInicial
            // 
            this.pnInicial.BackColor = System.Drawing.Color.White;
            this.pnInicial.Location = new System.Drawing.Point(315, 126);
            this.pnInicial.Name = "pnInicial";
            this.pnInicial.Size = new System.Drawing.Size(986, 411);
            this.pnInicial.TabIndex = 5;
            // 
            // pnTarefas
            // 
            this.pnTarefas.BackColor = System.Drawing.Color.White;
            this.pnTarefas.Location = new System.Drawing.Point(309, 185);
            this.pnTarefas.Name = "pnTarefas";
            this.pnTarefas.Size = new System.Drawing.Size(994, 512);
            this.pnTarefas.TabIndex = 7;
            // 
            // pnSobre
            // 
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Location = new System.Drawing.Point(309, 182);
            this.pnSobre.Name = "pnSobre";
            this.pnSobre.Size = new System.Drawing.Size(994, 512);
            this.pnSobre.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1307, 697);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnLinks);
            this.Controls.Add(this.pnInicial);
            this.Controls.Add(this.pnTarefas);
            this.Controls.Add(this.pnSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button painelBtn;
        private System.Windows.Forms.Button linksBtn;
        private System.Windows.Forms.Button tarefasBtn;
        private System.Windows.Forms.Button sobreBtn;
        private System.Windows.Forms.Button fechar;
        private Painel pnInicial;
        private Links pnLinks;
        private Tarefas pnTarefas;
        private Sobre pnSobre;
        private System.Windows.Forms.Panel pnIndicador;
    }
}

