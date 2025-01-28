namespace CertWeb
{
    partial class Tarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.executarBtn = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // flowLinks
            // 
            resources.ApplyResources(this.flowLinks, "flowLinks");
            this.flowLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLinks.Name = "flowLinks";
            // 
            // executarBtn
            // 
            resources.ApplyResources(this.executarBtn, "executarBtn");
            this.executarBtn.FlatAppearance.BorderSize = 0;
            this.executarBtn.Name = "executarBtn";
            this.executarBtn.UseVisualStyleBackColor = true;
            this.executarBtn.Click += new System.EventHandler(this.executarBtn_Click);
            // 
            // progress
            // 
            this.progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            resources.ApplyResources(this.progress, "progress");
            this.progress.Name = "progress";
            // 
            // Tarefas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.executarBtn);
            this.Controls.Add(this.flowLinks);
            this.Controls.Add(this.label1);
            this.Name = "Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLinks;
        private System.Windows.Forms.Button executarBtn;
        private System.Windows.Forms.ProgressBar progress;
    }
}
