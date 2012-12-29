using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laxy
{
    public partial class Form1 : Form
    {
        ObstacleManager ObstacleManager1 = new ObstacleManager();        
        //LevelManager levelManager1 = new LevelManager();        

       bool ADown = false; // Tastatur
        bool SpaceDown = false;
        bool DDown = false;

        public bool editorMode = false;
        int mX, mY;        
        string version = "v0.52";

        public Form1()
        {
            InitializeComponent();
            lbl_info.Text = version;
            ObstacleManager1.ConstructLevel1();

            timer1.Interval = 40;  // iter per tick -> 40
            timer1.Start();
            timer_tast.Interval = 40 / 10; // iter per tick mal 10
            timer_tast.Start();
            lbl_mouse.Text = "";
            

            //Background
            try
            {
                Image bg = Image.FromFile(@"pic\background.png");
                panel.BackgroundImage = bg;                
                
            }
            catch
            {
                MessageBox.Show("Fehler beim Laden des Hintergrundbildes (\"background.png\")");
                panel.BackColor = Color.Yellow;
            }
        }

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            ObstacleManager1.player1.Draw(e.Graphics);  
            ObstacleManager1.Paint(e.Graphics);
            if(hinzufügenToolStripMenuItem.Text == "abbrechen")
            e.Graphics.FillRectangle(Brushes.Red, mX, mY, ObstacleManager1.obst_width, ObstacleManager1.obst_height);
        }
        
        private void OnTimer(object sender, EventArgs e)
        {
            ObstacleManager1.CalcNextPos();
            panel.Invalidate();
            debuglabel.Text = "X " + (ObstacleManager1.player1.PlayerPos.XI).ToString() + " Y " + (ObstacleManager1.player1.PlayerPos.YI).ToString() + " Dir  X:" + ObstacleManager1.player1.m_V.XI + " Y: " + ObstacleManager1.player1.m_V.YI;

        }

        private void OnFormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                DDown = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                SpaceDown = true;
            }

            if (e.KeyCode == Keys.A)
            {
                ADown = true;
            }
        }
        private void OnFormKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                DDown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                SpaceDown = false;
            }
            if (e.KeyCode == Keys.A)
            {
                ADown = false;
            }
        }

        private void timer_tast_Tick(object sender, EventArgs e)
        {
            if (DDown)
                ObstacleManager1.player1.MoveRight();
          
            if (ADown)
                ObstacleManager1.player1.MoveLeft();
            if (SpaceDown)
                ObstacleManager1.player1.MoveUp();

            ObstacleManager1.WalkOnObstacle();
            ObstacleManager1.IsPlayerInFinish();
            lbl_oCount.Text = ObstacleManager1.ObstList.Count.ToString();
            
        }

        private void OnPanelMouseClick(object sender, MouseEventArgs e)
        {
            if (hinzufügenToolStripMenuItem.Text == "abbrechen")
            {
                Point pt = new Point(e.X, e.Y); 
                ObstacleManager1.AddObstacle(pt, editorMode);
            }
            
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            mX = e.X;
            mY = e.Y; 
            lbl_mouse.Text = "X: "+e.X.ToString() + "Y: " + e.Y.ToString();
        }



        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObstacleManager1.ResetObstacles();            
        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObstacleManager1.ConstructLevel1();
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObstacleManager1.ConstructLevel2();
        }       

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hinzufügenToolStripMenuItem.Text == "Hinzufügen")
            {
                hinzufügenToolStripMenuItem.Text = "abbrechen";
            }
            else
            {
                hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            }
        }

        private void editorModusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editorMode)
            {
                editorMode = false;
                return;
            }
            else
                editorMode = true;
            ObstacleManager1.ResetObstacles();

        }

        private void aktuellesLevelSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editorMode)
            {
                MessageBox.Show("Du bist nicht im Editor-Modus");
                return;                
            }

            FileStream fs;
            try
            {
                fs = new FileStream("level1", FileMode.Create, FileAccess.Write);
            }
            catch
            {
                MessageBox.Show("Level konnte nicht gespeichert werden");
                return;
            }

            StreamWriter sw = new StreamWriter(fs);
            foreach (Point pt in ObstacleManager1.ObstList)
            {
                sw.WriteLine("{0}, {1}", pt.X, pt.Y);
            }
            sw.Close();
            fs.Close();
        }



      
    }

       
}