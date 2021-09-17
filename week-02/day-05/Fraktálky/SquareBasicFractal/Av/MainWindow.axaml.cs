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
        public static void SquareFractal(FoxDraw foxDraw, int x, int y, int size, int n = 6)
        {
            foxDraw.SetBackgroundColor(Colors.Yellow);
            if (n == 0)
            {   
                return;
            }
            else
            {
                DrawSquare(foxDraw, x, y, size);
                SquareFractal(foxDraw, x + size/3, y, size/3,n-1);
                SquareFractal(foxDraw, x, y+ size/3, size / 3,n-1);
                SquareFractal(foxDraw, x + 2*(size/3), y+size/3, size / 3,n-1);
                SquareFractal(foxDraw, x + size / 3, y + 2*(size/3), size / 3,n-1);
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
