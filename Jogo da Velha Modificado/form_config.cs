using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogo_da_Velha
{
    public partial class form_config : Form
    {
        private bool onClick = false;
        private int difX, difY;

        public form_config()
        {
            InitializeComponent();
        }

        private void Form_config_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            form_main.isConfOpened = false;
            Dispose();
        }

        private void Label8_MouseDown(object sender, MouseEventArgs e)
        {
            onClick = true;
            difX = PointToClient(Cursor.Position).X;
            difY = PointToClient(Cursor.Position).Y;
        }

        private void Label8_MouseUp(object sender, MouseEventArgs e)
        {
            onClick = false;
        }

        private void Label8_MouseMove(object sender, MouseEventArgs e)
        {
            moveform();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (txt_pl1name.Text != "")
            {
                form_main.Player1 = txt_pl1name.Text;
                ConfigurationFeatures.setPlayer1Name(txt_pl1name.Text);
                form_main.instance.lbl_ptname1.Text = ConfigurationFeatures.player1Name;
                form_main.isConfOpened = false;
            }
            if (txt_pl2name.Text != "")
            {
                form_main.Player2 = txt_pl2name.Text;
                ConfigurationFeatures.setPlayer2Name(txt_pl2name.Text);
                form_main.instance.lbl_ptname2.Text = ConfigurationFeatures.player2Name;
                form_main.isConfOpened = false;

            }
           if (txt_img1.Text.Contains(":")) {
                ConfigurationFeatures.setPlayer1Directory(txt_img1.Text);
                form_main.setFilePl1(@ConfigurationFeatures.pl1directory);
                
            }
            if (txt_img2.Text.Contains(":")) {
                ConfigurationFeatures.setPlayer2Directory(txt_img2.Text);
                form_main.setFilePl2(@ConfigurationFeatures.pl2directory);
            }

            if (txt_pl1name.Text == "" && txt_pl2name.Text == "")
            {
                form_main.isConfOpened = false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
    
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        { 
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string caminho = openFileDialog1.FileName;
                ConfigurationFeatures.setPlayer1Directory(caminho);
                txt_img1.Text = caminho;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = openFileDialog1.FileName;
                ConfigurationFeatures.setPlayer2Directory(caminho);
                txt_img2.Text = caminho;
            }
        }

        private void moveform()
        {

            if (onClick)
            {
                int Xscreen = MousePosition.X;
                int Yscreen = MousePosition.Y;
                int X = Xscreen - difX;
                int Y = Yscreen - difY;
                Location = new Point(X, Y);
            }
        }
    }
}
