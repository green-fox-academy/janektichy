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
            MakeSquareFractal(foxDraw, 400, 400, 390, 5, 20);
        }
        public static void MakeSquare(FoxDraw foxDraw, double x, double y, double side, int strokeThickness)
        {
            foxDraw.SetFillColor(Colors.Transparent);
            foxDraw.SetStrokeThicknes(strokeThickness);
            List<Point> points = new List<Point>() { };
            points.Add(new Point(x - side / 2, y - side / 2));
            points.Add(new Point(x + side / 2, y - side / 2));
            points.Add(new Point(x + side / 2, y + side / 2));
            points.Add(new Point(x - side / 2, y + side / 2));
            foxDraw.DrawPolygon(points);

        }
        public static void MakeSquareFractal(FoxDraw foxDraw, double x, double y, double side, int depth, int strokeThickness)
        {
            if (depth == 0)
            {
                return;
            }
            else
            {
                MakeSquare(foxDraw, x, y, side, strokeThickness);
                MakeSquareFractal(foxDraw, x-side/2, y-side/2, side/2, depth - 1, strokeThickness / 2);
                MakeSquareFractal(foxDraw, x+side/2, y-side/2, side / 2, depth - 1, strokeThickness / 2);
                MakeSquareFractal(foxDraw, x+side/2, y+side/2, side / 2, depth - 1, strokeThickness / 2);
                MakeSquareFractal(foxDraw, x-side/2, y+side/2, side / 2, depth - 1, strokeThickness / 2);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
