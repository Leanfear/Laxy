using System;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using MV;


namespace Laxy
{
    class player
    {
       // public Point playerPos; <--!
        public Vect2D playerPos;  // private
        public Vect2D m_V = new Vect2D();
        Image playerIMG;      

        int playerwidth, playerheight;
        public bool IsOnGround;           

        public player()
        {           
            m_V.SetFrom_R_Phi(0,0);
            this.LoadPlayer();          
            playerwidth = playerIMG.Width;
            playerheight = playerIMG.Height;
            IsOnGround = false;            
        }

        public Vect2D PlayerPos
        {
            get { return playerPos; }
            set { playerPos = value; }
        }
        public int Playerheight
        {
            get { return playerheight; }
            set { playerheight = value; }
        }
        public int Playerwidth
        {
            get { return playerwidth; }
            set { playerwidth = value; }
        }

        public void MovePlayerToStart(Point startpunkt)
        {
            playerPos.X = startpunkt.X;
            playerPos.Y = GetInvertedYPos(startpunkt.Y);
        }
        public void LoadPlayer() // ladet player-img
        {
            try
            {
                playerIMG = Image.FromFile(@"pic\player.png");
            }
            catch
            {
                MessageBox.Show("Fehler beim Laden des Bildes (\"player.png\")");
            }

        }
        public void Draw(Graphics g) // drawImage
        {
            g.DrawImage(playerIMG, playerPos.XI, GetInvertedYPos(playerPos.YI));     
        }        
        public void MoveUp()
        {
            if (IsOnGround)
            {
                m_V.Y += 9;
                IsOnGround = false;
            }
           
        }            
        public void MoveLeft() { 
            
            playerPos.X -= 1; }        
        public void MoveRight() { playerPos.X += 1; }
        
        public int GetInvertedYPos(int y)
        {
            return 560 - y;
        }
        public void StayInWindow(Size aSz)      
           
        {
            if (playerPos.X < 0)                      
                playerPos.X += 1;                     

            if (playerPos.X > aSz.Width-playerwidth) 
                playerPos.X -= 1;                    

            if (playerPos.Y < playerheight)
            {          
                m_V.Y = 0; playerPos.Y = playerheight+1;
                IsOnGround = true;
            }

            if (playerPos.Y > aSz.Height)
            {                
                m_V.Y = -1;
            }
        }   
    }
}