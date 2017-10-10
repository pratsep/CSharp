using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineKohtumine
{
    class Punkt
    {
        private int _x, _y;

        public Punkt(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public double kaugusNullist()
        {
            double kaugus = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));
            return kaugus;
        }
        public void teataAndmed()
        {
            Console.WriteLine("Punkt on koordinaatidega x:" + _x + " ja y:" + _y);
        }

        public double kaugusTeisestPunktist(int x, int y)
        {
            double kaugus = Math.Sqrt((Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2)));
            return kaugus;
        }
        public bool kasOnAlgusPunkt()
        {
            if (_x == 0 && _y == 0)
            {
                return true;
            }
            return false;
        }
    }
}
