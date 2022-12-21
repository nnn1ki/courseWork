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
        List<Emitter> emitters = new List<Emitter>(); //лист эмиторов
        Emitter emitter; //поле для эмитора
        GravityPoint gravityPoint; 

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            { // можем задать параметры для этого эмитора
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

            // гравитон
            gravityPoint = new GravityPoint
            {
                X = (float)(picDisplay.Width * 0.25),
                Y = picDisplay.Height / 2
            };

            //emitter.impactPoints.Add(new GravityPoint
            //{
            //    X = (float)(picDisplay.Width * 0.25),
            //    Y = picDisplay.Height / 2
            //});

            //// в центре антигравитон
            //emitter.impactPoints.Add(new AntiGravityPoint
            //{
            //    X = picDisplay.Width / 2,
            //    Y = picDisplay.Height / 2
            //});

            // снова гравитон
            emitter.impactPoints.Add(new GravityPoint
            {
                X = (float)(picDisplay.Width * 0.75),
                Y = picDisplay.Height / 2
            });
        }
    

        //таймер для плавной отрисовки каждой частицы
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); //обновляем положение эмиттора

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); //очищяем перед отрисовкой
                emitter.Render(g); //рисуем
            }
            picDisplay.Invalidate();
        }

        //событие передвижения мышки по экрану
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунк
            lb1Direction.Text = $"{tbDirection.Value}°"; // добавил вывод значения
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value; 
            lbSpreading.Text = $"{tbSpreading.Value}°";
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = tbPerTic.Value;
            lbPerTic.Text = $"{tbPerTic.Value}"; 
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMax += tbSpeed.Value;
            lbSpeed.Text = $"{tbSpeed.Value}";
        }

        private void tbGraviti_Scroll(object sender, EventArgs e)
        {
            gravityPoint.Power = tbGraviti.Value;
            lbPower.Text = $"{tbGraviti.Value}";
        }
    }
}
