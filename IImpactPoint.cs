using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork
{
    //нужно сделать телепорт. Наследовать именно эти свойства? 

    //это два эмиттера, которые отрисовываются как круги
    //между двумя эмиторами надо будет построить прямую

    

    public abstract class IImpactPoint
    {
        public float X; // координата Х точки
        public float Y; // координата У точки
        public Color сolor = Color.OrangeRed; // начальный цвет частицы
        public abstract void ImpactParticle(Particle particle); // абстрактный метод с помощью которого будем изменять состояние частиц
        public virtual void Render(Graphics g) // базовый класс для отрисовки точечки
        {
            g.FillEllipse(new SolidBrush(Color.OrangeRed), X - 5, Y - 5, 10, 10);
        }

    }

    public class CountPoint : IImpactPoint
    {
        public int Radius = 100; // радиус
        public int Count = 0; // сам счётчик
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            var p = (particle as ParticleColorful);
            if (r + particle.Radius < Radius / 2) // если частица оказалось внутри окружности
            {
                p.Radius = 0; // чтобы частица не мешалась еще сколько то тиков при смерти, делаю радиус 0
                p.Life = 0; // а частица умерла туть(
                Count++; // а счётчик прибавился туть)
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse( // окружность с диаметром равным Radius
                    new Pen(Color.OrangeRed, 2),
                    X - Radius / 2,
                    Y - Radius / 2,
                    Radius,
                    Radius);
            var stringFormat = new StringFormat(); // экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали
            g.DrawString(
                    $"{Count}",
                    new Font("Verdana", 14),
                    new SolidBrush(Color.OrangeRed),
                    X, Y, stringFormat);
        }
    }



    public class RadarPoint : IImpactPoint
    {
        public int Radius = 100; // радиус
        List<Particle> radarParticles = new List<Particle>(); // место хранения частиц, которые попали во внутрь
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            var p = (particle as ParticleColorful);
            if (r + particle.Radius <= Radius / 2) // если частица оказалось внутри окружности или на окуржности
            {
                radarParticles.Add(p); // добавляем ее в лист частиц, которые внутри
                if (сolor == Color.OrangeRed) // здесь меняем цвет на медиумспрниггрин
                {
                    p.FromColor = Color.MediumSpringGreen;
                    p.ToColor = Color.MediumSpringGreen;
                }
            }
            if (r + particle.Radius > Radius / 2) // если частица оказалось вне окружности
            {
                radarParticles.Remove(p); // удаляем ее из листа частиц, котрые внутри
                if (сolor == Color.OrangeRed) // здесь меняем цвет обратно на оранжред
                {
                    p.FromColor = Color.OrangeRed;
                    p.ToColor = Color.Yellow;
                }
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse( // окружность с диаметром равным Radius
                 new Pen(Color.MediumSpringGreen, 2),
                 X - Radius / 2,
                 Y - Radius / 2,
                 Radius,
                 Radius
            );
            
            var stringFormat = new StringFormat(); // экземпляр класса
            stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
            stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали
            g.DrawString(
                 $"{radarParticles.Count}",
                 new Font("Verdana", 14),
                 new SolidBrush(Color.White),
                 X, Y, stringFormat
            );
        }
    }


}
