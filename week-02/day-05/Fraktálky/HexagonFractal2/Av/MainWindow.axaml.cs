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

            MakeHexagonFractal(foxDraw, 200, 50, 350, 7);
        }
        public static void DrawHexagon(FoxDraw foxDraw, double startX, double startY, double side)
        {
            double threeSqrt = System.Math.Sqrt(3);
            double height = (threeSqrt * side) / 2;
            foxDraw.SetFillColor(Colors.Transparent);
            List<Point> points = new List<Point>() { };
            points.Add(new Point(startX, startY));
            points.Add(new Point(startX + side, startY));
            points.Add(new Point(startX + side + side / 2, startY + height));
            points.Add(new Point(startX + side, startY + 2 * height));
            points.Add(new Point(startX, startY + 2 * height));
            points.Add(new Point(startX - side / 2, startY + height));
            foxDraw.DrawPolygon(points);
        }
        public static void MakeHexagonFractal(FoxDraw foxDraw, double x, double y, double side, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            else
            {
                double threeSqrt = System.Math.Sqrt(3);
                double height = (threeSqrt * side) / 2;
                DrawHexagon(foxDraw, x, y, side);
                MakeHexagonFractal(foxDraw, x, y, side / 3, depth - 1);
                MakeHexagonFractal(foxDraw, x + 2*side/3, y, side / 3, depth - 1);
                MakeHexagonFractal(foxDraw, x+3*side/3, y+2*height/3, side / 3, depth - 1);
                MakeHexagonFractal(foxDraw, x+2*side/3, y+4*height/3, side / 3, depth - 1);
                MakeHexagonFractal(foxDraw, x, y+4*height/3, side / 3, depth - 1);
                MakeHexagonFractal(foxDraw, x-side/3, y+2*height/3, side / 3, depth - 1);
            }

        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
