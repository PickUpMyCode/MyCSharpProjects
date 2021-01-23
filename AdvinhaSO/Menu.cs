using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace AdvinhaSO
{
    public partial class Menu : Form
    {
        bool close = false;
        Image triangulo = Image.FromFile("triangulo.jpg");
        Image numero = Image.FromFile("icone_numero.png");
        //bool test = true;
        public Menu()
        {
            InitializeComponent();
            // this.BackColor = Color.FromArgb(0, 0, 180);
           Thread t = new Thread(rainbow);
           t.Start();
           /* Thread t2 = new Thread(text_dance);
            t2.Start();*/
        }
       /* private void text_dance() {
            String word = "a";
            title.Text = word;
            Thread.Sleep(1000);
            word += "b";
            title.Text = word;
        }*/
        private void rainbow() {
            while (!close) {
                for (int b = 13; b <= 255; b++)
                {
                    if (!close) {
                        Thread.Sleep(10);
                        this.BackColor = Color.FromArgb(255, b, 13);
                    }
                }
                for (int b = 255; b >= 13; b--)
                {
                    if (!close) {
                        Thread.Sleep(10);
                        this.BackColor = Color.FromArgb(b, 255, 13);
                    }
                }
                for (int b = 13; b <= 255; b++)
                {
                    if (!close) {
                        Thread.Sleep(10);
                        this.BackColor = Color.FromArgb(13, 255, b);
                    }
                }
                for (int b = 255; b >= 13; b--)
                {
                    if (!close) {
                        Thread.Sleep(10);
                        this.BackColor = Color.FromArgb(13, b, 255);
                    }
                }
                for (int b = 13; b <= 255; b++)
                {
                    if (!close) {
                        Thread.Sleep(10);
                        this.BackColor = Color.FromArgb(b, 13, 255);
                    }
                }
                for (int b = 255; b >= 19; b--)
                {
                    if (!close) {
                        Thread.Sleep(10);
                        this.BackColor = Color.FromArgb(255, 13, b);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            painel_num a = new painel_num();
            a.Show();
            this.Hide();
        }

        private void triangulo_button_Click(object sender, EventArgs e)
        {
            painel_triangulo a = new painel_triangulo();
            a.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            close = true;
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void trianguloMouseUp(object sender, EventArgs e)
        {
            triangulo_button.BackgroundImage = triangulo;
        }

        private void trianguloMouseLeave(object sender, EventArgs e)
        {
            triangulo_button.BackgroundImage = null;
        }

        private void numeroMouseHover(object sender, EventArgs e)
        {
            //int i = 0;
            numero_button.BackgroundImage = numero;
                //numero_button.BackgroundImage = null;
            
        }

        private void numeroMouseLeave(object sender, EventArgs e)
        {
            numero_button.BackgroundImage = null;
        }
        private void Menu_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
