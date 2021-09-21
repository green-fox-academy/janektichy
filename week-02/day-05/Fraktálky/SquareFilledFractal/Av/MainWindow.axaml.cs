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

            MakeSquareFractal(foxDraw, 400, 400, 390,4);
        }
        public static void MakeSquare(FoxDraw foxDraw, double x, double y, double side)
        {
            List<Point> points = new List<Point>() { };
            points.Add(new Point(x-side/2, y-side/2));
            points.Add(new Point(x+side/2, y-side/2));
            points.Add(new Point(x+side/2, y+side/2));
            points.Add(new Point(x-side/2, y+side/2));
            foxDraw.DrawPolygon(points);

        }
        public static void MakeSquareFractal(FoxDraw foxDraw, double x, double y, double side, int depth)
        {
            if (depth == 0)
            {

                return;
            }
            else
            {
                foxDraw.SetFillColor(Colors.Transparent);
                MakeSquare(foxDraw, x, y, side);
                foxDraw.SetFillColor(Colors.Black);
                MakeSquare(foxDraw, x, y, side/2);
                side = side / 3;
                foxDraw.SetFillColor(Colors.Black);
                MakeSquareFractal(foxDraw, x - (side)*2, y- (side ) * 2, side, depth - 1);
                MakeSquareFractal(foxDraw, x, y- (side ) * 2, side, depth - 1);
                MakeSquareFractal(foxDraw, x+ (side ) * 2, y- (side ) * 2, side, depth - 1);
                MakeSquareFractal(foxDraw, x+ (side ) * 2, y, side , depth - 1);
                MakeSquareFractal(foxDraw, x+ (side ) * 2, y+ (side ) * 2, side, depth - 1);
                MakeSquareFractal(foxDraw, x, y+ (side ) * 2, side , depth - 1);
                MakeSquareFractal(foxDraw, x- (side ) * 2, y+ (side ) * 2, side, depth - 1);
                MakeSquareFractal(foxDraw, x- (side ) * 2, y, side, depth - 1);

            }
        }
            private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
