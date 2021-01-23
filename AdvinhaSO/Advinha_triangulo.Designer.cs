namespace AdvinhaSO
{
    partial class painel_triangulo
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
            this.valida = new System.Windows.Forms.Button();
            this.lado3 = new System.Windows.Forms.TextBox();
            this.lado2 = new System.Windows.Forms.TextBox();
            this.lado1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dicas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valida
            // 
            this.valida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valida.Location = new System.Drawing.Point(135, 225);
            this.valida.Name = "valida";
            this.valida.Size = new System.Drawing.Size(89, 33);
            this.valida.TabIndex = 0;
            this.valida.Text = "Verificar";
            this.valida.UseVisualStyleBackColor = true;
            this.valida.Click += new System.EventHandler(this.button1_Click);
            // 
            // lado3
            // 
            this.lado3.Location = new System.Drawing.Point(138, 181);
            this.lado3.Name = "lado3";
            this.lado3.Size = new System.Drawing.Size(87, 20);
            this.lado3.TabIndex = 1;
            // 
            // lado2
            // 
            this.lado2.Location = new System.Drawing.Point(138, 96);
            this.lado2.Name = "lado2";
            this.lado2.Size = new System.Drawing.Size(87, 20);
            this.lado2.TabIndex = 2;
            // 
            // lado1
            // 
            this.lado1.Location = new System.Drawing.Point(137, 138);
            this.lado1.Name = "lado1";
            this.lado1.Size = new System.Drawing.Size(87, 20);
            this.lado1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primeiro Lado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo Lado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terceiro Lado ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // alert
            // 
            this.alert.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert.Location = new System.Drawing.Point(131, 304);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(156, 34);
            this.alert.TabIndex = 7;
            this.alert.Text = "Fim do Jogo!";
            this.alert.Click += new System.EventHandler(this.alert_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quais são os Lados do Triângulo?";
            // 
            // dicas
            // 
            this.dicas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dicas.Location = new System.Drawing.Point(13, 235);
            this.dicas.Name = "dicas";
            this.dicas.Size = new System.Drawing.Size(112, 123);
            this.dicas.TabIndex = 0;
            // 
            // painel_triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(296, 378);
            this.Controls.Add(this.dicas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lado1);
            this.Controls.Add(this.lado2);
            this.Controls.Add(this.lado3);
            this.Controls.Add(this.valida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "painel_triangulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advinha SO triangulo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.painel_trianguloFormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valida;
        private System.Windows.Forms.TextBox lado3;
        private System.Windows.Forms.TextBox lado2;
        private System.Windows.Forms.TextBox lado1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dicas;
    }
}

