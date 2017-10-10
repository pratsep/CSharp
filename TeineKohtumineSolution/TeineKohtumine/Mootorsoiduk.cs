using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineKohtumine
{
    class Mootorsoiduk
    {
        private int _kiirus = 0;
        private int _max_kiirus;
        public Mootorsoiduk(int max_kiirus)
        {
            _max_kiirus = max_kiirus;
        }

        public void Kiirenda()
        {
            _kiirus = _kiirus + 10;
        }
        public void Kiirenda(int kiirus)
        {
            _kiirus = _kiirus + kiirus;
        }
        public void Stop()
        {
            _kiirus = 0;
        }
        public string Hetkeseis()
        {
            if(_kiirus == 0)
            {
                return "Auto seisab";
            }
            else
            {
                return "Auto sõidab kiirusega " + _kiirus + "km/h";
            }
        }
        public void ToString()
        {
            Console.WriteLine(Hetkeseis());
        }
    }
}
