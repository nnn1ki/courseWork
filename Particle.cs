using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace courseWork
{
    public class Particle
    {
        public int Radius; 
        public float X; 
        public float Y;
        public float SpeedX; 
        public float SpeedY; 

        public float Life; 
        public static Random rand = new Random();

        //конструктор класса 
        public Particle()
        {
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);

            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed); //задаем векторную скорость по иксу
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed); //задаем векторную скорость по игрику

            Radius = 2 + rand.Next(10); //генерируем радиус частицы
            Life = 20 + rand.Next(100); //ее время жизни
        }

        //отрисовка частицы
        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100); //коэф прозрачности
            int alpha = (int)(k * 255); //измение цвета из-за прозрачности

            var color = Color.FromArgb(alpha, Color.White); 
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }

    }

    //подкласс цыетных частиц
    public class ParticleColorful : Particle
    {
        public Color FromColor; //начальный цыет
        public Color ToColor; //конечный цвет

        //смешивание цыетов
        public static Color MixColor(Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1 - k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k))
            );
        }

        //отрисовка на экране 
        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            var color = MixColor(ToColor, FromColor, k);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }
    }
}
