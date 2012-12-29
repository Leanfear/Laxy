
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using MV;
using System.Data;

namespace Laxy
{
    class ObstacleManager
    {
      
       private List<Point> obstList  = new List<Point>();  
       public player player1 = new player();
       LevelManager levelManager1 = new LevelManager();

       int anzInventar, aktLevel; // anzahl von setzbaren blöcken(abhängig v. level), aktuelles level als zahl
       Size panelSize = new Size(620, 560);
       public int obst_height, obst_width;



       public ObstacleManager()
       {          
           anzInventar = 5;
           obst_height = 30;
           obst_width = 50;
       }

       public List<Point> ObstList
       {
           get { return (obstList); }
       }

        public void AddObstacle(Point pt, bool editorMode)
        {
            if (anzInventar > 0 || editorMode == true)
            {
                obstList.Add(pt);                
                anzInventar--;
            }             
          }
      

        public void ResetObstacles()
        {
            anzInventar = 5;
            obstList.Clear();            
        }

        public void Paint(Graphics aGr)
        {
            if (obstList.Count > 1)
            {
                for (int i = 2; i < obstList.Count; i++)  // 1. Punkt -> Starpunkt; 2. Punkt -> Zielpunkt; 3. Punkt -> 1. Obstacle
                {
                    Point pt = (Point)obstList[i];
                    aGr.FillRectangle(Brushes.Red, pt.X, pt.Y, obst_width, obst_height);
                }

                {
                    Point ptStarpunkt = (Point)obstList[0];
                    aGr.FillRectangle(Brushes.Blue, ptStarpunkt.X, ptStarpunkt.Y, 5, 5);

                    Point ptZielpunkt = (Point)obstList[1];
                    aGr.FillRectangle(Brushes.Green, ptZielpunkt.X, ptZielpunkt.Y, 5, 5);
                }
            }
            
        }

        public void IsPlayerInFinish()  // funktioniert noch nicht
        {
            if (obstList.Count > 2)
            {
                Point Zielpunkt = (Point)obstList[1];
                if ((player1.playerPos.X < Zielpunkt.X && player1.playerPos.X > Zielpunkt.X - 20) && (player1.playerPos.Y-player1.Playerheight < 560 - Zielpunkt.Y && player1.playerPos.Y-player1.Playerheight > 560 - Zielpunkt.Y - 20))
                {
                    // Player ist im Ziel   
                    levelManager1.LoadLevel((aktLevel + 1).ToString(), obstList); // nächstes Level laden (temporär) --> in echt sollte ConstructLevelX aufgerufen werden!
                    
                }
            }
        }

        public void ConstructLevel1()
        {
            levelManager1.LoadLevel("1", obstList);   
            player1.MovePlayerToStart((Point)obstList[0]);
            aktLevel = 1;
            anzInventar = 4;
        }

        public void ConstructLevel2()
        {
            levelManager1.LoadLevel("2", obstList);
            player1.MovePlayerToStart((Point)obstList[0]);
            aktLevel = 2;
            anzInventar = 2;
        }

        public void ConstructLevel3() // nicht in Verwendung
        {
            levelManager1.LoadLevel("3", obstList);
            aktLevel = 3;
            anzInventar = 2;
        }

        public void CalcNextPos()
        {                
            for (int i = 0; i <= 80; i++)   //<= 40 (-> iter per tick)
            {
                player1.StayInWindow(panelSize);
                WalkOnObstacle();  // weglass-bar? na!           
                player1.m_V.Y = player1.m_V.Y - (0.5 * (1.0 / 40.0));
                player1.playerPos.AddTo(player1.m_V, 1.0 / 40.0);
            }

        }

            public void WalkOnObstacle()
        {   // höhe und breite des obstacles zurzeit standardmäßig auf 30,30   players derzeitige größe: 21x42 aus img
            for(int i = 2;i<obstList.Count;i++) //foreach (Point pt in obstList)  // damit die ersten zwei nix stoppen (start u. ziel)
            {
                Point pt = obstList[i];
               
    //überprüfen ob player in rechteck:   von rechts, (vom player aus)                      links                                 oben                      füße                                      kopf        
                if ((player1.playerPos.X + player1.Playerwidth > pt.X) && (player1.playerPos.X < pt.X + obst_width) && (player1.playerPos.YI - player1.Playerheight <= panelSize.Height - pt.Y) && (player1.playerPos.YI > panelSize.Height - pt.Y - obst_height))
                {
                    if ((player1.playerPos.X + player1.Playerwidth > pt.X) && (player1.playerPos.X + player1.Playerwidth < pt.X + 5)) // v. links in pt
                    {
                        player1.playerPos.X -= 1;
                        return;                        
                    }

                    if ((player1.playerPos.X < pt.X + obst_width) && (player1.playerPos.X > pt.X + obst_width-10)) //v. rechts in pt (irgendwas ist da gepfuscht mit obst-width)
                    {
                        player1.playerPos.X += 1;
                        return;
                    }

                    if ((player1.playerPos.YI - player1.Playerheight < panelSize.Height - pt.Y) && (player1.playerPos.Y - player1.Playerheight > (panelSize.Height - pt.Y) - 2)) // v. oben
                    {
                        if (player1.m_V.Y < 0)
                        {
                            player1.m_V.Y += 1;
                            player1.IsOnGround = true;
                        }
                        
                    }
                   
                }
               
            }

        }
    }
}