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

            foxDraw.SetStrokeColor(Colors.Black);
            for (int i = 20; i < 790; i+=20)
            {
                foxDraw.DrawLine(400-i/2, i, 400+i/2, i);
                foxDraw.DrawLine(400 - i/2 + 10, i - 20, 810 - i, 780);
                foxDraw.DrawLine(400 + i / 2 - 10, i - 20, -10 + i, 780);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
