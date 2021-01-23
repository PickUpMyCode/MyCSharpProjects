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
    public partial class Escola_BD : Form
    {
        public Escola_BD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
  
        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoForm form = new AlunoForm();
            form.Show();
            Hide();
        }

        private void CadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TurmaForm form = new TurmaForm();
            form.Show();
            Hide();
        }

        private void Escola_BD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
