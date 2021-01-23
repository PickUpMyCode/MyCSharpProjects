using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
namespace AdvinhaSO
{
    public partial class painel_num : Form
    {
        private int num = 0;
        private int cont = 0;
        private bool nao_travar = true;
        private int tentativas = 0;
        public painel_num()
        {
            InitializeComponent();
            cont = 0;
            comparacao.ForeColor = Color.Red;
            quadro_dicas.Text = "              Dicas\n---------------------------------------";
            num = Processamento.gera("numero");
            Processamento.num = num;
             //MessageBox.Show(num+"");
            Thread t = new Thread(rainbow);
            t.Start();
        }

        private void rainbow() {
            while (nao_travar)
            {
                for (int b = 13; b <= 255; b++)
                {
                    if (nao_travar)
                    {
                        Thread.Sleep(10);
                        Title.ForeColor = Color.FromArgb(255, b, 13);
                    }
                }
                for (int b = 255; b >= 13; b--)
                {
                    if (nao_travar)
                    {
                        Thread.Sleep(10);
                        Title.ForeColor = Color.FromArgb(b, 255, 13);
                    }
                }
                for (int b = 13; b <= 255; b++)
                {
                    if (nao_travar)
                    {
                        Thread.Sleep(10);
                        Title.ForeColor = Color.FromArgb(13, 255, b);
                    }
                }
                for (int b = 255; b >= 13; b--)
                {
                    if (nao_travar)
                    {
                        Thread.Sleep(10);
                        Title.ForeColor = Color.FromArgb(13, b, 255);
                    }
                }
                for (int b = 13; b <= 255; b++)
                {
                    if (nao_travar)
                    {
                        Thread.Sleep(10);
                        Title.ForeColor = Color.FromArgb(b, 13, 255);
                    }
                }
                for (int b = 255; b >= 19; b--)
                {
                    if (nao_travar)
                    {
                        Thread.Sleep(10);
                        Title.ForeColor = Color.FromArgb(255, 13, b);
                    }
                }
            }
        }
        private void num_image_Click(object sender, EventArgs e)
        {

        }
        private void submete_Click(object sender, EventArgs e)
        {
            try
            {
                Processamento.num_entrada = num_entrada.Text;
                tentativas++;
                if (nao_travar)
                {
                    if (num_entrada.Text == null || num_entrada.Text == "")
                    {
                        MessageBox.Show("Por favor Insira alguma coisa!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cont++;
                        int entrada = Convert.ToInt16(num_entrada.Text);
                        if (num > entrada)
                        {
                           comparacao.Text = "Esse numero e maior que " + entrada + " "+"\n";
                        }
                        else
                        {
                            comparacao.Text = "Esse numero e menor que " + entrada + "\n";
                        }
                        
                        if (entrada == num)
                        {
                            char[] nums = num_entrada.Text.ToCharArray();
                            String[] numero = new String[nums.Length];
                            String acumula = "";
                            for (int i = 0; i < nums.Length; i++) {
                                if (Convert.ToString(Convert.ToInt16(nums[i])) != null)
                                {
                                    numero[i] = Convert.ToString(nums[i]);
                                    acumula += numero[i];
                                    if (i == 0) {
                                        num_image.Image = Image.FromFile("Numeros\\" + numero[i] + ".jpg");
                                    } else if (i == 1) {
                                        num_image2.Image = Image.FromFile("Numeros\\" + numero[i] + ".jpg");
                                    }
                                    else if (i == 2)
                                    {
                                        num_image3.Image = Image.FromFile("Numeros\\" + numero[i] + ".jpg");

                                    }
                                    else if (i == 3)
                                    {
                                        num_image4.Image = Image.FromFile("Numeros\\" + numero[i] + ".jpg");
                                    }
                                }
                            }
                            painel_num.ActiveForm.Height = 300;
                            Title.Left = 100;
                            quadro_dicas.Visible = false;
                            submete.Visible = false;
                            comparacao.Visible = false;
                            comparacao.Text = "";
                            num_entrada.Visible = false;
                            Title.Text = "O número é";
                            MessageBox.Show("Parabens voce advinhou o numero em "+tentativas+" tentativas!!!", "Parabens!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (MessageBox.Show("Voce deseja jogar de novo?", "Jogar novamente!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cont = 0;
                                Processamento.cont1 = 0;
                                tentativas = 0;
                                Title.Left = 32;
                                quadro_dicas.Visible = true;
                                submete.Visible = true;
                                comparacao.Visible = true;
                                num_entrada.Visible = true;
                                quadro_dicas.Text = "              Dicas\n---------------------------------------";
                                painel_num.ActiveForm.Height = 405;
                                Title.Text = "Qual será o número?";
                                num_image.Image = Image.FromFile("int.png");
                                num_image2.Image = Image.FromFile("int.png");
                                num_image3.Image = Image.FromFile("int.png");
                                num_image4.Image = Image.FromFile("int.png");
                                num = Processamento.gera("numero");
                               //MessageBox.Show("" + num);
                            }
                            else
                            {
                                nao_travar = false;
                            }
                        }
                        else
                        {
                            if (cont == 3)
                            {
                                quadro_dicas.Text += Processamento.dica("numero");
                                cont = 0;
                            }
                        }
                    }     
                }
                num_entrada.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show("Por favor insira numeros! "+ex.StackTrace, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show(gera()+"");
        }

        private void num_image2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void tela_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Processamento.cont1 = 0;
            nao_travar = false;
            this.Hide();
            Menu a = new Menu();
            a.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void num_image3_Click(object sender, EventArgs e)
        {
        }
        private void num_image4_Click(object sender, EventArgs e)
        {
        }
    }
}
