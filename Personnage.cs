using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame
{
    public abstract class Personnage : Entite
    {
        private int niveau;
        private int experience;

        public Personnage(string nom) : base(nom)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }

        public void gagnerExperience(int experience)
        {
            this.experience += experience;
            while (this.experience >= experienceRequise())
            {
                niveau += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Bravo ! Vous avez atteind le niveau " + niveau + " !");

                pointsDeVie += 10;
                degatsMin += 2;
                degatsMax += 2;
            }
        }

        public double experienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }

        public string Caracteristiques()
        {
            return this.nom + "\n" +
                "Points de vie : " + pointsDeVie + "\n" +
                "Niveau : " + niveau + "\n" +
                "Points d'experiences : (" + experience + "/" + experienceRequise() + ")\n" +
                "Dégats : [" + degatsMin + ";" + degatsMax + "]";
        }
    }
}
