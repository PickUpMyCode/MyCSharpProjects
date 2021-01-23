namespace CadastraAluno
{
    partial class AlunoForm
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
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.CPF_txt = new System.Windows.Forms.TextBox();
            this.matr_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dia_cb = new System.Windows.Forms.ComboBox();
            this.mes_cb = new System.Windows.Forms.ComboBox();
            this.ano_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(87, 59);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(100, 20);
            this.nome_txt.TabIndex = 2;
            // 
            // CPF_txt
            // 
            this.CPF_txt.Location = new System.Drawing.Point(87, 107);
            this.CPF_txt.Name = "CPF_txt";
            this.CPF_txt.Size = new System.Drawing.Size(100, 20);
            this.CPF_txt.TabIndex = 3;
            // 
            // matr_txt
            // 
            this.matr_txt.Location = new System.Drawing.Point(87, 153);
            this.matr_txt.Name = "matr_txt";
            this.matr_txt.Size = new System.Drawing.Size(100, 20);
            this.matr_txt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastrar";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matricula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento";
            // 
            // dia_cb
            // 
            this.dia_cb.FormattingEnabled = true;
            this.dia_cb.Location = new System.Drawing.Point(122, 202);
            this.dia_cb.Name = "dia_cb";
            this.dia_cb.Size = new System.Drawing.Size(35, 21);
            this.dia_cb.TabIndex = 11;
            // 
            // mes_cb
            // 
            this.mes_cb.FormattingEnabled = true;
            this.mes_cb.Location = new System.Drawing.Point(163, 202);
            this.mes_cb.Name = "mes_cb";
            this.mes_cb.Size = new System.Drawing.Size(35, 21);
            this.mes_cb.TabIndex = 12;
            // 
            // ano_cb
            // 
            this.ano_cb.FormattingEnabled = true;
            this.ano_cb.Location = new System.Drawing.Point(204, 202);
            this.ano_cb.Name = "ano_cb";
            this.ano_cb.Size = new System.Drawing.Size(57, 21);
            this.ano_cb.TabIndex = 13;
            this.ano_cb.SelectedIndexChanged += new System.EventHandler(this.Ano_cb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ano_cb);
            this.Controls.Add(this.mes_cb);
            this.Controls.Add(this.dia_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matr_txt);
            this.Controls.Add(this.CPF_txt);
            this.Controls.Add(this.nome_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AlunoForm";
            this.Text = "Aluno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlunoForm_FormClosed);
            this.Load += new System.EventHandler(this.AlunoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.TextBox CPF_txt;
        private System.Windows.Forms.TextBox matr_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dia_cb;
        private System.Windows.Forms.ComboBox mes_cb;
        private System.Windows.Forms.ComboBox ano_cb;
        private System.Windows.Forms.Button button1;
    }
}