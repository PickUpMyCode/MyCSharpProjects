using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Jogo_da_Velha
{
    public partial class form_main : Form
    {
        public static form_main instance;
        private static bool onClick = false;
        public static bool isConfOpened = false;
        private int difX, difY;
        private static string FilenameX = "";
        private static string FilenameO = "";
        public static string Player1, Player2;
        private int point1 = 0, point2 = 0;
        private static Image imgX, imgO;
        private bool player1 = true, jogofinalizado = false;
        private static int width = 100, height = 100;
        private char[,] j = { { ' ', ' ', ' ', }, { ' ', ' ', ' ', }, { ' ', ' ', ' ' } };
        public form_main()
        {
            InitializeComponent();
            instance = this;
            ConfigurationFeatures.setPlayer1Name("Player1");
            ConfigurationFeatures.setPlayer2Name("Player2");
            Player1 = "Player1";
            Player2 = "Player2";
            lbl_ptname1.Text = "Player1";
            lbl_ptname2.Text = "Player2";
            currentPlayerTurn(true);
            try
            {
                imgX = pictureBox1.Image;
                imgO = pictureBox2.Image;
                lbl_currentimg1.Image = imgX;
                lbl_currentimg2.Image = imgO;
            }
            catch  {
                MessageBox.Show("Image not found!");
            }
        }
        private void currentPlayerTurn(bool current) {
            if (current)
            {
                lbl_ptname1.ForeColor = Color.Blue;
                lbl_ptname2.ForeColor = Color.Black;
            }
            else
            {
                lbl_ptname2.ForeColor = Color.Blue;
                lbl_ptname1.ForeColor = Color.Black;
            }
        }
        private void definiganhador()
        {
            if (player1)
            {
                lbl_ptname2.ForeColor = Color.Black;
                lbl_ptname1.ForeColor = Color.Black;
                MessageBox.Show(Player2+" ganhou!", "PARABENS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                point2++;
                btn_reniciar.Visible = true;
                lbl_p2.Text = point2.ToString();
                lbl_title.Text = Player2+" VENCEU O JOGO!";
                return;
            }
            else
            {
                lbl_ptname2.ForeColor = Color.Black;
                lbl_ptname1.ForeColor = Color.Black;
                MessageBox.Show(Player1+" ganhou!", "PARABENS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_reniciar.Visible = true;
                point1++;
                lbl_p1.Text = point1.ToString();
                lbl_title.Text = Player1+" VENCEU O JOGO!";
                return;
            }
        }
        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);

                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            
            return destImage;
        }
        public static void setFilePl1(string FilePl1) {
            try
            {
                FilenameX = FilePl1;
                Bitmap x = new Bitmap(@FilenameX);
                imgX = ResizeImage(x, width, height);
                instance.lbl_currentimg1.Image = imgX;
            }
            catch { MessageBox.Show("Ocorreu um erro! Verifique se o caminho esta correto!"); }
        }
        public static void setFilePl2(string FilePl2)
        {
            try { 
                FilenameO = FilePl2;
                Bitmap o = new Bitmap(@FilenameO);
                imgO = ResizeImage(o, width, height);
                instance.lbl_currentimg2.Image = imgO;
            }
            catch { MessageBox.Show("Ocorreu um erro! Verifique se o caminho esta correto!"); }
}
        private void  verifica() {
            if(j[0, 0] == j[0, 1] && j[0, 1] == j[0, 2] && j[0, 0] != ' ' ){
                jogofinalizado = true;
                definiganhador();         

            }else  if(j[1, 0] == j[1, 1] && j[1, 1] == j[1, 2] && j[1, 0] != ' '){
                jogofinalizado = true;
                definiganhador();
            }
            else if (j[2, 0] == j[2, 1] && j[2, 1] == j[2, 2] && j[2, 0] != ' ')
            {
                jogofinalizado = true;
                definiganhador();
            }
            else if (j[0, 0] == j[1, 0] && j[1, 0] == j[2, 0] && j[0, 0] != ' ')
            {
                jogofinalizado = true;
                definiganhador();
            }
            else if (j[0, 1] == j[1, 1] && j[1, 1] == j[2, 1] && j[0, 1]  != ' ')
            {
                jogofinalizado = true;
                definiganhador();
            }
            else if (j[0,2] == j[1, 2] && j[1, 2] == j[2, 2] && j[0, 2] != ' ') 
            {
                jogofinalizado = true;
                definiganhador();
            }
            else if (j[0, 0] == j[1, 1] && j[1, 1] == j[2, 2] && j[0, 0] != ' ')
            {
                jogofinalizado = true;
                definiganhador();
            }
            else if (j[0, 2] == j[1, 1] && j[1, 1] == j[2, 0] && j[0, 2] != ' ')
            {
                jogofinalizado = true;
                definiganhador();
            }
            else {
                int cont = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (j[i, k] != ' ')
                        {
                            cont++;
                        }
                        else {
                            cont--;
                        }
                    }
                }
                if(cont == 9){
                    lbl_ptname2.ForeColor = Color.Black;
                    lbl_ptname1.ForeColor = Color.Black;
                    MessageBox.Show("Deu Veia!", "OPA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btn_reniciar.Visible = true;
                    return;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if(!jogofinalizado){
                if(j[0, 0] == ' '){
                    if (player1)
                    {
                        j[0, 0] = 'X';
                        button1.Image = imgX;
                        player1 = false;
                   
                    }
                    else
                    {
                        j[0, 0] = 'O';
                        button1.Image = imgO;
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!jogofinalizado)
            {
               
                if (j[0, 1] == ' ')
                {
                    if (player1)
                    {
                        j[0, 1] = 'X';
                        
                        button2.Image = imgX;
                        player1 = false;
                    }
                    else
                    {
                        j[0, 1] = 'O';
                        button2.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            if (!jogofinalizado)
            {
                
                if (j[0, 2] == ' ')
                {
                    if (player1)
                    {
                        j[0, 2] = 'X';
                        button3.Image = imgX;
                        
                        player1 = false;
                    }
                    else
                    {
                        j[0, 2] = 'O';
                        button3.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!jogofinalizado)
            {
               
                if (j[1, 0] == ' ')
                {
                    if (player1)
                    {
                        j[1, 0] = 'X';
                        button4.Image = imgX;
                        
                        player1 = false;
                    }
                    else
                    {
                        j[1, 0] = 'O';
                        button4.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            if (!jogofinalizado)
            {
               
                if (j[1, 1] == ' ')
                {
                    if (player1)
                    {
                        j[1, 1] = 'X';
                        button5.Image = imgX;
                        
                        player1 = false;
                    }
                    else
                    {
                        j[1, 1] = 'O';
                        button5.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!jogofinalizado)
            {
             
                if (j[1, 2] == ' ')
                {
                    if (player1)
                    {
                        j[1, 2] = 'X';
                        button6.Image = imgX;
                        player1 = false;
                        
                    }
                    else
                    {
                        j[1, 2] = 'O';
                        button6.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!jogofinalizado)
            {
               
                if (j[2, 2] == ' ')
                {
                    if (player1)
                    {
                        j[2, 2] = 'X';
                        button9.Image = imgX;
                        
                        player1 = false;
                    }
                    else
                    {
                        j[2, 2] = 'O';
                        button9.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!jogofinalizado)
            {
               
                if (j[2, 1] == ' ')
                {
                    if (player1)
                    {
                        j[2, 1] = 'X';
                        button8.Image = imgX;
                        
                        player1 = false;
                    }
                    else
                    {
                        j[2, 1] = 'O';
                        button8.Image = imgO;
                        
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void _Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            lbl_ptname1.Text = ConfigurationFeatures.player1Name;
            lbl_ptname2.Text = ConfigurationFeatures.player2Name;
        }

        private void Config_Click(object sender, EventArgs e)
        {
            if (!isConfOpened) {
                form_config cfg = new form_config();
                cfg.Show();
                isConfOpened = true;
            }
        }

        private void Label8_MouseMove(object sender, MouseEventArgs e)
        {
            moveform();
        }
        private void moveform() {

            if (onClick)
            {
                int Xscreen = MousePosition.X;
                int Yscreen = MousePosition.Y;
                int X = Xscreen - difX;
                int Y = Yscreen - difY;
               Location = new Point(X, Y);
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Lbl_currentimg2_Click(object sender, EventArgs e)
        {

        }

        private void Label8_MouseUp(object sender, MouseEventArgs e)
        {
            onClick = false;
        }

        private void Label8_MouseDown(object sender, MouseEventArgs e)
        {

            onClick = true;
            difX = PointToClient(Cursor.Position).X;
            difY = PointToClient(Cursor.Position).Y;
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!jogofinalizado)
            { 
                if (j[2, 0] == ' ')
                {
                    if (player1)
                    {
                        j[2, 0] = 'X';
                        button7.Image = imgX;                      
                        player1 = false;
                    }
                    else
                    {
                        j[2, 0] = 'O';
                        button7.Image = imgO;
                        player1 = true;
                    }
                }
                currentPlayerTurn(player1);
                verifica();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char[,] h =  {{' ', ' ', ' ',}, {' ', ' ', ' ',}, { ' ', ' ' , ' '}};
            j = h;
            lbl_title.Text = "JOGO DA VELHA";
            if (player1) {
                player1 = false;
            }
            else { player1 = true; }
            currentPlayerTurn(player1);
            btn_reniciar.Visible = false;
            jogofinalizado = false;
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
        }
    }
}
