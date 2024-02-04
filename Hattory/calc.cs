﻿using Cosmos.System.Graphics;
using System;
using System.Drawing;
using sus = Cosmos.System;
using System.Windows.Input;
using kern = Hattory.Kernel;

namespace Calculator
{
    public class Calc
    {
        private static Canvas canvas = kern.canvas;
        public static bool iscalcready = kern.iscalcready;
        public static string first = kern.first;
        public static string second = kern.second;
        public static long firstI = kern.firstI;
        public static long secondI = kern.secondI;
        public static float c = kern.c;

        //ыаыаыаыаыаыаыаы

        public static void Calculator()
        {
            try
            {
                canvas.DrawFilledRectangle(Color.DarkGray, 25, 60, 240, 335);
                Text.Otrisovka.Write("Calculator", 100, 65, Color.Black);
                //cifri buttons - 1
                canvas.DrawFilledRectangle(Color.Gray, 30, 170, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 80, 170, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 130, 170, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 180, 170, 40, 40);
                Text.Otrisovka.Write("1", 50, 190, Color.Black);
                Text.Otrisovka.Write("2", 100, 190, Color.Black);
                Text.Otrisovka.Write("3", 150, 190, Color.Black);
                Text.Otrisovka.Write("BS", 194, 190, Color.Black);
                //2
                canvas.DrawFilledRectangle(Color.Gray, 30, 220, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 80, 220, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 130, 220, 40, 40);
                Text.Otrisovka.Write("4", 50, 240, Color.Black);
                Text.Otrisovka.Write("5", 100, 240, Color.Black);
                Text.Otrisovka.Write("6", 150, 240, Color.Black);
                //3
                canvas.DrawFilledRectangle(Color.Gray, 30, 270, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 80, 270, 40, 40);
                canvas.DrawFilledRectangle(Color.Gray, 130, 270, 40, 40);
                Text.Otrisovka.Write("7", 50, 290, Color.Black);
                Text.Otrisovka.Write("8", 100, 290, Color.Black);
                Text.Otrisovka.Write("9", 150, 290, Color.Black);
                //0
                canvas.DrawFilledRectangle(Color.Gray, 80, 320, 40, 40);
                Text.Otrisovka.Write("0", 100, 340, Color.Black);
                canvas.DrawFilledRectangle(Color.Gray, 130, 320, 40, 40);
                Text.Otrisovka.Write("R", 150, 340, Color.Black);
                canvas.DrawFilledRectangle(Color.Gray, 30, 320, 40, 40);
                Text.Otrisovka.Write("-", 50, 340, Color.Black);
                //end
                //button press
                //1
                if (kern.Click(30, 170, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "1";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "1";
                        }
                    }
                }
                //2
                if (kern.Click(80, 170, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "2";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "2";
                        }
                    }
                }
                //3
                if (kern.Click(130, 170, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "3";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "3";
                        }
                    }
                }
                //4
                if (kern.Click(30, 220, 40, 40))
                {
                    if(iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "4";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "4";
                        }
                    }
                }
                //5
                if (kern.Click(80, 220, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "5";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "5";
                        }
                    }
                }
                //6
                if (kern.Click(130, 220, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "6";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "6";
                        }
                    }
                }
                //7
                if (kern.Click(30, 270, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "7";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "7";
                        }
                    }
                }
                //8
                if (kern.Click(80, 270, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "8";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "8";
                        }
                    }
                }
                //9
                if (kern.Click(130, 270, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "9";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "9";
                        }
                    }
                }
                //0
                if (kern.Click(80, 320, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 30)
                        {
                            first += "0";
                        }
                    }
                    else
                    {
                        if (second.Length < 30)
                        {
                            second += "0";
                        }
                    }
                }
                if (kern.Click(30, 320, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length < 1)
                        {
                            first += "-";
                        }
                    }
                    else
                    {
                        if (second.Length < 1)
                        {
                            second += "-";
                        }
                    }
                }
                if (kern.Click(180, 170, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        if (first.Length >= 1)
                        {
                            first = first.Remove(first.Length - 1, 1);
                        }
                    }
                    else
                    {
                        if (second.Length >= 1)
                        {
                            second = second.Remove(second.Length - 1, 1);
                        }
                        
                    }
                }
                //R
                if (kern.Click(130, 320, 40, 40))
                {
                    if (iscalcready == false)
                    {
                        iscalcready = true;
                    }
                    else if (iscalcready == true)
                    {
                        iscalcready = false;
                    }
                }
                //end
                if (iscalcready == false)
                {
                    canvas.DrawFilledRectangle(Color.Green, 30, 80, 190, 15);
                    canvas.DrawFilledRectangle(Color.White, 30, 115, 190, 15);
                }
                if (iscalcready == true)
                {
                    canvas.DrawFilledRectangle(Color.White, 30, 80, 190, 15);
                    canvas.DrawFilledRectangle(Color.Green, 30, 115, 190, 15);
                }
                canvas.DrawFilledRectangle(Color.White, 30, 145, 190, 15);
                Text.Otrisovka.Write(first, 35, 80, Color.Black);
                Text.Otrisovka.Write(second, 35, 115, Color.Black);
                Text.Otrisovka.Write("Plus", 30, 100, Color.Black); // 32
                Text.Otrisovka.Write("Minus", 70, 100, Color.Black); // 40 + 5
                Text.Otrisovka.Write("Devide", 120, 100, Color.Black); // 48 + 5
                Text.Otrisovka.Write("Multiply", 175, 100, Color.Black); //64 + 5
                firstI = Convert.ToInt64(first);
                secondI = Convert.ToInt64(second);
                if (kern.ClickInfinity(30, 100, 32, 16))
                {
                    c = firstI + secondI;
                    Text.Otrisovka.Write(c.ToString(), 30, 145, Color.Black);
                }
                if (kern.ClickInfinity(70, 100, 40, 16))
                {
                    c = firstI - secondI;
                    Text.Otrisovka.Write(c.ToString(), 30, 145, Color.Black);
                }
                if (kern.ClickInfinity(120, 100, 48, 16))
                {
                    c = firstI / secondI;
                    Text.Otrisovka.Write(c.ToString(), 30, 145, Color.Black);
                }
                if (kern.ClickInfinity(175, 100, 64, 16))
                {
                    c = firstI * secondI;
                    Text.Otrisovka.Write(c.ToString(), 30, 145, Color.Black);
                }
                Cosmos.Core.Memory.Heap.Collect();
            }
            catch (Exception) {
                Text.Otrisovka.Write("ERROR 1000-7", 30, 115, Color.Black);
            }
        }
    }
}