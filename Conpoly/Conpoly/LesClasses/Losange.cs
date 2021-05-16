using System;
using System.Collections.Generic;
using System.Text;

namespace Conpoly.LesClasses
{
    class Losange : Forme
    {

        public new void Dessine() // cette methode n'est pas override mais independante dans ce cas il faut mettre le mot cle  new
        {
            base.Dessine(); 
            // ici code specifiques pour dessiner un rectangle ou tous ce qui n'est pas dans la classe parent
            // dans une classe derive  il faut mettre tous les specifiques qui ne sont pas dans la classe de base
            Console.WriteLine("je dessine un losange");

        }
      /*
        public override void Efface()
        {
            base.Efface();
            // ici code specifiques pour Effacer un rectangle ou tous ce qui n'est pas dans la classe parent
            Console.WriteLine("effacer un cercle");

        }
      */
    }
}
