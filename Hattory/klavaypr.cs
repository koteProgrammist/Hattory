using System;
using Cosmos.System.Graphics;
using System.Drawing;
using ConsoleKeyy = Cosmos.System.ConsoleKeyEx;
using sus = Cosmos.System;
using Cosmos.HAL.BlockDevice;
using System.Linq;
using System.Text.RegularExpressions;
using aik = Hattory.Kernel;
using System.IO;
#pragma warning disable CA1416 // Проверка совместимости платформы

namespace kalavaypravlenie
{
    internal class klavaypr
    {
        public static bool On = true;
        public static string tt = "";
        public static void YPRklava()
        {
            if (On)
            {
                sus.KeyEvent k;
                bool IsKeyPressed = sus.KeyboardManager.TryReadKey(out k);
                /*if (k.Key == ConsoleKeyy.Spacebar)
                {
                    tt += " ";
                }
                else if (k.Key == ConsoleKeyy.Backspace)
                {
                    Notepad.ntepad.filename.Remove(Notepad.ntepad.filename.Length - 1);
                }
                else if (k.Key == ConsoleKeyy.Escape)
                {
                    tt = "";
                }
                else if (k.Key == ConsoleKeyy.Enter)
                {
                    try
                    {
                        File.WriteAllText(@path + @"\" + @pathFile, txta);
                        txta = "";
                        isended = true;
                    }
                    catch (Exception e)
                    {
                        sus.Power.Shutdown();
                    }
                }*/
                if (k.KeyChar != 'ｔ')
                {
                    sus.MouseManager.MouseState = sus.MouseState.None;
                }
                if (k.Key == ConsoleKeyy.UpArrow)
                {
                    sus.MouseManager.Y -= 6;
                }
                if (k.Key == ConsoleKeyy.DownArrow)
                {
                    sus.MouseManager.Y += 6;
                }
                if (k.Key == ConsoleKeyy.RightArrow)
                {
                    sus.MouseManager.X += 6;
                }
                if (k.Key == ConsoleKeyy.LeftArrow)
                {
                    sus.MouseManager.X -= 6;
                }
                if (k.Key == ConsoleKeyy.Minus)
                {
                    sus.MouseManager.MouseState = sus.MouseState.Left;
                }
                if (k.Key == ConsoleKeyy.Equal)
                {
                    sus.MouseManager.MouseState = sus.MouseState.Right;
                }
                //if (k.Key == ConsoleKeyy.Escape)
                //{
                //    sus.Power.Shutdown();
                //}
            }
        }
    }
}
