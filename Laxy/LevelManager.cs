using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Laxy
{
    class LevelManager
    {        
        public LevelManager()
        {           
            
        }
        
        public void LoadLevel(string number, List<Point> obstList)
        {
            FileStream fs;
            try
            {
                fs = new FileStream("level"+number, FileMode.Open, FileAccess.Read);

            }
            catch
            {
                MessageBox.Show("\"level" + number + "\" wurde nicht geladen/gefunden");
                return;
            }

            obstList.Clear(); ;
            StreamReader sr = new StreamReader(fs);
            string line;
            string[] words;
            Point pt = new Point();

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                words = line.Split(',');

                pt.X = Convert.ToInt32(words[0]);
                pt.Y = Convert.ToInt32(words[1]);

                obstList.Add(pt);
            }
            
            sr.Close(); fs.Close();
        }


    }
}
