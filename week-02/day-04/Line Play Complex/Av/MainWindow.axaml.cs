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

            int size = 3;
            int canvasLength = 800 / size;

            for (int y = 0; y <= 800; y+=canvasLength)
             {
                 for (int x = 0; x <= 800; x+=canvasLength)
                 {
                     for (int i = 0; i < canvasLength; i += canvasLength/20)
                     {

                        /*if ((x % (canvasLength * 2) == 0) || (y % (canvasLength * 2) == 0) && !(y % (canvasLength * 2) == 0 && (x % (canvasLength * 2) == 0)))
                        {
                            foxDraw.SetStrokeColor(Colors.Yellow);
                            foxDraw.DrawLine(x, y - i, x - i, y - canvasLength);
                            foxDraw.SetStrokeColor(Colors.Blue);
                            foxDraw.DrawLine(x - i, y, x - canvasLength, y - i);
                        }
                        else
                        {*/
                            foxDraw.SetStrokeColor(Colors.Blue);
                            foxDraw.DrawLine(x, y - i, x - i, y - canvasLength);
                            foxDraw.SetStrokeColor(Colors.Red);
                            foxDraw.DrawLine(x - i, y, x - canvasLength, y - i);
                        //}

                     }
                 }
             }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
