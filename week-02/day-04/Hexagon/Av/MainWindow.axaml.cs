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

            int x = 340;
            int y = 440;
            //MakeHexagon(foxDraw, x, y);
            //MakeHexagonRow(foxDraw, x, y, 5);
            MakeBigHexagon(foxDraw, x, y, 4);
        }
        private static void MakeHexagon(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.SetFillColor(Colors.Transparent);
            List<Point> points = new List<Point>();
            points.Add(new Point(x - 20, y));
            points.Add(new Point(x - 10, y - 20));
            points.Add(new Point(x + 10, y - 20));
            points.Add(new Point(x + 20, y));
            points.Add(new Point(x + 10, y + 20));
            points.Add(new Point(x - 10, y + 20));
            foxDraw.DrawPolygon(points);
        }
        private static void MakeHexagonRow(FoxDraw foxDraw, int x, int y, int rowLength)
        {
            for (int i = 0; i < rowLength; i++)
            {
                MakeHexagon(foxDraw, x, y - i * 40);
            }
            
        }
        private static void MakeBigHexagon(FoxDraw foxDraw, int x, int y, int rowLength)
        {
            for (int i = 0; i < 4; i++)
            {
                MakeHexagonRow(foxDraw, x + 30 * i, y, rowLength);
                rowLength++;
                y += 20;
            }
            for (int i = 4; i < 7; i++)
            {
                MakeHexagonRow(foxDraw, x + 30 * i, y-40, rowLength-2);
                rowLength--;
                y -= 20;
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
