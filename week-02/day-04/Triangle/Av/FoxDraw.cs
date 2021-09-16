using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.Media;
using Color = Avalonia.Media.Color;

namespace Av
{
    public class FoxDraw
    {
        private Canvas Canvas { get; set; }
        private SolidColorBrush LineColor { get; set; } = new SolidColorBrush(Colors.Black);
        private SolidColorBrush ShapeColor { get; set; } = new SolidColorBrush(Colors.DarkGreen);

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
        }

        public void SetBackgroundColor(Color color)
        {
            Canvas.Background = new SolidColorBrush(color);
        }

        public void SetStrokeColor(Color color)
        {
            LineColor = new SolidColorBrush(color);
        }

        public void SetFillColor(Color color)
        {
            ShapeColor = new SolidColorBrush(color);
        }

        public void DrawEllipse(double x, double y, double width, double height)
        {
            var ellipse = new Ellipse()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Width = width,
                Height = height
            };

            Canvas.Children.Add(ellipse);
            SetPosition(ellipse, x, y);
        }
        public void DrawLine(Point p1, Point p2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                StartPoint = p1,
                EndPoint = p2
            };
            Canvas.Children.Add(line);
        }
        public void DrawLine(double x1, double y1, double x2, double y2)
        {
            var line = new Line()
            {
                Stroke = LineColor,
                StartPoint = new Point(x1, y1),
                EndPoint = new Point(x2, y2)
            };

            Canvas.Children.Add(line);
        }

        public void DrawRectangle(double x, double y, double width, double height)
        {
            var rectangle = new Rectangle()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Width = width,
                Height = height
            };

            Canvas.Children.Add(rectangle);
            SetPosition(rectangle, x, y);
        }

        public void AddImage(Image image, double x, double y)
        {
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void SetPosition(InputElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public void DrawPolygon(IEnumerable<Point> points)
        {
            var polygon = new Polygon()
            {
                Stroke = LineColor,
                Fill = ShapeColor,
                Points = points.ToList()
            };

            Canvas.Children.Add(polygon);
        }
    }
}