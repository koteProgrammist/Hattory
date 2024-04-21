using Cosmos.Core;
using Cosmos.Core.Multiboot;
using Cosmos.HAL;
using Cosmos.HAL.Drivers.Video;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Drawing;
using System.IO;
using ConsoleKeyy = Cosmos.System.ConsoleKeyEx;
using sus = Cosmos.System;

#pragma warning disable CA1416 // бля меня этот ебучий варнинг заебал

namespace Hattory
{
    public class Kernel : sus.Kernel
    {

        //=====CANVAS======

        public static Canvas canvas;
        public static byte[] SBuffer = new byte[64000];
        public static VGADriver driver = new VGADriver();

        //====BOOLEANS====

        public static bool ispysk = false; //knopka pysk
        public static bool ispcinfo = false; //pc information
        public static bool iscolors = false; //color changer
        public static bool iscalc = false; //calculator
        public static bool istaskm = false; //hardware monitor (old task manager)
        public static bool isdiskman = false; //disk manager
        public static bool oboi = true; //show the wallpaper or not?
        public static bool isalwaysshowfps; //always true
        public static bool FVGAIU = false; //FUCKING VIDEO GRAPHICS ARRAY INTERFACE and something on U.
        public static bool isfilemanager = false; // file manager
        public static bool iscalcready = false; //idk lol, something for normal calculator work. I wrote this in 2021
        public static bool isformatsure = false; //Are you want to delete file?
        public static bool isfilerename = false; //Are you want to rename file?
        public static bool issettingmenu = false; // menu with PC management tools
        public static bool shutdown; // Do you want to shutdown the computer?
        public static bool isguessit = false;

        //====OTHER====

        public static string first; //for calculator
        public static string second; //for calculator
        public static float firstI; //for calculator
        public static float secondI; //for calculator
        public static float c; //for calculator
        public static string status = ""; //quo? for guess it yet
        public static string enterrednum = ""; //for guess it
        public static int randomnum; //for guess it
        public static int globaldskcnt = 0; //current disk number
        public static Color colora; //system background color
        public static sus.FileSystem.CosmosVFS fs = new CosmosVFS(); //FS
        [ManifestResourceStream(ResourceName = "Hattory.krab.bmp")] public static byte[] krabsburger;
        [ManifestResourceStream(ResourceName = "Hattory.cursor.bmp")] public static byte[] tallc;
        public static sus.Graphics.Bitmap image = new sus.Graphics.Bitmap(krabsburger);
        public static sus.Graphics.Bitmap tc = new sus.Graphics.Bitmap(tallc);

        //VGA MODE
        public static void SetPixel(int x, int y, int color)
        {
            SBuffer[(y * 320) + x] = (byte)color;
        }
        public static void ReDraw()
        {
            driver.DrawFilledRectangle(0, 0, driver.PixelWidth, driver.PixelHeight, 0);

            int c = 0;

            for (int y = 0; y < 200; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    uint cl = driver.GetPixel320x200x8((uint)x, (uint)y);
                    if (cl != (uint)SBuffer[c])
                    {
                        driver.SetPixel320x200x8((uint)x, (uint)y, SBuffer[c]);
                    }
                    c++;
                }
            }
            for (int i = 0; i < 64000; i++)
            {
                SBuffer[i] = 0;
            }
        }
        public static void DrawFilledRectangle(uint x0, uint y0, int Width, int Height, int color)
        {
            for (uint i = 0; i < Width; i++)
            {
                for (uint h = 0; h < Height; h++)
                {
                    SetPixel((int)(x0 + i), (int)(y0 + h), color);
                }
            }
        }

        //BEFORE RUN
        protected override void BeforeRun()
        {
            try
            {
                //Console.Beep(2000, 100);
                //canvas.Clear(1);
                //canvas.DrawImage(BIMG, 0, 0);
                //canvas.Display();
                //Console.Beep(2000, 1000);
                try
                {
                    VFSManager.RegisterVFS(fs);
                }
                catch (Exception) { } //FILE SYSTEM
                //GRAPHICS SELECT PHASE
                bool canvber()
                {
                    if (VBEDriver.ISAModeAvailable()) { return true; }
                    if (PCI.Exists(VendorID.VirtualBox, DeviceID.VBVGA)) { return true; }
                    if (PCI.Exists(VendorID.Bochs, DeviceID.BGA)) { return true; }
                    return Multiboot2.IsVBEAvailable;
                }
                colora = Color.Black;
                if (PCI.GetDevice(VendorID.VMWare, DeviceID.SVGAIIAdapter) != null && PCI.Exists(PCI.GetDevice(VendorID.VMWare, DeviceID.SVGAIIAdapter)))
                {
                    canvas = new SVGAIICanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
                    sus.MouseManager.ScreenWidth = 800;
                    sus.MouseManager.ScreenHeight = 600;
                }
                else if (canvber())
                {
                    canvas = new VBECanvas(new Mode(800, 600, ColorDepth.ColorDepth32));
                    sus.MouseManager.ScreenWidth = 800;
                    sus.MouseManager.ScreenHeight = 600;
                }
                else
                {
                    for (int i = 0; i < 64000; i++)
                    {
                        SBuffer[i] = 0;
                    }
                    driver.SetGraphicsMode(VGADriver.ScreenSize.Size320x200, VGADriver.ColorDepth.BitDepth8);
                    driver.DrawFilledRectangle(0, 0, driver.PixelWidth, driver.PixelHeight, 0);
                    sus.MouseManager.ScreenWidth = 320;
                    sus.MouseManager.ScreenHeight = 200;
                    FVGAIU = true;
                }
                sus.MouseManager.X = sus.MouseManager.ScreenWidth / 2;
                sus.MouseManager.Y = sus.MouseManager.ScreenHeight / 2;
                FpsShower.ShouldRender = true;
                //Console.Beep(3000, 1000);
            }
            catch (Exception e)
            {
                canvas.Disable();
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vse, kina ne bydet!");
                Console.Write("ERROR CODE: " + e.Message);
            }
        }
        public static bool Click(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Left)
                    {
                        sus.MouseManager.MouseState = sus.MouseState.None;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool ClickMiddle(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Middle)
                    {
                        sus.MouseManager.MouseState = sus.MouseState.None;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool ClickInfinity(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Left)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool CheckPos(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ClickRight(int x, int y, int w, int h)
        {
            if (sus.MouseManager.X <= x + w && sus.MouseManager.X >= x)
            {
                if (sus.MouseManager.Y <= y + h && sus.MouseManager.Y >= y)
                {
                    if (sus.MouseManager.MouseState == sus.MouseState.Right)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        protected override void Run()
        {
            try
            {
                if (FVGAIU)
                {
                    SetPixel((int)sus.MouseManager.X, (int)sus.MouseManager.Y, 5);
                    //Code generated by HattoryWindowCreator

                    DrawFilledRectangle(75, 100, 185, 50, 1); //window background
                    Otrisovka.Write("Please, shutdown PC", 80, 130, Color.Black, 255, true); //CWR=152
                    Otrisovka.Write("VGA Not supported", 80, 105, Color.Black, 255, true); //CWR=136
                    if (Click(75, 100, 185, 50))
                    {
                        sus.Power.Shutdown();
                    }
                    Console.Beep(2000, 1000);
                    ReDraw();
                }
                else
                {
                    canvas.Clear(colora);
                    //oboi
                    if (oboi == true)
                    {
                        canvas.DrawImage(image, 0, 0);
                    }
                    //pysk
                    canvas.DrawFilledRectangle(Color.Indigo, 0, 0, 800, 50);
                    canvas.DrawFilledCircle(Color.SlateBlue, 765, 25, 20);
                    //time
                    int mont;
                    mont = DateTime.Now.Month;
                    string montt = "";
                    switch (mont)
                    {
                        case 01:
                            montt = "January";
                            break;
                        case 02:
                            montt = "February";
                            break;
                        case 03:
                            montt = "March";
                            break;
                        case 04:
                            montt = "April";
                            break;
                        case 05:
                            montt = "May";
                            break;
                        case 06:
                            montt = "June";
                            break;
                        case 07:
                            montt = "July";
                            break;
                        case 08:
                            montt = "August";
                            break;
                        case 09:
                            montt = "September";
                            break;
                        case 10:
                            montt = "October";
                            break;
                        case 11:
                            montt = "November";
                            break;
                        case 12:
                            montt = "December";
                            break;
                    }
                    //pysk
                    if (CheckPos(745, 0, 45, 50))
                    {
                        if (ispysk == false)
                        {
                            ispysk = true;
                        }
                    }

                    // ----------------------------------------------\
                    // CLOSE WINDOWS / CLOSE WINDOWS / CLOSE WINDOWS |
                    //-----------------------------------------------/

                    //PC info
                    if (ClickRight(30, 60, 380, 102))
                    {
                        if (ispcinfo == true)
                        {
                            ispcinfo = false;
                        }
                    }
                    //colors
                    if (ClickRight(30, 60, 270, 75))
                    {
                        if (iscolors == true)
                        {
                            iscolors = false;
                        }
                    }
                    //calc
                    if (ClickRight(25, 60, 225, 325))
                    {
                        if (iscalc == true)
                        {
                            iscalc = false;
                            Calc.c = c;
                            Calc.first = first;
                            Calc.second = second;
                            Calc.firstI = firstI;
                            Calc.secondI = secondI;
                            Calc.iscalcready = false;
                        }
                    }
                    //taskman
                    if (ClickRight(645, 510, 150, 85))
                    {
                        if (istaskm == true)
                        {
                            istaskm = false;
                        }
                    }
                    //FileManager
                    if (ClickRight(10, 60, 270 + (Notepad.path.Length * 2), 250))
                    {
                        if (isfilemanager == true && isformatsure == false)
                        {
                            isfilemanager = false;
                        }
                    }
                    //DiskManager
                    if (ClickRight(10, 60, 300, 125))
                    {
                        if (isdiskman == true)
                        {
                            isdiskman = false;
                        }
                    }
                    //setting menu
                    if (ClickRight(100, 100, 200, 150))
                    {
                        if (issettingmenu == true)
                        {
                            issettingmenu = false;
                        }
                    }
                    //Guess It!
                    if (ClickRight(150, 100, 375, 200))
                    {
                        klavaypr.On = true;
                        isguessit = false;
                    }

                    // ------------------------------------------\
                    // CLICKS CLICKS CLICKS CLICKS CLICKS CLICKS |
                    //-------------------------------------------/

                    //====SettingMenu
                    if (Click(665, 52, 96, 15))
                    {
                        if (ispysk)
                        {
                            if (!issettingmenu)
                            {
                                isfilemanager = false;
                                shutdown = false;
                                iscalcready = false;
                                issettingmenu = true;
                                ispysk = false; //knopka pysk
                                ispcinfo = false; //pc information
                                iscolors = false; //color changer
                                iscalc = false; //calculator
                                isdiskman = false; //disk manager
                                isfilerename = false; //Are you want to rename file?
                                isguessit = false;
                                if (isformatsure)
                                {
                                    Notepad.islock = false;
                                    isformatsure = false; //Are you want to delete file?
                                }
                                else if (isfilerename)
                                {
                                    Notepad.islock = false;
                                    Notepad.filename = "";
                                    klavaypr.On = true;
                                    isfilerename = false;
                                }
                            }
                        }
                    }
                    //====FILE MANAGER
                    if (Click(665, 67, 112, 15))
                    {
                        if (ispysk)
                        {
                            if (!isfilemanager)
                            {
                                isfilemanager = true;
                                shutdown = false;
                                iscalcready = false;
                                issettingmenu = false;
                                ispysk = false; //knopka pysk
                                ispcinfo = false; //pc information
                                iscolors = false; //color changer
                                iscalc = false; //calculator
                                isdiskman = false; //disk manager
                                isfilerename = false; //Are you want to rename file?
                                isguessit = false;
                                if (isformatsure)
                                {
                                    Notepad.islock = false;
                                    isformatsure = false; //Are you want to delete file?
                                }
                                else if (isfilerename)
                                {
                                    Notepad.islock = false;
                                    Notepad.filename = "";
                                    klavaypr.On = true;
                                    isfilerename = false;
                                }
                            }
                        }
                    }
                    //====CALCULATOR
                    if (Click(665, 82, 96, 15))
                    {
                        if (ispysk == true)
                        {
                            if (iscalc == false)
                            {
                                isfilemanager = false;
                                c = 0;
                                firstI = 0;
                                secondI = 0;
                                first = "";
                                second = "";
                                shutdown = false;
                                iscalcready = false;
                                issettingmenu = false;
                                ispysk = false; //knopka pysk
                                ispcinfo = false; //pc information
                                iscolors = false; //color changer
                                iscalc = true; //calculator
                                isdiskman = false; //disk manager
                                isfilerename = false; //Are you want to rename file?
                                isguessit = false;
                                if (isformatsure)
                                {
                                    Notepad.islock = false;
                                    isformatsure = false; //Are you want to delete file?
                                }
                                else if (isfilerename)
                                {
                                    Notepad.islock = false;
                                    Notepad.filename = "";
                                    klavaypr.On = true;
                                    isfilerename = false;
                                }
                            }
                        }
                    }
                    //====Guess It!
                    if (Click(665, 98, 72, 15))
                    {
                        if (ispysk)
                        {
                            if (!issettingmenu)
                            {
                                isfilemanager = false;
                                shutdown = false;
                                iscalcready = false;
                                issettingmenu = false;
                                ispysk = false; //knopka pysk
                                ispcinfo = false; //pc information
                                iscolors = false; //color changer
                                iscalc = false; //calculator
                                isdiskman = false; //disk manager
                                isfilerename = false; //Are you want to rename file?
                                isguessit = true;
                                klavaypr.On = false;
                                randomnum = new Random().Next(0, 101);
                                status = "New number has made";
                                enterrednum = "";
                                if (isformatsure)
                                {
                                    Notepad.islock = false;
                                    isformatsure = false; //Are you want to delete file?
                                }
                                else if (isfilerename)
                                {
                                    Notepad.islock = false;
                                    Notepad.filename = "";
                                    klavaypr.On = true;
                                    isfilerename = false;
                                }
                            }
                        }
                    }
                    //====disable pysk
                    if (sus.MouseManager.MouseState == sus.MouseState.Right)
                    {
                        if (ispysk == true)
                        {
                            ispysk = false;
                        }
                    }
                    //====shutdown
                    if (Click(665, 150, 30, 30))
                    {
                        if (ispysk)
                        {
                            if (!shutdown)
                            {
                                isfilemanager = false;
                                shutdown = true;
                                iscalcready = false;
                                issettingmenu = false;
                                ispysk = false; //knopka pysk
                                ispcinfo = false; //pc information
                                iscolors = false; //color changer
                                iscalc = false; //calculator
                                isdiskman = false; //disk manager
                                isfilerename = false; //Are you want to rename file?
                                isguessit = false;
                                if (isformatsure)
                                {
                                    isformatsure = false; //Are you want to delete file?
                                    Notepad.islock = false;
                                }
                                else if (isfilerename)
                                {
                                    isfilerename = false;
                                    Notepad.islock = false;
                                    Notepad.filename = "";
                                    klavaypr.On = true;
                                }
                            }
                        }
                    }
                    //=====rebbot
                    if (Click(705, 150, 30, 30))
                    {
                        if (ispysk == true)
                        {
                            sus.Power.Reboot();
                        }
                    }

                    // ---------------------------------------------\
                    // BOOLEANS BOOLEANS BOOLEANS BOOLEANS BOOLEANS |
                    //----------------------------------------------/

                    //====shutdown MENU
                    if (shutdown)
                    {
                        //Code generated by HattoryWindowCreator

                        canvas.DrawFilledRectangle(Color.DarkGray, 250, 200, 250, 100); //window background
                        canvas.DrawFilledRectangle(Color.Gray, 390, 240, 100, 50); //button
                        canvas.DrawFilledRectangle(Color.Gray, 260, 240, 100, 50); //button
                        Otrisovka.Write("Are you want to shutdown PC?", 260, 210, Color.Black); //CWR=224
                        Otrisovka.Write("Yes", 298, 257, Color.Black); //CWR=24
                        Otrisovka.Write("No", 432, 257, Color.Black); //CWR=16

                        if (Click(390, 240, 100, 50))
                        {
                            shutdown = false;
                        }

                        if (Click(260, 240, 100, 50))
                        {
                            sus.Power.Shutdown();
                        }
                    }
                    //====FPS
                    if (isalwaysshowfps == true)
                    {
                        canvas.DrawFilledRectangle(Color.Black, 0, 1055, 70, 25);
                        Otrisovka.Write("FPS: " + (FpsShower.FPS / 2).ToString(), 5, 1060, Color.White);
                    }
                    //====PCInformation
                    if (ispcinfo == true)
                    {
                        canvas.DrawFilledRectangle(Color.LightGray, 30, 60, 380, 102);
                        Otrisovka.Write("Computer Information", 35, 62, Color.Black);
                        Otrisovka.Write("RAM: " + CPU.GetAmountOfRAM().ToString() + "MB", 35, 78, Color.Black);
                        try
                        {
                            Otrisovka.Write("CPU: " + CPU.GetCPUBrandString(), 35, 94, Color.Black);
                        }
                        catch (Exception) { }
                        Otrisovka.Write("Frames Per Second: " + (FpsShower.FPS / 2).ToString(), 35, 110, Color.Black);
                        Otrisovka.Write("Video Driver: " + canvas.Name(), 35, 126, Color.Black);
                        Otrisovka.Write("Resolution: " + canvas.Mode.Width + "x" + canvas.Mode.Height + " 32 bit color", 35, 142, Color.Black);
                        if (Click(35, 110, 176, 16))
                        {
                            if (isalwaysshowfps == false)
                            {
                                isalwaysshowfps = true;
                            }
                            else if (isalwaysshowfps == true)
                            {
                                isalwaysshowfps = false;
                            }
                        }
                    }
                    //====SETTING MENU
                    if (issettingmenu == true)
                    {
                        //Code generated by HattoryWindowCreator

                        canvas.DrawFilledRectangle(Color.DarkGray, 100, 100, 200, 150);
                        Otrisovka.Write("Disk Manager", 110, 170, Color.Black);
                        Otrisovka.Write("Hardware Monitor", 110, 150, Color.Black);
                        Otrisovka.Write("PC Information", 110, 130, Color.Black);
                        Otrisovka.Write("Colors", 110, 110, Color.Black);
                        //colors
                        if (Click(110, 110, 48, 16))
                        {
                            if (iscolors == false)
                            {
                                ispcinfo = false;
                                ispysk = false;
                                iscalc = false;
                                isfilemanager = false;
                                isdiskman = false;
                                iscolors = true;
                                issettingmenu = false;
                            }
                        }
                        //PCInf
                        if (Click(110, 130, 112, 16))
                        {
                            if (ispcinfo == false)
                            {
                                iscolors = false;
                                ispysk = false;
                                isdiskman = false;
                                iscalc = false;
                                isfilemanager = false;
                                ispcinfo = true;
                                issettingmenu = false;
                            }
                        }
                        //HM
                        if (Click(110, 150, 128, 16))
                        {
                            if (istaskm == false)
                            {
                                istaskm = true;
                            }
                        }
                        //DM
                        if (Click(110, 170, 96, 16))
                        {
                            if (isdiskman == false)
                            {
                                iscalcready = false;
                                isfilemanager = false;
                                ispcinfo = false;
                                ispysk = false;
                                iscolors = false;
                                iscalc = false;
                                isdiskman = true;
                                issettingmenu = false;
                            }
                        }
                    }
                    //====FILE MANAGER
                    if (isfilemanager == true)
                    {
                        //Notepad.path = globaldskcnt.ToString() + @":\";
                        Notepad.enternote();
                    }
                    //===COLOR CHANGER
                    if (iscolors == true)
                    {
                        canvas.DrawFilledRectangle(Color.LightGray, 30, 60, 270, 75);
                        canvas.DrawFilledRectangle(Color.MidnightBlue, 35, 65, 75, 30);
                        canvas.DrawFilledRectangle(Color.Black, 115, 65, 75, 30);
                        Otrisovka.Write("Wallpaper", 117, 80, Color.White);
                        canvas.DrawFilledRectangle(Color.Navy, 195, 65, 75, 30);
                        canvas.DrawFilledRectangle(Color.DarkSlateGray, 35, 100, 75, 30);
                        canvas.DrawFilledRectangle(Color.Black, 115, 100, 75, 30);
                        canvas.DrawFilledRectangle(Color.Teal, 195, 100, 75, 30);
                        if (Click(35, 65, 75, 30))
                        {
                            colora = Color.MidnightBlue;
                        }
                        if (Click(115, 65, 75, 30))
                        {
                            if (oboi == false)
                            {
                                oboi = true;
                            }
                            else if (oboi == true)
                            {
                                oboi = false;
                            }
                        }
                        if (Click(195, 65, 75, 30))
                        {
                            colora = Color.Navy;
                        }
                        if (Click(35, 100, 75, 30))
                        {
                            colora = Color.DarkSlateGray;
                        }
                        if (Click(115, 100, 75, 30))
                        {
                            colora = Color.Black;
                        }
                        if (Click(195, 100, 75, 30))
                        {
                            colora = Color.Teal;
                        }
                    }
                    //=====KNOPKA PUSK
                    if (ispysk == true)
                    {
                        canvas.DrawFilledRectangle(Color.SlateBlue, 660, 50, 140, 140);
                        Otrisovka.Write("Settigs Menu", 665, 52, Color.White);
                        Otrisovka.Write("File Inspector", 665, 68, Color.White);
                        Otrisovka.Write("Calculator", 665, 84, Color.White);
                        Otrisovka.Write("Guess It!", 665, 100, Color.White);
                        canvas.DrawFilledRectangle(Color.Crimson, 665, 150, 30, 30);
                        canvas.DrawFilledRectangle(Color.OrangeRed, 705, 150, 30, 30);
                        //------------------------------
                    }
                    //=====HARDWARE MONITOR
                    if (istaskm == true)
                    {
                        float URIM = GCImplementation.GetUsedRAM() / 1024 / 1024;
                        int URpercentage = (int)(URIM / CPU.GetAmountOfRAM() * 100); //get percentage
                        canvas.DrawFilledRectangle(Color.LightGray, 645, 510, 150, 85);
                        Otrisovka.Write("Hardware Monitor", 650, 525, Color.Black);
                        Otrisovka.Write("RAM Usage in MBs:", 650, 540, Color.Black);
                        canvas.DrawFilledRectangle(Color.DarkGreen, 650, 555, 100, 20);
                        canvas.DrawFilledRectangle(Color.Lime, 650, 555, URpercentage, 20);
                        Otrisovka.Write(URIM.ToString() + " MBs / " + URpercentage.ToString() + " %", 652, 558, Color.Black);
                        Otrisovka.Write("FPS: " + (FpsShower.FPS / 2).ToString(), 650, 575, Color.Black);
                    }
                    //===CALCULATOR
                    if (iscalc == true)
                    {
                        Calc.Calculator();
                    }
                    //=====DISK MAMAGER
                    if (isdiskman == true)
                    {
                        try
                        {
                            canvas.DrawFilledRectangle(Color.Purple, 10, 60, 300, 125);
                            Otrisovka.Write("Disks: " + "current - " + globaldskcnt, 15, 65, Color.Black);
                            var diskslist = VFSManager.GetDisks();
                            int iznai = 80;
                            int dskcnt = 0;
                            foreach (var disk in diskslist)
                            {
                                Otrisovka.Write("Disk " + dskcnt + " - " + (disk.Size / 1024 / 1024) + "MB, " + "MBR: " + disk.IsMBR, 15, iznai, Color.Black);
                                if (Click(15, iznai, 36, 16))
                                {
                                    globaldskcnt = dskcnt;
                                    Notepad.path = dskcnt + @":\";
                                    isfilemanager = true;
                                    isdiskman = false;
                                }
                                /*try
                                {
                                    disk.Mount();
                                }
                                catch (Exception) { }
                                if (ClickRight(15, iznai, 36, 9))
                                {
                                    isformatsure = true;
                                }*/
                                dskcnt += 1;
                                iznai += 16;
                            }
                        }
                        catch (Exception) { }
                    }
                    //Guess It!
                    if (isguessit == true)
                    {
                        //Code generated by HattoryWindowCreator
                        canvas.DrawFilledRectangle(Color.DarkGray, 150, 100, 375, 200); //window background
                        canvas.DrawFilledRectangle(Color.Gray, 415, 150, 100, 75); //button
                        canvas.DrawFilledRectangle(Color.Gray, 153, 201, 200, 15);
                        Otrisovka.Write("New Number", 427, 184, Color.Black); //CWR=48
                        Otrisovka.Write("I made random number from 0 to 100, Guess It!", 155, 105, Color.Black); //CWR=360
                        sus.KeyEvent k;
                        bool IsKeyPressed = sus.KeyboardManager.TryReadKey(out k);
                        Otrisovka.Write(enterrednum, 155, 200, Color.Black);
                        Otrisovka.Write(status, 155, 280, Color.Black);
                        if (k.Key == ConsoleKeyy.Spacebar)
                        {
                            enterrednum += " ";
                        }
                        else if (k.Key == ConsoleKeyy.Backspace)
                        {
                            if (enterrednum.Length >= 1)
                            {
                                enterrednum = enterrednum.Remove(enterrednum.Length - 1);
                            }
                        }
                        else if (k.Key == ConsoleKeyy.Escape)
                        {
                            klavaypr.On = true;
                            isguessit = false;
                        }
                        else if (k.Key == ConsoleKeyy.Enter)
                        {
                            try
                            {
                                int num = Convert.ToInt32(enterrednum);
                                if (num > randomnum)
                                {
                                    status = "Guessed number less than " + num.ToString();
                                }
                                else if (num < randomnum)
                                {
                                    status = "Guessed number greater than " + num.ToString();
                                }
                                else if (num == randomnum)
                                {
                                    status = "You guess it! Congratulations!";
                                    randomnum = new System.Random().Next(0, 101);
                                }
                            }
                            catch (Exception) { }
                        }
                        else
                        {
                            if (k.KeyChar != 'ｔ')
                            {
                                enterrednum += k.KeyChar;
                            }
                        }
                        if (Click(415, 150, 100, 75))
                        {
                            randomnum = new System.Random().Next(0, 101);
                            status = "New number has made";
                            enterrednum = "";
                        }
                    }
                    //======SureDelete
                    if (isformatsure == true)
                    {
                        canvas.DrawFilledRectangle(Color.LightGray, 400, 240, 100, 50); // 270, 200
                        Otrisovka.Write("Delete File?", 405, 245, Color.Black);
                        canvas.DrawFilledRectangle(Color.DarkGray, 415, 260, 35, 25);
                        Otrisovka.Write("Yes", 420, 270, Color.Black);
                        canvas.DrawFilledRectangle(Color.DarkGray, 455, 260, 35, 25);
                        Otrisovka.Write("No", 465, 270, Color.Black);
                        if (Click(415, 260, 35, 25))
                        {
                            File.Delete(Notepad.path + Notepad.filenameeee);
                            Notepad.islock = false;
                            isformatsure = false;
                        }
                        if (Click(455, 260, 35, 25))
                        {
                            //Directory.CreateDirectory(@"0:\");
                            Notepad.islock = false;
                            isformatsure = false;
                        }
                    }
                    //=====RenameFile
                    if (isfilerename == true)
                    {
                        canvas.DrawFilledRectangle(Color.Gray, 305, 240, 180, 50); // 270, 200       //420
                        Otrisovka.Write("Create file with name:", 310, 245, Color.Black); //775
                        try
                        {
                            sus.KeyEvent k;
                            bool IsKeyPressed = sus.KeyboardManager.TryReadKey(out k);
                            Otrisovka.Write(Notepad.filename, 310, 260, Color.Black);
                            if (k.Key == ConsoleKeyy.Spacebar)
                            {
                                Notepad.filename += " ";
                            }
                            else if (k.Key == ConsoleKeyy.Backspace)
                            {
                                Notepad.filename = Notepad.filename.Remove(Notepad.filename.Length - 1);
                            }
                            else if (k.Key == ConsoleKeyy.Escape)
                            {
                                Notepad.filename = "";
                                Notepad.islock = false;
                                klavaypr.On = true;
                                isfilerename = false;
                            }
                            else if (k.Key == ConsoleKeyy.Enter)
                            {
                                try
                                {
                                    File.Create(Notepad.path + @"\" + Notepad.filename);
                                    Notepad.filename = "test.txt";
                                    Notepad.islock = false;
                                    klavaypr.On = true;
                                    isfilerename = false;
                                }
                                catch (Exception)
                                {
                                    Notepad.filename = "";
                                    Notepad.islock = false;
                                    klavaypr.On = true;
                                    isfilerename = false;
                                }
                            }
                            else
                            {
                                if (k.KeyChar != 'ｔ')
                                {
                                    Notepad.filename += k.KeyChar;
                                }
                            }
                        }
                        catch (Exception) { }
                    }

                    // ------------------------------------------\
                    // OTHER OTHER OTHER OTHER OTHER OTHER OTHER |
                    //-------------------------------------------/

                    //Time
                    Otrisovka.Write(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), 5, 1, Color.White);
                    Otrisovka.Write(montt, 5, 17, Color.White);
                    Otrisovka.Write(DateTime.Now.Day.ToString() + "th " + DateTime.Now.Year.ToString(), 5, 33, Color.White);
                    //mouse
                    try
                    {
                        canvas.DrawImageAlpha(tc, (int)sus.MouseManager.X, (int)sus.MouseManager.Y);
                    }
                    catch (Exception) { }
                    klavaypr.YPRklava();
                    canvas.Display();
                }
                Cosmos.Core.Memory.Heap.Collect();
            }
            catch (Exception)
            {
                sus.PCSpeaker.Beep();
            }
        }
    }
}