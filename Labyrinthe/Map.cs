using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Labyrinthe
{
    public class Map
    {
        private string nom;
        private int[,] plateau;

        public Map(string prmNom)
        {
            this.nom = prmNom;
            string repertoire = AppDomain.CurrentDomain.BaseDirectory;
            plateau = new int[20,15];
            StreamReader reader = new StreamReader(@""+repertoire+@"\plateauDeb.txt");
            
            switch (prmNom)
            {
                case "plateauMed":
                    plateau = new int[30,20];
                    reader = new StreamReader(@""+repertoire+@"\plateauMed.txt");
                    break;
                case "plateauGen":
                    plateau = new int[40,25];
                    reader = new StreamReader(@""+repertoire+@"\plateauGen.txt");
                    break;
            }

            string ligne;
            int idxLigne = 0;
            while ((ligne = reader.ReadLine()) != null)
            {
                for (int i = 0; i < ligne.Length; i++)
                {
                    plateau[i, idxLigne] = Convert.ToInt32(ligne[i].ToString());
                }
                idxLigne++;
            }
        }

        public int[,] GetPlateau()
        {
            return plateau;
        }
    }
}