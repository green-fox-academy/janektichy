using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Collections.Generic;

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

            int k = 0;
            for (int i = 100; i < 800; i+=40)
            {
                k = i - 50; 
                foxDraw.SetStrokeColor(Colors.Purple);
                foxDraw.DrawLine(i, 0, 800, k);
                foxDraw.SetStrokeColor(Colors.LimeGreen);
                foxDraw.DrawLine(0, i, k, 800);

            }

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
