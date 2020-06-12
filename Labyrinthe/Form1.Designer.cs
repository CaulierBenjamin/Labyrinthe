namespace Labyrinthe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textUser = new System.Windows.Forms.TextBox();
            this.buttonUser = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDifficulter = new System.Windows.Forms.Label();
            this.buttonFacile = new System.Windows.Forms.Button();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonDifficile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(96, 230);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(170, 20);
            this.textUser.TabIndex = 0;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(297, 216);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(189, 50);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.Text = "Valider";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(96, 210);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(170, 17);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Entrer votre nom :";
            // 
            // labelTitre
            // 
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.labelTitre.Location = new System.Drawing.Point(297, 28);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(346, 140);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "Labyrinthe";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(849, 35);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(83, 50);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDifficulter
            // 
            this.labelDifficulter.Location = new System.Drawing.Point(96, 310);
            this.labelDifficulter.Name = "labelDifficulter";
            this.labelDifficulter.Size = new System.Drawing.Size(141, 28);
            this.labelDifficulter.TabIndex = 5;
            this.labelDifficulter.Text = "Difficulté :";
            this.labelDifficulter.Visible = false;
            // 
            // buttonFacile
            // 
            this.buttonFacile.Location = new System.Drawing.Point(210, 292);
            this.buttonFacile.Name = "buttonFacile";
            this.buttonFacile.Size = new System.Drawing.Size(112, 48);
            this.buttonFacile.TabIndex = 6;
            this.buttonFacile.Text = "Facile";
            this.buttonFacile.UseVisualStyleBackColor = true;
            this.buttonFacile.Visible = false;
            this.buttonFacile.Click += new System.EventHandler(this.buttonFacile_Click);
            // 
            // buttonNormal
            // 
            this.buttonNormal.Location = new System.Drawing.Point(328, 292);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(112, 48);
            this.buttonNormal.TabIndex = 7;
            this.buttonNormal.Text = "Normal";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Visible = false;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonDifficile
            // 
            this.buttonDifficile.Location = new System.Drawing.Point(446, 292);
            this.buttonDifficile.Name = "buttonDifficile";
            this.buttonDifficile.Size = new System.Drawing.Size(112, 48);
            this.buttonDifficile.TabIndex = 8;
            this.buttonDifficile.Text = "Difficile";
            this.buttonDifficile.UseVisualStyleBackColor = true;
            this.buttonDifficile.Visible = false;
            this.buttonDifficile.Click += new System.EventHandler(this.buttonDifficile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 616);
            this.Controls.Add(this.buttonDifficile);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.buttonFacile);
            this.Controls.Add(this.labelDifficulter);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.textUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonDifficile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonFacile;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label labelDifficulter;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textUser;

        private System.Windows.Forms.PictureBox picturebox1;

        #endregion
        //private System.Windows.Forms.Button buttoncreatepicturebox;
        
        
    }
}