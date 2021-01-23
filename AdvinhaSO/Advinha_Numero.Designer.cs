namespace AdvinhaSO
{
    partial class painel_num
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(painel_num));
            this.num_entrada = new System.Windows.Forms.TextBox();
            this.submete = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.num_image4 = new System.Windows.Forms.Label();
            this.num_image2 = new System.Windows.Forms.Label();
            this.num_image3 = new System.Windows.Forms.Label();
            this.num_image = new System.Windows.Forms.Label();
            this.quadro_dicas = new System.Windows.Forms.Label();
            this.comparacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num_entrada
            // 
            this.num_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_entrada.ForeColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.num_entrada, "num_entrada");
            this.num_entrada.Name = "num_entrada";
            // 
            // submete
            // 
            resources.ApplyResources(this.submete, "submete");
            this.submete.Name = "submete";
            this.submete.UseVisualStyleBackColor = true;
            this.submete.Click += new System.EventHandler(this.submete_Click);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // num_image4
            // 
            this.num_image4.Image = global::AdvinhaSO.Properties.Resources._3;
            resources.ApplyResources(this.num_image4, "num_image4");
            this.num_image4.Name = "num_image4";
            this.num_image4.Click += new System.EventHandler(this.num_image4_Click);
            // 
            // num_image2
            // 
            this.num_image2.Image = global::AdvinhaSO.Properties.Resources._3;
            resources.ApplyResources(this.num_image2, "num_image2");
            this.num_image2.Name = "num_image2";
            this.num_image2.Click += new System.EventHandler(this.num_image2_Click);
            // 
            // num_image3
            // 
            this.num_image3.Image = global::AdvinhaSO.Properties.Resources._3;
            resources.ApplyResources(this.num_image3, "num_image3");
            this.num_image3.Name = "num_image3";
            this.num_image3.Click += new System.EventHandler(this.num_image3_Click);
            // 
            // num_image
            // 
            this.num_image.Image = global::AdvinhaSO.Properties.Resources._3;
            resources.ApplyResources(this.num_image, "num_image");
            this.num_image.Name = "num_image";
            this.num_image.Click += new System.EventHandler(this.num_image_Click);
            // 
            // quadro_dicas
            // 
            this.quadro_dicas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quadro_dicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quadro_dicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.quadro_dicas, "quadro_dicas");
            this.quadro_dicas.Name = "quadro_dicas";
            // 
            // comparacao
            // 
            this.comparacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.comparacao, "comparacao");
            this.comparacao.Name = "comparacao";
            // 
            // painel_num
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.comparacao);
            this.Controls.Add(this.quadro_dicas);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.num_image4);
            this.Controls.Add(this.num_image2);
            this.Controls.Add(this.num_image3);
            this.Controls.Add(this.num_image);
            this.Controls.Add(this.submete);
            this.Controls.Add(this.num_entrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "painel_num";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tela_principal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_entrada;
        private System.Windows.Forms.Button submete;
        private System.Windows.Forms.Label num_image;
        private System.Windows.Forms.Label num_image3;
        private System.Windows.Forms.Label num_image2;
        private System.Windows.Forms.Label num_image4;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label quadro_dicas;
        private System.Windows.Forms.Label comparacao;
    }
}

