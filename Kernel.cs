using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Cosmosinside
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1023;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();

                while (true)
                {
                    Thread.Sleep(200);

                    tests.mainLoop();



                    ;

                }
            }


        }
    }





    class tests



    {

        static int x = 512-100, y = 400-50,w=200,h=100;
        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 3);

            graf.canvas.Clear(Color.White);

            if ((int)Sys.MouseManager.Y >= 0 && (int)Sys.MouseManager.X >= 0 && (int)Sys.MouseManager.Y < 800 && (int)Sys.MouseManager.X < 1024)
            {
                graf.canvas.DrawLine(p, (int)Sys.MouseManager.X - 25, (int)Sys.MouseManager.Y, (int)Sys.MouseManager.X + 25, (int)Sys.MouseManager.Y);
                graf.canvas.DrawLine(p, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y - 25, (int)Sys.MouseManager.X, (int)Sys.MouseManager.Y + 25);
                graf.canvas.DrawRectangle( p,new Sys.Graphics.Point(x,y),w,h);
                if ((int)Sys.MouseManager.MouseState==1 && (int)Sys.MouseManager.Y >= y && (int)Sys.MouseManager.X >= x && (int)Sys.MouseManager.Y < y+h && (int)Sys.MouseManager.X < x+w)
                {


                    Console.Beep();
                    
                }
                graf.displays();
            }

        }

    }






}
