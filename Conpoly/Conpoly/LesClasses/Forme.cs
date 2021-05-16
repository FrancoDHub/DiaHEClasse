using System;
using System.Collections.Generic;
using System.Text;

namespace Conpoly.LesClasses
{
    class Forme
    {
        public int Hauteur { get; set; }
        public int Largeur { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public virtual void Dessine() // ici code commun pour dessiner les formes
        {
            Console.WriteLine("On est dans la classe de base des formes");
        }
        public virtual void Efface() // ici code commun pour effacer les formes
        {
            Console.WriteLine("Oui on est dans la classe de base des formes");

        }
    }
}
