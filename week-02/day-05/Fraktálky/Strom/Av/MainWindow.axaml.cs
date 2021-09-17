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

            DrawTree(foxDraw, 400, 700);
        }
        public static void DrawTree(FoxDraw foxDraw, int x, int y, int n = 7, int c = 0)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                foxDraw.DrawLine(x, y, c, y - 50);
                DrawTree(foxDraw, x - c, y - 50, --n, c + 5);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
