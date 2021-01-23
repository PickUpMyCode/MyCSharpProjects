namespace AdvinhaSO
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numero_button = new System.Windows.Forms.Button();
            this.triangulo_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.title_numero = new System.Windows.Forms.Label();
            this.title_triangulo = new System.Windows.Forms.Label();
            this.subtitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numero_button
            // 
            this.numero_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numero_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numero_button.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_button.Location = new System.Drawing.Point(30, 184);
            this.numero_button.Name = "numero_button";
            this.numero_button.Size = new System.Drawing.Size(123, 117);
            this.numero_button.TabIndex = 0;
            this.numero_button.UseVisualStyleBackColor = true;
            this.numero_button.Click += new System.EventHandler(this.button1_Click);
            this.numero_button.MouseLeave += new System.EventHandler(this.numeroMouseLeave);
            this.numero_button.MouseHover += new System.EventHandler(this.numeroMouseHover);
            // 
            // triangulo_button
            // 
            this.triangulo_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangulo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangulo_button.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangulo_button.Location = new System.Drawing.Point(180, 184);
            this.triangulo_button.Name = "triangulo_button";
            this.triangulo_button.Size = new System.Drawing.Size(123, 117);
            this.triangulo_button.TabIndex = 1;
            this.triangulo_button.UseVisualStyleBackColor = true;
            this.triangulo_button.Click += new System.EventHandler(this.triangulo_button_Click);
            this.triangulo_button.MouseLeave += new System.EventHandler(this.trianguloMouseLeave);
            this.triangulo_button.MouseHover += new System.EventHandler(this.trianguloMouseUp);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(46, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(236, 45);
            this.title.TabIndex = 2;
            this.title.Text = "Escolha um Jogo!";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // title_numero
            // 
            this.title_numero.AutoSize = true;
            this.title_numero.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_numero.Location = new System.Drawing.Point(48, 159);
            this.title_numero.Name = "title_numero";
            this.title_numero.Size = new System.Drawing.Size(87, 22);
            this.title_numero.TabIndex = 3;
            this.title_numero.Text = "Número";
            // 
            // title_triangulo
            // 
            this.title_triangulo.AutoSize = true;
            this.title_triangulo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_triangulo.Location = new System.Drawing.Point(192, 159);
            this.title_triangulo.Name = "title_triangulo";
            this.title_triangulo.Size = new System.Drawing.Size(102, 22);
            this.title_triangulo.TabIndex = 4;
            this.title_triangulo.Text = "Triângulo";
            // 
            // subtitulo
            // 
            this.subtitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtitulo.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.subtitulo.Location = new System.Drawing.Point(27, 54);
            this.subtitulo.Name = "subtitulo";
            this.subtitulo.Size = new System.Drawing.Size(294, 70);
            this.subtitulo.TabIndex = 5;
            this.subtitulo.Text = "Você terá que advinhar qual foi o número gerado ou quais foram os lados do triâng" +
    "ulo gerados.";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(338, 313);
            this.Controls.Add(this.subtitulo);
            this.Controls.Add(this.title_triangulo);
            this.Controls.Add(this.title_numero);
            this.Controls.Add(this.title);
            this.Controls.Add(this.triangulo_button);
            this.Controls.Add(this.numero_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivinha SO";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numero_button;
        private System.Windows.Forms.Button triangulo_button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label title_numero;
        private System.Windows.Forms.Label title_triangulo;
        private System.Windows.Forms.Label subtitulo;
    }
}