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
            foxDraw.SetStrokeThicknes(1);
            foxDraw.SetStrokeColor(Colors.Yellow);
            foxDraw.SetBackgroundColor(Colors.Black);
            DrawTree(foxDraw, 400, 700, 400, 630, 9);
        }
            public static void DrawTree(FoxDraw foxDraw, double x, double y, double x2, double y2, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            else
            {
                double vektorX = x2 - x;
                double vektorY = y2 - y;
                double reversedVectorX = vektorY/2;
                double reversedVectorY = vektorX/2;

                foxDraw.DrawLine(x, y, x2, y2);
                DrawTree(foxDraw, x2, y2, x2 + vektorX, y2 + vektorY, depth - 1);
                DrawTree(foxDraw, x2, y2, x2 + 0.5*(vektorX + reversedVectorX), y2 + 0.5*(vektorY - reversedVectorY), depth - 1);
                DrawTree(foxDraw, x2, y2, x2 + 0.5*(vektorX - reversedVectorX), y2 + 0.5*(vektorY + reversedVectorY), depth - 1);

            }
        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
