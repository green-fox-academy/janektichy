using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Collections.Generic;
using GreenFox;

namespace Av
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            SquareFractal(foxDraw, 0,0, 800);

        }
        public static void SquareFractal(FoxDraw foxDraw, int x, int y, int size, int n = 4)
        {
            
            if (n == 0)
            {   
                return;
            }
            {
                for (int j = 0; j < 3; ++j, y += size / 3)
                {
                    for (int i = 0; i < 3; ++i, x+=size/3)
                    {
                        DrawSquare(foxDraw, x, y, size/3);
                    }
                    x = 0;
                }
                y = 0;
                SquareFractal(foxDraw, x, y, size/3, --n);
            }

        }

        public static void DrawSquare(FoxDraw foxDraw, int x, int y, int size)
        {
            foxDraw.SetFillColor(Colors.Transparent);
            List<Point> squareCorners = new List<Point>() { };
            squareCorners.Add(new Point(x, y));
            squareCorners.Add(new Point(x+size, y));
            squareCorners.Add(new Point(x+size, y+size));
            squareCorners.Add(new Point(x, y+size));
            foxDraw.DrawPolygon(squareCorners);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
