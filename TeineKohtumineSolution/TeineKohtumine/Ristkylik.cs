using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineKohtumine
{
    //Vaikimisi on see klass internal
    //See tähendab, et tegemist on klassiga mis on nähtav terve selle assembly(ehk konkreetse projekti sees)
    class Ristkylik
    {
        private int _pikkus, _laius;
        
        //Konstruktor. Kui luuakse uus konstruktor siis tühja konstruktorit enam pole.
        public Ristkylik(int pikkus, int laius)
        {
            _pikkus = pikkus;
            _laius = laius;
        }
        
        //Arvuta pindala
        //Kas meetid peaks midagi tagastama? Pindala(int)
        //Mis peaks olema nimi? Arvuta pindala
        //Kas meetod vajab sisendparameetried? Ei
        public int arvutaPindala()
        {
            return _pikkus * _laius;
        }
        public int arvutaYmbermoot()
        {
            return (_pikkus + _laius)*2;
        }

        //Kas meetod peaks peaks olema static? ei
        //Mis peaks olema nimi? kasOnVordsed
        //Kas meetod vajab sisendparameetreid? Jah, ristkylikut millega võrrelda
        public bool kasOnVordsed(Ristkylik r)
        {
            if ((r._laius == this._laius && r._pikkus == this._pikkus) || (r._laius == this._pikkus && r._pikkus == this._laius))
            {
                return true;
            }
            return false;
        }

        public bool kasRuut()
        {
            if (_laius == _pikkus)
            {
                return true;
            }
            return false;
        }
    }
}
