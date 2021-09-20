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

            MakeKochLine(foxDraw, 50, 600, 500, 2);
        }
        public static void MakeKochLine(FoxDraw foxDraw, double x, double y, double length, int depth)
        {
            if (depth == 0)
            {
                return;
            }
            else
            {

                double height = System.Math.Sqrt((length/6*length/6) + (length/3*length/3));
                double x2 = x + length;
                y2=
                foxDraw.DrawLine(x, y, x2, y2);
                MakeKochLine(foxDraw, x + length / 3, y-height, length / 3, depth - 1);
            }
        }
            
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
