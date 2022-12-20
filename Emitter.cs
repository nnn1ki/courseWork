using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWork
{
    class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public int MousePositionX;
        public int MousePositionY;

        public float GravitationX = 0;
        public float GravitationY = 1; 

        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1;
                if (particle.Life < 0)
                {
                    // тоже не трогаем
                    particle.Life = 20 + Particle.rand.Next(100);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;

                    var direction = (double)Particle.rand.Next(360);
                    var speed = 1 + Particle.rand.Next(10);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

                    particle.Radius = 2 + Particle.rand.Next(10);
                }
                else
                {
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    // это не трогаем
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }

                for (var i = 0; i < 10; ++i)
                {
                    if (particles.Count < 500)
                    {
                        var part = new ParticleColorful();
                        
                        part.FromColor = Color.Black;
                        part.ToColor = Color.FromArgb(0, Color.Magenta);
                        part.X = MousePositionX;
                        part.Y = MousePositionY;
                        particles.Add(part);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public virtual void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }
    }
}
