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

            DrawTree(foxDraw, 400, 700, 50);
        }
        public static void DrawTree(FoxDraw foxDraw, int x, int y, int size, int n = 7)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                foxDraw.DrawLine(x, y, x, y - size);
                DrawTree(foxDraw, x + size, y + size, size - size / 20, --n);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
