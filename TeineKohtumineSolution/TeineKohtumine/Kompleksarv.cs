using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineKohtumine
{
    class Kompleksarv
    {
        private int _reaalosa, _imaginaarosa;
        public Kompleksarv(int reaalosa, int imaginaarosa)
            {
                _reaalosa = reaalosa;
                _imaginaarosa = imaginaarosa;
            }
        public void Liida(Kompleksarv k)
        {
            int reaalosa_tulemus = this._reaalosa + k._reaalosa;
            int imaginaarosa_tulemus = this._imaginaarosa + k._imaginaarosa;
            if(imaginaarosa_tulemus >= 0)
            {
                Console.WriteLine("Liitsite kompleksarvud ja tulemus on " + reaalosa_tulemus + "+" + imaginaarosa_tulemus + "i");
            }
            else
            {
                Console.WriteLine("Liitsite kompleksarvud ja tulemus on " + reaalosa_tulemus +""+ imaginaarosa_tulemus + "i");
            }

        }
        //public void Liida(Kompleksarv k, out int reaalosa_tulemus, out int imaginaarosa_tulemus)
        //{
        //    reaalosa_tulemus = this._reaalosa + k._reaalosa;
        //    imaginaarosa_tulemus = this._imaginaarosa + k._imaginaarosa;
        //}
        public void Lahuta(Kompleksarv k)
        {
            int reaalosa_tulemus = this._reaalosa - k._reaalosa;
            int imaginaarosa_tulemus = this._imaginaarosa - k._imaginaarosa;
            if (imaginaarosa_tulemus >= 0)
            {
                Console.WriteLine("Lahutasite kompleksarvud ja tulemus on " + reaalosa_tulemus + "+" + imaginaarosa_tulemus + "i");
            }
            else
            {
                Console.WriteLine("Lahutasite kompleksarvud ja tulemus on " + reaalosa_tulemus + "" + imaginaarosa_tulemus + "i");
            }

        }
    }

    

}
