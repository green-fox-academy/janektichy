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
            foxDraw.SetStrokeColor(Colors.LimeGreen);

            for (int i = 0; i < 400; i+=20)
            {
                foxDraw.DrawLine(400, i, 400 - i, 400);
                foxDraw.DrawLine(400, i, 400 + i, 400);
                foxDraw.DrawLine(400, 800-i, 400 - i, 400);
                foxDraw.DrawLine(400, 800 - i, 400 + i, 400);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
