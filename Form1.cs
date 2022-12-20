using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courseWork
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter(); // добавили эмиттер

        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            // гравитон
            emitter.impactPoints.Add(new GravityPoint
            {
                X = (float)(picDisplay.Width * 0.25),
                Y = picDisplay.Height / 2
            });

            // в центре антигравитон
            emitter.impactPoints.Add(new AntiGravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            });

            // снова гравитон
            emitter.impactPoints.Add(new GravityPoint
            {
                X = (float)(picDisplay.Width * 0.75),
                Y = picDisplay.Height / 2
            });
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); 

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g);
            }
            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }
    }
}
