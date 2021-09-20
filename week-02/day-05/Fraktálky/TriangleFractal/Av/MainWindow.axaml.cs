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

            DrawTriangleFractal(foxDraw, 400, 100, 600, 8);
        }
        public static void DrawTriangle(FoxDraw foxDraw, double x, double y, double side)
        {
            double height = System.Math.Sqrt(side * side - (side / 2) * (side / 2));
            foxDraw.SetFillColor(Colors.Transparent);
            List<Point> points = new List<Point>() { };
            points.Add(new Point(x, y));
            points.Add(new Point(x + side / 2, y + height));
            points.Add(new Point(x - side / 2, y + height));
            foxDraw.DrawPolygon(points);
        }
        public static void DrawTriangleUpsideDown(FoxDraw foxDraw, double x, double y, double side)
        {
            double height = System.Math.Sqrt((side * side) - (side / 2) * (side / 2));
            foxDraw.SetFillColor(Colors.Transparent);
            List<Point> points = new List<Point>() { };
            points.Add(new Point(x - side/2, y));
            points.Add(new Point(x + side / 2, y));
            points.Add(new Point(x, y + height));
            foxDraw.DrawPolygon(points);
        }
        public static void DrawTriangleFractal(FoxDraw foxDraw, double x, double y, double side, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            else
            {
                double height = System.Math.Sqrt(side * side - (side / 2) * (side / 2));
                DrawTriangleUpsideDown(foxDraw, x, y, side);
                DrawTriangleFractal(foxDraw, x - side / 4, y, side / 2, depth - 1);
                DrawTriangleFractal(foxDraw, x + side / 4, y, side / 2, depth - 1);
                DrawTriangleFractal(foxDraw, x, y + height/2, side / 2, depth - 1);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
