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
            
            foxDraw.SetFillColor(Colors.Transparent);
            foxDraw.SetBackgroundColor(Colors.Black);
            foxDraw.SetStrokeColor(Colors.Red);
            CircleFractal(foxDraw, 50, 50, 600, 7);
        }
        public static void CircleFractal(FoxDraw foxDraw, double x, double y, double size, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            else
            {
                foxDraw.DrawEllipse(x, y, size, size);
                CircleFractal(foxDraw, x + size/4, y, size / 2, depth - 1);
                CircleFractal(foxDraw, x + size/32, y + size/2 - size/8, size / 2, depth - 1);
                CircleFractal(foxDraw, x + size/2 - size/32 , y + size /2 - size/8, size / 2, depth - 1);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
