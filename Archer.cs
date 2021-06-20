using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 105;
            degatsMin = 15;
            degatsMax = 20;
        }
    }
}
