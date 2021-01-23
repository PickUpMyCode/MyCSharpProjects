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
    public partial class painel_triangulo : Form
    {
        private int l1 = 0;
        private int l2 = 0;
        private int l3 = 0;
        private int cont = 0;
        private bool travar = false;
        public painel_triangulo()
        {
            InitializeComponent();
            alert.Visible = false;
            dicas.Text = "            Dicas\n----------------------------------";
            Processamento.gera("triangulo");
            this.l1 = Processamento.l1;
            this.l2 = Processamento.l2;
            this.l3 = Processamento.l3;
           MessageBox.Show(l1 + " " + l2 + " " + l3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!travar){
                    Processamento.l1 = this.l1;
                    Processamento.l2 = this.l2;
                    Processamento.l3 = this.l3;
                    int l1 = Convert.ToInt16(lado1.Text);
                    int l2 = Convert.ToInt16(lado2.Text);
                    int l3 = Convert.ToInt16(lado3.Text);
                    if (!((l1 > Math.Abs((l2 - l3)) && l1 < (l2 + l3)) && (l2 > Math.Abs((l1 - l3)) && l2 < (l1 + l3)) && (l3 > Math.Abs((l1 - l2)) && l3 < (l1 + l2))))
                    {
                        MessageBox.Show("Trinagulo nao existe, digite novamente!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lado1.Text = "";
                        lado2.Text = "";
                        lado3.Text = "";
                    }
                    else
                    {
                        if ((this.l1 == l1 || this.l1 == l2 || this.l1 == l3) && (this.l2 == l2 || this.l2 == l3 || this.l2 == l1) && (this.l3 == l3 || this.l3 == l2 || this.l3 == l1))
                        {
                            if (MessageBox.Show("Parabens voce acertou! Deseja jogar de novo?", "Parabens!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                dicas.Text = "            Dicas\n----------------------------------";
                                Processamento.gera("trinagulo");
                                Processamento.cont = 0;
                                this.l1 = Processamento.l1;
                                this.l2 = Processamento.l2;
                                this.l3 = Processamento.l3;
                                cont = 0;
                               // MessageBox.Show(l1 + " " + l2 + " " + l3);
                            }
                            else
                            {
                                dicas.Visible = false;
                                label1.Visible = false;
                                label2.Visible = false;
                                label3.Visible = false;
                                lado1.Visible = false;
                                lado2.Visible = false;
                                lado3.Visible = false;
                                valida.Visible = false;
                                alert.Visible = true;
                                Point a = new Point(78, 170);
                                alert.Location = a;
                                travar = true;
                            }
                        }
                        else
                        {
                            cont++;
                            if (cont == 3)
                            {
                                if (Processamento.cont > 3)
                                {
                                    MessageBox.Show("Tente de Novo!");
                                }
                                else {
                                    dicas.Text += Processamento.dica("triangulo");
                                }
                                cont = 0;
                            }
                        }
                        lado1.Text = "";
                        lado2.Text = "";
                        lado3.Text = "";
                    }
                }
            }catch(Exception ex){
                // MessageBox.Show("Opa ta errado! \n"+ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Opa ta errado! Insira alguma coisa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void alert_Click(object sender, EventArgs e)
        {

        }

        private void painel_trianguloFormClosed(object sender, FormClosedEventArgs e)
        {
            Processamento.cont = 0;
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
