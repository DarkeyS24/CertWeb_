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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "Links";
            // 
            // flowLinks
            // 
            this.flowLinks.AutoScroll = true;
            this.flowLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLinks.Location = new System.Drawing.Point(28, 145);
            this.flowLinks.Name = "flowLinks";
            this.flowLinks.Size = new System.Drawing.Size(635, 337);
            this.flowLinks.TabIndex = 2;
            this.flowLinks.WrapContents = false;
            // 
            // executarBtn
            // 
            this.executarBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("executarBtn.BackgroundImage")));
            this.executarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.executarBtn.FlatAppearance.BorderSize = 0;
            this.executarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executarBtn.Location = new System.Drawing.Point(706, 196);
            this.executarBtn.Name = "executarBtn";
            this.executarBtn.Size = new System.Drawing.Size(257, 242);
            this.executarBtn.TabIndex = 4;
            this.executarBtn.UseVisualStyleBackColor = true;
            this.executarBtn.Click += new System.EventHandler(this.executarBtn_Click);
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.executarBtn);
            this.Controls.Add(this.flowLinks);
            this.Controls.Add(this.label1);
            this.Name = "Tarefas";
            this.Size = new System.Drawing.Size(1000, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLinks;
        private System.Windows.Forms.Button executarBtn;
    }
}
