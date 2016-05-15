using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBirds
{
    class World
    {
        public static int tempurature = 0;
        public static int windSpeed = 0;
    }

    abstract class Birds : World
    {
        protected int distanceTravled { get; set; }

        public virtual void hop()
        {
            throw new ApplicationException("don't hop!");
        }

        public virtual void fly()
        {
            throw new ApplicationException("can't fly!");
        }

        public Birds ()
        {
            distanceTravled = 0;
        }

        public int getDistanceTravled
        {
            get { return distanceTravled; }
        }
    }

    class Penguin : Birds
    {
        public override void hop()
        {
            distanceTravled += 2;
        }
        
        public override void fly()
        {
            try
            {
                base.fly();
            }
            catch (Exception e)
            {
                String msg = "Penguins " + e;
            }
        }
    }

    class Hawk : Birds
    {
        public override void hop()
        {
            try
            {
                base.hop();
            }
            catch (Exception e)
            {
                String msg = "Hawks " + e;
            }
        }

        public override void fly ()
        {
            if (windSpeed <= 40)
                distanceTravled += 100;
        }
    }

    class Robin : Birds
    {
        public override void hop()
        {
            if (tempurature >= 0)
                distanceTravled += 1;
        }

        public override void fly()
        {
            if (windSpeed <= 20)
                distanceTravled += 20;
        }
    }

    class Crow : Birds
    {
        public override void hop()
        {
            if (tempurature >= 0)
                distanceTravled += 1;
        }

        public override void fly()
        {
            if (windSpeed <= 25)
                distanceTravled += 30;
        }
    }
}
