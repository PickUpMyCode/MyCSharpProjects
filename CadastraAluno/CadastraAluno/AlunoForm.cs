using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastraAluno
{
    public partial class AlunoForm : Form
    {
        private BDConnect bd;
        public AlunoForm()
        {
            InitializeComponent();
            Define();
        }
        private void Define() {
            for (int i = 1990; i <= 2016; i++) {
                ano_cb.Items.Add(i);
            }
            for (int i = 1; i <= 30; i++) {
                dia_cb.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++) {
                mes_cb.Items.Add(i);
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AlunoForm_Load(object sender, EventArgs e)
        {

        }

        private void Ano_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bd = new BDConnect("root", "''", "escola", "localhost");
            if (bd.ConnectBD())
            {
                if (nome_txt.Text.Length <= 40 && nome_txt.Text.Length > 2 && matr_txt.Text.Length > 1 && CPF_txt.Text.Length == 11 && dia_cb.Text != "" && mes_cb.Text != "" && ano_cb.Text != "")
                {
                    DateTime data = new DateTime(int.Parse(ano_cb.Text), int.Parse(mes_cb.Text), int.Parse(dia_cb.Text));
                    Aluno aluno = new Aluno(nome_txt.Text, CPF_txt.Text, int.Parse(matr_txt.Text), data);
                    bd.Cadastrar(aluno);
                    bd.desconnectBD();
                    MessageBox.Show("Cadastrado!");
                }
                else {
                    MessageBox.Show("insira valores corretos");
                }
            }
            else {
                MessageBox.Show(bd.error);
            }
        }

        private void AlunoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Escola_BD form = new Escola_BD();
            form.Show();
            Hide();
        }
    }
}
