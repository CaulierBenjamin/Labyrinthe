using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labyrinthe
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        
        public void CreationPlateau(int[,] pPlateau)
        {
           
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

        private void TextBox1_KeyDown(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show( $"KeyDown code: {e.KeyCode}, value: {e.KeyValue}, modifiers: {e.Modifiers}" + "\r\n");

        }
    }
}