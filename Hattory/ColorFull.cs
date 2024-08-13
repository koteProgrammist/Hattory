using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using sus = Cosmos.System;
using lol = Hattory.Kernel;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.System.Graphics.Fonts;

namespace Hattory
{
    public class Colorfull
    {
        public static List<string> coords = new List<string>();
        public static void Start() {
            lol.canvas.DrawFilledRectangle(Color.Red, 30, 610, 50, 25);
            Otrisovka.Write("SAVE", 35, 619, Color.Black);
            //lol.canvas.DrawFilledRectangle(Color.LightYellow, 30, 640, 50, 25);
            //Otrisovka.Write("LOAD", 35, 649, Color.Black);
            lol.canvas.DrawFilledRectangle(Color.White, 90, 610, 50, 25);
            Otrisovka.Write("CLEAR", 95, 619, Color.Black);
            lol.canvas.DrawFilledRectangle(Color.White, 30, 300, 300, 300);
            if (lol.Click(30, 300, 300, 300))
            {
                if (!coords.Contains((int)sus.MouseManager.X + ";" + (int)sus.MouseManager.Y))
                {
                    coords.Add((int)sus.MouseManager.X + ";" + (int)sus.MouseManager.Y);
                }
            }
            if (lol.ClickRight(30, 300, 300, 300))
            {
                if (coords.Count != 0)
                {
                    foreach (string s in coords)
                    {
                        string[] coordinates = s.Split(';');
                        int x = Convert.ToInt32(coordinates.First());
                        int y = Convert.ToInt32(coordinates.Last());
                        float d = (float)Math.Sqrt((int)Math.Pow((int)sus.MouseManager.X - x, 2) + (int)Math.Pow((int)sus.MouseManager.Y - y, 2));
                        if (d <= 3.0f)
                        {
                            coords.Remove(s);
                        }
                    }
                }
            }
            if (coords.Count != 0)
            {
                foreach (string s in coords)
                {
                    string[] coordinates = s.Split(';');
                    lol.canvas.DrawFilledCircle(Color.Black, Convert.ToInt32(coordinates.First()), Convert.ToInt32(coordinates.Last()), 2);
                }
            }
            if(lol.Click(30, 610, 50, 25)){
                string ftext = "";
                foreach (string s in coords)
                {
                    ftext += s + "&";
                }
                string filenam;
                for (int i = 0; ; i++) {
                    filenam = "MyImage" + i.ToString();
                    if (!Directory.Exists(@"0:\ColorFull")) { Directory.CreateDirectory(@"0:\ColorFull"); }
                    if (!File.Exists(@"0:\ColorFull\" + filenam + ".cfi")) {
                        File.Create(@"0:\ColorFull\" + filenam + ".cfi");
                        File.WriteAllText(@"0:\ColorFull\" + filenam + ".cfi", ftext);
                        break;
                    }
                }
            }
            /*if (lol.Click(30, 640, 50, 25) && File.Exists(@"0:\MyImage.CFI"))
            {
                string data = File.ReadAllText(@"0:\MyImage.CFI");
                string[] pixelarr = data.Split("&");
                List<string> pixellist = pixelarr.ToList();
                pixellist.Remove(pixellist.Last());
                foreach (string s in pixellist)
                {
                    if (!coords.Contains(s)) { coords.Add(s); }
                }
            }*/
            if (lol.Click(90, 610, 50, 25))
            {
                coords.Clear();
            }
        }
        public static void Loadd(string info)
        {
            string[] pixelarr = info.Split("&");
            List<string> pixellist = pixelarr.ToList();
            pixellist.Remove(pixellist.Last());
            coords = pixellist;
        }
    }
}
