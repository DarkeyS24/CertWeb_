namespace CertWeb
{
    partial class Links
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Links));
            this.flowLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLinks
            // 
            resources.ApplyResources(this.flowLinks, "flowLinks");
            this.flowLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLinks.Name = "flowLinks";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // salvarBtn
            // 
            resources.ApplyResources(this.salvarBtn, "salvarBtn");
            this.salvarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            this.salvarBtn.ForeColor = System.Drawing.Color.White;
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.UseVisualStyleBackColor = false;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // descTxt
            // 
            resources.ApplyResources(this.descTxt, "descTxt");
            this.descTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.descTxt.Name = "descTxt";
            this.descTxt.Enter += new System.EventHandler(this.descTxt_Enter);
            this.descTxt.Leave += new System.EventHandler(this.descTxt_Leave);
            // 
            // linkTxt
            // 
            resources.ApplyResources(this.linkTxt, "linkTxt");
            this.linkTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.Enter += new System.EventHandler(this.linkTxt_Enter);
            this.linkTxt.Leave += new System.EventHandler(this.linkTxt_Leave);
            // 
            // Links
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkTxt);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.flowLinks);
            this.Controls.Add(this.label1);
            this.Name = "Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.TextBox linkTxt;
    }
}
