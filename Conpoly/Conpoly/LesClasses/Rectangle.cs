using System;
using System.Collections.Generic;
using System.Text;

namespace Conpoly.LesClasses
{
    class Rectangle : Forme
    {

        public override void Dessine()
        {
            base.Dessine(); 
            // ici code specifiques pour dessiner un rectangle ou tous ce qui n'est pas dans la classe parent
            // dans une classe derive  il faut mettre tous les specifiques qui ne sont pas dans la classe de base
            Console.WriteLine("je dessine un rectangle");

        }
        public override void Efface()
        {
            base.Efface();
            // ici code specifiques pour Effacer un rectangle ou tous ce qui n'est pas dans la classe parent
            Console.WriteLine("effacer un rectangle");

        }

    }
}
