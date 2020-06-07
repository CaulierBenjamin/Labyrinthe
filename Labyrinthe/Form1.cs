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
            CreationPlateau(n1.GetPlateau());
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            Map n1 = new Map("plateauMed");
            CreationPlateau(n1.GetPlateau());
        }

        private void buttonDifficile_Click(object sender, EventArgs e)
        {
            Map n1 = new Map("plateauGen");
            CreationPlateau(n1.GetPlateau());
        }

        public void CreationPlateau(int[,] pPlateau)
        {
            this.labelTitre.Visible = false;
            this.labelDifficulter.Visible = false;
            this.labelUser.Visible = false;
            this.buttonDifficile.Visible = false;
            this.buttonNormal.Visible = false;
            this.buttonFacile.Visible = false;
            this.buttonUser.Visible = false;
            //Creation du contoure du plateau
            int sidex = pPlateau.GetLength(0) + 2;
            int sidey = pPlateau.GetLength(1)+1;
            for (int i = 0; i < sidex; i++)
            {
                CreatePictuebox(i*30,0 ,@"\mur.png");
                
                CreatePictuebox(i*30,sidey*30 ,@"\mur.png");
                
            }
                
            for (int i = 0; i < sidey; i++)
            {
                CreatePictuebox(0,30 + i*30 ,@"\mur.png");
                
                CreatePictuebox(sidex*30,0 + i*30 ,@"\mur.png");
                
            }
            CreatePictuebox(sidex*30,sidey*30 ,@"\mur.png");
            
            //Creation du plateau
            int x = 30;
            int y = 30;
            for (int i = 0; i < pPlateau.GetLength(1); i++)
            {
                for (int j = 0; j < pPlateau.GetLength(0); j++)
                {
                    if (pPlateau[j, i] == 1)
                    {
                        CreatePictuebox(x,y,@"\mur.png");
                    }
                    else if (pPlateau[j, i] == 2)
                    {
                        picturebox1 = new PictureBox();
                        Controls.Add(picturebox1);
                        picturebox1.Name = "picturebox1";
                        picturebox1.Location = new Point(x, y);
                        picturebox1.Size = new Size(30, 30);
                        picturebox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        picturebox1.BackColor = Color.Red;
                    }
                    x = x +30;
                }
                x = 30;
                y =y+30;
            }
        }

        public void CreatePictuebox(int prmX, int prmY, string prmImage)
        {
            picturebox1 = new PictureBox();
            Controls.Add(picturebox1);
            picturebox1.Name = "picturebox1";
            picturebox1.Location = new Point(prmX, prmY);
            picturebox1.Size = new Size(30, 30);
            picturebox1.SizeMode = PictureBoxSizeMode.CenterImage;
            picturebox1.Image = Image.FromFile(@"" + (AppDomain.CurrentDomain.BaseDirectory) + @""+prmImage);
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                picturebox1.Visible = false;
            }
            
        }
    }
}