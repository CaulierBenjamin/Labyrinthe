using System;
using System.Windows.Forms;

namespace Labyrinthe
{
    public class Joueur
    {
        private string username;
        private int score;
        private int x;
        private int y;

        public Joueur(string prmUsername)
        {
            this.username = prmUsername;
        }

        public string GetUsername()
        {
            return this.username;
        }

        /*public bool Verification(string prmUserName)
        {
            
        }*/
        public static bool Move(KeyPressEventArgs touche)
        {
            if (touche.KeyChar == (char)Keys.Z)
            {
                MessageBox.Show("test");
            }

            
            switch (touche.KeyChar)
            {
                case (char)Keys.Return:
                    return true;
                    
                    break;
                case (char)Keys.Z:
                    
                    break;
                case (char)Keys.Q:
                    
                    break;
                case (char)Keys.S:
                    
                    break;
                case (char)Keys.D:
                    
                    break;
                
            }

            return false;
        }
    }
}