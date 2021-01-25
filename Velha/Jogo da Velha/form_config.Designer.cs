namespace Jogo_da_Velha
{
    partial class form_config
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_img2 = new System.Windows.Forms.TextBox();
            this.txt_img1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pl1name = new System.Windows.Forms.TextBox();
            this.txt_pl2name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_img2);
            this.panel1.Controls.Add(this.txt_img1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_pl1name);
            this.panel1.Controls.Add(this.txt_pl2name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 395);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Player1 (X)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Player 2 (O)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Image";
            // 
            // txt_img2
            // 
            this.txt_img2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_img2.Location = new System.Drawing.Point(452, 217);
            this.txt_img2.Name = "txt_img2";
            this.txt_img2.ReadOnly = true;
            this.txt_img2.Size = new System.Drawing.Size(186, 20);
            this.txt_img2.TabIndex = 34;
            this.txt_img2.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.txt_img2.Leave += new System.EventHandler(this.TextBox2_Leave);
            // 
            // txt_img1
            // 
            this.txt_img1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_img1.Location = new System.Drawing.Point(73, 221);
            this.txt_img1.Name = "txt_img1";
            this.txt_img1.ReadOnly = true;
            this.txt_img1.Size = new System.Drawing.Size(186, 20);
            this.txt_img1.TabIndex = 33;
            this.txt_img1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txt_img1.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.txt_img1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(651, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(-1, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(744, 32);
            this.label8.TabIndex = 30;
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label8_MouseDown);
            this.label8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label8_MouseMove);
            this.label8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label8_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(306, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "Aplicar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Configurações";
            // 
            // txt_pl1name
            // 
            this.txt_pl1name.Location = new System.Drawing.Point(73, 168);
            this.txt_pl1name.Name = "txt_pl1name";
            this.txt_pl1name.Size = new System.Drawing.Size(100, 20);
            this.txt_pl1name.TabIndex = 26;
            // 
            // txt_pl2name
            // 
            this.txt_pl2name.Location = new System.Drawing.Point(452, 168);
            this.txt_pl2name.Name = "txt_pl2name";
            this.txt_pl2name.Size = new System.Drawing.Size(100, 20);
            this.txt_pl2name.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(265, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 24);
            this.button3.TabIndex = 40;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(652, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 24);
            this.button4.TabIndex = 41;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // form_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(744, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_config";
            this.Text = "form_config";
            this.Load += new System.EventHandler(this.Form_config_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pl1name;
        private System.Windows.Forms.TextBox txt_pl2name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_img2;
        private System.Windows.Forms.TextBox txt_img1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}