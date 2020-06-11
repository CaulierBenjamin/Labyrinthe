using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinthe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Joueur.Verification(Textusername.Text);
            Joueur test = new Joueur(textUser.Text);
            labelUser.Dispose();
            textUser.Dispose();
            buttonUser.Dispose();
           
            buttonDifficile.Visible = true;
            buttonFacile.Visible = true;
            buttonNormal.Visible = true;
            labelDifficulter.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFacile_Click(object sender, EventArgs e)
        {
            Map n1 = new Map("plateauDeb");
            Form2 main = new Form2();
            main.Show();
            this.Visible = false;
            main.CreationPlateau(n1.GetPlateau());
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            Map n1 = new Map("plateauMed");
            Form2 main = new Form2();
            main.Show();
            this.Visible = false;
            main.CreationPlateau(n1.GetPlateau());
        }

        private void buttonDifficile_Click(object sender, EventArgs e)
        {
            Map n1 = new Map("plateauGen");
            Form2 main = new Form2();
            main.Show();
            this.Visible = false;
            main.CreationPlateau(n1.GetPlateau());
        }
        
    }
}