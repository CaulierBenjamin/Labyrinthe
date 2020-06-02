namespace Labyrinthe
{
    public class Joueur
    {
        private string username;
        private int score;

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
    }
}