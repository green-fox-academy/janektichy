using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            //First Exercise - Middle lines
            /*
            var pointStart = new Point(0, 400);
            var pointEnd = new Point(1000, 400);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(pointStart, pointEnd);
            var pointStart1 = new Point(400, 0);
            var pointEnd1 = new Point(400, 1000);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(pointStart1, pointEnd1);
            */

            //Second Exercise - Colored box
            /*
            foxDraw.SetStrokeThicknes(5);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawRectangle(0, 0, 400, 400);
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(0, 0, 400, 0);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 0, 0, 400);
            foxDraw.SetStrokeColor(Colors.Purple);
            foxDraw.DrawLine(0, 400, 400, 400);
            foxDraw.SetStrokeColor(Colors.Yellow);
            foxDraw.DrawLine(400, 0, 400, 400);
            */

            //Third Exercise - Diagonals
            /*
            foxDraw.SetStrokeThicknes(5);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 1000, 1000);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(1000, 0, 0,1000);
            */

            //Fourth Exercise - To the center
            /*
            int x = 250;
            int y = 400;
            foxDraw.SetStrokeColor(Colors.Green);
            DrawLineCenter(foxDraw, x, y);
            */

            //Fifth Exercise - Horizontal
            /*
            foxDraw.SetStrokeColor(Colors.Red);
            for (int i = 1; i < 4; i++)
            {
                DrawHorizontalLine(foxDraw, i*100, i*100);
            }*/


            //Sisxth Exercise - Centered Square
            /*
            foxDraw.DrawRectangle(400, 400, 10, 10);
            */


            //Seventh Exercise - Four Rectangles / do not know how to change the colors
            /*
            for (int i = 10; i < 50; i+=10)
            {
                foxDraw.DrawRectangle(i, i, i, i);
            }
            */

            //Eighth Exercise - Draw Square
            /*
            int x = 0;
            int y = 0;
            int k = 0;
            for (int i = 1; i < 4; i+=1)
            {
                DrawASquare(foxDraw, x, y + k);
                k += 100;
            }*/

            //Nineth Exercise - Centered Boxes
            /*
            for (int size = 300; size >= 100; size-=100)
            {
                DrawSquareWithTwoParameters(foxDraw, size);
            }*/

            //Tenth Exercise - Rainbow Boxes
            /*
            Color[] colors = { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet  };
            MakeRainbowBoxes(foxDraw, 100, Colors.Red);
            int size = 700;
            foreach (Color color in colors)
            {
                MakeRainbowBoxes(foxDraw, size, color);
                size -= 100;
            }*/

            //Purple Steps Exercise
            /*
            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 0; i < 400; i+=20)
            {
                foxDraw.DrawRectangle(i, i, 20, 20);
            }*/


            //Purple Steps 3D
            /*int k = 0;
            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 0; i < 160; i += 20)
            {
                foxDraw.DrawRectangle(k, k, i, i);
                k += i-1;
            }*/

            //Checkboard Exercise
            /*
            for (int i = 0; i < 800; i+=20)
            {
                for (int j = 0; j < 800; j+=20)
                {
                    if (i % 40 == 0)
                    {
                        if (j % 40 == 0)
                        {
                            foxDraw.SetFillColor(Colors.Black);
                        }
                        else
                        {
                            foxDraw.SetFillColor(Colors.White);
                        }
                    }
                    if (i % 40 != 0)
                    {
                        if (j % 40 == 0)
                        {
                            foxDraw.SetFillColor(Colors.White);
                        }
                        else
                        {
                            foxDraw.SetFillColor(Colors.Black);
                        }
                    }


                    foxDraw.DrawRectangle(j, i, 20, 20);
                }
            }*/
            //Function to Center Exercise
            /*
            for (int i = 0; i <= 800; i+=20)
            {
                LineToCenter(foxDraw, i, 0);
                LineToCenter(foxDraw, 800, i);
                LineToCenter(foxDraw, 0, i);
                LineToCenter(foxDraw, i, 800);
            }*/

            //Connect Points Exercise
            /*
            List<Point> listOfPoints = new List<Point> { };
            listOfPoints.Add(new Point(50, 100));
            listOfPoints.Add(new Point(70, 70));
            listOfPoints.Add(new Point(80, 90));
            listOfPoints.Add(new Point(90, 90));
            listOfPoints.Add(new Point(100, 70));
            listOfPoints.Add(new Point(120, 100));
            listOfPoints.Add(new Point(85, 130));
            listOfPoints.Add(new Point(50, 100));
            ConnectPoints(foxDraw, listOfPoints);*/

            //The Night Sky Exercise
            /*
            System.Random random = new System.Random();
            Color[] shadesOfGrey = { Colors.Gray, Colors.DarkGray, Colors.DarkSlateGray, Colors.DimGray, Colors.LightGray, Colors.LightSlateGray, Colors.SlateGray };
            foxDraw.SetBackgroundColor(Colors.Black);
            for (int i = 0; i < 1000; i++)
            {
                foxDraw.SetFillColor(shadesOfGrey[random.Next(0, shadesOfGrey.Length)]);
                int starSize = random.Next(0, 10);
                foxDraw.DrawRectangle(random.Next(0, 800), random.Next(0, 800), starSize, starSize);
            }*/





        }
        public static void DrawLineCenter(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, 400, 400);
        }
        public static void DrawHorizontalLine(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, x + 50, y + 50);
        }
        public static void DrawASquare(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawRectangle(x, y, 50, 50);
        }
        public static void DrawSquareWithTwoParameters(FoxDraw foxDraw, int size)
        {
            foxDraw.DrawRectangle(400 - size / 2, 400 - size / 2, size, size);
        }
        public static void MakeRainbowBoxes(FoxDraw foxDraw, int size, Color color)
        {
            foxDraw.SetFillColor(color);
            foxDraw.DrawRectangle(400 - size / 2, 400 - size / 2, size, size);
        }
        public static void LineToCenter (FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, 400, 400);
        }
        public static void ConnectPoints(FoxDraw foxDraw, List<Point> listOfPoints)
        {
            int i = 0;
            foxDraw.SetStrokeColor(Colors.Green);
            for (; i < listOfPoints.Count-1; i++)
            {
                foxDraw.DrawLine(listOfPoints[i], listOfPoints[i + 1]);
            }
            foxDraw.DrawLine(listOfPoints[listOfPoints.Count - 1], listOfPoints[0]);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}