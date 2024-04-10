using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritance
{
    public enum StarColor { blue, white, yellow, orange, red };
    public enum CometName { B999C, GH56, YO817, TL62, NE555 };
    public class CosmicObject 
    {
        protected int mas = 0; // масса
        protected static Random rnd = new Random();
        public virtual String GetInfo()
        {
            var str = String.Format("\nМасса: {0}", this.mas);
            return str;
        }
        public virtual String getType()
        {
            return "Я космический объект";
        }

    }


    public class Planet : CosmicObject
    {
        private int radius = 0; // радиус
        private bool withAtmosphere = false; // наличие атмосферы
        private int gravitationalForce = 0; // сила притяжения

        public override String GetInfo()
        {
            var str = "Я планета";

            //txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
            str += base.GetInfo();
            str += String.Format("\nРадиус: {0}", this.radius);
            str += String.Format("\nНаличеие атмосферы: {0}", this.withAtmosphere);
            str += String.Format("\nСила гравитации: {0}", this.gravitationalForce);
            return str;
        }
        public static Planet Generate()
        {
            return new Planet
            {
                mas = rnd.Next() % 10000, // масса от 0 до 10000
                radius = rnd.Next() % 10000, // радиус от 0 до 10000
                withAtmosphere = rnd.Next() % 2 == 0, // атмосфера true/false
                gravitationalForce = rnd.Next() % 100 // гравитация от 0 до 100
            };
        }
    }
    
    public class Star : CosmicObject
    {
        private int density = 0; // плотность
        private StarColor color = StarColor.red; // цвет
        private int temp = 0; // температура
        public override String GetInfo()
        {
            var str = "Я звезда";
            str += base.GetInfo();
            str += String.Format("\nПлотность: {0}", this.density);
            str += String.Format("\nЦвет: {0}", this.color);
            str += String.Format("\nТемпература: {0}", this.temp);
            return str;

        }
        public static Star Generate()
        {
            return new Star
            {
                mas = rnd.Next() % 10000, // масса от 0 до 10000
                density = rnd.Next() % 10000, // плотность от 0 до 10000
                color = (StarColor)rnd.Next(5), // цвет
                temp = -1000 + rnd.Next() % 10000 // температура от -1000 до 9000
            };
        }
    }
   
    public class Comet : CosmicObject
    {
        private int period = 0; // период
        private CometName name = CometName.GH56; // название
        public override String GetInfo()
        {
            var str = "Я комета";
            str += base.GetInfo();
            str += String.Format("\nПериод прохождения: {0}", this.period);
            str += String.Format("\nНазвание: {0}", this.name);
            return str;
        }
        public static Comet Generate()
        {
            
            return new Comet
            {
                mas = rnd.Next() % 10000, // масса от 0 до 10000
                period = 1 + rnd.Next() % 10000, // Период от 1 до 10001
                name = (CometName)rnd.Next(5), // имя
            };
        }
    }
}