using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Juego_Submarino
{
    public partial class Form1 : Form
    {
        int Distancia = 0;
        bool VolarArriba = false;
        Random posicionRandom = new Random();
        SoundPlayer cancion = new SoundPlayer("D:/VS22/All Documents/Juego Submarino/Juego Submarino/Resources/musica.wav");
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            cancion.Play();
        }

        public void IniciarJuego()
        {
            Player.Location = new Point(12, 188);
            Distancia = posicionRandom.Next(-160, 118);
            ObstaculoArriba.Location = new Point(270, -173 - Distancia);
            ObstaculoAbajo.Location = new Point(270, 319 - Distancia);
            Puntaje.Text = "0";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ObtaculoArriba_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ly = Player.Location.Y;
            int lx = Player.Location.X;

            if (VolarArriba)
            {
                ly = ly - 15;
                VolarArriba = false;
            }
            else
            {
                ly++;
            }

            Player.Location = new Point(Player.Location.X, ly);

            if ((Player.Bounds.IntersectsWith(Obstaculo.Bounds)) || (Player.Bounds.IntersectsWith(ObstaculoArriba.Bounds)) || (Player.Bounds.IntersectsWith(ObstaculoAbajo.Bounds)))
            {
                IniciarJuego();
            }

            Puntaje.Location = new Point(Player.Location.X + 30, Player.Location.Y - 25);
            Puntaje.Text = (ObstaculoArriba.Location.X == Player.Location.X) ? Convert.ToString((Convert.ToInt32(Puntaje.Text) + 1)).ToString() : Puntaje.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                VolarArriba = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ObstaculoAbajo.Location.X > -140)
            {
                ObstaculoAbajo.Location = new Point((ObstaculoAbajo.Location.X) - 1, ObstaculoAbajo.Location.Y);
                ObstaculoArriba.Location = new Point((ObstaculoArriba.Location.X) - 1, ObstaculoArriba.Location.Y);
            }
            else
            {
                Distancia = posicionRandom.Next(-170, 118);
                ObstaculoAbajo.Location = new Point(280, 319 + Distancia);
                ObstaculoArriba.Location = new Point(280, -173 + Distancia);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Obstaculo.Location = (Obstaculo.Location.X > -480) ? new Point((Obstaculo.Location.X) - 1, Obstaculo.Location.Y) : Obstaculo.Location = new Point(-9, Obstaculo.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
