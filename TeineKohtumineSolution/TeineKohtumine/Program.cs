using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeineKohtumine
{
    class Program
    {
        static void Main(string[] args)
        {
            Ristkylik esimeneRistkylik = new Ristkylik(2, 3);
            Ristkylik teineRistkylik = new Ristkylik(3, 2);
            Console.WriteLine("Ristküliku pindala on " + esimeneRistkylik.arvutaPindala());
            Console.WriteLine("Ristküliku ümbermõõt on " + esimeneRistkylik.arvutaYmbermoot());
            Console.WriteLine("Kas võrdsed? " + esimeneRistkylik.kasOnVordsed(teineRistkylik));
            Console.WriteLine("Kas ruut? " + esimeneRistkylik.kasRuut());

            Punkt esimenePunkt = new Punkt(3, 4);
            Console.WriteLine("Punkti kaugus nullpunktist on " + esimenePunkt.kaugusNullist());
            esimenePunkt.teataAndmed();
            Console.WriteLine("Kaugus punktist on " + esimenePunkt.kaugusTeisestPunktist(0, 0));
            Console.WriteLine("Kas on alguspunkt? " + esimenePunkt.kasOnAlgusPunkt());

            Kompleksarv esimeneKompleksarv = new Kompleksarv(4, 5);
            Kompleksarv teineKompleksarv = new Kompleksarv(-2, 4);
            esimeneKompleksarv.Liida(teineKompleksarv);
            esimeneKompleksarv.Lahuta(teineKompleksarv);
            Console.WriteLine();

            Mootorsoiduk auto = new Mootorsoiduk(90);
            Console.WriteLine(auto);
            auto.Kiirenda();
            Console.WriteLine(auto);
            auto.Kiirenda(14);
            Console.WriteLine(auto);
            auto.Stop();
            Console.WriteLine(auto);


            //int tulemus = new Ristkylik(2, 3).arvutaPindala();
            Console.ReadLine();
        }
    }


}
