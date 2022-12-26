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

//список
/*
- сделать телепорт
- сделать задание со снегом - окрашивание и счетчик 
 
- сделать ОТЧЕТ
*/



namespace courseWork
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>(); //лист эмиторов
        Emitter emitter; //поле для эмитора

        CountPoint countPoint; // добавил поле под точку счетчик
        RadarPoint radarPoint; // добавил поле под точку радар


        //когда я нажимаю на кнопку, нужно отрисовывать объекты в зависимости от задания 

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 270,
                Spreading = 200,
                SpeedMin = 1,
                SpeedMax = 10,
                ColorFrom = Color.OrangeRed,
                ColorTo = Color.FromArgb(0, Color.Yellow),
                ParticlesPerTick = 150,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / picDisplay.Height,
            };
            emitters.Add(this.emitter);
            countPoint = new CountPoint { X = picDisplay.Width / 2, Y = picDisplay.Height / 2, };
            radarPoint = new RadarPoint { X = picDisplay.Width, Y = picDisplay.Height, };
            emitter.impactPoints.Add(countPoint);
            emitter.impactPoints.Add(radarPoint);
        }
    

        //таймер для плавной отрисовки каждой частицы
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }
            //lb_Count.Text = $"{emitter1.particles.Where(particle => particle.Life > 0).Count()}"; // счётчик кол-ва частиц на форме в данный момент
            picDisplay.Invalidate();
        }
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;
            }
            radarPoint.X = e.X; // передаем положение мыши, в положение радара
            radarPoint.Y = e.Y;
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

        
    }
}
