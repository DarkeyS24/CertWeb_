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
            this.flowLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.linkTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLinks
            // 
            this.flowLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLinks.Location = new System.Drawing.Point(18, 256);
            this.flowLinks.Name = "flowLinks";
            this.flowLinks.Size = new System.Drawing.Size(964, 235);
            this.flowLinks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Links";
            // 
            // salvarBtn
            // 
            this.salvarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(28)))), ((int)(((byte)(251)))));
            this.salvarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarBtn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarBtn.ForeColor = System.Drawing.Color.White;
            this.salvarBtn.Location = new System.Drawing.Point(18, 104);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(132, 46);
            this.salvarBtn.TabIndex = 2;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = false;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // descTxt
            // 
            this.descTxt.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTxt.Location = new System.Drawing.Point(18, 48);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(421, 40);
            this.descTxt.TabIndex = 3;
            this.descTxt.Text = "Descrição";
            // 
            // linkTxt
            // 
            this.linkTxt.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTxt.Location = new System.Drawing.Point(445, 48);
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.Size = new System.Drawing.Size(421, 40);
            this.linkTxt.TabIndex = 4;
            this.linkTxt.Text = "Link";
            // 
            // Links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.linkTxt);
            this.Controls.Add(this.descTxt);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.flowLinks);
            this.Controls.Add(this.label1);
            this.Name = "Links";
            this.Size = new System.Drawing.Size(1000, 512);
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
