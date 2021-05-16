using Conpoly.LesClasses;
using System;
using System.Collections.Generic;



namespace Conpoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Forme> dessin = new List<Forme>();
            dessin.Add(new Rectangle());
            dessin.Add(new Triangle());
            dessin.Add(new Cercle());
            dessin.Add(new Losange());
            Losange monlosange = new Losange();  // methode instancie
            monlosange.Dessine();




            foreach (Forme f in dessin)
            {
               f.Dessine();
                f.Efface();
            }

            Console.ReadKey();


        }
    }
}
